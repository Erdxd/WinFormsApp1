namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button = new Button();
            name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            password = new TextBox();
            hScrollBar1 = new HScrollBar();
            регистрация = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Cursor = Cursors.Hand;
            button.Location = new Point(459, 96);
            button.Name = "button";
            button.Size = new Size(158, 45);
            button.TabIndex = 0;
            button.Text = "Войти";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            button.KeyPress += button_KeyPress;
            // 
            // name
            // 
            name.Location = new Point(219, 109);
            name.Name = "name";
            name.Size = new Size(134, 23);
            name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 85);
            label1.Name = "label1";
            label1.Size = new Size(134, 47);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 148);
            label2.Name = "label2";
            label2.Size = new Size(162, 47);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // password
            // 
            password.Location = new Point(219, 171);
            password.Name = "password";
            password.Size = new Size(134, 23);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(386, 212);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(8, 8);
            hScrollBar1.TabIndex = 5;
            // 
            // регистрация
            // 
            регистрация.AutoSize = true;
            регистрация.Cursor = Cursors.Hand;
            регистрация.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            регистрация.Location = new Point(219, 212);
            регистрация.Name = "регистрация";
            регистрация.Size = new Size(110, 21);
            регистрация.TabIndex = 6;
            регистрация.Text = "регистрация";
            регистрация.Click += регистрация_Click;
            // 
            // Form1
            // 
            AcceptButton = button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(регистрация);
            Controls.Add(hScrollBar1);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(button);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox name;
        private Label label1;
        private Label label2;
        private TextBox password;
        private HScrollBar hScrollBar1;
        private Label регистрация;
    }
}
