using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSourceControl.Models;

namespace TeamSourceControl
{
    static class MovieDb
    {
        public static void Add(Movie m)
        {
            // establishing connection and creating cmd
            SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            // insert query
            insertCmd.CommandText = "INSERT INTO Movies(MovieName, MovieGenre, MovieStatus, ReleaseYear, RunTime)"
                                    + "VALUES(@title, @genre, @status, @release, @runtime)";
            insertCmd.Parameters.AddWithValue("@id", m.MovieId);
            insertCmd.Parameters.AddWithValue("@title", m.Title);
            insertCmd.Parameters.AddWithValue("@genre", m.Genre);
            insertCmd.Parameters.AddWithValue("@status", m.Status);
            insertCmd.Parameters.AddWithValue("@release", m.ReleaseDate);
            insertCmd.Parameters.AddWithValue("@runtime", m.RunTime);

            // execution
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Update(Movie m)
        {
            // establishing connection and creating cmd
            SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;

            // update query
            updateCmd.CommandText = "UPDATE Movies SET MovieName = @title, MovieGenre = @genre, MovieStatus = @status, ReleaseYear = @release, RunTime = @runtime WHERE MovieId = @id";

            updateCmd.Parameters.AddWithValue("@id", m.MovieId);
            updateCmd.Parameters.AddWithValue("@title", m.Title);
            updateCmd.Parameters.AddWithValue("@genre", m.Genre);
            updateCmd.Parameters.AddWithValue("@status", m.Status);
            updateCmd.Parameters.AddWithValue("@release", m.ReleaseDate);
            updateCmd.Parameters.AddWithValue("@runtime", m.RunTime);

            // execution
            con.Open();
            updateCmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Delete(Movie m) 
        {
            // establishing connection and creating cmd
            SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand deleteCmd = new SqlCommand();
            deleteCmd.Connection = con;

            // update query
            deleteCmd.CommandText = "DELETE FROM Movies WHERE MovieId = @id)";
            deleteCmd.Parameters.AddWithValue("@id", m.MovieId);

            // execution
            con.Open();
            deleteCmd.ExecuteNonQuery();
            con.Close();
        }

        public static List<Movie> GetAll() 
        {
            // establishing connection and creating cmd
            SqlConnection conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = conn;

            // select query
            selCmd.CommandText = "SELECT * FROM Movies ORDER BY MovieName asc";

            // execution
            conn.Open();
            SqlDataReader reader = selCmd.ExecuteReader();

            // making list of movies to be returned
            List<Movie> moviesList = new List<Movie>();
            while (reader.Read())
            {
                int movieId = Convert.ToInt32(reader["MovieID"]);
                string movieName = reader["MovieName"].ToString();
                string movieGenre = reader["MovieGenre"].ToString();
                string movieStatus = reader["MovieStatus"].ToString();
                DateTime releaseDate = Convert.ToDateTime(reader["ReleaseYear"]);
                TimeSpan runtime = TimeSpan.FromTicks(((TimeSpan)reader["RunTime"]).Ticks);

                Movie temp = new Movie(movieName, movieGenre, movieStatus, releaseDate, runtime);
                temp.MovieId = movieId;

                moviesList.Add(temp);
            }

            conn.Close();
            return moviesList;
        }

        public static Movie Get(int id)
        {
            // establishing connection and creating cmd
            SqlConnection conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=MoviesDatabase;Integrated Security=True");
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = conn;

            // select query
            selCmd.CommandText = "SELECT * FROM Movies WHERE MovieId = @id";
            selCmd.Parameters.AddWithValue("@id", id);

            // execution
            conn.Open();
            SqlDataReader reader = selCmd.ExecuteReader();

            // making movie object to be returned
            int movieId = Convert.ToInt32(reader["MovieID"]);
            string movieName = reader["MovieName"].ToString();
            string movieGenre = reader["MovieGenre"].ToString();
            string movieStatus = reader["MovieStatus"].ToString();
            DateTime releaseDate = Convert.ToDateTime(reader["ReleaseYear"]);
            TimeSpan runtime = TimeSpan.FromTicks(((TimeSpan)reader["RunTime"]).Ticks);

            Movie movie = new Movie(movieName, movieGenre, movieStatus, releaseDate, runtime);
            movie.MovieId = movieId;

            conn.Close();
            return movie;
        }
    }
}
