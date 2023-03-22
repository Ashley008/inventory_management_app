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

namespace tawa
{
    public partial class Signup : Form
    {
        string ConStr = @"Data Source=CLYDEN\SQLEXPRESS;Initial Catalog = DBMSProj; Integrated Security = True";
        SqlConnection con;

        public Signup()
        {
            InitializeComponent();
            con = new SqlConnection(ConStr);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Regester_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password does not match...");
            }
            else
            {
                string query = @"INSERT INTO [dbo].[SignUp]
               ([username]
               ,[password])
         VALUES
               ('" + textBox2.Text + "','" + textBox3.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account successfully created!");
                con.Close();
                Form frm = new login();
                frm.Show();
                this.Hide();
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            Form frm = new login();
            frm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
    }
}