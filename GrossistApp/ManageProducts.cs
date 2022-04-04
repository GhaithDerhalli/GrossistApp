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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\derha\OneDrive\Documents\OrdersAndCustomersDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo2.ValueMember = "CatName";
                SearchCombo2.DataSource = dt;

                Con.Close();
            }
            catch 
            {

            }
        }
        
        void populate()
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
        void filterByCategory()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from ProductTbl where ProductCat='"+SearchCombo2.SelectedValue.ToString()+"'";
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
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProductId.Text + "', '" + ProductName.Text + "', '" + ProductPrice.Text + "', '" + ProductQuantity.Text + "', '" + Description.Text + "', '" + CatCombo.SelectedValue.ToString() + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Successfully Added");
            Con.Close();
            populate();
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProductName='"+ProductName.Text+"',ProductQuantity='"+ProductQuantity.Text+"',ProductPrice='"+ProductPrice.Text +"',ProductDesc='" + Description.Text + "',ProductCat='" + CatCombo.SelectedValue.ToString() + "' where ProductId='"+ ProductId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {


            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProductId.Text == "")
            {
                MessageBox.Show("Enter The ProductId");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from ProductTbl where ProductId= '" + ProductId.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void ProductsGY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId.Text = ProductsGY.SelectedCells[0].Value.ToString();
            ProductName.Text = ProductsGY.SelectedCells[1].Value.ToString();
            ProductPrice.Text = ProductsGY.SelectedCells[1].Value.ToString();
            ProductQuantity.Text = ProductsGY.SelectedCells[1].Value.ToString();
            Description.Text = ProductsGY.SelectedCells[1].Value.ToString();
            CatCombo.Text = ProductsGY.SelectedCells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void SearchCombo2_SelectedIndexChanged(object sender, EventArgs e)
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
