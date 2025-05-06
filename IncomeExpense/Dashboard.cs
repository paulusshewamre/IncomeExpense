using Microsoft.Data.SqlClient;
using System.Data;

namespace IncomeExpense
{
    public partial class Dashboard : Form
    {
        int totalIncome;
        int totalExpense;
        public Dashboard()
        {
            InitializeComponent();
            GetToInc();
            GetToExp();
            IncomeTransactionCount();
            ExpenseTransactionCount();
            LastIncomeDate();
            LastExpenseDate();
            GetMaxIncome();
            GetMaxExpense();
            GetMinIncome();
            GetMinExpense();
            GetBalance();
            GetMaxIncomeCat();
            GetMaxExpenseCat();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();++
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void IncLbl_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {
            ViewExpenses obj = new ViewExpenses();
            obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulu\Documents\FinanceDb.mdf;Integrated Security=True;Connect Timeout=30");

        public void GetToInc()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TotIncLbl.Text = "Rs " + dt.Rows[0][0].ToString();
                totalIncome = int.Parse(dt.Rows[0][0].ToString());
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
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
                totalExpense = int.Parse(dt.Rows[0][0].ToString());
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }

        public void IncomeTransactionCount()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from IncomeTbl where IncUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }
        public void ExpenseTransactionCount()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumExpLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }

        public void LastIncomeDate()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from IncomeTbl where IncUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateIncLbl.Text = dt.Rows[0][0].ToString();
                DateIncLbl1.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }
        public void LastExpenseDate()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateExpLbl.Text = dt.Rows[0][0].ToString();
                DateExpLbl1.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        public void GetMaxIncome()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncAmt) from IncomeTbl where IncUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }

        public void GetMaxExpense()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTbl where ExpUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxExpLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        public void GetMinIncome()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Min(IncAmt) from IncomeTbl where IncUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        public void GetMinExpense()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser ='" + Login.User + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinExpLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        public void GetBalance()
        {
            try
            {
                BalanceLbl.Text = "Rs " + (totalIncome - totalExpense).ToString();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }

        public void GetMaxExpenseCat()
        {
            try
            {
                Con.Open();

                string InnerQuery = "select MAX(ExpAmt) from ExpenseTbl where ExpUser = @ExpUser";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.SelectCommand.Parameters.AddWithValue("@ExpUser", Login.User);
                sda1.Fill(dt1);
                string Query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestExpLbl.Text = dt.Rows[0][0].ToString();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }
        public void GetMaxIncomeCat()
        {
            try
            {
                Con.Open();

                string InnerQuery = "select MAX(IncAmt) from IncomeTbl where IncUser = @IncUser";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.SelectCommand.Parameters.AddWithValue("@IncUser", Login.User);
                sda1.Fill(dt1);

                string Query = "select IncCat from IncomeTbl where IncAmt = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestIncLbl.Text = dt.Rows[0][0].ToString();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void NumIncLbl_Click(object sender, EventArgs e)
        {

        }

        private void BestExpLbl_Click(object sender, EventArgs e)
        {

        }

        private void BestIncLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
