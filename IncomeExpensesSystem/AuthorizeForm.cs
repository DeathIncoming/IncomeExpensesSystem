using IncomeExpensesSystem.Models;

namespace IncomeExpensesSystem
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginRegistryBtn_Click(object sender, EventArgs e)
        {
            RegistryForm registryForm = new();
            registryForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using ContextDB context = new();
            var user = context.Users.FirstOrDefault(u => u.Name == loginUserName.Text && u.Password == loginPassword.Text);
            if (user != null)
            {
                MainForm mainForm = new(user);
                mainForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Неверный логин/пароль");

        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = loginShowPass.Checked ? '\0' : '*';
        }
    }
}
