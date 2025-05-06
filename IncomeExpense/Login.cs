using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IncomeExpense
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulu\Documents\FinanceDb.mdf;Integrated Security=True;Connect Timeout=30");

        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both UserName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName = '" + UnameTb.Text + "' and UPass ='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = UnameTb.Text;
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password!!!","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                Con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
