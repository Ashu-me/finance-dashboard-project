using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finance_manager_project
{
    
    public partial class AddTransectionForm : Form
    {

        SqlConnection Sqlcon;

        SqlDataAdapter SqlAdap;
        SqlCommand SqlCmd;



        public AddTransectionForm()
        {
            InitializeComponent();
            fillcomboBox1();
            fillcomboBox2();
            
            
            

        }
          private void AddTransectionForm_Load_1(object sender, EventArgs e)
        {
            
        }
        public void fillcomboBox1()
        {
            Sqlcon = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;");
            Sqlcon.Open();
            SqlCmd = new SqlCommand("Select Type From [Expense Catogary]", Sqlcon);
            SqlDataReader reader;
            reader = SqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string Type = reader["Type"].ToString().Trim();

                comboBox1.Items.Add(Type);
            }
           

            reader.Close();
            Sqlcon.Close();
        }
        public void fillcomboBox2()
        {
            Sqlcon = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;");
            Sqlcon.Open();
            SqlCmd = new SqlCommand("Select Category  From [Expense1]", Sqlcon);
            SqlDataReader reader;
            reader = SqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string Category = reader["Category"].ToString();

                comboBox2.Items.Add(Category);
            }
            reader.Close();
            Sqlcon.Close();
        }


      
       

       
       



        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                string Type = comboBox1.SelectedItem?.ToString();
                string Category = comboBox2.SelectedItem?.ToString(); // Assuming it's dropdown too
                Decimal Amount=Decimal.Parse(textBox1.Text);
                DateTime Date = dateTimePicker1.Value.Date;
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid Type from the dropdown.", "Missing Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                try
                {
                    // Ensure Sqlcon is open and initialized
                    if (Sqlcon.State != ConnectionState.Open)
                    {
                        Sqlcon.Open();
                    }

                    string query = "INSERT INTO Expense1 ( Category, Amount, Date) VALUES ( @Category, @Amount, @Date)";
                    using (SqlCommand cmd = new SqlCommand(query, Sqlcon))
                    {
                       
                        cmd.Parameters.AddWithValue("@Category", Category);
                        cmd.Parameters.AddWithValue("@Amount", Amount);
                        cmd.Parameters.AddWithValue("@Date", Date);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close AddTransactionForm after success
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); // Clear current categories
            if (comboBox1.SelectedItem.ToString() == "Home")
            {
                comboBox2.Items.AddRange(new string[] { "Budget", "Child", "Electric Bill", "Self", "Office", "Medical" });
            }
            else if (comboBox1.SelectedItem.ToString() == "Investment")
            {
                comboBox2.Items.AddRange(new string[] { "Stock", "Property" });
            }
            else if (comboBox1.SelectedItem.ToString() == "Vehical")
            {
                comboBox2.Items.AddRange(new string[] { "Petrol", "Service" });
            }
            else if (comboBox1.SelectedItem.ToString() == "Self")
            { 
                comboBox2.Items.AddRange(new string[] { "Haircut", "Shopping", "Travelling" });
            }
            else if (comboBox1.SelectedItem.ToString() == "Medical")
            {
                comboBox2.Items.AddRange(new string[] { "Bills", "observation" });
            }
            else
            {
                comboBox2.Items.AddRange(new string[] { "Salary", "Bonus", "Interest" });
            }

           

        }

            

        


      








        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        {
           
        }


    }


}



}





