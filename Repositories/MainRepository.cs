using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuSistemi.Data;
using HastaneRandevuSistemi.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace HastaneRandevuSistemi.Repositories
{
    public class MainRepository
    {
        private string _connectionString = "Server=localhost;Database=deneme;Uid=root;Pwd=kerem4567";

        public List<User> GetAllUsers() {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString)) {
                conn.Open();

                string query = "SELECT id, username, password, isAdmin FROM users";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read())
                    {
                        User user = new User()
                        {
                            Id = reader.GetInt32("id"),
                            Username = reader.GetString("username"),
                            Password = reader.GetString("password"),
                        };
                        users.Add(user);
                    }
                }

            }
            return users;

        }


        public User Login(string username, string password)
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT id, username, password, isAdmin FROM users WHERE username=@username AND password=@password";
                using (var cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32("id"),
                                Username = reader.GetString("username"),
                                Password = reader.GetString("password"),
                                IsAdmin = reader.GetBoolean("isAdmin")
                                

                            };
                        }
                    }
                }
            }

            return null;
        }

        public List<Doctor> GetAllDoctors() {
            List<Doctor> doctors = new List<Doctor>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM doctors";

                using (MySqlCommand cmd = new MySqlCommand(@query, conn))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try {
                                Doctor doctor = new Doctor()
                                {
                                    Id = reader.GetInt32("id"),
                                    FirstName = reader.GetString("first_name"),
                                    LastName = reader.GetString("last_name"),
                                    Gender = reader.GetString("gender"),
                                    BirthDate = reader.GetString("birth_date"),
                                    Specialization = reader.GetString("specialization"),
                                    ExperienceYear = reader.GetString("experience_year"),
                                    Email = reader.GetString("email"),
                                    Phone = reader.GetString("phone"),
                                    Password = reader.GetString("password"),

                                    /*
                                    Id = reader.GetInt32("id"),
                                    FirstName = reader["first_name"]?.ToString(),
                                    LastName = reader["last_name"]?.ToString(),
                                    Gender = reader["gender"]?.ToString(),
                                    BirthDate = reader["birth_date"]?.ToString(),
                                    Specialization = reader["specialization"]?.ToString(),
                                    ExperienceYear = reader["experience_year"]?.ToString(),
                                    Email = reader["email"]?.ToString(),
                                    Phone = reader["phone"]?.ToString(),
                                    Password = reader["password"]?.ToString(),
                                    */
                                };
                                doctors.Add(doctor);
                            }
                            catch (Exception ex){
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }

                }
                return doctors;

            }

        }

        

        public Doctor LoginDoctor(string email, string password) {
            using (var conn = new MySqlConnection(_connectionString)) {
                conn.Open();

                string query = "SELECT email, password FROM doctors WHERE email=@email AND password=@password";
                using (var cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            return new Doctor
                            {
                                Email = reader.GetString("email"),
                                Password = reader.GetString("password"),
                            };
                        }
                    }

                }
            }

            return null;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (var conn = new MySqlConnection(_connectionString)) {
                conn.Open();

                string query = "INSERT INTO doctors " +
                    
                    "(first_name, last_name, gender, birth_date, specialization, experience_year, email, phone, password)" +
                    "VALUES (@first_name, @last_name, @gender, @birth_date, @specialization, @experience_year, @email, @phone, @password )";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", doctor.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", doctor.LastName);
                    cmd.Parameters.AddWithValue("@gender", doctor.Gender);
                    cmd.Parameters.AddWithValue("@birth_date", doctor.BirthDate);
                    cmd.Parameters.AddWithValue("@specialization", doctor.Specialization);
                    cmd.Parameters.AddWithValue("@experience_year", doctor.ExperienceYear);
                    cmd.Parameters.AddWithValue("@email", doctor.Email);
                    cmd.Parameters.AddWithValue("@phone", doctor.Phone);
                    cmd.Parameters.AddWithValue("@password", doctor.Password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Yazma başarılı");
                    }
                    
                }
            }
        }

        public void AddUser(User user) {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string query = "INSERT INTO users (username, password, isAdmin) VALUES (@username, @password, @isAdmin)";


                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Yazma başarılı");
                    }

                }
            }
        }

        public void Insert(User user) {
            using (var conn = new MySqlConnection(_connectionString)) {
                conn.Open();

                string query = @"INSERT INTO users (username, password, role) VALUES (@usernam, @password, @role)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);

                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) { 
                            
                        }
                    }
                }

            }
        }


    }
}
