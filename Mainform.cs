using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace finance_manager_project
{
    public partial class Mainform : Form
    {
        SqlConnection Sqlcon;
        SqlCommand Cmd;

        SqlDataAdapter SqlAdap;
        SqlCommand SqlCmd;
        public Mainform()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void chtmonth_Click(object sender, EventArgs e)
        
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Expense1 by Category");

            SqlConnection con = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;");
            con.Open();

            string query = "SELECT Category, SUM(Amount) AS Total FROM Expense1 GROUP BY Category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            Series series = new Series
            {
                Name = "Categories",
                ChartType = SeriesChartType.Bar
            };

            while (reader.Read())
            {
                string category = reader["Category"].ToString();
                decimal total = Convert.ToDecimal(reader["Total"]);
                series.Points.AddXY(category, total);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Interval = 1; // Ensure all labels show
            chart1.Legends[0].Enabled = false;

            con.Close();
        }

        

        private void Mainform_Load(object sender, EventArgs e)
        {
            
            try
            {
                Sqlcon = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;");
                Sqlcon.Open();



                if (Sqlcon.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected successfully.");
                }
                else
                {
                    MessageBox.Show("Connection failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
            }
        }
        private void Loaddata()
        {
            try
            {
                // Load Current Balance
                SqlCommand cmd = new SqlCommand("SELECT * Transection ", Sqlcon);
                object incomeResult = cmd.ExecuteScalar();
                decimal totalIncome = incomeResult != DBNull.Value ? Convert.ToDecimal(incomeResult) : 0;

                cmd.CommandText = "SELECT SUM(amount) FROM Transection WHERE type = 'Expense'";
                object expenseResult = cmd.ExecuteScalar();
                decimal totalExpenses = expenseResult != DBNull.Value ? Convert.ToDecimal(expenseResult) : 0;

                decimal currentBalance = totalIncome - totalExpenses;
                lblCurrent.Text = $"$ {currentBalance:0.00}";
                lbltotal.Text = $"$ {totalIncome:0.00}";
                lblexpense.Text = $"$ {totalExpenses:0.00}";

                // Load Chart Data
                LoadChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void LoadChart()
        {
            chart1.Series[0].Points.Clear();
            string query = "SELECT category, SUM(amount) FROM Transection WHERE type = 'Expense' GROUP BY category";

            using (SqlCommand cmd = new SqlCommand(query, Sqlcon))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    chart1.Series[0].Points.AddXY(reader.GetString(0), reader.GetDecimal(1));
                }
            }
        }

        private void btntransection_Click(object sender, EventArgs e)
        {
            AddTransectionForm addTransectionForm = new AddTransectionForm();
            addTransectionForm.ShowDialog();    
            
           
        
            
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "30000";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            using (SqlConnection con = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;"))
            {
                con.Open();

                // Get total income
                string incomeQuery = "SELECT SUM(Amount) FROM Expense1 WHERE Category = 'Income'";
                using (SqlCommand incomeCmd = new SqlCommand(incomeQuery, con))
                {
                    object incomeResult = incomeCmd.ExecuteScalar();
                    if (incomeResult != DBNull.Value)
                    {
                        totalIncome = Convert.ToDecimal(incomeResult);
                    }
                }

                // Get total expenses
                string expenseQuery = "SELECT SUM(Amount) FROM Expense1 WHERE Category = 'Income'";
                using (SqlCommand expenseCmd = new SqlCommand(expenseQuery, con))
                {
                    object expenseResult = expenseCmd.ExecuteScalar();
                    if (expenseResult != DBNull.Value)
                    {
                        totalExpenses = Convert.ToDecimal(expenseResult);
                    }
                }
            }

            decimal balance = totalIncome - totalExpenses;
            textBox3.Text = balance.ToString("C"); // e.g., ₹15,000.00
        }


        

        private void textBox3_TextChanged(object sender, EventArgs e)
        
        {
            decimal totalExpenses = 0;

            using (SqlConnection con = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;"))
            {
                con.Open();

                // Get all transactions that are NOT income
                string query = "SELECT SUM(Amount) FROM Expense1 WHERE Category != 'Income'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalExpenses = Convert.ToDecimal(result);
                    }
                }
            }

            textBox2.Text = totalExpenses.ToString("C"); // e.g., ₹20,000.00
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask the user if they are sure they want to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks 'No', cancel the close event
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                // Close the entire application
                Application.Exit();
            }
        }


    }
}


