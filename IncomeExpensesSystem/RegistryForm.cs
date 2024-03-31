using IncomeExpensesSystem.Models;
using System.Windows.Forms;

namespace IncomeExpensesSystem
{
    public partial class RegistryForm : Form
    {
        private string selectedIconPath;

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
            AuthorizeForm authorizeForm = new AuthorizeForm();
            authorizeForm.Show();
            this.Close();
        }

        private void registryBtn_Click(object sender, EventArgs e)
        {
            // Проверяем, что иконка была выбрана
            if (string.IsNullOrEmpty(selectedIconPath))
            {
                MessageBox.Show("Выберите иконку пользователя.");
                return;
            }

            var user = new User()
            {
                Name = registryUserName.Text,
                Password = registryPassword.Text,
                IconPath = selectedIconPath
            };

            if (user != null)
            {
                MessageBox.Show("Вы успешно зарегистрировались!\nВаш логин: " + user.Name + "\nВаш пароль: " + user.Password);
                using ContextDB db = new ContextDB();
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

        private void addUserIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedIconPath = openFileDialog.FileName;

                try
                {
                    using (var originalImage = new Bitmap(openFileDialog.FileName))
                    {
                        // Масштабируем изображение до размера 100x100
                        addUserIcon.Image = ResizeImage(originalImage, new Size(100, 100));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }

        private Image ResizeImage(Image image, Size size)
        {
            var resizedImage = new Bitmap(size.Width, size.Height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, size.Width, size.Height);
            }
            return resizedImage;
        }
    }
}