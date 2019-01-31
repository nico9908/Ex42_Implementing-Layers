using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ex42_Implementing_Layers
{
    public class Database_Controller
    {
        private static string connectionString =
        "Server = ealSQL1.eal.local; Database = A_DB27_2018; User Id = A_STUDENT27; Password = A_OPENDB27;";

        public void InsertPet(Pet pet)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertPet", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Insert pet name");
                    cmd1.Parameters.Add(new SqlParameter("@PetName", Console.ReadLine()));
                    Console.WriteLine("Insert pet type");
                    cmd1.Parameters.Add(new SqlParameter("@PetType", Console.ReadLine()));
                    Console.WriteLine("Insert pet breed");
                    cmd1.Parameters.Add(new SqlParameter("@PetBreed", Console.ReadLine()));
                    Console.WriteLine("Insert pet date of birth");
                    cmd1.Parameters.Add(new SqlParameter("@PetDOB", Console.ReadLine()));
                    Console.WriteLine("Insert pet weight");
                    cmd1.Parameters.Add(new SqlParameter("@PetWeight", Console.ReadLine()));
                    Console.WriteLine("Insert owner id");
                    cmd1.Parameters.Add(new SqlParameter("@OwnerID", Console.ReadLine()));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }

        public void InsertOwner(Owner owner)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertPet_Owner", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Insert owner first name");
                    cmd1.Parameters.Add(new SqlParameter("@OwnerFirstName", Console.ReadLine()));
                    Console.WriteLine("Insert owner last name");
                    cmd1.Parameters.Add(new SqlParameter("@OwnerLastName", Console.ReadLine()));
                    Console.WriteLine("Insert owner phone");
                    cmd1.Parameters.Add(new SqlParameter("@OwnerPhone", Console.ReadLine()));
                    Console.WriteLine("Insert owner email");
                    cmd1.Parameters.Add(new SqlParameter("@OwnerEmail", Console.ReadLine()));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }
        public void ShowPets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("GetPets", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string name = read["PetName"].ToString();
                            string type = read["PetType"].ToString();
                            string breed = read["PetBreed"].ToString();
                            string DOB = read["PetDOB"].ToString();
                            string weight = read["PetWeight"].ToString();
                            string ownerid = read["OwnerID"].ToString();
                            Console.WriteLine(ownerid + " " + name + " " + type + " " + breed + " " + DOB + " " + weight);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }

        public void FindOwnerByLastName(string lastName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("GetOwnerByLastName", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@LastName", lastName));

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string fname = read["OwnerFirstName"].ToString();
                            string lname = read["OwnerLastName"].ToString();
                            string phone = read["OwnerPhone"].ToString();
                            string email = read["OwnerEmail"].ToString();
                            Console.WriteLine(fname + " " + lname + " " + phone + " " + email);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }

        public void FindOwnerByEmail(string ownerEmail, string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("GetOwnerByEmail", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@Name", name));
                    cmd2.Parameters.Add(new SqlParameter("@Email", ownerEmail));

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string fname = read["OwnerFirstName"].ToString();
                            string lname = read["OwnerLastName"].ToString();
                            string phone = read["OwnerPhone"].ToString();
                            string email = read["OwnerEmail"].ToString();
                            Console.WriteLine(fname + " " + lname + " " + phone + " " + email);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }
    }
}
