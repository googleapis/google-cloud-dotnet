// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Auth.OAuth2;
using Google.Cloud.OsLogin.Common;
using System;

namespace Google.Cloud.OsLogin.V1.SmokeTests
{
    // Unlike most smoke tests, this is manually written as it relies on data not available to most
    // smoke tests. If smoke tests are ever generated, this file can be deleted.

    public class OsLoginServiceSmokeTest
    {
        public static int Main(string[] args)
        {
            var credential = GoogleCredential.GetApplicationDefault();
            if (!(credential.UnderlyingCredential is ServiceAccountCredential serviceAccount))
            {
                Console.WriteLine("Skipping smoke test; requires service account.");
                // Don't cause test automation to fail.
                return 0;
            }
            
            // Create client
            OsLoginServiceClient client = OsLoginServiceClient.Create();
            
            UserName userName = new UserName(serviceAccount.Id);
            var response = client.GetLoginProfile(userName);

            // Show the result
            Console.WriteLine(response);

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
