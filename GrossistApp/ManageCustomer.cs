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

namespace GrossistApp
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\derha\OneDrive\Documents\OrdersAndCustomersDB.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder buillder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGY.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {


            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + CustomerIdTB.Text + "', '" + CustomerNameTB.Text + "' , '" + CustomerStoreNameTB.Text + "', '" + CustomerPhoneTB.Text + "', '" + CustomerEmailTB.Text + "', '" + CustomerCityTB.Text + "', '" + CustomerPostAdressCustomer.Text + "', '" + CustomerAdressTB.Text + "', '" + CustomerType.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            
        }

        private void CustomersGY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTB.Text = CustomersGY.SelectedCells[0].Value.ToString();
            CustomerNameTB.Text = CustomersGY.SelectedCells[1].Value.ToString();
            CustomerStoreNameTB.Text = CustomersGY.SelectedCells[2].Value.ToString();
            CustomerPhoneTB.Text = CustomersGY.SelectedCells[3].Value.ToString();
            CustomerEmailTB.Text = CustomersGY.SelectedCells[4].Value.ToString();
            CustomerCityTB.Text = CustomersGY.SelectedCells[5].Value.ToString();
            CustomerPostAdressCustomer.Text = CustomersGY.SelectedCells[6].Value.ToString();
            CustomerAdressTB.Text = CustomersGY.SelectedCells[7].Value.ToString();
            CustomerType.Text = CustomersGY.SelectedCells[8].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIdTB.Text == "")
            {
                MessageBox.Show("Enter The Customer Id");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from CustomerTbl where CustId= '" + CustomerIdTB.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName= '" + CustomerNameTB.Text + "',CustCompanyName='" + CustomerStoreNameTB.Text + "',CustName= '" + CustomerNameTB.Text + "',CustPhone='" + CustomerPhoneTB.Text + "',CustEmail='" + CustomerEmailTB.Text + "',CustCity='" + CustomerCityTB.Text + "',CustPostAdress='" + CustomerPostAdressCustomer.Text + "',CustAdress='" + CustomerAdressTB.Text + "',CustType='" + CustomerType.Text + "', where CustId='" + CustomerIdTB.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {


            }
            
        }

        private void CustomerStoreNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CustomerIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerPhoneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
