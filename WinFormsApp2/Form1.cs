namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 rt;
        Form3 gf;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (name.Text == "" && password.Text == "")
            {
                MessageBox.Show("Логин или пароль неверный", "ошибка");
            }


            else if (name.Text == Class1.юзер && password.Text == Class1.пароль)
            {
                rt = new Form2();
                rt.Show();
            }




        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void регистрация_Click(object sender, EventArgs e)
        {
           
            gf = new Form3();
            gf .Show();
        }
    }
}
