using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Point_of_Sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost_of_Items()
        {
            double sum = 0;
            int i = 0;

                for (i = 0; i < (dataGridView1.Rows.Count);
                i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        private void AddCost()
        {
            Double tax, q;
            tax = 3.9;
           if ( dataGridView1.Rows.Count>0)
            {
                lblTax.Text = String.Format("{0:c2}", (((Cost_of_Items() * tax) / 100)));
                lblSubtotal.Text = String.Format("{0:c2}", (Cost_of_Items()));
                q = ((Cost_of_Items() * tax) / 100);
                lblTotal.Text = String.Format("{0:c2}", (Cost_of_Items() + q));
                lblBarCode.Text = Convert.ToString(q + Cost_of_Items());

            }
        }
        private void Change()
        {

            Double tax, q, c;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_Items() * tax) / 100 + Cost_of_Items());
                c = Convert.ToInt32(lblCash.Text);
                lblChange.Text = string.Format("{0:c2}", c - q);

            }
        }

            private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Double CostofItem = 35.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Doritos"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Doritos", "1", CostofItem);
            AddCost();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Double CostofItem = 35.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Potato Chips"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Potato Chips", "1", CostofItem);
            AddCost();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Donut"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Donut", "1", CostofItem);
            AddCost();
        }

        private void button28_Click(object sender, EventArgs e)
        {

            Double CostofItem = 75.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Grilled Cheese with Egg and Bacon"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Grilled Cheese with Egg and Bacon", "1", CostofItem);
            AddCost();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Lumpia"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Lumpia", "1", CostofItem);
            AddCost();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Double CostofItem = 65.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Grilled Cheese with Fries"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Grilled Cheese with Fries", "1", CostofItem);
            AddCost();
        }

        private void button31_Click(object sender, EventArgs e)
        {

            Double CostofItem = 40.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Blue Lemonade"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Blue Lemonade", "1", CostofItem);
            AddCost();
        }

        private void button32_Click(object sender, EventArgs e)
        {

            Double CostofItem = 40.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Nestea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Nestea", "1", CostofItem);
            AddCost();
        }

        private void button33_Click(object sender, EventArgs e)
        {

            Double CostofItem = 50.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Spritz"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Spritz", "1", CostofItem);
            AddCost();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Double CostofItem = 40.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Hot Choco"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Hot Choco", "1", CostofItem);
            AddCost();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Double CostofItem = 20.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Tea", "1", CostofItem);
            AddCost();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double CostofItem = 80.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Java Chips Frappe"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Java Chips Frappe", "1", CostofItem);
            AddCost();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Double CostofItem = 45.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Twister Fries"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Twister Fries", "1", CostofItem);
            AddCost();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double CostofItem = 85.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Double patty burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Double patty burger", "1", CostofItem);
            AddCost();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double CostofItem = 95.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cheese Burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Cheese Burger", "1", CostofItem);
            AddCost();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            Double CostofItem = 55.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Lychee"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Lychee", "1", CostofItem);
            AddCost();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Double CostofItem = 65.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pancake"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pancake", "1", CostofItem);
            AddCost();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            Double CostofItem = 45.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Egg"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Egg", "1", CostofItem);
            AddCost();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Bottom Ice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Bottom Ice", "1", CostofItem);
            AddCost();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Black Gulaman"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Black Gulaman", "1", CostofItem);
            AddCost();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Red Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Red Tea", "1", CostofItem);
            AddCost();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Double CostofItem = 60.00;
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
               if((bool)(row.Cells[0].Value = "Capp Coffee"))
                        {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value)* CostofItem;
                   
                }
            }
            dataGridView1.Rows.Add("Capp Coffee", "1", CostofItem);
            AddCost();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double CostofItem = 50.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cappuccino"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Cappuccino", "1", CostofItem);
            AddCost();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Black Coffee"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Black Coffee", "1", CostofItem);
            AddCost();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBarCode_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (cmbPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
             try
            {
                lblBarCode.Text = "";
                lblCash.Text = "0";
                lblChange.Text = "";
                lblSubtotal.Text = "";
                lblTax.Text = "";
                lblTotal.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cmbPayment.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Bitmap bitmap;
        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button40_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            if (cmbPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Visa Card");
            cmbPayment.Items.Add("Master Card");
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (lblCash.Text=="0")
            {
                lblCash.Text = "";
                    lblCash.Text = b.Text;
            }
            else if (b.Text == ("."))
            {
                if ( ! lblCash.Text.Contains ("."))
                {
                    lblCash.Text = lblCash.Text + b.Text;
                }
                    
            }
            else
                lblCash.Text = lblCash.Text + b.Text;
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            lblCash.Text = "0";
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            Double CostofItem = 120.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pizza"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pizza", "1", CostofItem);
            AddCost();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Double CostofItem = 35.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Footlong"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Footlong", "1", CostofItem);
            AddCost();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Double CostofItem = 20.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ice Cream"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Ice Cream", "1", CostofItem);
            AddCost();
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            Double CostofItem = 30.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Apple Pie"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Apple Pie", "1", CostofItem);
            AddCost();
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            Double CostofItem = 85.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Nuggets"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Nuggets", "1", CostofItem);
            AddCost();
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            Double CostofItem = 25.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Fries"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Fries", "1", CostofItem);
            AddCost();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Double CostofItem = 165.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Baked Chicken Wings"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Baked Chicken Wings", "1", CostofItem);
            AddCost();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Double CostofItem = 165.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Spicy Chicken"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Spicy Chicken", "1", CostofItem);
            AddCost();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Double CostofItem = 165.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chicken Wings Terayaki"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chicken Wings Terayaki", "1", CostofItem);
            AddCost();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Double CostofItem = 165.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chicken Wings Garlic Parmesan"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chicken Wings Garlic Parmesan", "1", CostofItem);
            AddCost();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Double CostofItem = 165.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chicken Wings Buffalo"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chicken Wings Buffalo", "1", CostofItem);
            AddCost();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Double CostofItem = 165.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chicken Wings Salted Egg"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chicken Wings Salted Egg", "1", CostofItem);
            AddCost();
        }
    }
}
