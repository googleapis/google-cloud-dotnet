// See https://aka.ms/new-console-template for more information


using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.V1;

public class Program
{
    public static void Main(string[] args)
    {
        string projectId = "";
        string instanceId = "";
        string databaseId = "";
        string? universeDomain = "";
        string? host = null;
        int? port = null;
        string credentialFilePath = "";
        int rowId = 1;

        string connectionString = $"Data Source=projects/{projectId}/instances/{instanceId}/databases/{databaseId};Host={host};Port={port};UniverseDomain={universeDomain};CredentialFile={credentialFilePath}";
        Console.WriteLine("Starting execution..");

        try
        {
            Console.WriteLine(CreateTables(connectionString, databaseId));
        }
        catch (Exception ex) {

            // Catch for exception indicating table schema already exists
            if(!ex.Message.Contains("Duplicate name in schema"))
            {
                throw;
            }
        }

        Console.WriteLine("Executing Insert Row..");
        Console.WriteLine(Insert(connectionString, rowId));

    }

    public static int CreateTables(string connectionString, string databaseId)
    {

        using var connection = new SpannerConnection(connectionString);
        var createSingersTable =
            @"CREATE TABLE Singers (
                SingerId INT64 NOT NULL,
                FirstName STRING(1024),
                LastName STRING(1024),
                ComposerInfo BYTES(MAX),
                FullName STRING(2048) AS (ARRAY_TO_STRING([FirstName, LastName], "" "")) STORED
            ) PRIMARY KEY (SingerId)";
        // Define create table statement for table #2.
        var createAlbumsTable =
            @"CREATE TABLE Albums (
                SingerId INT64 NOT NULL,
                AlbumId INT64 NOT NULL,
                AlbumTitle STRING(MAX)
            ) PRIMARY KEY (SingerId, AlbumId),
            INTERLEAVE IN PARENT Singers ON DELETE CASCADE";

        using var createDbCommand = connection.CreateDdlCommand(createSingersTable, createAlbumsTable);
        return createDbCommand.ExecuteNonQueryAsync().Result;
    }

    private static int Insert(string connectionString, int rowId)
    {
        var options = new SessionPoolOptions();
        var poolManager = SessionPoolManager.Create(options);
        var connectionStringBuilder = new SpannerConnectionStringBuilder
        {
            ConnectionString = connectionString,
            LogCommitStats = true,
            SessionPoolManager = poolManager,
        };

        using var connection = new SpannerConnection(connectionStringBuilder);
        Console.WriteLine("Start waiting on connection open..");
        connection.OpenAsync().Wait();

        using var cmd = connection.CreateDmlCommand($"INSERT Singers (SingerId, FirstName, LastName) VALUES ({rowId}, 'Virginia', 'Watson')");
        var rowCount = cmd.ExecuteNonQueryAsync().Result;

        Console.WriteLine($"{rowCount} row(s) inserted...");

        return rowCount;
    }
}

