using BloodBankManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.DAL
{
     class donorDAL
    {
        static String myconnstring= ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region SELECT
        public DataTable Select()
        {
            DataTable dt  = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            
            try
            {
                String sql = "SELECT * FROM tbl_donors";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region INSERT data into database 
        public bool Insert(donorBLL d,donation s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_donors(FirstName,LastName,Email,Contact,Gender,City,BloodGroup,AddedDate) VALUES(@FirstName,@LastName,@Email,@Contact,@Gender,@City,@BloodGroup,@AddedDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", d.FirstName);
                cmd.Parameters.AddWithValue("@LastName", d.LastName);
                cmd.Parameters.AddWithValue("@Email", d.Email);
                cmd.Parameters.AddWithValue("@Contact", d.Contact);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);
                cmd.Parameters.AddWithValue("@City", s.City);
                cmd.Parameters.AddWithValue("@BloodGroup", s.BloodGroup);
                cmd.Parameters.AddWithValue("@AddedDate", s.AddedDate);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
       

        #region UPDATE data in databse
        public bool Update(donorBLL d,donation s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            { 
                String sql = "UPDATE tbl_donors SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Contact=@Contact, Gender=@Gender, City=@City, BloodGroup=@BloodGroup, AddedDate=@AddedDate WHERE  DonorId=@DonorId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", d.FirstName);
                cmd.Parameters.AddWithValue("@LastName", d.LastName);
                cmd.Parameters.AddWithValue("@Email", d.Email);
                cmd.Parameters.AddWithValue("@Contact", d.Contact);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);
                cmd.Parameters.AddWithValue("@DonorId", d.DonorId);
                cmd.Parameters.AddWithValue("@City", s.City);
                cmd.Parameters.AddWithValue("@BloodGroup", s.BloodGroup);
                cmd.Parameters.AddWithValue("@AddedDate", s.AddedDate);
                cmd.Parameters.AddWithValue("@DonorId", s.DonorId);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
       

        #region DELETE

        public bool Delete(donorBLL d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "DELETE FROM tbl_donors WHERE DonorId=@DonorId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DonorId", d.DonorId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region COUNT donors for specific blood group
        public string countDonors(string blood_group)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            string donors = "0";

            try
            {
                string sql = "SELECT * FROM tbl_donors WHERE BloodGroup = '"+ blood_group +"'";

                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                donors = dt.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return donors;

        }
        #endregion

        #region SEARCH 
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable(); 
            
            try
            {
                string sql = "SELECT FROM tbl_donors WHERE DonorId LIKE '%" + keywords + "%' OR FirstName LIKE '%" + keywords + "%' OR LastName LIKE '%" + keywords + "%' OR Email LIKE '%" + keywords + "%' OR BloodGroup LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

    }
}
