// Copyright 2019 Google LLC
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

namespace Google.Cloud.OsLogin.V1.Snippets
{
    using Google.Cloud.OsLogin.Common;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedOsLoginServiceClientSnippets
    {
        /// <summary>Snippet for DeletePosixAccount</summary>
        public void DeletePosixAccount_RequestObject()
        {
            // Snippet: DeletePosixAccount(DeletePosixAccountRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = new PosixAccountName("[USER]", "[PROJECT]"),
            };
            // Make the request
            osLoginServiceClient.DeletePosixAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountAsync_RequestObject()
        {
            // Snippet: DeletePosixAccountAsync(DeletePosixAccountRequest, CallSettings)
            // Additional: DeletePosixAccountAsync(DeletePosixAccountRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = new PosixAccountName("[USER]", "[PROJECT]"),
            };
            // Make the request
            await osLoginServiceClient.DeletePosixAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccount</summary>
        public void DeletePosixAccount()
        {
            // Snippet: DeletePosixAccount(string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/projects/[PROJECT]";
            // Make the request
            osLoginServiceClient.DeletePosixAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountAsync()
        {
            // Snippet: DeletePosixAccountAsync(string, CallSettings)
            // Additional: DeletePosixAccountAsync(string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/projects/[PROJECT]";
            // Make the request
            await osLoginServiceClient.DeletePosixAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccount</summary>
        public void DeletePosixAccount_ResourceNames()
        {
            // Snippet: DeletePosixAccount(PosixAccountName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            PosixAccountName name = new PosixAccountName("[USER]", "[PROJECT]");
            // Make the request
            osLoginServiceClient.DeletePosixAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountAsync_ResourceNames()
        {
            // Snippet: DeletePosixAccountAsync(PosixAccountName, CallSettings)
            // Additional: DeletePosixAccountAsync(PosixAccountName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            PosixAccountName name = new PosixAccountName("[USER]", "[PROJECT]");
            // Make the request
            await osLoginServiceClient.DeletePosixAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKey</summary>
        public void DeleteSshPublicKey_RequestObject()
        {
            // Snippet: DeleteSshPublicKey(DeleteSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = new SshPublicKeyName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyAsync_RequestObject()
        {
            // Snippet: DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest, CallSettings)
            // Additional: DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = new SshPublicKeyName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            await osLoginServiceClient.DeleteSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKey</summary>
        public void DeleteSshPublicKey()
        {
            // Snippet: DeleteSshPublicKey(string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyAsync()
        {
            // Snippet: DeleteSshPublicKeyAsync(string, CallSettings)
            // Additional: DeleteSshPublicKeyAsync(string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            // Make the request
            await osLoginServiceClient.DeleteSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKey</summary>
        public void DeleteSshPublicKey_ResourceNames()
        {
            // Snippet: DeleteSshPublicKey(SshPublicKeyName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyAsync_ResourceNames()
        {
            // Snippet: DeleteSshPublicKeyAsync(SshPublicKeyName, CallSettings)
            // Additional: DeleteSshPublicKeyAsync(SshPublicKeyName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            // Make the request
            await osLoginServiceClient.DeleteSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfile</summary>
        public void GetLoginProfile_RequestObject()
        {
            // Snippet: GetLoginProfile(GetLoginProfileRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
                ProjectId = "",
                SystemId = "",
            };
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileAsync_RequestObject()
        {
            // Snippet: GetLoginProfileAsync(GetLoginProfileRequest, CallSettings)
            // Additional: GetLoginProfileAsync(GetLoginProfileRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
                ProjectId = "",
                SystemId = "",
            };
            // Make the request
            LoginProfile response = await osLoginServiceClient.GetLoginProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfile</summary>
        public void GetLoginProfile()
        {
            // Snippet: GetLoginProfile(string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]";
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileAsync()
        {
            // Snippet: GetLoginProfileAsync(string, CallSettings)
            // Additional: GetLoginProfileAsync(string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]";
            // Make the request
            LoginProfile response = await osLoginServiceClient.GetLoginProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfile</summary>
        public void GetLoginProfile_ResourceNames()
        {
            // Snippet: GetLoginProfile(UserName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName name = new UserName("[USER]");
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileAsync_ResourceNames()
        {
            // Snippet: GetLoginProfileAsync(UserName, CallSettings)
            // Additional: GetLoginProfileAsync(UserName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = new UserName("[USER]");
            // Make the request
            LoginProfile response = await osLoginServiceClient.GetLoginProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKey</summary>
        public void GetSshPublicKey_RequestObject()
        {
            // Snippet: GetSshPublicKey(GetSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = new SshPublicKeyName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyAsync_RequestObject()
        {
            // Snippet: GetSshPublicKeyAsync(GetSshPublicKeyRequest, CallSettings)
            // Additional: GetSshPublicKeyAsync(GetSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = new SshPublicKeyName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            SshPublicKey response = await osLoginServiceClient.GetSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKey</summary>
        public void GetSshPublicKey()
        {
            // Snippet: GetSshPublicKey(string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyAsync()
        {
            // Snippet: GetSshPublicKeyAsync(string, CallSettings)
            // Additional: GetSshPublicKeyAsync(string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            // Make the request
            SshPublicKey response = await osLoginServiceClient.GetSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKey</summary>
        public void GetSshPublicKey_ResourceNames()
        {
            // Snippet: GetSshPublicKey(SshPublicKeyName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyAsync_ResourceNames()
        {
            // Snippet: GetSshPublicKeyAsync(SshPublicKeyName, CallSettings)
            // Additional: GetSshPublicKeyAsync(SshPublicKeyName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            // Make the request
            SshPublicKey response = await osLoginServiceClient.GetSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey_RequestObject()
        {
            // Snippet: ImportSshPublicKey(ImportSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
                ProjectId = "",
            };
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKeyAsync_RequestObject()
        {
            // Snippet: ImportSshPublicKeyAsync(ImportSshPublicKeyRequest, CallSettings)
            // Additional: ImportSshPublicKeyAsync(ImportSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
                ProjectId = "",
            };
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey1()
        {
            // Snippet: ImportSshPublicKey(string, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKey1Async()
        {
            // Snippet: ImportSshPublicKeyAsync(string, SshPublicKey, CallSettings)
            // Additional: ImportSshPublicKeyAsync(string, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey1_ResourceNames()
        {
            // Snippet: ImportSshPublicKey(UserName, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKey1Async_ResourceNames()
        {
            // Snippet: ImportSshPublicKeyAsync(UserName, SshPublicKey, CallSettings)
            // Additional: ImportSshPublicKeyAsync(UserName, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey2()
        {
            // Snippet: ImportSshPublicKey(string, SshPublicKey, string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey, projectId);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKey2Async()
        {
            // Snippet: ImportSshPublicKeyAsync(string, SshPublicKey, string, CallSettings)
            // Additional: ImportSshPublicKeyAsync(string, SshPublicKey, string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(parent, sshPublicKey, projectId);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey2_ResourceNames()
        {
            // Snippet: ImportSshPublicKey(UserName, SshPublicKey, string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey, projectId);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKey2Async_ResourceNames()
        {
            // Snippet: ImportSshPublicKeyAsync(UserName, SshPublicKey, string, CallSettings)
            // Additional: ImportSshPublicKeyAsync(UserName, SshPublicKey, string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(parent, sshPublicKey, projectId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey_RequestObject()
        {
            // Snippet: UpdateSshPublicKey(UpdateSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = new SshPublicKeyName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKeyAsync_RequestObject()
        {
            // Snippet: UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = new SshPublicKeyName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey1()
        {
            // Snippet: UpdateSshPublicKey(string, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKey1Async()
        {
            // Snippet: UpdateSshPublicKeyAsync(string, SshPublicKey, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(string, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey1_ResourceNames()
        {
            // Snippet: UpdateSshPublicKey(SshPublicKeyName, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKey1Async_ResourceNames()
        {
            // Snippet: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey2()
        {
            // Snippet: UpdateSshPublicKey(string, SshPublicKey, FieldMask, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKey2Async()
        {
            // Snippet: UpdateSshPublicKeyAsync(string, SshPublicKey, FieldMask, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(string, SshPublicKey, FieldMask, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/sshPublicKeys/[FINGERPRINT]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey2_ResourceNames()
        {
            // Snippet: UpdateSshPublicKey(SshPublicKeyName, SshPublicKey, FieldMask, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKey2Async_ResourceNames()
        {
            // Snippet: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, FieldMask, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, FieldMask, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = new SshPublicKeyName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask);
            // End snippet
        }
    }
}
