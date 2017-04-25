using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Spanner;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Text = @"Working!";
            button1.Enabled = false;
            using (var connection = new SpannerConnection("Data Source=spanneref/myspanner/mydatabase"))
            {
                // QUERY EXAMPLE
                var cmd = connection.CreateSelectCommand("SELECT * FROM Books");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Debug.WriteLine($"Name: {reader["Name"]}");
                    }
                }

                // READ EXAMPLE
                cmd = connection.CreateTableDirectReadCommand("Books");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Debug.WriteLine($"Name: {reader["Name"]}");
                    }
                }

                //QUERY SCALAR
                cmd = connection.CreateSelectCommand("SELECT MAX(ID) FROM Books");
                var maxId = await cmd.ExecuteScalarAsync<long>();
                maxId++;

                // INSERT EXAMPLE
                cmd = connection.CreateInsertCommand("Books", new SpannerParameterCollection {
                    {"ID", SpannerDbType.Int64 },
                    {"Author", SpannerDbType.String },
                    {"ISBN", SpannerDbType.String },
                    {"Name", SpannerDbType.String },
                    {"PublishDate", SpannerDbType.Date },
                });

                cmd.Parameters["ID"].Value = maxId;
                cmd.Parameters["Author"].Value = "Phil Fritzche";
                cmd.Parameters["ISBN"].Value = "12345678";
                cmd.Parameters["Name"].Value = "Testing Spanner using Examples.";
                cmd.Parameters["PublishDate"].Value = DateTime.Today;
                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                Debug.WriteLine($"{rowsAffected} Rows affected.");

                // UPDATE EXAMPLE
                cmd = connection.CreateUpdateCommand("Books", new SpannerParameterCollection {
                    {"ID", SpannerDbType.Int64 },
                    {"Author", SpannerDbType.String },
                    {"ISBN", SpannerDbType.String },
                    {"Name", SpannerDbType.String },
                    {"PublishDate", SpannerDbType.Date },
                });

                cmd.Parameters["ID"].Value = maxId;
                cmd.Parameters["Author"].Value = "Phil Fritzche";
                cmd.Parameters["ISBN"].Value = "12345678";
                cmd.Parameters["Name"].Value = $"Testing Spanner using Examples. {maxId} Edition";
                cmd.Parameters["PublishDate"].Value = DateTime.Today;
                rowsAffected = await cmd.ExecuteNonQueryAsync();
                Debug.WriteLine($"{rowsAffected} Rows affected.");
            }

            button1.Text = @"GO!";
            button1.Enabled = true;
        }
    }
}
