using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services.Contracts;
using System.Data.SqlClient;

namespace Assembly.MusicApp.DataMsSql
{
    public class UserRepository : IUserRepository
    {

        private readonly string _tableName = "Users";
        private readonly string _cs = @"Server=.\SQLEXPRESS11;Database=MusicApp;Trusted_Connection=True;";

        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            var list = new List<User>();

            using SqlConnection conn = new SqlConnection(_cs);

            conn.Open();

            string query = $"SELECT * FROM {_tableName}";
            using SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (int)dr["Id"];
                string name = (string)dr["Name"];
                string description = (string)dr["Description"];
                int age = (int)dr["Age"];
                list.Add(new User()
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Age = age
                });
            }

            return list;
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            return true;
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
