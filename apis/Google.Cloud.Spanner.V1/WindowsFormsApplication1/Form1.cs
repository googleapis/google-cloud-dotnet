using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.V1;
using Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static bool s_onceTrue = true;

        private async void button1_Click(object sender, EventArgs e)
        {
            TestExtensions.SessionGetter = (session) =>
            {
                if (s_onceTrue)
                {
                    s_onceTrue = false;
                    //use a valid expired session.
                    return new SessionName(session.SessionName.ProjectId, session.SessionName.InstanceId,
                        session.SessionName.DatabaseId, "AGxixuX72Phx7LDjnAe8a-AJKEs9lg_XO-avnpjYAWgqXcn-V4xuQ1DagA8");
                }
                return session.SessionName;
            };

            SpannerConnection.ConnectionPoolOptions.LogPerformanceTraces = true;
            SpannerConnection.ConnectionPoolOptions.PerformanceTraceLogInterval = 10000;
            SpannerConnection.ConnectionPoolOptions.ResetPerformanceTracesEachInterval = false;
            button1.Text = @"Working!";
            button1.Enabled = false;

            var retryPolicy =
                new RetryPolicy<SpannerTransientErrorDetector>(
                    new ExponentialBackoff(3, TimeSpan.FromMilliseconds(10),
                        TimeSpan.FromMilliseconds(10000), TimeSpan.FromMilliseconds(200)));

            await retryPolicy.ExecuteAsync(async () =>
            {
                using (var connection = new SpannerConnection("Data Source=spanneref/myspanner/mydatabase"))
                {
                    await connection.OpenAsync();
                    // QUERY EXAMPLE
                    var cmd = connection.CreateSelectCommand("SELECT * FROM Books ORDER BY ID");
                    long idCheck = 1;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            if (reader.GetInt64(0) != idCheck)
                            {
                                Debug.WriteLine(
                                    $"Id Check failed for Name: {reader["Name"]}  idCheck: {idCheck} readerValue: {reader.GetInt64(0)}");
                                idCheck = reader.GetInt64(0);
                            }
                            idCheck++;
                        }
                    }

                    long maxId = 0;
                    int rowsAffected;

                    for (int i = 0; i < 2; i++)
                    {
                        //QUERY SCALAR
                        cmd = connection.CreateSelectCommand("SELECT MAX(ID) FROM Books");
                        maxId = await cmd.ExecuteScalarAsync<long>();
                        maxId += i + 1;

                        // INSERT EXAMPLE
                        cmd = connection.CreateInsertCommand("Books", new SpannerParameterCollection {
                            {"ID", SpannerDbType.Int64},
                            {"Author", SpannerDbType.String},
                            {"ISBN", SpannerDbType.String},
                            {"Name", SpannerDbType.String},
                            {"PublishDate", SpannerDbType.Date},
                        });

                        button1.Text = $@"writing {maxId}";

                        cmd.Parameters["ID"].Value = maxId;
                        cmd.Parameters["Author"].Value = "Phil Fritzche";
                        cmd.Parameters["ISBN"].Value = "12345678";
                        cmd.Parameters["Name"].Value = $"Testing Spanner using Examples #{maxId}";
                        cmd.Parameters["PublishDate"].Value = DateTime.Today;
                        rowsAffected = await cmd.ExecuteNonQueryAsync();
                        Debug.WriteLine($"{rowsAffected} Rows affected.");
                    }

                    // UPDATE EXAMPLE
                    cmd = connection.CreateUpdateCommand("Books", new SpannerParameterCollection {
                        {"ID", SpannerDbType.Int64},
                        {"Author", SpannerDbType.String},
                        {"ISBN", SpannerDbType.String},
                        {"Name", SpannerDbType.String},
                        {"PublishDate", SpannerDbType.Date},
                    });

                    cmd.Parameters["ID"].Value = maxId;
                    cmd.Parameters["Author"].Value = "Phil Fritzche";
                    cmd.Parameters["ISBN"].Value = "12345678";
                    cmd.Parameters["Name"].Value = $"Testing Spanner using Examples. {maxId} Edition";
                    cmd.Parameters["PublishDate"].Value = DateTime.Today;
                    rowsAffected = await cmd.ExecuteNonQueryAsync();
                    Debug.WriteLine($"{rowsAffected} Rows affected. MaxId={maxId}");
                }
            });

            button1.Text = @"GO!";
            button1.Enabled = true;
        }
    }

    class SpannerTransientErrorDetector : ITransientErrorDetectionStrategy
    {
        public bool IsTransient(Exception ex)
        {
            return ex.IsTransientSpannerFault();
        }
    }
}
