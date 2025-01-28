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
using System.Net.NetworkInformation;

namespace HotelBillingSystem
{
    public partial class FoodEntry : Form
    {
        public FoodEntry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True");
        string g;
        private void nv_CheckedChanged(object sender, EventArgs e)
        {
            if(nv.Checked == true)
            {
                g = "N";
            }
        }

        private void v_CheckedChanged(object sender, EventArgs e)
        {
            if(v.Checked == true)
            {
                g = "V";
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = fn.Text;
                string Ftype = g;
                float Fprice = float.Parse(fp.Text);
                string Favailable = fa.Text;

                SqlCommand cmd = new SqlCommand("INSERT INTO tblFood (Fname, Ftype, Fprice, Favailable) VALUES (@Fname, @Ftype, @Fprice, @Favailable)", con);
                cmd.Parameters.AddWithValue("@Fname", Fname);
                cmd.Parameters.AddWithValue("@Ftype", Ftype);
                cmd.Parameters.AddWithValue("@Fprice", Fprice);
                cmd.Parameters.AddWithValue("@Favailable", Favailable);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show((res != 0) ? "Data Saved..." : "Data not Saved...");

                fn.Clear();
                fp.Clear();
                nv.Checked = false;
                v.Checked = false;
                fa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = fn.Text;

                if (string.IsNullOrEmpty(Fname))
                {
                    MessageBox.Show("Please enter the Food Name to delete the record.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM tblFood WHERE Fname = @Fname", con);
                cmd.Parameters.AddWithValue("@Fname", Fname);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show((res != 0) ? "Record Deleted Successfully!" : "No Record Found to Delete.");
                fn.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = fn.Text;
                if (string.IsNullOrEmpty(Fname))
                {
                    MessageBox.Show("Please enter the Food Name to load the record.");
                    return;
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblFood WHERE Fname = @Fname", con);
                cmd.Parameters.AddWithValue("@Fname", Fname);
                con.Open(); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gv.DataSource = ds.Tables[0]; 
                con.Close();
                fn.Clear();
            }
            catch (Exception ex) { 
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = fn.Text.Trim();
                float Fprice;

                if (string.IsNullOrEmpty(Fname))
                {
                    MessageBox.Show("Please enter the Food Name to update the record.");
                    return;
                }

                if (!float.TryParse(fp.Text, out Fprice) || Fprice <= 0)
                {
                    MessageBox.Show("Please enter a valid Food Price greater than 0.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("UPDATE tblFood SET Fprice = @Fprice WHERE Fname = @Fname", con);
                cmd.Parameters.AddWithValue("@Fname", Fname);
                cmd.Parameters.AddWithValue("@Fprice", Fprice);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show((res > 0) ? "Data Updated Successfully!" : "No Record Found to Update.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            try
            {
                if (con == null || string.IsNullOrEmpty(con.ConnectionString))
                {
                    MessageBox.Show("Database connection is not properly initialized.");
                    return;
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblFood", con);
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
}
