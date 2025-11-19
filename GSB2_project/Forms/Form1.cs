using GSB2_project.DAO;
using GSB2_project.Forms;
using GSB2_project.Models;
using System.Security.Cryptography;
using System.Text;

namespace GSB2_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.textBoxLoginPassword.Text));
            string hashString = BitConverter.ToString(hashValue).Replace("-", "").ToLowerInvariant();
            string email = this.textBoxLoginEmail.Text;
            UserDAO userDAO = new UserDAO();
            User user = userDAO.Login(email, hashString);

            if (user != null && user.Role == true)
            {
                this.Hide();
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();

            }
            else if (user != null && user.Role == false)
            {
                this.Hide();
                FormDoctor formDoctor = new FormDoctor();
                formDoctor.Show();

            }
            else
            {
                MessageBox.Show("Incorrect email and/or password");
            }
        }
    }
}

