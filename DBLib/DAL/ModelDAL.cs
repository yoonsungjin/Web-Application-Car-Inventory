using DBLib.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBLib.DAL
{
    public class ModelDAL
    {
        ConnectionFactory connectionFactory = new ConnectionFactory();

        public List<Model> GetModel(int makeId)
        {
            List<Model> modelList = new List<Model>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select Id, Name from Model where MakeId=@MakeId", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@MakeId", makeId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Model m = new Model(Convert.ToInt16(reader["Id"]), reader["Name"].ToString());
                    modelList.Add(m);
                }
            }
            return modelList;
        }

    }
}
