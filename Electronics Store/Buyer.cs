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
using Electronics_Store.classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;

namespace Electronics_Store
{
    public partial class Buyer : Form
    {
        private DataGridViewRow draggingRow;
        private Cursor dragCursor;
        private Cursor computerDragCursor;
        private Cursor phoneDragCursor;
        private Cursor caseDragCursor;

        public Buyer()
        {
            InitializeComponent();
            dataGrid_basket.AutoGenerateColumns = false;

            // Add columns to the data grid basket
            dataGrid_basket.Columns.Add("Id", "Id");
            dataGrid_basket.Columns.Add("Name", "Name");
            dataGrid_basket.Columns.Add("Price", "Price");

            // Load the custom drag cursors for each product type
            computerDragCursor = new Cursor(Properties.Resources._computer.GetHicon());
            phoneDragCursor = new Cursor(Properties.Resources._phone.GetHicon());
            caseDragCursor = new Cursor(Properties.Resources._case.GetHicon());

            // Set AllowDrop property to true
            dataGrid_basket.AllowDrop = true;

            // Enable row drag and drop
            dataGrid_view.AllowUserToAddRows = false;
            dataGrid_view.MouseMove += dataGrid_view_MouseMove;
            dataGrid_view.MouseDown += dataGrid_view_MouseDown;
            dataGrid_basket.DragEnter += dataGrid_basket_DragEnter;
            dataGrid_basket.DragDrop += dataGrid_basket_DragDrop;

            // Load the custom drag cursor image
            dragCursor = new Cursor(Properties.Resources._phone.GetHicon());
        }

        private void dataGrid_view_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && draggingRow == null)
            {
                int rowIndex = dataGrid_view.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    draggingRow = dataGrid_view.Rows[rowIndex];

                    // Get the underlying data bound object
                    var product = (Product)draggingRow.DataBoundItem;

                    // Check the type of the product
                    if (product is Computer)
                    {
                        // Product is a Computer
                        // Set the appropriate drag cursor for computer
                        Cursor.Current = computerDragCursor;
                    }
                    else if (product is Phone)
                    {
                        // Product is a Phone
                        // Set the appropriate drag cursor for phone
                        Cursor.Current = phoneDragCursor;
                    }
                    else if (product is Case)
                    {
                        // Product is a Case
                        // Set the appropriate drag cursor for case
                        Cursor.Current = caseDragCursor;
                    }
                    else
                    {
                        // Unknown product type
                        Cursor.Current = Cursors.Default;
                    }

                    // Perform the drag operation
                    dataGrid_view.DoDragDrop(draggingRow, DragDropEffects.Move);
                }
            }
        }

        private void dataGrid_view_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset the mouse cursor to the default image
            Cursor.Current = Cursors.Default;
            draggingRow = null;
        }
        private void dataGrid_view_MouseDown(object sender, MouseEventArgs e)
        {
            draggingRow = null;
        }

        private void dataGrid_basket_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGrid_basket_DragDrop(object sender, DragEventArgs e)
        {
            if (draggingRow != null)
            {
                DataGridViewRow row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                if (row != null)
                {
                    // Add the dragged row to the basket grid
                    int rowIndex = dataGrid_basket.Rows.Add();
                    dataGrid_basket.Rows[rowIndex].Cells["Id"].Value = row.Cells["_Id"].Value;
                    dataGrid_basket.Rows[rowIndex].Cells["Name"].Value = row.Cells["_Name"].Value;
                    dataGrid_basket.Rows[rowIndex].Cells["Price"].Value = row.Cells["_Price"].Value;

                    // Remove the row from the source grid
                    dataGrid_view.Rows.Remove(row);

                    // Calculate and update the total order amount
                    UpdateTotalOrderAmount();
                }
            }

            // Reset the mouse cursor to the default image
            Cursor.Current = Cursors.Default;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            if (dataGrid_view.SelectedRows.Count > 0)
            {
                dataGrid_basket.AutoGenerateColumns = true;
                // Get the selected product from the data grid view
                var selectedProduct = dataGrid_view.SelectedRows[0].DataBoundItem as Product;

                // Add the selected product to the data grid basket
                dataGrid_basket.Rows.Add(selectedProduct._Id, selectedProduct._Name, selectedProduct._Price);

                //Calculate and update the total order amount
                UpdateTotalOrderAmount();
            }
        }

        private void btn_remove_from_cart_Click(object sender, EventArgs e)
        {
            if (dataGrid_basket.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid_basket.SelectedRows[0];

                // Remove the selected row from the data grid basket
                dataGrid_basket.Rows.Remove(selectedRow);

                //Calculate and update the total order amount
                 UpdateTotalOrderAmount();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lbl_total_order_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotalOrderAmount()
        {
            decimal totalAmount = 0;

            // Iterate over the rows in the data grid basket
            foreach (DataGridViewRow row in dataGrid_basket.Rows)
            {
                //// Get the price value from the row
                //if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                //{
                //    // Add the price to the total amount
                //    totalAmount += price;
                //}

                int.TryParse(row.Cells["Id"].Value.ToString(), out int num);
                Product temp = DataManager.getById(num);
                totalAmount += temp.getPrice() ;
                    }

            // Update the total order amount label
            lbl_total_counter.Text = "Total Order : $ " + totalAmount.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_basket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_totalOrder_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_counter_Click(object sender, EventArgs e)
        {

        }

        private void cbSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cbSelectRole.SelectedItem?.ToString();
            if (selection == "Computers")
            {
                BindingList<Computer> computers = DataManager.GetSpecificProduct<Computer>();
                dataGrid_view.AutoGenerateColumns = true; // Enable auto-generated columns
                dataGrid_view.DataSource = computers;
                dataGrid_view.Columns["_Memory"].HeaderText = "Memory";
                dataGrid_view.Columns["_HasDiskSpace"].HeaderText = "Disk Slot";


            }
            if (selection == "Phones")
            {
                BindingList<Phone> phones = DataManager.GetSpecificProduct<Phone>();
                dataGrid_view.AutoGenerateColumns = true; // Enable auto-generated columns
                dataGrid_view.DataSource = phones;
                dataGrid_view.Columns["_Memory"].HeaderText = "Memory";
                dataGrid_view.Columns["_RearCameraQuality"].HeaderText = "Camera";


            }
            if (selection == "Cases")
            {
                BindingList<Case> cases = DataManager.GetSpecificProduct<Case>();
                dataGrid_view.AutoGenerateColumns = true; // Enable auto-generated columns
                dataGrid_view.DataSource = cases;
                dataGrid_view.Columns["_Material"].HeaderText = "Material";

            }

            // Modify column order
            dataGrid_view.Columns["_Id"].DisplayIndex = 0;
            dataGrid_view.Columns["_Name"].DisplayIndex = 1;
            dataGrid_view.Columns["_Price"].DisplayIndex = 2;


            // Remove underscore from column names
            dataGrid_view.Columns["_Id"].HeaderText = "Id";
            dataGrid_view.Columns["_Name"].HeaderText = "Name";
            dataGrid_view.Columns["_Price"].HeaderText = "Price";
        }

        private void btn_pay_now_Click(object sender, EventArgs e)
        {
            //// Create a StringBuilder to store the receipt content
            //StringBuilder receipt = new StringBuilder();

            //// Add the heading to the receipt
            //receipt.AppendLine("************ Order Receipt ************");
            //receipt.AppendLine();

            //// Add the order summary
            //receipt.AppendLine("Order Summary:");
            //receipt.AppendLine("---------------");

            //decimal totalAmount = 0;

            //// Iterate over the rows in the data grid basket
            //foreach (DataGridViewRow row in dataGrid_basket.Rows)
            //{
            //    string productName = row.Cells["Name"].Value.ToString();
            //    decimal price = decimal.Parse(row.Cells["Price"].Value.ToString());

            //    // Add the product details to the receipt
            //    receipt.AppendLine(productName + " - ₪ " + price.ToString());

            //    // Add the price to the total amount
            //    totalAmount += price;
            //}

            //receipt.AppendLine();

            //// Add the total order amount
            //receipt.AppendLine("Total Order Amount: ₪ " + totalAmount.ToString());
            //receipt.AppendLine();

            //// Add the payment information (you can customize this based on your payment method)
            //receipt.AppendLine("Payment Information:");
            //receipt.AppendLine("-------------------");
            //receipt.AppendLine("Payment Method: Credit Card");
            //receipt.AppendLine("Card Number: XXXX-XXXX-XXXX-1234"); // Display only the last 4 digits for security

            //// Display the receipt
            //MessageBox.Show(receipt.ToString(), "Order Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //// Perform any additional actions (e.g., save the receipt to a file, send it via email, etc.)
            //// ...

            // Create a new PDF document
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("receipt.pdf", FileMode.Create));
            document.Open();

            // Set up the font styles
            iTextSharp.text.Font headingFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18, iTextSharp.text.Font.UNDERLINE);
            Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            // Add the heading to the receipt
            Paragraph heading = new Paragraph("Order Receipt", headingFont);
            heading.Alignment = Element.ALIGN_CENTER;
            document.Add(heading);
            document.Add(Chunk.NEWLINE);

            // Add the order summary
            Paragraph orderSummary = new Paragraph("Order Summary", boldFont);
            document.Add(orderSummary);
            document.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5f, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -1)));
            document.Add(Chunk.NEWLINE);

            decimal totalAmount = 0;

            // Create a table to display the product details
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2f, 4f, 2f });

            // Add table headers
            table.AddCell(new PdfPCell(new Phrase("Product Name", boldFont)));
            table.AddCell(new PdfPCell(new Phrase("Price", boldFont)));
            table.AddCell(new PdfPCell(new Phrase("Quantity", boldFont)));

            // Iterate over the rows in the data grid basket
            foreach (DataGridViewRow row in dataGrid_basket.Rows)
            {
                string productName = row.Cells["Name"].Value.ToString();
                decimal price = decimal.Parse(row.Cells["Price"].Value.ToString());

                // Add the product details to the table
                table.AddCell(new PdfPCell(new Phrase(productName, normalFont)));
                table.AddCell(new PdfPCell(new Phrase("₪ " + price.ToString(), normalFont)));
                table.AddCell(new PdfPCell(new Phrase("1", normalFont)));

                // Add the price to the total amount
                totalAmount += price;
            }

            // Add the table to the document
            document.Add(table);
            document.Add(Chunk.NEWLINE);

            // Add the total order amount
            Paragraph totalOrderAmount = new Paragraph("Total Order Amount: $ " + totalAmount.ToString(), boldFont);
            document.Add(totalOrderAmount);
            document.Add(Chunk.NEWLINE);

            // Add the payment information
            Paragraph paymentInfo = new Paragraph("Payment Information", boldFont);
            document.Add(paymentInfo);
            document.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5f, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -1)));
            document.Add(Chunk.NEWLINE);
            Paragraph paymentMethod = new Paragraph("Payment Method: Credit Card", normalFont);
            document.Add(paymentMethod);
            Paragraph cardNumber = new Paragraph("Card Number: XXXX-XXXX-XXXX-1234", normalFont);
            document.Add(cardNumber);

            // Close the document
            document.Close();

            // Open the PDF file
            System.Diagnostics.Process.Start("receipt.pdf");
        }


    }
}
