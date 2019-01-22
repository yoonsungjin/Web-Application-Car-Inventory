using DBLib.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.DAL
{
    public class GarageDAL
    {
        ConnectionFactory connectionFactory = new ConnectionFactory();

        public void AddToGarage(int memberId, int carId)
        {

            using (SqlConnection cnn = connectionFactory.GetConnection())

            using (SqlCommand cmd = new SqlCommand("insert into Garage(MemberId, CarId) values (@MemberId, @CarId)", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@CarId", carId);

                //              count = Convert.ToInt32(cmd.ExecuteScalar());   //returning the auto generated id(=count)

                cmd.ExecuteNonQuery();
            }
        }

        public int GetCarId(int makeId, int modelId)
        {
            int carId=0;

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select CarId from Car where MakeId=@MakeId and ModelId=@ModelId", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@MakeId", makeId);
                cmd.Parameters.AddWithValue("@ModelId", modelId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    carId = Convert.ToInt16(reader["CarId"]);


                }
                

            }
            return carId;


        }

        public List<Car> GetCarByMemberId(int memberId)
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select * from car where CarId in (select CarId from Garage where MemberId=@MemberId)", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car c = new Car(Convert.ToInt16(reader["MakeId"]), Convert.ToInt16(reader["ModelId"]), Convert.ToInt32(reader["Year"]),
                        Convert.ToDouble(reader["Price"]), Convert.ToDouble(reader["Mileage"]), reader["PhotoUrl"].ToString());
                    cars.Add(c);
                }


            }
            return cars;


        }

    }
}
