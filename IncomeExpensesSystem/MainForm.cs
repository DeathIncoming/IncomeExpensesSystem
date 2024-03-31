using IncomeExpensesSystem.Models;

namespace IncomeExpensesSystem
{
    public partial class MainForm : Form
    {
        private ContextDB profileManager;
        public MainForm(User user)
        {
            InitializeComponent();
            userNameLabel.Text = user.Name;
            profileManager = new ContextDB();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Получаем текущего пользователя
            User currentUser = profileManager.Users.FirstOrDefault(u => u.Name == userNameLabel.Text);

            // Проверяем, что пользователь и путь к иконке существуют
            if (currentUser != null && !string.IsNullOrEmpty(currentUser.IconPath))
            {
                try
                {
                    // Загружаем изображение из пути IconPath
                    using (var originalImage = new Bitmap(currentUser.IconPath))
                    {
                        // Масштабируем и отображаем изображение
                        pictureBox2.Image = ResizeImage(originalImage, new Size(100, 100));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            residueForm1.Visible = false;
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            residueForm1.Visible = false;
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expensesForm1.Visible = false;
            residueForm1.Visible = false;
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = true;
            residueForm1.Visible = false;
        }

        private void residueBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
            residueForm1.Visible = true;
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
