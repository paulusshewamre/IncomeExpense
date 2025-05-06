using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpense
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            GetToExp();
        }

        private void ExpenseLbl_Click(object sender, EventArgs e)
        {
            Expense obj = new Expense();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ViewIncomes obj = new ViewIncomes();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ViewExpenses obj = new ViewExpenses();
            obj.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulu\Documents\FinanceDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            CatCb.SelectedIndex = -1;
            ExpDescTb.Text = "";

        }

        private void ExpSaveBtn_Click(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information","Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl (ExpName, ExpAmt,ExpCat, ExpDate,ExpDesc,ExpUser) values (@EN,@EA,@EC,@ED,@EDe,@EU)", Con);
                    cmd.Parameters.AddWithValue("@En", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EDe", ExpDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Added!!!");
                    Con.Close();
                    GetToExp();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetToExp()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TotExpLbl.Text = "Rs " + dt.Rows[0][0].ToString();
                //totalIncome = int.Parse(dt.Rows[0][0].ToString());
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
