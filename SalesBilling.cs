using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelBillingSystem
{
    public partial class SalesBilling : Form
    {
        public SalesBilling()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True");
        float pricePerUnit = 0;

        private void SalesBilling_Load(object sender, EventArgs e)
        {
            LoadFoodItems();
            GenerateBillNumber();
        }

        private void LoadFoodItems()
        {
            try
            {
                con.Open();
                string query = "SELECT Fid, Fname FROM tblFood";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        fd.Items.Clear();
                        while (dr.Read())
                        {
                            fd.Items.Add(new ComboBoxItem(dr["Fname"].ToString(), dr["Fid"].ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void GenerateBillNumber()
        {
            Random random = new Random();
            bn.Text = random.Next(1000, 9999).ToString();
        }

        private void fd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fd.SelectedItem is ComboBoxItem selectedFood)
                {
                    string foodName = selectedFood.Text;
                    con.Open();
                    string query = "SELECT Fprice FROM tblFood WHERE Fname = @Fname";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Fname", foodName);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                pr.Text = dr["Fprice"].ToString();
                                pricePerUnit = float.Parse(dr["Fprice"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void amt_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(qn.Text, out float quantity))
            {
                amt.Text = (quantity * pricePerUnit).ToString();
            }
            else
            {
                amt.Text = "0";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (fd.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid food item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(qn.Text, out float quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(pr.Text, out float price) || price <= 0)
                {
                    MessageBox.Show("Price must be valid and greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(bn.Text, out int billNo))
                {
                    MessageBox.Show("Invalid bill number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedFood = (ComboBoxItem)fd.SelectedItem;
                int foodId = int.Parse(selectedFood.Value);
                float amount = quantity * price;

                con.Open();
                string query = "INSERT INTO tblBilling (BillNo, Fid, Quantity, Price, Amount) VALUES (@BillNo, @Fid, @Quantity, @Price, @Amount)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BillNo", billNo);
                    cmd.Parameters.AddWithValue("@Fid", foodId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Bill added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                if (con == null || string.IsNullOrEmpty(con.ConnectionString))
                {
                    MessageBox.Show("Database connection is not properly initialized.");
                    return;
                }
                SqlCommand cmd = new SqlCommand("SELECT BillNo, Fname AS Food, Price, Quantity, Amount FROM tblBilling INNER JOIN tblFood ON tblFood.Fid = tblBilling.Fid; ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data found in the tblFood table.");
                }
                else
                {
                    //gv.AutoGenerateColumns = true;
                    gv.DataSource = ds.Tables[0];
                    double totalAmount = 0;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        totalAmount += Convert.ToDouble(row["Amount"]);
                    }

                    total.Text = totalAmount.ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            HotelApp previousForm = new HotelApp();
            previousForm.Show();
            this.Close();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text; // Display food name in dropdown
        }
    }
}
