// Copyright 2020 Google LLC
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

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Temporary command used by uploaddocs.sh to print "the first part of the service endpoint" in
    /// order to upload docs to the right path. For example, all Spanner APIs have an endpoint of
    /// "spanner.googleapis.com" so this command would print "spanner".
    /// 
    /// REST-based APIs (Storage, BigQuery and Translation) are special-cased, as are Firestore and Spanner.
    /// 
    /// The service endpoints are loaded from the Service Directory.
    /// 
    /// I'm hoping this can be replaced with a command to print the docuploader metadata directly,
    /// instead of using docuploader create-metadata.
    /// </summary>
    public class PrintApiShortName : CommandBase
    {
        public PrintApiShortName()
            : base("print-api-short-name", "Retrieves the first part of an API's service endpoint, if any", "id")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];

            // Validate that the API exists.
            var catalog = ApiCatalog.Load();
            _ = catalog[id];

            var serviceDirectory = ServiceDirectory.LoadFromGoogleapis();
            var service = serviceDirectory.Services.FirstOrDefault(service => service.CSharpNamespaceFromProtos == id);

            if (service is null)
            {
                // No direct service - special case REST APIs and Firestore/Spanner:
                string name = id switch
                {
                    "Google.Cloud.Storage.V1" => "storage",
                    "Google.Cloud.BigQuery.V2" => "bigquery",
                    "Google.Cloud.Translation.V2" => "translate",
                    "Google.Cloud.Spanner.Data" => "spanner",
                    "Google.Cloud.Firestore" => "firestore",
                    _ => null
                };
                Console.WriteLine(name);
                return;
            }

            // Just ignore non-googleapis.com APIs for now.
            if (service.Name.EndsWith(".googleapis.com"))
            {                
            }
            Console.WriteLine(service.Name.Substring(0, service.Name.Length - ".googleapis.com".Length));
        }
    }
}
