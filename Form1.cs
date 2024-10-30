using TestProj.Data;

namespace TestProj
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext _dbContext;
        public Form1(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = LogTb.Text;
            string password = PassTb.Text;

            var user = _dbContext.Users.FirstOrDefault(s => s.Login == username && s.Password == password);

            if (user != null)
            {
                Form2 form2 = new Form2(_dbContext);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
