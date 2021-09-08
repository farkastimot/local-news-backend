using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocalNewsApi.Models
{
    public class DatabaseContext
    {
        public string ConnectionString { get; set; }

        public DatabaseContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        // --------------------------------------------------------------------------------------------------------------- ARTICLES
        //  Get all of the articles
        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM articles;", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        articles.Add(new Article()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Author = reader["author"].ToString(),
                            Category = Convert.ToInt32(reader["category"]),
                            Title = reader["title"].ToString(),
                            Description = reader["description"].ToString(),
                            UrlToImage = reader["urlToImage"].ToString(),
                            PublishedAt = Convert.ToDateTime(reader["publishedAt"]),
                            Content = reader["content"].ToString()
                        });
                    }
                }
            }

            return articles;
        }

        //  get top news
        public List<Article> GetTopArticles(int category, int page, int amount)
        {
            List<Article> articles = new List<Article>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string sqlCommand = "SELECT id, category, title, description, urlToImage, publishedAt FROM articles WHERE TIMESTAMPDIFF(DAY,`publishedAt`,now()) < 30";
                if (category != 0) sqlCommand += " AND `category` = @Category ";
                sqlCommand += " ORDER BY `publishedAt` DESC LIMIT @Limit ";
                if (page != 0) sqlCommand += " OFFSET "+(page*10).ToString()+" ";
                sqlCommand += ";";

                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Limit", amount);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        articles.Add(new Article()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Author = "",
                            Category = Convert.ToInt32(reader["category"]),
                            Title = reader["title"].ToString(),
                            Description = reader["description"].ToString(),
                            UrlToImage = reader["urlToImage"].ToString(),
                            PublishedAt = Convert.ToDateTime(reader["publishedAt"]),
                            Content = ""
                        });
                    }
                }
            }

            return articles;
        }

        // --------------------------------------------------------------------------------------------------------------- CATEGORIES
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString()
                        });
                    }
                }
            }


            return categories;
        }

        public List<Category> GetCategoryByID(int id)
        {
            List<Category> category = new List<Category>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories WHERE id=@Id LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        category.Add(new Category()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString()
                        });
                    }
                }
            }

            return category;
        }
    }
}
