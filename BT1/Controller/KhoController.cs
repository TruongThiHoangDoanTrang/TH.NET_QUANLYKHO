using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT1.Model;
using BT1.Utils;

namespace BT1.Controller
{
    internal class KhoController
    {
       List<Kho> khoList;
        public KhoController()
        {
            khoList = new List<Kho>();
        }
        public List<Kho> load()
        {

            SqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select*from Kho", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String MaKho = reader["MaKho"].ToString();
                    String TenKho = reader["TenKho"].ToString();
                    String DiaChi = reader["DiaChi"].ToString();

                    Kho kho = new Kho(MaKho, TenKho, DiaChi);

                }
               
            }
            catch (Exception ex) { }
            return khoList;
        }

    }
}
