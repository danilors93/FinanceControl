using System.Data.SqlClient;

namespace FinanceControl
{
    public partial class Expenses : Form
    {
        Functions Con;
        public Expenses()
        {
            InitializeComponent();
            Con = new Functions();
            ShowExpenses();
        }
        private void ShowExpenses()
        {
            string Query = "select * from ExpenseTbl";
            ExpenseList.DataSource = Con.GetData(Query);
            ExpenseList.Columns["ExpId"].HeaderText = "Id";
            ExpenseList.Columns["ExpName"].HeaderText = "Name";
            ExpenseList.Columns["ExpAmt"].HeaderText = "Amount";
            ExpenseList.Columns["ExpCat"].HeaderText = "Category";
            ExpenseList.Columns["ExpDate"].HeaderText = "Date";
            ExpenseList.Columns["ExpDesc"].HeaderText = "Description";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string EName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "INSERT INTO ExpenseTbl (ExpName, ExpAmt, ExpCat, ExpDate, ExpDesc) VALUES (@Name, @Amt, @Category, @Date, @Description)";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", EName);
                            command.Parameters.AddWithValue("@Amt", Amt);
                            command.Parameters.AddWithValue("@Category", Category);
                            command.Parameters.AddWithValue("@Date", DateTb.Value.Date);
                            command.Parameters.AddWithValue("@Description", Description);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Expense Added!");
                                ShowExpenses();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add income.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void ExpenseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ExpenseList.SelectedRows[0].Cells[1].Value.ToString();
            AmountTb.Text = ExpenseList.SelectedRows[0].Cells[2].Value.ToString();
            CatTb.Text = ExpenseList.SelectedRows[0].Cells[3].Value.ToString();
            //DateTb.Text = ExpenseList.SelectedRows[0].Cells[4].Value.ToString();
            DescTb.Text = ExpenseList.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ExpenseList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Select an Expense");
            }
            else
            {
                try
                {
                    string EName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;

                    string Query = "UPDATE ExpenseTbl SET ExpName = @Name, ExpAmt = @Amt, ExpCat = @Category, ExpDate = @Date, ExpDesc = @Description WHERE ExpId = @Id";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", EName);
                            command.Parameters.AddWithValue("@Amt", Amt);
                            command.Parameters.AddWithValue("@Category", Category);
                            command.Parameters.AddWithValue("@Date", DateTb.Value.Date);
                            command.Parameters.AddWithValue("@Description", Description);
                            command.Parameters.AddWithValue("@Id", key);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Expense Updated!");
                                ShowExpenses();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update expense.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select an Expense");
            }
            else
            {
                try
                {
                    string Query = "DELETE FROM ExpenseTbl WHERE ExpId = @Id";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", key);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Expense Deleted!");
                                ShowExpenses();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete expense.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AmountTb.Text = "";
            CatTb.Text = "";
            DateTb.Value = DateTime.Now;
            DescTb.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
