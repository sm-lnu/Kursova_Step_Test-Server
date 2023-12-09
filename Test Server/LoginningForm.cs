using System;
using System.Windows.Forms;

namespace Test_Server
{
    public partial class LoginningForm : Form
    {
        private string Login;
        private string Password;

        public LoginningForm()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            CheckEnableLoginButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Login = textBox1.Text;
            CheckEnableLoginButton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text;
            CheckEnableLoginButton();
        }

        private void CheckEnableLoginButton()
        {
            button1.Enabled = !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}