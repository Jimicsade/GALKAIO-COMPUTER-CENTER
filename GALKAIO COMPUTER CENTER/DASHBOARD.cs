using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SOMALI_COMPUTER_CENTER
{
    public partial class DASHBOARD : Form
    {
        // CODE TO CREATE CONNECTION
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        int FINALCOST = 0;

        public DASHBOARD()
        {

            InitializeComponent();
            // CODE TO GET INVOICE ID
            GETINVOICE();

            // CODE TO GET PRODUCTS
            GETPRODUCTS();

            // CODE TO LOAD DATA
            LOADDATA();

        }

        // CODE TO GET INVOICE ID FROM DATABASE
        void GETINVOICE()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT INVOICE_ID FROM ORDERS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count < 1)
            {
                INVOICE_TXT.Text = "1";
            }
            else
            {
                string query2 = "SELECT MAX(INVOICE_ID) FROM ORDERS";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                INVOICE_TXT.Text = a.ToString();

                con.Close();


            }

        }


        // CODE TO ALLOW FULLNAME TO ACCEPT ONLY TEXT
        private void FULLNAME_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar))

                e.Handled = true;
        }

        // CODE TO VALIDATE PRODUCTS TEXTBOX
        private void PRODUCTS_TXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PRODUCTS_TXT.SelectedItem == null)
            {
                PRODUCTS_TXT.Focus();
                ERROR_QUANTITY.SetError(this.PRODUCTS_TXT, "Please select product");
            }
            else
            {
                GETPRICE();
                GETDISCOUNT();
                QUANTITY_TXT.Enabled = true;

            }

        }

        // CODE TO GET PRODUCTS FROM DATABASE
        void GETPRODUCTS()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM PRODUCTS";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string PRODUCTS = dr.GetString(1);
                PRODUCTS_TXT.Items.Add(PRODUCTS);
            }
            con.Close();
        }

        // CODE TO GET PRICE FROM DATABASE
        void GETPRICE()
        {
            if (PRODUCTS_TXT.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT PRICE FROM PRODUCTS WHERE BRAND = @BRAND";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@BRAND", PRODUCTS_TXT.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["PRICE"]);
                }

                // CODE TO DISPLAY PRODUCT PRICE 
                PRICE_TXT.Text = price.ToString();
            }
        }

        // CODE TO GET DISCOUNT FROM DATABASE
        void GETDISCOUNT()
        {
            if (PRODUCTS_TXT.SelectedItem == null)
            {

            }
            else
            {
                int discount = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT DISCOUNT FROM PRODUCTS WHERE BRAND = @BRAND";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@BRAND", PRODUCTS_TXT.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    discount = Convert.ToInt32(data.Rows[0]["DISCOUNT"]);
                }

                // CODE TO DISPLAY QUANTITY
                DISCOUNT_TXT.Text = discount.ToString();
            }
        }


        // CODE TO ALLOW QUANTITY TO ACCEPT ONLY NUMBERS
        private void QUANTITY_TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar))

                e.Handled = true;

        }

        // CODE TO VALIDATE QUANTITY, GET SUBTOTAL 
        private void QUANTITY_TXT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QUANTITY_TXT.Text) == true)
            {
                QUANTITY_TXT.Focus();
                ERROR_QUANTITY.SetError(this.QUANTITY_TXT, "Please fill this quantity");
            }
            else

            {
                int price = Convert.ToInt32(PRICE_TXT.Text);
                int discount = Convert.ToInt32(DISCOUNT_TXT.Text);
                int quantity = Convert.ToInt32(QUANTITY_TXT.Text);
                int Amount = price * quantity;
                Amount = Amount - discount * quantity;

                //CODE TO SHOW TOTAL COST
                SUBTOTAL_TXT.Text = Amount.ToString();
                ERROR_QUANTITY.Clear();

            }

        }

        // CODE TO ADD DATA TO DATAGRIDVIEW
        void AddDataToDataGridView(string Serial, string Product, string Price, string Discount, string Quantity, string SUBTOTAL)
        {
            string[] row = { Serial, Product, Price, Discount, Quantity, SUBTOTAL };
            dataGridView1.Rows.Add(row);
        }


    
        // CODE TO RESET ALL TEXTBOXES
        void RESETCONTROLS()
        {
            INVOICE_TXT.Focus();
            PRODUCTS_TXT.SelectedItem = null;
            FULLNAME_TXT.Clear();
            PRICE_TXT.Clear();
            DISCOUNT_TXT.Clear();
            QUANTITY_TXT.Clear();
            SUBTOTAL_TXT.Clear();
            ERROR_QUANTITY.Clear();
            GENDER_TXT.SelectedItem = null;
            QUANTITY_TXT.Enabled = false;
            BUY_BTN.Enabled = true;
            UPDATE_BTN.Enabled = false;
            DELETE_BTN.Enabled = false;
        }

        private void RESET_BTN_Click(object sender, EventArgs e)
        {
            RESETCONTROLS();
        }



        // CODE TO VALIDATE FULLNAME TEXTBOX
        private void FULLNAME_TXT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FULLNAME_TXT.Text) == true)
            {
                FULLNAME_TXT.Focus();
                ERROR_FN.SetError(this.FULLNAME_TXT, "Please fill this fullname");
            }
            else

            {

                ERROR_FN.Clear();

            }

        }

        // CODE TO VALIDATE GENDER TEXTBOX
        private void GENDER_TXT_Leave(object sender, EventArgs e)
        {
            if (GENDER_TXT.SelectedItem == null)
            {
                GENDER_TXT.Focus();
                ERROR_GENDER.SetError(this.GENDER_TXT, "Please select gender");
            }
            else
            {
                ERROR_GENDER.Clear();
            }

        }



        // CODE TO INSERT DATA IN DATABASE
        private void BUY_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FULLNAME_TXT.Text) == true)
            {
                FULLNAME_TXT.Focus();
                ERROR_FN.SetError(this.FULLNAME_TXT, "Please fill this fullname");
            }
            else if (GENDER_TXT.SelectedItem == null)
            {
                GENDER_TXT.Focus();
                ERROR_GENDER.SetError(this.GENDER_TXT, "Please select gender");
            }
            else if (PRODUCTS_TXT.SelectedItem == null)
            {
                PRODUCTS_TXT.Focus();
                ERROR_QUANTITY.SetError(this.PRODUCTS_TXT, "Please select product");
            }
            else if (string.IsNullOrEmpty(QUANTITY_TXT.Text) == true)
            {
                QUANTITY_TXT.Focus();
                ERROR_QUANTITY.SetError(this.QUANTITY_TXT, "Please fill this quantity");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "INSERT INTO ORDERS VALUES(@INVOICE_ID, @FULLNAME, @GENDER, @PRODUCTS, @PRICE, @DISCOUNT, @QUANTITY, @DATE, @TOTALCOST)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@INVOICE_ID", INVOICE_TXT.Text);
                cmd.Parameters.AddWithValue("@FULLNAME", FULLNAME_TXT.Text);
                cmd.Parameters.AddWithValue("@GENDER", GENDER_TXT.SelectedItem);
                cmd.Parameters.AddWithValue("@PRODUCTS", PRODUCTS_TXT.Text);
                cmd.Parameters.AddWithValue("@PRICE", PRICE_TXT.Text);
                cmd.Parameters.AddWithValue("@DISCOUNT", DISCOUNT_TXT.Text);
                cmd.Parameters.AddWithValue("@QUANTITY", QUANTITY_TXT.Text);
                cmd.Parameters.AddWithValue("@DATE", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@TOTALCOST", SUBTOTAL_TXT.Text);


                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Thanks for your purchasing", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GETINVOICE();
                    RESETCONTROLS();
                    LOADDATA();

                }
                else
                {
                    MessageBox.Show("Order was not completed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        // CODE TO LOAD DATA
        private void LOADDATA()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = " SELECT * FROM ORDERS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

      

        // CODE TO SHOW INFORMATION TO THE TEXTBOX
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            INVOICE_TXT.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FULLNAME_TXT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            GENDER_TXT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PRODUCTS_TXT.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PRICE_TXT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            DISCOUNT_TXT.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            QUANTITY_TXT.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            SUBTOTAL_TXT.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            BUY_BTN.Enabled = false;
            UPDATE_BTN.Enabled = true;
            DELETE_BTN.Enabled = true;
         
        }


        // CODE TO UPDATE  
        private void UPDATE_BTN_Click(object sender, EventArgs e)
        {
            DialogResult DIALOG = MessageBox.Show("Are you sure you want to update", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DIALOG == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "UPDATE ORDERS SET FULLNAME = @FULLNAME, GENDER = @GENDER, PRODUCTS = @PRODUCTS, PRICE = @PRICE, DISCOUNT = @DISCOUNT, QUANTITY = @QUANTITY, TOTALCOST = @TOTALCOST WHERE INVOICE_ID = @INVOICE_ID";
                SqlCommand CMD = new SqlCommand(query, con);
                CMD.Parameters.AddWithValue("@FULLNAME", FULLNAME_TXT.Text);
                CMD.Parameters.AddWithValue("@GENDER", GENDER_TXT.SelectedItem);
                CMD.Parameters.AddWithValue("@PRODUCTS", PRODUCTS_TXT.SelectedItem);
                CMD.Parameters.AddWithValue("@PRICE", PRICE_TXT.Text);
                CMD.Parameters.AddWithValue("@DISCOUNT", DISCOUNT_TXT.Text);
                CMD.Parameters.AddWithValue("@QUANTITY", QUANTITY_TXT.Text);
                CMD.Parameters.AddWithValue("@TOTALCOST", SUBTOTAL_TXT.Text);
                CMD.Parameters.AddWithValue("@INVOICE_ID", INVOICE_TXT.Text);
                con.Open();
                int a = CMD.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Products information has been updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESETCONTROLS();
                    LOADDATA();

                }
                else
                {
                    MessageBox.Show("Products information has not been updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // NOTHING HAPPENED
            }

        }


        // CODE TO DELETE DATA FROM DATABASE
        private void DELETE_BTN_Click(object sender, EventArgs e)
        {

            DialogResult DIALOG = MessageBox.Show("Are you sure you want to delete", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DIALOG == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "DELETE FROM ORDERS WHERE INVOICE_ID = @INVOICE_ID";
                SqlCommand CMD = new SqlCommand(query, con);
                CMD.Parameters.AddWithValue("@INVOICE_ID", INVOICE_TXT.Text);
                con.Open();
                int a = CMD.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Products information has been deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESETCONTROLS();
                    LOADDATA();

                }
                else
                {
                    MessageBox.Show("Products information has not been deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // NOTHING HAPPENED
            }

        }
    }

}

