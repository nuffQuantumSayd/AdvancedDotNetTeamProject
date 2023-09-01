using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSourceControl.Models;

namespace TeamSourceControl
{
    static class ActorDb
    {
        public static void Add(Actor a)
        {
            // establishing connection and creating cmd
            SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            // insert query
            insertCmd.CommandText = "INSERT INTO Actors(ActorFirstName, ActorLastName, ActorFollowed)"
                                    + "VALUES(@fname, @lname, @followed)";
            insertCmd.Parameters.AddWithValue("@id", a.ActorId);
            insertCmd.Parameters.AddWithValue("@fname", a.FirstName);
            insertCmd.Parameters.AddWithValue("@lname", a.LastName);
            insertCmd.Parameters.AddWithValue("@followed", a.Followed);

            // execution
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Update(Actor a)
        {
            // establishing connection and creating cmd
            SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;

            // update query
            updateCmd.CommandText = "UPDATE Actors SET ActorFirstName = @fname, ActorLastName = @lname, ActorFollowed = @followed WHERE ActorId = @id)";

            updateCmd.Parameters.AddWithValue("@id", a.ActorId);
            updateCmd.Parameters.AddWithValue("@fname", a.FirstName);
            updateCmd.Parameters.AddWithValue("@lname", a.LastName);
            updateCmd.Parameters.AddWithValue("@followed", a.Followed);

            // execution
            con.Open();
            updateCmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Delete(Actor a)
        {
            // establishing connection and creating cmd
            SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand deleteCmd = new SqlCommand();
            deleteCmd.Connection = con;

            // update query
            deleteCmd.CommandText = "DELETE FROM Actors WHERE ActorId = @id)";
            deleteCmd.Parameters.AddWithValue("@id", a.ActorId);

            // execution
            con.Open();
            deleteCmd.ExecuteNonQuery();
            con.Close();
        }

        public static List<Actor> GetAll()
        {
            // establishing connection and creating cmd
            SqlConnection conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = conn;

            // select query
            selCmd.CommandText = "SELECT * FROM Actors ORDER BY ActorLastName asc";

            // execution
            conn.Open();
            SqlDataReader reader = selCmd.ExecuteReader();

            // making list of movies to be returned
            List<Actor> actorsList = new List<Actor>();
            while (reader.Read())
            {
                int actorId = Convert.ToInt32(reader["ActorID"]);
                string fName = reader["ActorFirstName"].ToString();
                string lName = reader["ActorLastName"].ToString();
                bool followed = reader["ActorFollowed"] as bool? ?? false; // will return false in case of null

                Actor temp = new Actor(fName, lName, followed);
                temp.ActorId = actorId;

                actorsList.Add(temp);
            }

            conn.Close();
            return actorsList;
        }

        public static Actor Get(int id)
        {
            // establishing connection and creating cmd
            SqlConnection conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = conn;

            // select query
            selCmd.CommandText = "SELECT * FROM Actors WHERE ActorId = @id";
            selCmd.Parameters.AddWithValue("@id", id);

            // execution
            conn.Open();
            SqlDataReader reader = selCmd.ExecuteReader();

            // making movie object to be returned
            int actorId = Convert.ToInt32(reader["ActorID"]);
            string fName = reader["ActorFirstName"].ToString();
            string lName = reader["ActorLastName"].ToString();
            bool followed = reader["ActorFollowed"] as bool? ?? false; // will return false in case of null

            Actor actor = new Actor(fName, lName, followed);
            actor.ActorId = actorId;

            conn.Close();
            return actor;
        }
    }
}
