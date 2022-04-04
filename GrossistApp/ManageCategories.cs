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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\derha\OneDrive\Documents\OrdersAndCustomersDB.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder buillder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGY.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + CategorieId.Text + "', '" + CategorieName.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category Successfully Added");
            Con.Close();
            populate();
        }

        private void CategorieId_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CatName= '" + CategorieName.Text + "'where CatId='" + CategorieId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CategorieId.Text == "")
            {
                MessageBox.Show("Enter The CategoryId");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from CategoryTbl where CatId= '" + CategorieId.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoriesGY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategorieId.Text = CategoriesGY.SelectedCells[0].Value.ToString();
            CategorieName.Text = CategoriesGY.SelectedCells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
