using System.Data;
using System.Data.SqlClient;

namespace GrossistApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\derha\OneDrive\Documents\OrdersAndCustomersDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTbl where Uname = '" + UserTbl.Text + "' and Upassword = '" + PasswordTbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password");
            }
            Con.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                PasswordTbl.UseSystemPasswordChar = false;
            else
                PasswordTbl.UseSystemPasswordChar = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserTbl.Text = "";
            PasswordTbl.Text = "";
        }
    }
}