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

namespace GrossistApp
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\derha\OneDrive\Documents\OrdersAndCustomersDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder buillder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGY.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + unameTb.Text + "', '" + FnameTb.Text + "' , '" + PasswordTb.Text + "', '" + phoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

               
            }
        }

        private void UsersGY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGY.SelectedCells[0].Value.ToString();
            FnameTb.Text = UsersGY.SelectedCells[1].Value.ToString();
            PasswordTb.Text = UsersGY.SelectedCells[2].Value.ToString();
            phoneTb.Text = UsersGY.SelectedCells[3].Value.ToString();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (phoneTb.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from UserTbl where Uphone= '" + phoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void unameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='"+unameTb.Text+"',UFullName= '"+FnameTb.Text+"',Upassword='"+PasswordTb.Text+"' where Uphone='"+phoneTb.Text+"'",Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
