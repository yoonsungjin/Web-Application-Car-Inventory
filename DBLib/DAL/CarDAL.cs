using DBLib.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBLib.DAL
{
    public class CarDAL
    {
        ConnectionFactory connectionFactory = new ConnectionFactory();

        public int Add(Car c)
        {
            int count = 0;
            using (SqlConnection cnn = connectionFactory.GetConnection())


            using (SqlCommand cmd = new SqlCommand("insert into Car values (@Make, @Model, @Year, @Price, @Mileage, @PhotoURL)", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@Make", c.MakeId);
                cmd.Parameters.AddWithValue("@Model", c.ModelId);
                cmd.Parameters.AddWithValue("@Year", c.Year);
                cmd.Parameters.AddWithValue("@Price", c.Price);
                cmd.Parameters.AddWithValue("@Mileage", c.Mileage);
                cmd.Parameters.AddWithValue("@PhotoURL", c.PhotoUrl);
                count = Convert.ToInt32(cmd.ExecuteScalar());   //returning the auto generated id(=count)
                //cmd.ExecuteNonQuery();
            }
            return count;
        }


        public List<Car> ReadByMakeId(int makeId)
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select * from Car where MakeId=@MakeId", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@MakeId", makeId);
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

        public List<Car> SearchCar(int makeId, int modelId)
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select * from Car where MakeId=@MakeId and ModelId=@ModelId", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@MakeId", makeId);
                cmd.Parameters.AddWithValue("@ModelId", modelId);
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

        public List<Car> ReadByCarId(int carId)
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select * from Car where CarId=@CarId", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@CarId", carId);
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

        public List<Car> ReadByPrice(double price)
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection cnn = connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand("select * from Car where Price <= @Price", cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@Price", price);
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
