
namespace CRUD_client
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.btn_saveUserId = new System.Windows.Forms.Button();
            this.list_todos = new System.Windows.Forms.ListBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createTodo = new System.Windows.Forms.Button();
            this.btn_complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserisci il tuo userId";
            // 
            // txt_userId
            // 
            this.txt_userId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userId.Location = new System.Drawing.Point(147, 33);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(239, 29);
            this.txt_userId.TabIndex = 3;
            // 
            // btn_saveUserId
            // 
            this.btn_saveUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveUserId.Location = new System.Drawing.Point(230, 68);
            this.btn_saveUserId.Name = "btn_saveUserId";
            this.btn_saveUserId.Size = new System.Drawing.Size(75, 34);
            this.btn_saveUserId.TabIndex = 4;
            this.btn_saveUserId.Text = "Salva";
            this.btn_saveUserId.UseVisualStyleBackColor = true;
            this.btn_saveUserId.Click += new System.EventHandler(this.btn_saveUserId_Click);
            // 
            // list_todos
            // 
            this.list_todos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_todos.FormattingEnabled = true;
            this.list_todos.ItemHeight = 21;
            this.list_todos.Location = new System.Drawing.Point(92, 187);
            this.list_todos.Name = "list_todos";
            this.list_todos.Size = new System.Drawing.Size(324, 172);
            this.list_todos.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(92, 365);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 34);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Rimuovi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crea un nuovo TODO";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(147, 465);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(290, 29);
            this.txt_title.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Titolo";
            // 
            // btn_createTodo
            // 
            this.btn_createTodo.Location = new System.Drawing.Point(234, 500);
            this.btn_createTodo.Name = "btn_createTodo";
            this.btn_createTodo.Size = new System.Drawing.Size(75, 36);
            this.btn_createTodo.TabIndex = 12;
            this.btn_createTodo.Text = "Crea";
            this.btn_createTodo.UseVisualStyleBackColor = true;
            this.btn_createTodo.Click += new System.EventHandler(this.btn_createTodo_Click);
            // 
            // btn_complete
            // 
            this.btn_complete.Location = new System.Drawing.Point(326, 365);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(90, 34);
            this.btn_complete.TabIndex = 13;
            this.btn_complete.Text = "Completa";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 727);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.btn_createTodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.list_todos);
            this.Controls.Add(this.btn_saveUserId);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.Button btn_saveUserId;
        private System.Windows.Forms.ListBox list_todos;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_createTodo;
        private System.Windows.Forms.Button btn_complete;
    }
}

