using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceControl
{
    public partial class Incomes : Form
    {
        Functions Con;
        public Incomes()
        {
            Con = new Functions();
            InitializeComponent();
            ShowIncomes();
        }
        private void ShowIncomes()
        {
            string Query = "select * from IncomeTbl";
            IncomeList.DataSource = Con.GetData(Query);
            IncomeList.Columns["IncId"].HeaderText = "Id";
            IncomeList.Columns["IncName"].HeaderText = "Name";
            IncomeList.Columns["IncAmt"].HeaderText = "Amount";
            IncomeList.Columns["IncCat"].HeaderText = "Category";
            IncomeList.Columns["IncDate"].HeaderText = "Date";
            IncomeList.Columns["IncDesc"].HeaderText = "Description";
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
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
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "INSERT INTO IncomeTbl (IncName, IncAmt, IncCat, IncDate, IncDesc) VALUES (@Name, @Amt, @Category, @Date, @Description)";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", IName);
                            command.Parameters.AddWithValue("@Amt", Amt);
                            command.Parameters.AddWithValue("@Category", Category);
                            command.Parameters.AddWithValue("@Date", DateTb.Value.Date);
                            command.Parameters.AddWithValue("@Description", Description);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Income Added!");
                                ShowIncomes();
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
        private void IncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = IncomeList.SelectedRows[0].Cells[1].Value.ToString();
            AmountTb.Text = IncomeList.SelectedRows[0].Cells[2].Value.ToString();
            CatTb.Text = IncomeList.SelectedRows[0].Cells[3].Value.ToString();
            //DateTb.Text = IncomeList.SelectedRows[0].Cells[4].Value.ToString();
            DescTb.Text = IncomeList.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(IncomeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Select an Income");
            }
            else
            {
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;

                    string Query = "UPDATE IncomeTbl SET IncName = @Name, IncAmt = @Amt, IncCat = @Category, IncDate = @Date, IncDesc = @Description WHERE IncId = @Id";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", IName);
                            command.Parameters.AddWithValue("@Amt", Amt);
                            command.Parameters.AddWithValue("@Category", Category);
                            command.Parameters.AddWithValue("@Date", DateTb.Value.Date);
                            command.Parameters.AddWithValue("@Description", Description);
                            command.Parameters.AddWithValue("@Id", key);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Income Updated!");
                                ShowIncomes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update income.");
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
                MessageBox.Show("Select an Income");
            }
            else
            {
                try
                {
                    string Query = "DELETE FROM IncomeTbl WHERE IncId = @Id";

                    using (SqlConnection connection = new SqlConnection(Con.ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", key);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Income Deleted!");
                                ShowIncomes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete income.");
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expenses obj = new Expenses();
            obj.Show();
            this.Hide();
        }
    }
}
