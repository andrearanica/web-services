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

            HttpResponseMessage response = await client.PostAsJsonAsync("/todos", todo);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Todo> UpdateTodoAsync(Todo todo)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"/todos/{ todo.id }", todo);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            todo = await JsonSerializer.DeserializeAsync<Todo>(await response.Content.ReadAsStreamAsync());
            return todo;
        }

        static async Task<HttpStatusCode> DeleteTodoAsync (int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"/todos/{ id }");
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
                        list_todos.Items.Add($"{ todo.id } | ▣ # { todo.title }");
                    } else {
                        list_todos.Items.Add($"{ todo.id } | ▢ # { todo.title }");
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
            try {
                int todoId = int.Parse(list_todos.Items[list_todos.SelectedIndex].ToString().Split('|')[0].Split(' ')[0]);
                HttpStatusCode code = await DeleteTodoAsync(todoId);
                // MessageBox.Show("Eliminazione avvenuta con successo");
                showTodos();
            } catch (Exception) {
                MessageBox.Show("Seleziona l'elemento da eliminare");
            }
        }

        private async void btn_createTodo_Click (object sender, EventArgs e) {
            Todo todo = new Todo(userId, 0, txt_title.Text, false);
            Uri uri = await CreateTodoAsync(todo);
            showTodos();
        }

        private async void btn_complete_Click(object sender, EventArgs e) {
            Todo todo = new Todo(userId, int.Parse(list_todos.SelectedItem.ToString().Split(' ')[0]), list_todos.SelectedItem.ToString().Split('#')[1], true);
            try
            {
                Todo newTodo = await UpdateTodoAsync(todo);
                showTodos();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
    public class Todo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        public Todo (int userId, int id, string title, bool completed) {
            this.userId = userId;
            this.id = id;
            this.title = title;
            this.completed = completed;
        }
    }
}
