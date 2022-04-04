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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
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
        void populateProducts()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder buillder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGY.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {


            }
        }
        void populateOrders()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder buillder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {


            }
        }

        void fillCategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo2.ValueMember = "CatName";
                SearchCombo2.DataSource = dt;

                Con.Close();
            }
            catch
            {

            }
        }
        

        private void CustomersInOrdersGY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Cust.Text = CustomersGY.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int num = 0;
        int uprice, totprice, qty;
        string product;
        DataTable table = new DataTable();
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            fillCategory();
            populateOrders();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        int flag = 0;
        int stock;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void SearchCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        int productId = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Enter the quantity of the product");
            }
           
            else if (ProductId.Text == "")
            {
                MessageBox.Show("Enter the Product ID of the product");
            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("No Enough Stock Available");
            }

            else
            {
               
                
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderTbl values('" + IdTbl.Text + "','" + CustomerId.Text + "', '" + ProductId.Text + "', '" + OrderDate.Value + "', '" + QtyTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfully Added");
                Con.Close();
                updateProducts();
                populateProducts();
                populate();
                

            }
            
        }

        void updateProducts()
        {
            Con.Open(); 
            SqlCommand cmd2 = new SqlCommand("update ProductTbl set ProductQuantity = ProductQuantity - " + Convert.ToInt32(QtyTb.Text) + " where ProductId =" + ProductId.Text + "", Con);
            cmd2.ExecuteNonQuery();
            Con.Close();

        }

        private void ProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void SearchCombo2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from ProductTbl where ProductCat='" + SearchCombo2.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder buillder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGY.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {


            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
