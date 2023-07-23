
namespace Electronics_Store
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_All_Products = new System.Windows.Forms.Button();
            this.btn_update_product = new System.Windows.Forms.Button();
            this.tb_Material = new System.Windows.Forms.TextBox();
            this.tb_Memory = new System.Windows.Forms.TextBox();
            this.tb_Camera = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.cb_Select_Category = new System.Windows.Forms.ComboBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.dataGrid_basket = new System.Windows.Forms.DataGridView();
            this.Add_product = new System.Windows.Forms.Button();
            this.btn_remove_product = new System.Windows.Forms.Button();
            this.cb_show_category = new System.Windows.Forms.ComboBox();
            this.check_box_Disk_slot = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_basket)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(444, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 49);
            this.label1.TabIndex = 19;
            this.label1.Text = "Electronics Store ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.check_box_Disk_slot);
            this.panel1.Controls.Add(this.cb_show_category);
            this.panel1.Controls.Add(this.btn_All_Products);
            this.panel1.Controls.Add(this.btn_update_product);
            this.panel1.Controls.Add(this.tb_Material);
            this.panel1.Controls.Add(this.tb_Memory);
            this.panel1.Controls.Add(this.tb_Camera);
            this.panel1.Controls.Add(this.tb_Price);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.tb_Product_Name);
            this.panel1.Controls.Add(this.cb_Select_Category);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.dataGrid_basket);
            this.panel1.Controls.Add(this.Add_product);
            this.panel1.Controls.Add(this.btn_remove_product);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 693);
            this.panel1.TabIndex = 20;
            // 
            // btn_All_Products
            // 
            this.btn_All_Products.BackColor = System.Drawing.Color.White;
            this.btn_All_Products.FlatAppearance.BorderSize = 0;
            this.btn_All_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_All_Products.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All_Products.ForeColor = System.Drawing.Color.Teal;
            this.btn_All_Products.Location = new System.Drawing.Point(480, 12);
            this.btn_All_Products.Name = "btn_All_Products";
            this.btn_All_Products.Size = new System.Drawing.Size(242, 49);
            this.btn_All_Products.TabIndex = 34;
            this.btn_All_Products.Text = "All Products\r\n";
            this.btn_All_Products.UseVisualStyleBackColor = false;
            this.btn_All_Products.Click += new System.EventHandler(this.btn_All_Products_Click);
            // 
            // btn_update_product
            // 
            this.btn_update_product.BackColor = System.Drawing.Color.White;
            this.btn_update_product.FlatAppearance.BorderSize = 0;
            this.btn_update_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_product.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_product.ForeColor = System.Drawing.Color.Teal;
            this.btn_update_product.Location = new System.Drawing.Point(9, 517);
            this.btn_update_product.Name = "btn_update_product";
            this.btn_update_product.Size = new System.Drawing.Size(242, 50);
            this.btn_update_product.TabIndex = 33;
            this.btn_update_product.Text = "Update Product";
            this.btn_update_product.UseVisualStyleBackColor = false;
            this.btn_update_product.Click += new System.EventHandler(this.btn_update_product_Click);
            // 
            // tb_Material
            // 
            this.tb_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Material.Location = new System.Drawing.Point(10, 404);
            this.tb_Material.Name = "tb_Material";
            this.tb_Material.Size = new System.Drawing.Size(227, 41);
            this.tb_Material.TabIndex = 32;
            this.tb_Material.Text = "Material";
            this.tb_Material.TextChanged += new System.EventHandler(this.Material_TextChanged);
            // 
            // tb_Memory
            // 
            this.tb_Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Memory.Location = new System.Drawing.Point(10, 243);
            this.tb_Memory.Name = "tb_Memory";
            this.tb_Memory.Size = new System.Drawing.Size(227, 41);
            this.tb_Memory.TabIndex = 27;
            this.tb_Memory.Text = "Memory";
            this.tb_Memory.TextChanged += new System.EventHandler(this.tb_Memory_TextChanged);
            // 
            // tb_Camera
            // 
            this.tb_Camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Camera.Location = new System.Drawing.Point(10, 350);
            this.tb_Camera.Name = "tb_Camera";
            this.tb_Camera.Size = new System.Drawing.Size(227, 41);
            this.tb_Camera.TabIndex = 26;
            this.tb_Camera.Text = "Camera";
            this.tb_Camera.TextChanged += new System.EventHandler(this.tb_Camera_TextChanged);
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Price.Location = new System.Drawing.Point(10, 186);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(227, 41);
            this.tb_Price.TabIndex = 25;
            this.tb_Price.Text = "Price";
            this.tb_Price.TextChanged += new System.EventHandler(this.tb_Price_TextChanged);
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Id.Location = new System.Drawing.Point(10, 74);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(227, 41);
            this.tb_Id.TabIndex = 24;
            this.tb_Id.Text = "Id";
            this.tb_Id.TextChanged += new System.EventHandler(this.tb_Id_TextChanged);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Product_Name.Location = new System.Drawing.Point(10, 130);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(227, 41);
            this.tb_Product_Name.TabIndex = 23;
            this.tb_Product_Name.Text = "Product Name";
            this.tb_Product_Name.TextChanged += new System.EventHandler(this.product_name_TextChanged);
            // 
            // cb_Select_Category
            // 
            this.cb_Select_Category.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Select_Category.ForeColor = System.Drawing.Color.Black;
            this.cb_Select_Category.FormattingEnabled = true;
            this.cb_Select_Category.Items.AddRange(new object[] {
            "Computer",
            "Phone",
            "Case"});
            this.cb_Select_Category.Location = new System.Drawing.Point(7, 7);
            this.cb_Select_Category.Name = "cb_Select_Category";
            this.cb_Select_Category.Size = new System.Drawing.Size(265, 40);
            this.cb_Select_Category.TabIndex = 21;
            this.cb_Select_Category.Text = "Select Category";
            this.cb_Select_Category.SelectedIndexChanged += new System.EventHandler(this.CbSelectRole_SelectedIndexChanged);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 634);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(126, 51);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // dataGrid_basket
            // 
            this.dataGrid_basket.AllowUserToAddRows = false;
            this.dataGrid_basket.AllowUserToDeleteRows = false;
            this.dataGrid_basket.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_basket.Location = new System.Drawing.Point(269, 71);
            this.dataGrid_basket.Name = "dataGrid_basket";
            this.dataGrid_basket.ReadOnly = true;
            this.dataGrid_basket.RowHeadersWidth = 92;
            this.dataGrid_basket.RowTemplate.Height = 37;
            this.dataGrid_basket.Size = new System.Drawing.Size(919, 605);
            this.dataGrid_basket.TabIndex = 18;
            this.dataGrid_basket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_basket_CellContentClick);
            // 
            // Add_product
            // 
            this.Add_product.BackColor = System.Drawing.Color.White;
            this.Add_product.FlatAppearance.BorderSize = 0;
            this.Add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_product.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_product.ForeColor = System.Drawing.Color.Teal;
            this.Add_product.Location = new System.Drawing.Point(10, 460);
            this.Add_product.Name = "Add_product";
            this.Add_product.Size = new System.Drawing.Size(242, 44);
            this.Add_product.TabIndex = 17;
            this.Add_product.Text = "Add Product";
            this.Add_product.UseVisualStyleBackColor = false;
            this.Add_product.Click += new System.EventHandler(this.Add_product_Click);
            // 
            // btn_remove_product
            // 
            this.btn_remove_product.BackColor = System.Drawing.Color.White;
            this.btn_remove_product.FlatAppearance.BorderSize = 0;
            this.btn_remove_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_product.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_product.ForeColor = System.Drawing.Color.Teal;
            this.btn_remove_product.Location = new System.Drawing.Point(7, 582);
            this.btn_remove_product.Name = "btn_remove_product";
            this.btn_remove_product.Size = new System.Drawing.Size(242, 46);
            this.btn_remove_product.TabIndex = 16;
            this.btn_remove_product.Text = "Remove Product";
            this.btn_remove_product.UseVisualStyleBackColor = false;
            this.btn_remove_product.Click += new System.EventHandler(this.btn_remove_product_Click);
            // 
            // cb_show_category
            // 
            this.cb_show_category.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_show_category.ForeColor = System.Drawing.Color.Black;
            this.cb_show_category.FormattingEnabled = true;
            this.cb_show_category.Items.AddRange(new object[] {
            "Computers",
            "Phones",
            "Cases"});
            this.cb_show_category.Location = new System.Drawing.Point(933, 14);
            this.cb_show_category.Name = "cb_show_category";
            this.cb_show_category.Size = new System.Drawing.Size(251, 40);
            this.cb_show_category.TabIndex = 35;
            this.cb_show_category.Text = "Show Category";
            this.cb_show_category.SelectedIndexChanged += new System.EventHandler(this.cb_show_category_SelectedIndexChanged);
            // 
            // check_box_Disk_slot
            // 
            this.check_box_Disk_slot.AutoSize = true;
            this.check_box_Disk_slot.BackColor = System.Drawing.Color.White;
            this.check_box_Disk_slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.check_box_Disk_slot.Location = new System.Drawing.Point(13, 298);
            this.check_box_Disk_slot.Name = "check_box_Disk_slot";
            this.check_box_Disk_slot.Size = new System.Drawing.Size(165, 40);
            this.check_box_Disk_slot.TabIndex = 36;
            this.check_box_Disk_slot.Text = "Disk Slot";
            this.check_box_Disk_slot.UseVisualStyleBackColor = false;
            this.check_box_Disk_slot.CheckedChanged += new System.EventHandler(this.check_box_Disk_slot_CheckedChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.ComboBox cb_Select_Category;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DataGridView dataGrid_basket;
        private System.Windows.Forms.Button Add_product;
        private System.Windows.Forms.Button btn_remove_product;
        private System.Windows.Forms.TextBox tb_Material;
        private System.Windows.Forms.TextBox tb_Memory;
        private System.Windows.Forms.TextBox tb_Camera;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Button btn_update_product;
        private System.Windows.Forms.Button btn_All_Products;
        private System.Windows.Forms.ComboBox cb_show_category;
        private System.Windows.Forms.CheckBox check_box_Disk_slot;
    }
}