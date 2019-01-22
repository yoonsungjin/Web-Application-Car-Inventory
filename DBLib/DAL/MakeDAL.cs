using DBLib.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBLib.DAL
{
    public class MakeDAL
    {
        ConnectionFactory connectionFactory = new ConnectionFactory();

        public List<Make> GetAll()
        {
            List<Make> makeList = new List<Make>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select * from Make", cnn))
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Make m = new Make(Convert.ToInt16(reader["Id"]), reader["Name"].ToString());
                    makeList.Add(m);
                }
            }
            return makeList;
        }
    }
}
