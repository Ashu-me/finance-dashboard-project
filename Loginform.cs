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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace finance_manager_project
{
    

    public partial class Loginform : Form
    {
        SqlConnection Sqlcon;
        
        SqlDataAdapter SqlAdap;
        SqlCommand SqlCmd;

        public Loginform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            private void Form1_Load(object sender, EventArgs e)
            {
            

            try
            {
                    Sqlcon = new SqlConnection("Server=PRADNYEYA\\SQLEXPRESS01;Database=Finance;Integrated Security=True;TrustServerCertificate=True;");
                    Sqlcon.Open();

                    if (Sqlcon.State == ConnectionState.Open)
                    {
                        MessageBox.Show("connection successfully.");
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

            private void btnLogin_Click(object sender, EventArgs e)
            {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

                try
                {
                    string qry = "SELECT * FROM [Users] WHERE Username = @username AND Password = @password";
                    SqlCmd = new SqlCommand(qry, Sqlcon);
                    SqlCmd.Parameters.AddWithValue("@username", Username);
                    SqlCmd.Parameters.AddWithValue("@password", Password);

                    SqlAdap = new SqlDataAdapter(SqlCmd);
                    DataTable dt = new DataTable();
                    SqlAdap.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Mainform mainform = new Mainform();
                        mainform.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("The Username or Password is Invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Login error: {ex.Message}");
                }
                finally
                {
                    Sqlcon.Close();
                }
            }
        }
    }
