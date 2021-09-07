﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocalNewsApi.Models
{
    public class ArticleContext
    {
        public string ConnectionString { get; set; }

        public ArticleContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM articles;", conn);

                using (var reader = cmd.ExecuteReader())
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

            return articles;
        }
    }
}
