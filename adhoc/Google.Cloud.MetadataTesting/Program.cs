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
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Google.Cloud.MetadataTesting
{
    /// <summary>
    /// Used to investigate https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1394
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Test(MakeLanguageRequest);
            Test(ShowPlatform);
            Test(ShowRunningOnComputeEngine);
        }

        static void Test(Func<string> function)
        {
            string name = function.Method.Name;
            try
            {
                Console.WriteLine($"{name}: {function()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{name}: Exception: {e.GetType().Name}: {e.Message}");
            }
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
    }
}
