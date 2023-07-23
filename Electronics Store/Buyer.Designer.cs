
namespace Electronics_Store
{
    partial class Buyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyer));
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_basket = new System.Windows.Forms.Label();
            this.btn_pay_now = new System.Windows.Forms.Button();
            this.lbl_total_counter = new System.Windows.Forms.Label();
            this.lbl_totalOrder = new System.Windows.Forms.Label();
            this.dataGrid_view = new System.Windows.Forms.DataGridView();
            this.dataGrid_basket = new System.Windows.Forms.DataGridView();
            this.cbSelectRole = new System.Windows.Forms.ComboBox();
            this.lbl_item_Search = new System.Windows.Forms.Label();
            this.btn_add_to_cart = new System.Windows.Forms.Button();
            this.btn_remove_from_cart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_basket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Teal;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(12, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(120, 82);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 17;
            this.btnLogo.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Teal;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1133, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(126, 79);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbl_basket);
            this.panel1.Controls.Add(this.btn_pay_now);
            this.panel1.Controls.Add(this.lbl_total_counter);
            this.panel1.Controls.Add(this.lbl_totalOrder);
            this.panel1.Controls.Add(this.dataGrid_view);
            this.panel1.Controls.Add(this.dataGrid_basket);
            this.panel1.Controls.Add(this.cbSelectRole);
            this.panel1.Controls.Add(this.lbl_item_Search);
            this.panel1.Controls.Add(this.btn_add_to_cart);
            this.panel1.Controls.Add(this.btn_remove_from_cart);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 692);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_basket
            // 
            this.lbl_basket.AutoSize = true;
            this.lbl_basket.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_basket.ForeColor = System.Drawing.Color.White;
            this.lbl_basket.Location = new System.Drawing.Point(0, 0);
            this.lbl_basket.Name = "lbl_basket";
            this.lbl_basket.Size = new System.Drawing.Size(357, 56);
            this.lbl_basket.TabIndex = 28;
            this.lbl_basket.Text = "Shopping Cart";
            // 
            // btn_pay_now
            // 
            this.btn_pay_now.BackColor = System.Drawing.Color.White;
            this.btn_pay_now.FlatAppearance.BorderSize = 0;
            this.btn_pay_now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay_now.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay_now.ForeColor = System.Drawing.Color.Teal;
            this.btn_pay_now.Location = new System.Drawing.Point(10, 626);
            this.btn_pay_now.Name = "btn_pay_now";
            this.btn_pay_now.Size = new System.Drawing.Size(474, 59);
            this.btn_pay_now.TabIndex = 27;
            this.btn_pay_now.Text = "Pay Now";
            this.btn_pay_now.UseVisualStyleBackColor = false;
            this.btn_pay_now.Click += new System.EventHandler(this.btn_pay_now_Click);
            // 
            // lbl_total_counter
            // 
            this.lbl_total_counter.AutoSize = true;
            this.lbl_total_counter.BackColor = System.Drawing.Color.White;
            this.lbl_total_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_total_counter.Location = new System.Drawing.Point(184, 580);
            this.lbl_total_counter.Name = "lbl_total_counter";
            this.lbl_total_counter.Size = new System.Drawing.Size(27, 29);
            this.lbl_total_counter.TabIndex = 26;
            this.lbl_total_counter.Text = "0";
            this.lbl_total_counter.Click += new System.EventHandler(this.lbl_total_counter_Click);
            // 
            // lbl_totalOrder
            // 
            this.lbl_totalOrder.AutoSize = true;
            this.lbl_totalOrder.BackColor = System.Drawing.Color.White;
            this.lbl_totalOrder.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalOrder.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalOrder.Location = new System.Drawing.Point(11, 579);
            this.lbl_totalOrder.Name = "lbl_totalOrder";
            this.lbl_totalOrder.Size = new System.Drawing.Size(149, 28);
            this.lbl_totalOrder.TabIndex = 25;
            this.lbl_totalOrder.Text = "Total order :";
            this.lbl_totalOrder.Click += new System.EventHandler(this.lbl_totalOrder_Click);
            // 
            // dataGrid_view
            // 
            this.dataGrid_view.AllowUserToAddRows = false;
            this.dataGrid_view.AllowUserToDeleteRows = false;
            this.dataGrid_view.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_view.Location = new System.Drawing.Point(496, 66);
            this.dataGrid_view.Name = "dataGrid_view";
            this.dataGrid_view.ReadOnly = true;
            this.dataGrid_view.RowHeadersWidth = 92;
            this.dataGrid_view.RowTemplate.Height = 37;
            this.dataGrid_view.Size = new System.Drawing.Size(743, 619);
            this.dataGrid_view.TabIndex = 24;
            this.dataGrid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_view_CellContentClick);
            // 
            // dataGrid_basket
            // 
            this.dataGrid_basket.AllowUserToAddRows = false;
            this.dataGrid_basket.AllowUserToDeleteRows = false;
            this.dataGrid_basket.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGrid_basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_basket.Location = new System.Drawing.Point(10, 66);
            this.dataGrid_basket.Name = "dataGrid_basket";
            this.dataGrid_basket.ReadOnly = true;
            this.dataGrid_basket.RowHeadersWidth = 92;
            this.dataGrid_basket.RowTemplate.Height = 37;
            this.dataGrid_basket.Size = new System.Drawing.Size(474, 343);
            this.dataGrid_basket.TabIndex = 22;
            this.dataGrid_basket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_basket_CellContentClick);
            // 
            // cbSelectRole
            // 
            this.cbSelectRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectRole.ForeColor = System.Drawing.Color.Black;
            this.cbSelectRole.FormattingEnabled = true;
            this.cbSelectRole.Items.AddRange(new object[] {
            "Computers",
            "Phones",
            "Cases"});
            this.cbSelectRole.Location = new System.Drawing.Point(876, 9);
            this.cbSelectRole.Name = "cbSelectRole";
            this.cbSelectRole.Size = new System.Drawing.Size(363, 51);
            this.cbSelectRole.TabIndex = 21;
            this.cbSelectRole.Text = "Show Category";
            this.cbSelectRole.SelectedIndexChanged += new System.EventHandler(this.cbSelectRole_SelectedIndexChanged);
            // 
            // lbl_item_Search
            // 
            this.lbl_item_Search.AutoSize = true;
            this.lbl_item_Search.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_Search.ForeColor = System.Drawing.Color.White;
            this.lbl_item_Search.Location = new System.Drawing.Point(486, 0);
            this.lbl_item_Search.Name = "lbl_item_Search";
            this.lbl_item_Search.Size = new System.Drawing.Size(303, 56);
            this.lbl_item_Search.TabIndex = 19;
            this.lbl_item_Search.Text = "Item Search";
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.BackColor = System.Drawing.Color.White;
            this.btn_add_to_cart.FlatAppearance.BorderSize = 0;
            this.btn_add_to_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_to_cart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_to_cart.ForeColor = System.Drawing.Color.Teal;
            this.btn_add_to_cart.Location = new System.Drawing.Point(10, 439);
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Size = new System.Drawing.Size(474, 60);
            this.btn_add_to_cart.TabIndex = 17;
            this.btn_add_to_cart.Text = "Add to cart";
            this.btn_add_to_cart.UseVisualStyleBackColor = false;
            this.btn_add_to_cart.Click += new System.EventHandler(this.btn_add_to_cart_Click);
            // 
            // btn_remove_from_cart
            // 
            this.btn_remove_from_cart.BackColor = System.Drawing.Color.White;
            this.btn_remove_from_cart.FlatAppearance.BorderSize = 0;
            this.btn_remove_from_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_from_cart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_from_cart.ForeColor = System.Drawing.Color.Teal;
            this.btn_remove_from_cart.Location = new System.Drawing.Point(10, 505);
            this.btn_remove_from_cart.Name = "btn_remove_from_cart";
            this.btn_remove_from_cart.Size = new System.Drawing.Size(474, 60);
            this.btn_remove_from_cart.TabIndex = 16;
            this.btn_remove_from_cart.Text = "Remove from cart";
            this.btn_remove_from_cart.UseVisualStyleBackColor = false;
            this.btn_remove_from_cart.Click += new System.EventHandler(this.btn_remove_from_cart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(379, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 70);
            this.label1.TabIndex = 18;
            this.label1.Text = "Electronics Store ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_logout);
            this.Name = "Buyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_to_cart;
        private System.Windows.Forms.Button btn_remove_from_cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_item_Search;
        private System.Windows.Forms.ComboBox cbSelectRole;
        private System.Windows.Forms.DataGridView dataGrid_basket;
        private System.Windows.Forms.DataGridView dataGrid_view;
        private System.Windows.Forms.Label lbl_total_counter;
        private System.Windows.Forms.Label lbl_totalOrder;
        private System.Windows.Forms.Button btn_pay_now;
        private System.Windows.Forms.Label lbl_basket;
    }
}