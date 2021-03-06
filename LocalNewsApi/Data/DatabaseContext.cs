using System;
using System.Collections.Generic;
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
        public List<Article> GetArticles(string searchTerm, int category, int page, bool top = false, int amount = 10, bool all = false)
        {
            List<Article> articles = new List<Article>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                //Build our sql query
                string sqlCommand = "SELECT id, category, title, description, urlToImage, publishedAt FROM articles ";
                if (top || category != 0 || searchTerm != "") sqlCommand += "WHERE ";
                //if we need the top articles only select from the last 7 days
                if (top) sqlCommand += "TIMESTAMPDIFF(DAY,`publishedAt`, now()) < 30";
                //If we need to add a category, add a category
                if (category != 0) sqlCommand += (top ? " AND " : " ") + "`category` = @Category ";
                //Search if we have a search term (in title, description and content)
                if (searchTerm != "") sqlCommand += (top || category != 0 ? " AND " : " ") + " (title LIKE @TitleSearch) OR (description LIKE @DescSearch) OR (content LIKE @ContentSearch) ";
                //Add the limit (all the time)
                sqlCommand += (searchTerm != "" ? "" : " ORDER BY `publishedAt` DESC ") + " LIMIT @Limit ";
                if (page != 0) sqlCommand += " OFFSET " + (page * 10).ToString() + " ";
                sqlCommand += ";";
                //JUST GET IT ALL INSTEAD
                if (all) sqlCommand = "SELECT * FROM articles;";

                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                if (category != 0) cmd.Parameters.AddWithValue("@Category", category);
                if (searchTerm != "")
                {
                    cmd.Parameters.AddWithValue("@TitleSearch", "%" + searchTerm + "%");
                    cmd.Parameters.AddWithValue("@DescSearch", "%" + searchTerm + "%");
                    cmd.Parameters.AddWithValue("@ContentSearch", "%" + searchTerm + "%");
                }
                cmd.Parameters.AddWithValue("@Limit", amount);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        articles.Add(new Article()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Author = "ONLY AVAILABLE FOR FULL ARTICLE",
                            Category = Convert.ToInt32(reader["category"]),
                            Title = reader["title"].ToString(),
                            Description = reader["description"].ToString(),
                            UrlToImage = reader["urlToImage"].ToString(),
                            PublishedAt = Convert.ToDateTime(reader["publishedAt"]),
                            Content = "ONLY AVAILABLE FOR FULL ARTICLE"
                        });
                    }
                }
            }

            return articles;
        }

        public List<Article> GetSingleArticle(int id)
        {
            List<Article> articles = new List<Article>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                //Build our sql query
                string sqlCommand = "SELECT * FROM articles WHERE id = @Id;";

                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                cmd.Parameters.AddWithValue("@Id", id);


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

        // --------------------------------------------------------------------------------------------------------------- CATEGORIES
        public List<Category> GetCategories(int id = 0)
        {
            List<Category> categories = new List<Category>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string sqlCommand = "SELECT * FROM categories";
                if (id != 0)
                {
                    sqlCommand += " WHERE id = @Id LIMIT 1";
                }

                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                cmd.Parameters.AddWithValue("@Id", id);

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
    }
}
