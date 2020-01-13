using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBIzsaukums
{
    class Program
    {
        //public static SqlConnection SqlConnection { get; private set; }

        static void Main(string[] args)
        {

            SqlReader();
            EntityFramework();
            Console.ReadLine();
            
        }
        static void EntityFramework()
        {

            List<UserData> users = new List<UserData>();
            using (var db = new DB()) // conection open, connection close
            {
               
                users = db.Users.OrderBy(u => u.LastName).ToList();
            }
            foreach (UserData user in users)
            {
                Console.WriteLine("Id = {0}, vards = {1} {2}", user.Id, user.FirstName, user.LastName);

            }


        }

        static void SqlReader()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string query = "Select * from users order by LastName";
            SqlCommand command = new SqlCommand(query, conn); // tiek sagatavots pieprasijums
            SqlDataReader reader = command.ExecuteReader();   // izpildit lasisanu, katru  ierakstu atgriezis ka katru rindiu

            List<UserData> users = new List<UserData>();
            while (reader.Read())  // lasis lidz pedejai rindai
            {
                int id = Convert.ToInt32(reader["Id"]);  // jebkura kollona, kas interese
                // int id = int.Parse(reader["Id"].ToString())
                string firstName = Convert.ToString(reader["FirstName"]);
                string lastName = Convert.ToString(reader["LastName"]);

                users.Add(new UserData()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                });

                

            }
            reader.Close(); // aizvert lasisanu
            conn.Close();

            Console.WriteLine("Lietotaji: ");
            foreach (UserData user in users)
            {
                Console.WriteLine("Id: {0}, vards {1} {2} ", user.Id, user.FirstName, user.LastName);
            }
        }
    }
}
