using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShortCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //when clicking the exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //when clicking the login button
        private void LogInButton_Click(object sender, EventArgs e)
        {
            /*
            //these lines below are supposed to call a data table with user name and passwords
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Daniel Martin\Documents\Data.mdf';Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username=' " + UserNameTextBox.Text + "' and Password ='" + PasswordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

            //
            */
            
                this.Hide();


                Main ss = new Main();
                ss.Show();
            
            /*
            //
            }
            else
            {
                MessageBox.Show("Please Check your password, Dawg"); 
            }
            //
            */
            
        }


    }
}
