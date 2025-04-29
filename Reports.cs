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
using System.Windows.Forms.DataVisualization.Charting;

namespace finance_manager_project
{
   
    public partial class Reports : Form
      
    
    {
        public Reports()
        {
            InitializeComponent();
            chart1.Titles.Add("Pie Chart");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Food", "48%");
            chart1.Series["s1"].Points.AddXY("Rent", "12%");
            chart1.Series["s1"].Points.AddXY("Transport", "12%");
            chart1.Series["s1"].Points.AddXY("Other", "22%");
            
        
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Expenses by Category");

            using (SqlConnection con = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;"))
            {
                con.Open();

                string query = "SELECT Category, SUM(Amount) AS Total FROM Expense1 GROUP BY Category";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    var series = new Series
                    {
                        Name = "Categories",
                        ChartType = SeriesChartType.Pie,          // ← pie chart
                        IsValueShownAsLabel = true,               // show values on slices
                        LabelFormat = "#,0"                       // integer format
                    };

                    while (reader.Read())
                    {
                        string category = reader["Category"].ToString();
                        decimal total = Convert.ToDecimal(reader["Total"]);
                        series.Points.AddXY(category, total);
                    }

                    chart1.Series.Add(series);
                    chart1.Legends[0].Enabled = true;   // show legend
                }
            }
        }


        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT Type, SUM(Amount) AS Total FROM [Transection] GROUP BY Type";

                SqlConnection SqlCon = null;
                using (SqlCommand cmd = new SqlCommand(query, SqlCon )) // assuming sqlcon is your connection
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Clear previous data
                    chart1.Series.Clear();
                    chart1.Titles.Clear();

                    Series series = new Series("Report");
                    series.ChartType = SeriesChartType.Pie;

                    while (reader.Read())
                    {
                        string type = reader["Type"].ToString();
                        decimal total = Convert.ToDecimal(reader["Total"]);

                        series.Points.AddXY(type, total);
                    }

                    chart1.Series.Add(series);
                    chart1.Titles.Add("Income vs Expense");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }
    }
}
