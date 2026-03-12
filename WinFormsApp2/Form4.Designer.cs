namespace WinFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            name2 = new Label();
            name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._507a932c_5dbb_4ccb_9b3f_a547dae5724e;
            pictureBox1.Location = new Point(-3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.Font = new Font("Segoe UI Variable Display Semib", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name2.Location = new Point(30, 330);
            name2.Name = "name2";
            name2.Size = new Size(180, 47);
            name2.TabIndex = 2;
            name2.Text = "Фамилия ";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Variable Display Semib", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(30, 259);
            name.Name = "name";
            name.Size = new Size(90, 47);
            name.TabIndex = 3;
            name.Text = "Имя";
            name.Click += label3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(name);
            Controls.Add(name2);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label name2;
        private Label name;
    }
}