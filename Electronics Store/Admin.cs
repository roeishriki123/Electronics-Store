using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electronics_Store.classes ;



namespace Electronics_Store
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(DataManager.saveProd);
            dataGrid_basket.AutoGenerateColumns = true;
        }

        private void product_name_TextChanged(object sender, EventArgs e)
        {



        }

        private void Material_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void dataGrid_basket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_basket.AutoGenerateColumns = true;

        }

        private void Add_product_Click(object sender, EventArgs e)
        {
            int Id, Price;
            string Name;

            if (isValidForm())
            {
                Id = int.Parse(tb_Id.Text);
                Price = int.Parse(tb_Price.Text);
                Name = tb_Product_Name.Text;

                string selection = cb_Select_Category.SelectedItem?.ToString();
                    
                        if (selection == "Computer")
                    {
                        int Memory = int.Parse(tb_Memory.Text);
                        bool HasDiskSpace;
                        HasDiskSpace = check_box_Disk_slot.Checked;
                        Product computer = new Computer(Id, Name, Price, Memory, HasDiskSpace);
                        DataManager.AddProduct(computer);
                    }
                    if (selection == "Phone")
                    {
                        int Memory = int.Parse(tb_Memory.Text);
                        string RearCameraQuality = tb_Camera.Text;
                        Product phone = new Phone(Id, Name, Price, Memory, RearCameraQuality);
                        DataManager.AddProduct(phone);
                    }
                    if (selection == "Case")
                    {
                        String Material = tb_Material.Text;
                        Product caseProduct = new Case(Id, Name, Price, Material);
                        DataManager.AddProduct(caseProduct);
                    }
                    

                    MessageBox.Show("Product Added Successfuly");
                    SetDefaultValues();


            }

        }


        private void tb_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Disk_Slot_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Memory_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Camera_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cb_Select_Category.SelectedItem?.ToString();
            if (selection == "Computer")
            {
                tb_Product_Name.Visible = true;
                tb_Id.Visible = true;
                tb_Price.Visible = true;
                check_box_Disk_slot.Visible = true;
                tb_Camera.Visible = false;
                tb_Material.Visible = false;
                tb_Memory.Visible = true;
            }
            if (selection == "Phone")
            {
                tb_Product_Name.Visible = true;
                tb_Id.Visible = true;
                tb_Price.Visible = true;
                check_box_Disk_slot.Visible = false;
                tb_Camera.Visible = true;
                tb_Material.Visible = false;
                tb_Memory.Visible = true;
            }
            if (selection == "Case")
            {
                tb_Product_Name.Visible = true;
                tb_Id.Visible = true;
                tb_Price.Visible = true;
                check_box_Disk_slot.Visible = false;
                tb_Camera.Visible = false;
                tb_Material.Visible = true;
                tb_Memory.Visible = false;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_All_Products_Click(object sender, EventArgs e)
        {

            BindingList<Product> products = DataManager.GetProducts();
            dataGrid_basket.AutoGenerateColumns = true; // Enable auto-generated columns
            dataGrid_basket.DataSource = products;
            foreach (DataGridViewColumn column in dataGrid_basket.Columns)
            {
                column.HeaderText = column.HeaderText.Replace("_", " ");
            }
        }

        private void btn_remove_product_Click(object sender, EventArgs e)
        {
            if (dataGrid_basket.SelectedCells.Count > 0)
            {
                // Display a confirmation dialog to the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete the product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms the deletion
                if (result == DialogResult.Yes)
                {
                    // Get the index of the selected row in the DataGridView
                    int selectedRowIndex = dataGrid_basket.SelectedCells[0].RowIndex;

                    // Remove the selected row from the DataGridView
                    dataGrid_basket.Rows.RemoveAt(selectedRowIndex);

                    // Perform any additional deletion logic or update data sources as needed
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void cb_show_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cb_show_category.SelectedItem?.ToString();
            if (selection == "Computers")
            {
                BindingList<Computer> computers = DataManager.GetSpecificProduct<Computer>();
                dataGrid_basket.AutoGenerateColumns = true; // Enable auto-generated columns
                dataGrid_basket.DataSource = computers;
                foreach (DataGridViewColumn column in dataGrid_basket.Columns)
                {
                    column.HeaderText = column.HeaderText.Replace("_", " ");
                }
            }
            if (selection == "Phones")
            {
                BindingList<Phone> phones = DataManager.GetSpecificProduct<Phone>();
                dataGrid_basket.AutoGenerateColumns = true; // Enable auto-generated columns
                dataGrid_basket.DataSource = phones;
                foreach (DataGridViewColumn column in dataGrid_basket.Columns)
                {
                    column.HeaderText = column.HeaderText.Replace("_", " ");
                }
            }
            if (selection == "Cases")
            {
                BindingList<Case> cases = DataManager.GetSpecificProduct<Case>();
                dataGrid_basket.AutoGenerateColumns = true; // Enable auto-generated columns
                dataGrid_basket.DataSource = cases;
                foreach (DataGridViewColumn column in dataGrid_basket.Columns)
                {
                    column.HeaderText = column.HeaderText.Replace("_", " ");
                }
            }
        }

        private void check_box_Disk_slot_CheckedChanged(object sender, EventArgs e)
        {

        }
        bool isValidForm()
        {
            // Check if product name is empty
            if (string.IsNullOrEmpty(tb_Product_Name.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if name contains only letters
            if (string.IsNullOrEmpty(tb_Product_Name.Text))
            {
                MessageBox.Show("Please enter a valid product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if ID is a valid integer
            if (!int.TryParse(tb_Id.Text, out int id))
            {
                MessageBox.Show("Please enter a valid ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if price is a valid integer
            if (!int.TryParse(tb_Price.Text, out int price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Additional validation for specific categories (Computer, Phone, Case)

            string selection = cb_Select_Category.SelectedItem?.ToString();

            if (selection != "Computer" &&  selection != "Phone" && selection != "Case")
            {
                MessageBox.Show("Please choose category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;

            }

                if (selection == "Computer")
            {
                // Check if memory is a valid integer
                if (!int.TryParse(tb_Memory.Text, out int memory))
                {
                    MessageBox.Show("Please enter a valid memory size for the computer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (selection == "Phone")
            {
                // Check if memory is a valid integer
                if (!int.TryParse(tb_Memory.Text, out int memory))
                {
                    MessageBox.Show("Please enter a valid memory size for the phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if camera quality is empty
                if (string.IsNullOrEmpty(tb_Camera.Text))
                {
                    MessageBox.Show("Please enter the rear camera quality for the phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (selection == "Case")
            {
                // Check if material is empty
                if (string.IsNullOrEmpty(tb_Material.Text))
                {
                    MessageBox.Show("Please enter the material for the case.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if material contains only letters
                if (!Regex.IsMatch(tb_Material.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid material containing only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // All validations passed
            return true;
        }

        private void btn_update_product_Click(object sender, EventArgs e)
        {
            if (dataGrid_basket.SelectedCells.Count > 0)
            {
                if (isValidForm())
                {
                    // Get the index of the selected row in the DataGridView
                    int selectedRowIndex = dataGrid_basket.SelectedCells[0].RowIndex;

                    // Get the selected product from the DataGridView's DataSource
                    Product selectedProduct = (Product)dataGrid_basket.Rows[selectedRowIndex].DataBoundItem;

                    // Check the type of the selected product and perform updates accordingly
                    if (selectedProduct is Computer computer)
                    {
                        // Update properties specific to Computer
                        computer._Memory = int.Parse(tb_Memory.Text);
                        computer._HasDiskSpace = check_box_Disk_slot.Checked;
                    }
                    else if (selectedProduct is Phone phone)
                    {
                        // Update properties specific to Phone
                        phone._Memory = int.Parse(tb_Memory.Text);
                        phone._RearCameraQuality = tb_Camera.Text;
                    }
                    else if (selectedProduct is Case caseProduct)
                    {
                        // Update properties specific to Case
                        caseProduct._Material = tb_Material.Text;
                    }
                    

                    // Update the common properties of the selected product
                    selectedProduct._Name = tb_Product_Name.Text;
                    selectedProduct._Price = int.Parse(tb_Price.Text);
                    selectedProduct._Id = int.Parse(tb_Id.Text);
                    // Update the DataGridView to reflect the changes
                    dataGrid_basket.Refresh();

                    // Save the updated list of products
                    DataManager.saveProd(this, null);

                    MessageBox.Show("Product updated successfully");
                }
                else
                {
                    MessageBox.Show("Please select a product to update");
                }
            }
        }

        private void SetDefaultValues()
        {
            tb_Product_Name.Text = "Product Name";
            tb_Id.Text = "Id";
            tb_Price.Text = "Price";
            tb_Memory.Text = "Memory in GB";
            tb_Camera.Text = "Camera";
            tb_Material.Text = "Material";
            check_box_Disk_slot.Checked = false;

        }

        
    }
}

    


