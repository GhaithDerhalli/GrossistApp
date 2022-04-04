namespace GrossistApp
{
    partial class ManageOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchCombo2 = new System.Windows.Forms.ComboBox();
            this.ProductsGY = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.CustomersGY = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.Cust = new System.Windows.Forms.Label();
            this.OrDa = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTbl = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGY)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(854, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(752, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "My System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 839);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 34);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 150);
            this.panel1.TabIndex = 29;
            // 
            // SearchCombo2
            // 
            this.SearchCombo2.FormattingEnabled = true;
            this.SearchCombo2.Location = new System.Drawing.Point(1294, 173);
            this.SearchCombo2.Name = "SearchCombo2";
            this.SearchCombo2.Size = new System.Drawing.Size(363, 33);
            this.SearchCombo2.TabIndex = 55;
            this.SearchCombo2.Text = "Select Category";
            this.SearchCombo2.SelectedIndexChanged += new System.EventHandler(this.SearchCombo2_SelectedIndexChanged);
            this.SearchCombo2.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo2_SelectionChangeCommitted);
            // 
            // ProductsGY
            // 
            this.ProductsGY.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsGY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsGY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGY.GridColor = System.Drawing.Color.Crimson;
            this.ProductsGY.Location = new System.Drawing.Point(903, 228);
            this.ProductsGY.Name = "ProductsGY";
            this.ProductsGY.RowHeadersWidth = 62;
            this.ProductsGY.RowTemplate.Height = 33;
            this.ProductsGY.Size = new System.Drawing.Size(942, 232);
            this.ProductsGY.TabIndex = 56;
            this.ProductsGY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1328, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(1327, 498);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(359, 31);
            this.QtyTb.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1693, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 59;
            this.button1.Text = "Add to order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderGv
            // 
            this.OrderGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.GridColor = System.Drawing.Color.Crimson;
            this.OrderGv.Location = new System.Drawing.Point(-135, 535);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersWidth = 62;
            this.OrderGv.RowTemplate.Height = 33;
            this.OrderGv.Size = new System.Drawing.Size(1821, 259);
            this.OrderGv.TabIndex = 60;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(906, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "ProductId";
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(905, 498);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(359, 31);
            this.ProductId.TabIndex = 63;
            this.ProductId.TextChanged += new System.EventHandler(this.ProductId_TextChanged);
            // 
            // CustomersGY
            // 
            this.CustomersGY.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersGY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CustomersGY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGY.GridColor = System.Drawing.Color.Crimson;
            this.CustomersGY.Location = new System.Drawing.Point(26, 228);
            this.CustomersGY.Name = "CustomersGY";
            this.CustomersGY.RowHeadersWidth = 62;
            this.CustomersGY.RowTemplate.Height = 33;
            this.CustomersGY.Size = new System.Drawing.Size(769, 232);
            this.CustomersGY.TabIndex = 30;
            this.CustomersGY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersInOrdersGY_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(152, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 37);
            this.label10.TabIndex = 37;
            this.label10.Text = "Customers List";
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(370, 498);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(359, 31);
            this.CustomerId.TabIndex = 65;
            this.CustomerId.TextChanged += new System.EventHandler(this.CustomerId_TextChanged);
            // 
            // Cust
            // 
            this.Cust.AutoSize = true;
            this.Cust.Location = new System.Drawing.Point(370, 470);
            this.Cust.Name = "Cust";
            this.Cust.Size = new System.Drawing.Size(110, 25);
            this.Cust.TabIndex = 67;
            this.Cust.Text = "CustomerId";
            // 
            // OrDa
            // 
            this.OrDa.AutoSize = true;
            this.OrDa.Location = new System.Drawing.Point(26, 470);
            this.OrDa.Name = "OrDa";
            this.OrDa.Size = new System.Drawing.Size(101, 25);
            this.OrDa.TabIndex = 68;
            this.OrDa.Text = "OrderDate";
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(26, 496);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(300, 31);
            this.OrderDate.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Id";
            // 
            // IdTbl
            // 
            this.IdTbl.Location = new System.Drawing.Point(771, 496);
            this.IdTbl.Name = "IdTbl";
            this.IdTbl.Size = new System.Drawing.Size(94, 31);
            this.IdTbl.TabIndex = 70;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1693, 733);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 61);
            this.button4.TabIndex = 72;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 873);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTbl);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.OrDa);
            this.Controls.Add(this.Cust);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.ProductsGY);
            this.Controls.Add(this.SearchCombo2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomersGY);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "ManageOrders";
            this.Text = "View orders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private ComboBox SearchCombo2;
        private DataGridView ProductsGY;
        private Label label4;
        private TextBox QtyTb;
        private Button button1;
        private DataGridView OrderGv;
        private Label label6;
        private TextBox ProductId;
        private DataGridView CustomersGY;
        private Label label10;
        private TextBox CustomerId;
        private Label Cust;
        private Label OrDa;
        private DateTimePicker OrderDate;
        private Label label3;
        private TextBox IdTbl;
        private Button button4;
    }
}