using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceControl
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Con = new Functions();
            SumExpenses();
            SumIncome();
            CountExp();
            CountInc();
            ResidualAmt();
            UpdateIncomes();
            UpdateExpenses();
        }
        Functions Con;
        private void SumExpenses()
        {
            string Query = "select Sum (ExpAmt) from ExpenseTbl";
            DataTable dt = Con.GetData(Query);
            ExpenseLbl.Text = "$ " + dt.Rows[0][0].ToString();
        }
        private void CountExp()
        {
            string Query = "select Count (*) from ExpenseTbl";
            DataTable dt = Con.GetData(Query);
            NumExpLbl.Text = "Expenses: " + dt.Rows[0][0].ToString();
        }
        private void CountInc()
        {
            string Query = "select Count (*) from IncomeTbl";
            DataTable dt = Con.GetData(Query);
            NumIncLbl.Text = "Incomes: " + dt.Rows[0][0].ToString();
        }
        private void SumIncome()
        {
            string Query = "select Sum (IncAmt) from IncomeTbl";
            DataTable dt = Con.GetData(Query);
            IncLbl.Text = "$ " + dt.Rows[0][0].ToString();
        }
        private void ResidualAmt()
        {
            string expensesQuery = "SELECT SUM(ExpAmt) FROM ExpenseTbl";
            string incomeQuery = "SELECT SUM(IncAmt) FROM IncomeTbl";

            DataTable expensesDt = Con.GetData(expensesQuery);
            DataTable incomeDt = Con.GetData(incomeQuery);

            double expensesTotal = 0;
            double incomeTotal = 0;

            if (expensesDt.Rows.Count > 0 && expensesDt.Rows[0][0] != DBNull.Value)
            {
                expensesTotal = Convert.ToDouble(expensesDt.Rows[0][0]);
            }

            if (incomeDt.Rows.Count > 0 && incomeDt.Rows[0][0] != DBNull.Value)
            {
                incomeTotal = Convert.ToDouble(incomeDt.Rows[0][0]);
            }

            double residualAmt = incomeTotal - expensesTotal;
            if (residualAmt >= 0)
            {
                SummaryLbl.Text = "You have: $" + residualAmt.ToString();
                SummaryLbl.ForeColor = Color.Black;
            }
            else if (residualAmt < 0)
            {
                SummaryLbl.Text = "You are $" + Math.Abs(residualAmt).ToString() + " short";
                SummaryLbl.ForeColor = Color.OrangeRed;
            }
        }
        private void UpdateExpenses()
        {
            string totalExpensesQuery = "SELECT COUNT(*) FROM ExpenseTbl";
            DataTable totalExpensesDt = Con.GetData(totalExpensesQuery);
            ExpTotal.Text = "Total Expenses: " + totalExpensesDt.Rows[0][0].ToString();

            string totalExpensesAmountQuery = "SELECT SUM(ExpAmt) FROM ExpenseTbl";
            DataTable totalExpensesAmountDt = Con.GetData(totalExpensesAmountQuery);
            ExpAmtTotal.Text = "Total Amount: $" + totalExpensesAmountDt.Rows[0][0].ToString();

            DateTime now = DateTime.Now;
            string currentMonthExpensesQuery = $"SELECT COUNT(*) FROM ExpenseTbl WHERE MONTH(ExpDate) = {now.Month} AND YEAR(ExpDate) = {now.Year}";
            DataTable currentMonthExpensesDt = Con.GetData(currentMonthExpensesQuery);
            ExpMonth.Text = "Expenses This Month: " + currentMonthExpensesDt.Rows[0][0].ToString();

            string currentMonthExpensesAmountQuery = $"SELECT SUM(ExpAmt) FROM ExpenseTbl WHERE MONTH(ExpDate) = {now.Month} AND YEAR(ExpDate) = {now.Year}";
            DataTable currentMonthExpensesAmountDt = Con.GetData(currentMonthExpensesAmountQuery);
            ExpAmtMonth.Text = "Amount This Month: $" + currentMonthExpensesAmountDt.Rows[0][0].ToString();
        }

        private void UpdateIncomes()
        {
            string totalIncomesQuery = "SELECT COUNT(*) FROM IncomeTbl";
            DataTable totalIncomesDt = Con.GetData(totalIncomesQuery);
            IncTotal.Text = "Total Incomes: " + totalIncomesDt.Rows[0][0].ToString();

            string totalIncomesAmountQuery = "SELECT SUM(IncAmt) FROM IncomeTbl";
            DataTable totalIncomesAmountDt = Con.GetData(totalIncomesAmountQuery);
            IncAmtTotal.Text = "Total Amount: $" + totalIncomesAmountDt.Rows[0][0].ToString();

            DateTime now = DateTime.Now;
            string currentMonthIncomesQuery = $"SELECT COUNT(*) FROM IncomeTbl WHERE MONTH(IncDate) = {now.Month} AND YEAR(IncDate) = {now.Year}";
            DataTable currentMonthIncomesDt = Con.GetData(currentMonthIncomesQuery);
            IncMonth.Text = "Incomes This Month: " + currentMonthIncomesDt.Rows[0][0].ToString();

            string currentMonthIncomesAmountQuery = $"SELECT SUM(IncAmt) FROM IncomeTbl WHERE MONTH(IncDate) = {now.Month} AND YEAR(IncDate) = {now.Year}";
            DataTable currentMonthIncomesAmountDt = Con.GetData(currentMonthIncomesAmountQuery);
            IncAmtMonth.Text = "Amount This Month: $" + currentMonthIncomesAmountDt.Rows[0][0].ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expenses obj = new Expenses();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IncLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
