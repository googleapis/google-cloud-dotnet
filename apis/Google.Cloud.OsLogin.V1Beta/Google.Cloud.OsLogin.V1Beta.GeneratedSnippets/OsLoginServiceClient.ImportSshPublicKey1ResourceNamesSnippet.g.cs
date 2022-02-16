// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.OsLogin.V1Beta.Snippets
{
    // [START oslogin_v1beta_generated_OsLoginService_ImportSshPublicKey_sync_flattened1_resourceNames]
    using Google.Cloud.OsLogin.Common;
    using Google.Cloud.OsLogin.V1Beta;

    public sealed partial class GeneratedOsLoginServiceClientSnippets
    {
        /// <summary>Snippet for ImportSshPublicKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ImportSshPublicKey1ResourceNames()
        {
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey);
        }
    }
    // [END oslogin_v1beta_generated_OsLoginService_ImportSshPublicKey_sync_flattened1_resourceNames]
}
