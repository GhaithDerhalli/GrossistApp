namespace GrossistApp
{
    partial class ManageProducts
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductsGY = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.SearchCombo2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 895);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1824, 34);
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
            this.panel1.Size = new System.Drawing.Size(1824, 150);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(776, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(684, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "My System";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "ProductId";
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(54, 219);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(327, 31);
            this.ProductId.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "ProductName";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(52, 296);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(327, 31);
            this.ProductName.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "ProductPrice";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(49, 466);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(327, 31);
            this.ProductPrice.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Description";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(50, 547);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(327, 31);
            this.Description.TabIndex = 43;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // CatCombo
            // 
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(50, 611);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(330, 33);
            this.CatCombo.TabIndex = 45;
            this.CatCombo.Text = "Product Category";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(121, 798);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 61);
            this.button4.TabIndex = 49;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(271, 740);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 48;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(163, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 47;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(56, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1186, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 46);
            this.label10.TabIndex = 51;
            this.label10.Text = "products List";
            // 
            // ProductsGY
            // 
            this.ProductsGY.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsGY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ProductsGY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGY.GridColor = System.Drawing.Color.Crimson;
            this.ProductsGY.Location = new System.Drawing.Point(799, 268);
            this.ProductsGY.Name = "ProductsGY";
            this.ProductsGY.RowHeadersWidth = 62;
            this.ProductsGY.RowTemplate.Height = 33;
            this.ProductsGY.Size = new System.Drawing.Size(989, 609);
            this.ProductsGY.TabIndex = 50;
            this.ProductsGY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGY_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "ProductQuantity";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Location = new System.Drawing.Point(48, 383);
            this.ProductQuantity.Multiline = true;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(327, 31);
            this.ProductQuantity.TabIndex = 52;
            // 
            // SearchCombo2
            // 
            this.SearchCombo2.FormattingEnabled = true;
            this.SearchCombo2.Location = new System.Drawing.Point(1144, 219);
            this.SearchCombo2.Name = "SearchCombo2";
            this.SearchCombo2.Size = new System.Drawing.Size(330, 33);
            this.SearchCombo2.TabIndex = 54;
            this.SearchCombo2.Text = "Select Category";
            this.SearchCombo2.SelectedIndexChanged += new System.EventHandler(this.SearchCombo2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1471, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 34);
            this.button5.TabIndex = 55;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1566, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 34);
            this.button6.TabIndex = 56;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 929);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SearchCombo2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProductsGY);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label13;
        private TextBox ProductId;
        private Label label3;
        private TextBox ProductName;
        private Label label5;
        private TextBox ProductPrice;
        private Label label6;
        private TextBox Description;
        private ComboBox CatCombo;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label10;
        private DataGridView ProductsGY;
        private Label label8;
        private TextBox ProductQuantity;
        private ComboBox SearchCombo2;
        private Button button5;
        private Button button6;
    }
}