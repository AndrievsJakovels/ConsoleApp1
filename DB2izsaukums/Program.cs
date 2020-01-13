using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2izsaukums
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlReader();
          
            EntityFramework();
            Console.Read();
        }

        static void EntityFramework()
        {

            List<Users> users = new List<Users>();

            using (var db = new DB())
            {
                
                users = db.Users.OrderBy(u => u.LastName).ToList();

            }

            foreach (Users user in users)
            {
                Console.WriteLine("Id: {0}, Vārds: {1}, Uzvārds {2}", user.Id, user.FirstName, user.LastName);

            }

        }

        static void SqlReader()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string query = "SELECT * FROM Users ORDER BY LastName";
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();


            List<UserData> users = new List<UserData>();



            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string firstName = Convert.ToString(reader["FirstName"]);
                string lastName = Convert.ToString(reader["LastName"]);

                users.Add(new UserData()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,


                });
 ;
            }

            reader.Close();
            conn.Close();
            Console.WriteLine("Lietotaji:");
            foreach (UserData user in users)
            {
                Console.WriteLine("Id: {0}, Vārds: {1}, Uzvārds {2}", user.Id, user.FirstName, user.LastName);


            }

        }


    }
}
