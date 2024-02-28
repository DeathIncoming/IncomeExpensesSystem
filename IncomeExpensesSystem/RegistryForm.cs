using IncomeExpensesSystem.Models;

namespace IncomeExpensesSystem
{
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registryLoginBtn_Click(object sender, EventArgs e)
        {
            AuthorizeForm authorizeForm = new();
            authorizeForm.Show();
            this.Close();
        }

        private void registryBtn_Click(object sender, EventArgs e)
        {
            var user = new User() { Name = registryUserName.Text, Password = registryPassword.Text };
            if (user != null)
            {
                MessageBox.Show("Вы успешно зарегестрировались!\nВаш логин: " + user.Name + "\nВаш пароль: " + user.Password);
                using ContextDB db = new();
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Пожалуйста, перезапустите приложение перед авторизацией");
            }

        }

        private void registryShowPass_CheckedChanged(object sender, EventArgs e)
        {
            registryPassword.PasswordChar = registryShowPass.Checked ? '\0' : '*';
            registryRepeatPassword.PasswordChar = registryShowPass.Checked ? '\0' : '*';
        }
    }
}
