using Kiet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiet.DAO
{
    public class CustomerDAO : DBConnection
    {
        public List<ProductDTO> ReadCustomer()
        {
        
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CONGNO", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<ProductDTO> lstCus = new List<ProductDTO>();
          
            while (reader.Read())
            {
                ProductDTO cus = new ProductDTO();
                cus.MAKH= reader["MAKH"].ToString();
                cus.TENKH= reader["TENKH"].ToString();
                cus.SDT = reader["SDT"].ToString() ;
                cus.SOTIENNO = (int.Parse(reader["SOTIENNO"].ToString()));
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
           
        }   
        public void EditCustomer(ProductDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Updated", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MAKH", cus.MAKH));
            cmd.Parameters.Add(new SqlParameter("@TENKH", cus.TENKH));
            cmd.Parameters.Add(new SqlParameter("@SDT", cus.SDT));
            cmd.Parameters.Add(new SqlParameter("@SOTIENNO", cus.SOTIENNO));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustomer(ProductDTO cus)
        {
           
            SqlConnection conn = CreateConnection();
            SqlCommand cmd = new SqlCommand("Deleted", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MAKH", cus.MAKH));
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void NewCustomer(ProductDTO cus)
        {
            SqlConnection conn = CreateConnection();
            SqlCommand cmd = new SqlCommand("Inserted", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add(new SqlParameter("@MAKH", cus.MAKH));
            cmd.Parameters.Add(new SqlParameter("@TENKH", cus.TENKH));
            cmd.Parameters.Add(new SqlParameter("@SDT", cus.SDT));
            cmd.Parameters.Add(new SqlParameter("@SOTIENNO", cus.SOTIENNO));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
