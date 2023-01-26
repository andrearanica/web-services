using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace CRUD_client {
    public partial class Form1 : Form {
        int userId = 0;
        static HttpClient client = new HttpClient();

        static async Task<Todo> GetTodoAsync(string path)
        {
            Todo product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product =  await JsonSerializer.DeserializeAsync<Todo>(await response.Content.ReadAsStreamAsync());
            }
            return product;
        }

        static async Task<List<Todo>> GetTodoList (int userId) {
            List<Todo> todos = null;
            HttpResponseMessage response = await client.GetAsync($"/todos?userId={ userId }");
            if (response.IsSuccessStatusCode) {
                todos = await JsonSerializer.DeserializeAsync<List<Todo>>(await response.Content.ReadAsStreamAsync());
            }
            return todos;
        }

        static async Task<Uri> CreateTodoAsync(Todo todo)
        {

            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/todos", todo);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Todo> UpdateTodoAsync(Todo todo)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/todos/{ todo.id }", todo);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            todo = await JsonSerializer.DeserializeAsync<Todo>(await response.Content.ReadAsStreamAsync());
            return todo;
        }

        static async Task<HttpStatusCode> DeleteTodoAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"/todos/{ id }");
            return response.StatusCode;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void showTodos ()
        {
            try
            {
                list_todos.Items.Clear();
                List<Todo> todos = await GetTodoList(userId);
                foreach (Todo todo in todos) {
                    if (todo.completed) { 
                        list_todos.Items.Add($"{ todo.id } | ▢ { todo.title }");
                    } else {
                        list_todos.Items.Add($"▣ { todo.title }");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_saveUserId_Click(object sender, EventArgs e) {
            userId = int.Parse(txt_userId.Text);
            showTodos();
        }

        private void Form1_Load(object sender, EventArgs e) {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void btn_delete_Click(object sender, EventArgs e) {
            int todoId = int.Parse(list_todos.Items[list_todos.SelectedIndex].ToString().Split(' ')[0]);
            HttpStatusCode code = await DeleteTodoAsync(todoId);
            if (code == HttpStatusCode.OK) {
                MessageBox.Show("Eliminazione avvenuta con successo");
                showTodos();
            } else {
                MessageBox.Show("Seleziona l'elemento da eliminare");
            }
        }
    }
    public class Todo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
