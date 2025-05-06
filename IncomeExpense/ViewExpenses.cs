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
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
            DisplayExpenses();
            
        }

        private void ViewExpenseLbl_Click(object sender, EventArgs e)
        {
            ViewExpenses obj = new ViewExpenses();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
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

        private void ViewExpenses_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulu\Documents\FinanceDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayExpenses()
        {
            Con.Open();

            string Query = $"Select * from ExpenseTbl where ExpUser = @ExpUser";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            sda.SelectCommand.Parameters.AddWithValue("@ExpUser", Login.User);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void ExpenseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Con.Open();
            string search_item = CatCb.SelectedItem.ToString();
            string Query = $"Select * from ExpenseTbl where ExpCat = @ExpCat and ExpUser = @ExpUser";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            sda.SelectCommand.Parameters.AddWithValue("@ExpUser", Login.User);
            sda.SelectCommand.Parameters.AddWithValue("@ExpCat", search_item);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
