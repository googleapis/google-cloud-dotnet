// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Language.V1;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Google.Cloud.MetadataTesting
{
    /// <summary>
    /// Used to investigate https://github.com/googleapis/google-cloud-dotnet/issues/1394
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TestAsync(MakeMetadataRequest);
            Test(MakeLanguageRequest);
            Test(ShowPlatform);
            Test(ShowRunningOnComputeEngine);
        }

        static void Test(Func<string> function)
        {
            string name = function.Method.Name;
            try
            {
                Log($"{name}: {function()}");
            }
            catch (Exception e)
            {
                Log($"{name}: {e.GetType().Name}: {e.Message}");
            }
        }

        static void TestAsync(Func<Task<string>> function)
        {
            string name = function.Method.Name;
            try
            {
                var result = Task.Run(function).Result;
                Log($"{name}: {result}");
            }
            catch (AggregateException e)
            {
                foreach (var inner in e.InnerExceptions)
                {
                    Log($"{name}: {inner.GetType().Name}: {inner.Message}");
                }
            }
        }

        static async Task<string> MakeMetadataRequest()
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, "http://metadata.google.internal");
            var cts = new CancellationTokenSource(5000);

            var httpClient = new HttpClient();
            var stopwatch = Stopwatch.StartNew();
            var response = await httpClient.SendAsync(httpRequest, cts.Token).ConfigureAwait(false);
            stopwatch.Stop();

            bool googleFlavor = false;
            if (response.IsSuccessStatusCode && response.Headers.TryGetValues("Metadata-Flavor", out var headerValues))
            {
                googleFlavor = headerValues.Contains("Google");
            }

            return $"{response.StatusCode} ({(int) stopwatch.ElapsedMilliseconds}ms) / Google flavor ? {googleFlavor}";
        }

        static string ShowRunningOnComputeEngine() =>
            ComputeCredential.IsRunningOnComputeEngine().Result.ToString();

        static string ShowPlatform() => Platform.Instance().ToString();        

        static string MakeLanguageRequest()
        {
            var client = LanguageServiceClient.Create();
            var annotation = client.AnnotateText(
                Document.FromPlainText("This is a test for Google."),
                new Features { ExtractEntities = true });
            return $"Language service returned {annotation.Entities.Count} entities";
        }

        static void Log(string message) =>
            Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss.FFFFFF}: {message}");
    }
}
