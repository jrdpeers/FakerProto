using Faker;
using System.Data.SqlClient;

namespace FakerProto
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = "Server=DEN-PC\\SQLEXPRESS;Database=TheyMightBeGiants;Trusted_Connection=true"
            };
            SqlCommand command = new SqlCommand("INSERT INTO Customers values (@firstName, @lastName, @company, @BS)");

            Customer[] customerList = new Customer[10];

            for (int i=0; i<customerList.Length; i++)
            {
                customerList[i] = new Customer()
                {
                    FirstName = Name.First(),
                    LastName = Name.Last(),
                    Company = Company.Name(),
                    BS = Company.BS()
                };

                conn.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@firstName", customerList[i].FirstName);
                command.Parameters.AddWithValue("@lastName", customerList[i].LastName);
                command.Parameters.AddWithValue("@company", customerList[i].Company);
                command.Parameters.AddWithValue("@BS", customerList[i].BS);

                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
            }
            conn.Dispose();
        }
    }
}
