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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
            GetToInc();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {

        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expense obj = new Expense();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ViewIncomes obj = new ViewIncomes();
            obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            ViewExpenses obj = new ViewExpenses();
            obj.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulu\Documents\FinanceDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            IncNameTb.Text = "";
            IncAmtTb.Text = "";
            CatCb.SelectedIndex = -1;
            IncDescTb.Text = "";

        }
        private void IncSaveBtn_Click(object sender, EventArgs e)
        {
            if (IncNameTb.Text == "" || IncAmtTb.Text == "" || IncDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into IncomeTbl (IncName, IncAmt,IncCat, IncDate,IncDesc,IncUser) values (@IN,@IA,@IC,@ID,@IDe,@IU)", Con);
                    cmd.Parameters.AddWithValue("@In", IncNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", IncAmtTb.Text);
                    cmd.Parameters.AddWithValue("@IC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID", IncDate.Value.Date);
                    cmd.Parameters.AddWithValue("@IDe", IncDescTb.Text);
                    cmd.Parameters.AddWithValue("@IU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Added!!!");
                    Con.Close();
                    GetToInc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
        public void GetToInc()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TotIncLbl.Text = "Rs " + dt.Rows[0][0].ToString();
                //totalIncome = int.Parse(dt.Rows[0][0].ToString());
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        private void IncDescTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
