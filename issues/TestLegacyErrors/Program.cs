using Google.Cloud.Compute.V1;
using Grpc.Core;
using lro = Google.LongRunning;

// Run program `dotnet run project-id={your-project-id} zone={your-zone} disk-name={your-disk-name}`
namespace test_legacy_errors
{
    class Program
    {
        const string PROJECT_ID_ARG = "project-id";
        const string ZONE_ARG = "zone";
        const string DISK_NAME_ARG = "disk-name";
        static string PROJECT_ID = "";
        static string ZONE = "";
        static string DISK_NAME = "";
        // const int SIZE_GB = 10;

        static void Main(string[] args)
        {
            InitializeCommandLineArgs(args);
            InsertDisk();
        }

        private static void InitializeCommandLineArgs(string[] args)
        {
            var arguments = new Dictionary<string, string>();

            foreach (string argument in args)
            {
                string[] splitted = argument.Split('=');

                if (splitted.Length == 2)
                {
                    arguments[splitted[0]] = splitted[1];
                }
            }

            try
            {
                PROJECT_ID = arguments[PROJECT_ID_ARG];
                ZONE = arguments[ZONE_ARG];
                DISK_NAME = arguments[DISK_NAME_ARG];
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine($"You did not provide a necessary command line argument! {e.Message}");
                throw;
            }

        }

        private static void InsertDisk()
        {
            // Create client
            DisksClient disksClient = DisksClient.Create();

            // Initialize request argument(s)
            Disk newDisk = new Disk();
            newDisk.Name = DISK_NAME;
            InsertDiskRequest request = new InsertDiskRequest
            {
                Zone = ZONE,
                DiskResource = newDisk,
                RequestId = "",
                Project = PROJECT_ID,
            };

            try
            {
                // Make the request
                lro::Operation<Operation, Operation> response = disksClient.Insert(request);
                // Poll until the returned long-running operation is complete
                lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
                // Retrieve the operation result
                Operation result = completedResponse.Result;
                if (result.HasHttpErrorStatusCode)
                {
                    Console.WriteLine($"Error code detected: {result.HttpErrorStatusCode}");
                    Console.WriteLine($"Error message detected: {result.HttpErrorMessage}");
                }
                else
                {
                    Console.WriteLine($"No errors found {result}");
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine("Got Exception!!");
                Console.WriteLine($"Status(StatusCode = {e.StatusCode}, Detail =  {e.Message}");
                Console.WriteLine($"Status = {e.Status}");

                Console.WriteLine("Printing Metadata of exception...");
                foreach (var entry in e.Trailers)
                {
                    string key = entry.Key;
                    var value = entry.IsBinary ? "" : entry.Value;
                    if (entry.IsBinary)
                    {
                        // Encoding ref: https://grpc.github.io/grpc/csharp/api/Grpc.Core.Metadata.Entry.html#Grpc_Core_Metadata_Entry_ValueBytes
                        value = System.Text.Encoding.ASCII.GetString(entry.ValueBytes);
                    }

                    Console.WriteLine($"Key: {key} , Value: {value}");
                }
            }
        }

    }
}
