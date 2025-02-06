// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Cloud.OsLogin.Common;
    using Google.Cloud.OsLogin.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOsLoginServiceClientSnippets
    {
        /// <summary>Snippet for CreateSshPublicKey</summary>
        public void CreateSshPublicKeyRequestObject()
        {
            // Snippet: CreateSshPublicKey(CreateSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            CreateSshPublicKeyRequest request = new CreateSshPublicKeyRequest
            {
                ParentAsUserName = UserName.FromUser("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.CreateSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSshPublicKeyAsync</summary>
        public async Task CreateSshPublicKeyRequestObjectAsync()
        {
            // Snippet: CreateSshPublicKeyAsync(CreateSshPublicKeyRequest, CallSettings)
            // Additional: CreateSshPublicKeyAsync(CreateSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSshPublicKeyRequest request = new CreateSshPublicKeyRequest
            {
                ParentAsUserName = UserName.FromUser("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            // Make the request
            SshPublicKey response = await osLoginServiceClient.CreateSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSshPublicKey</summary>
        public void CreateSshPublicKey()
        {
            // Snippet: CreateSshPublicKey(string, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = osLoginServiceClient.CreateSshPublicKey(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for CreateSshPublicKeyAsync</summary>
        public async Task CreateSshPublicKeyAsync()
        {
            // Snippet: CreateSshPublicKeyAsync(string, SshPublicKey, CallSettings)
            // Additional: CreateSshPublicKeyAsync(string, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.CreateSshPublicKeyAsync(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for CreateSshPublicKey</summary>
        public void CreateSshPublicKeyResourceNames()
        {
            // Snippet: CreateSshPublicKey(UserName, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = osLoginServiceClient.CreateSshPublicKey(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for CreateSshPublicKeyAsync</summary>
        public async Task CreateSshPublicKeyResourceNamesAsync()
        {
            // Snippet: CreateSshPublicKeyAsync(UserName, SshPublicKey, CallSettings)
            // Additional: CreateSshPublicKeyAsync(UserName, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.CreateSshPublicKeyAsync(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccount</summary>
        public void DeletePosixAccountRequestObject()
        {
            // Snippet: DeletePosixAccount(DeletePosixAccountRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            // Make the request
            osLoginServiceClient.DeletePosixAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountRequestObjectAsync()
        {
            // Snippet: DeletePosixAccountAsync(DeletePosixAccountRequest, CallSettings)
            // Additional: DeletePosixAccountAsync(DeletePosixAccountRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
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
        public void DeletePosixAccountResourceNames()
        {
            // Snippet: DeletePosixAccount(PosixAccountName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            PosixAccountName name = PosixAccountName.FromUserProject("[USER]", "[PROJECT]");
            // Make the request
            osLoginServiceClient.DeletePosixAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountResourceNamesAsync()
        {
            // Snippet: DeletePosixAccountAsync(PosixAccountName, CallSettings)
            // Additional: DeletePosixAccountAsync(PosixAccountName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            PosixAccountName name = PosixAccountName.FromUserProject("[USER]", "[PROJECT]");
            // Make the request
            await osLoginServiceClient.DeletePosixAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKey</summary>
        public void DeleteSshPublicKeyRequestObject()
        {
            // Snippet: DeleteSshPublicKey(DeleteSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyRequestObjectAsync()
        {
            // Snippet: DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest, CallSettings)
            // Additional: DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
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
        public void DeleteSshPublicKeyResourceNames()
        {
            // Snippet: DeleteSshPublicKey(SshPublicKeyName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyResourceNamesAsync()
        {
            // Snippet: DeleteSshPublicKeyAsync(SshPublicKeyName, CallSettings)
            // Additional: DeleteSshPublicKeyAsync(SshPublicKeyName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            // Make the request
            await osLoginServiceClient.DeleteSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfile</summary>
        public void GetLoginProfileRequestObject()
        {
            // Snippet: GetLoginProfile(GetLoginProfileRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = UserName.FromUser("[USER]"),
                ProjectId = "",
                SystemId = "",
                View = LoginProfileView.Unspecified,
            };
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileRequestObjectAsync()
        {
            // Snippet: GetLoginProfileAsync(GetLoginProfileRequest, CallSettings)
            // Additional: GetLoginProfileAsync(GetLoginProfileRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = UserName.FromUser("[USER]"),
                ProjectId = "",
                SystemId = "",
                View = LoginProfileView.Unspecified,
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
        public void GetLoginProfileResourceNames()
        {
            // Snippet: GetLoginProfile(UserName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromUser("[USER]");
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileResourceNamesAsync()
        {
            // Snippet: GetLoginProfileAsync(UserName, CallSettings)
            // Additional: GetLoginProfileAsync(UserName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromUser("[USER]");
            // Make the request
            LoginProfile response = await osLoginServiceClient.GetLoginProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKey</summary>
        public void GetSshPublicKeyRequestObject()
        {
            // Snippet: GetSshPublicKey(GetSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyRequestObjectAsync()
        {
            // Snippet: GetSshPublicKeyAsync(GetSshPublicKeyRequest, CallSettings)
            // Additional: GetSshPublicKeyAsync(GetSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
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
        public void GetSshPublicKeyResourceNames()
        {
            // Snippet: GetSshPublicKey(SshPublicKeyName, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyResourceNamesAsync()
        {
            // Snippet: GetSshPublicKeyAsync(SshPublicKeyName, CallSettings)
            // Additional: GetSshPublicKeyAsync(SshPublicKeyName, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            // Make the request
            SshPublicKey response = await osLoginServiceClient.GetSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKeyRequestObject()
        {
            // Snippet: ImportSshPublicKey(ImportSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = UserName.FromUser("[USER]"),
                SshPublicKey = new SshPublicKey(),
                ProjectId = "",
                View = LoginProfileView.Unspecified,
                Regions = { "", },
            };
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKeyRequestObjectAsync()
        {
            // Snippet: ImportSshPublicKeyAsync(ImportSshPublicKeyRequest, CallSettings)
            // Additional: ImportSshPublicKeyAsync(ImportSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = UserName.FromUser("[USER]"),
                SshPublicKey = new SshPublicKey(),
                ProjectId = "",
                View = LoginProfileView.Unspecified,
                Regions = { "", },
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
        public void ImportSshPublicKey1ResourceNames()
        {
            // Snippet: ImportSshPublicKey(UserName, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKey1ResourceNamesAsync()
        {
            // Snippet: ImportSshPublicKeyAsync(UserName, SshPublicKey, CallSettings)
            // Additional: ImportSshPublicKeyAsync(UserName, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
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
        public void ImportSshPublicKey2ResourceNames()
        {
            // Snippet: ImportSshPublicKey(UserName, SshPublicKey, string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(parent, sshPublicKey, projectId);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKey2ResourceNamesAsync()
        {
            // Snippet: ImportSshPublicKeyAsync(UserName, SshPublicKey, string, CallSettings)
            // Additional: ImportSshPublicKeyAsync(UserName, SshPublicKey, string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(parent, sshPublicKey, projectId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKeyRequestObject()
        {
            // Snippet: UpdateSshPublicKey(UpdateSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKeyRequestObjectAsync()
        {
            // Snippet: UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
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
        public void UpdateSshPublicKey1ResourceNames()
        {
            // Snippet: UpdateSshPublicKey(SshPublicKeyName, SshPublicKey, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKey1ResourceNamesAsync()
        {
            // Snippet: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
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
        public void UpdateSshPublicKey2ResourceNames()
        {
            // Snippet: UpdateSshPublicKey(SshPublicKeyName, SshPublicKey, FieldMask, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKey2ResourceNamesAsync()
        {
            // Snippet: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, FieldMask, CallSettings)
            // Additional: UpdateSshPublicKeyAsync(SshPublicKeyName, SshPublicKey, FieldMask, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SshPublicKeyName name = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for SignSshPublicKey</summary>
        public void SignSshPublicKeyRequestObject()
        {
            // Snippet: SignSshPublicKey(SignSshPublicKeyRequest, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            SignSshPublicKeyRequest request = new SignSshPublicKeyRequest
            {
                SshPublicKey = "",
                Parent = "",
            };
            // Make the request
            SignSshPublicKeyResponse response = osLoginServiceClient.SignSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for SignSshPublicKeyAsync</summary>
        public async Task SignSshPublicKeyRequestObjectAsync()
        {
            // Snippet: SignSshPublicKeyAsync(SignSshPublicKeyRequest, CallSettings)
            // Additional: SignSshPublicKeyAsync(SignSshPublicKeyRequest, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            SignSshPublicKeyRequest request = new SignSshPublicKeyRequest
            {
                SshPublicKey = "",
                Parent = "",
            };
            // Make the request
            SignSshPublicKeyResponse response = await osLoginServiceClient.SignSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SignSshPublicKey</summary>
        public void SignSshPublicKey()
        {
            // Snippet: SignSshPublicKey(string, string, CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            string sshPublicKey = "";
            // Make the request
            SignSshPublicKeyResponse response = osLoginServiceClient.SignSshPublicKey(parent, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for SignSshPublicKeyAsync</summary>
        public async Task SignSshPublicKeyAsync()
        {
            // Snippet: SignSshPublicKeyAsync(string, string, CallSettings)
            // Additional: SignSshPublicKeyAsync(string, string, CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            string sshPublicKey = "";
            // Make the request
            SignSshPublicKeyResponse response = await osLoginServiceClient.SignSshPublicKeyAsync(parent, sshPublicKey);
            // End snippet
        }
    }
}
