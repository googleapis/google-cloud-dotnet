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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.OsLogin.Common;
using Google.Cloud.OsLogin.V1Beta;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.OsLogin.V1Beta.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedOsLoginServiceClientSnippets
    {
        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountAsync()
        {
            // Snippet: DeletePosixAccountAsync(ProjectName,CallSettings)
            // Additional: DeletePosixAccountAsync(ProjectName,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[USER]", "[PROJECT]");
            // Make the request
            await osLoginServiceClient.DeletePosixAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccount</summary>
        public void DeletePosixAccount()
        {
            // Snippet: DeletePosixAccount(ProjectName,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[USER]", "[PROJECT]");
            // Make the request
            osLoginServiceClient.DeletePosixAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccountAsync</summary>
        public async Task DeletePosixAccountAsync_RequestObject()
        {
            // Snippet: DeletePosixAccountAsync(DeletePosixAccountRequest,CallSettings)
            // Additional: DeletePosixAccountAsync(DeletePosixAccountRequest,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                ProjectName = new ProjectName("[USER]", "[PROJECT]"),
            };
            // Make the request
            await osLoginServiceClient.DeletePosixAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePosixAccount</summary>
        public void DeletePosixAccount_RequestObject()
        {
            // Snippet: DeletePosixAccount(DeletePosixAccountRequest,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                ProjectName = new ProjectName("[USER]", "[PROJECT]"),
            };
            // Make the request
            osLoginServiceClient.DeletePosixAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyAsync()
        {
            // Snippet: DeleteSshPublicKeyAsync(FingerprintName,CallSettings)
            // Additional: DeleteSshPublicKeyAsync(FingerprintName,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            // Make the request
            await osLoginServiceClient.DeleteSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKey</summary>
        public void DeleteSshPublicKey()
        {
            // Snippet: DeleteSshPublicKey(FingerprintName,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKeyAsync</summary>
        public async Task DeleteSshPublicKeyAsync_RequestObject()
        {
            // Snippet: DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest,CallSettings)
            // Additional: DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            await osLoginServiceClient.DeleteSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSshPublicKey</summary>
        public void DeleteSshPublicKey_RequestObject()
        {
            // Snippet: DeleteSshPublicKey(DeleteSshPublicKeyRequest,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileAsync()
        {
            // Snippet: GetLoginProfileAsync(UserName,CallSettings)
            // Additional: GetLoginProfileAsync(UserName,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = new UserName("[USER]");
            // Make the request
            LoginProfile response = await osLoginServiceClient.GetLoginProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfile</summary>
        public void GetLoginProfile()
        {
            // Snippet: GetLoginProfile(UserName,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UserName name = new UserName("[USER]");
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfileAsync</summary>
        public async Task GetLoginProfileAsync_RequestObject()
        {
            // Snippet: GetLoginProfileAsync(GetLoginProfileRequest,CallSettings)
            // Additional: GetLoginProfileAsync(GetLoginProfileRequest,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
            };
            // Make the request
            LoginProfile response = await osLoginServiceClient.GetLoginProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoginProfile</summary>
        public void GetLoginProfile_RequestObject()
        {
            // Snippet: GetLoginProfile(GetLoginProfileRequest,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
            };
            // Make the request
            LoginProfile response = osLoginServiceClient.GetLoginProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyAsync()
        {
            // Snippet: GetSshPublicKeyAsync(FingerprintName,CallSettings)
            // Additional: GetSshPublicKeyAsync(FingerprintName,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            // Make the request
            SshPublicKey response = await osLoginServiceClient.GetSshPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKey</summary>
        public void GetSshPublicKey()
        {
            // Snippet: GetSshPublicKey(FingerprintName,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKeyAsync</summary>
        public async Task GetSshPublicKeyAsync_RequestObject()
        {
            // Snippet: GetSshPublicKeyAsync(GetSshPublicKeyRequest,CallSettings)
            // Additional: GetSshPublicKeyAsync(GetSshPublicKeyRequest,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            SshPublicKey response = await osLoginServiceClient.GetSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSshPublicKey</summary>
        public void GetSshPublicKey_RequestObject()
        {
            // Snippet: GetSshPublicKey(GetSshPublicKeyRequest,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.GetSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        public async Task ImportSshPublicKeyAsync1()
        {
            // Snippet: ImportSshPublicKeyAsync(UserName,SshPublicKey,CallSettings)
            // Additional: ImportSshPublicKeyAsync(UserName,SshPublicKey,CancellationToken)
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
        public void ImportSshPublicKey1()
        {
            // Snippet: ImportSshPublicKey(UserName,SshPublicKey,CallSettings)
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
        public async Task ImportSshPublicKeyAsync2()
        {
            // Snippet: ImportSshPublicKeyAsync(UserName,SshPublicKey,string,CallSettings)
            // Additional: ImportSshPublicKeyAsync(UserName,SshPublicKey,string,CancellationToken)
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

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey2()
        {
            // Snippet: ImportSshPublicKey(UserName,SshPublicKey,string,CallSettings)
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
        public async Task ImportSshPublicKeyAsync_RequestObject()
        {
            // Snippet: ImportSshPublicKeyAsync(ImportSshPublicKeyRequest,CallSettings)
            // Additional: ImportSshPublicKeyAsync(ImportSshPublicKeyRequest,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportSshPublicKey</summary>
        public void ImportSshPublicKey_RequestObject()
        {
            // Snippet: ImportSshPublicKey(ImportSshPublicKeyRequest,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            // Make the request
            ImportSshPublicKeyResponse response = osLoginServiceClient.ImportSshPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKeyAsync1()
        {
            // Snippet: UpdateSshPublicKeyAsync(FingerprintName,SshPublicKey,CallSettings)
            // Additional: UpdateSshPublicKeyAsync(FingerprintName,SshPublicKey,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey1()
        {
            // Snippet: UpdateSshPublicKey(FingerprintName,SshPublicKey,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKeyAsync2()
        {
            // Snippet: UpdateSshPublicKeyAsync(FingerprintName,SshPublicKey,FieldMask,CallSettings)
            // Additional: UpdateSshPublicKeyAsync(FingerprintName,SshPublicKey,FieldMask,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey2()
        {
            // Snippet: UpdateSshPublicKey(FingerprintName,SshPublicKey,FieldMask,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(name, sshPublicKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKeyAsync</summary>
        public async Task UpdateSshPublicKeyAsync_RequestObject()
        {
            // Snippet: UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest,CallSettings)
            // Additional: UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest,CancellationToken)
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
            };
            // Make the request
            SshPublicKey response = await osLoginServiceClient.UpdateSshPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSshPublicKey</summary>
        public void UpdateSshPublicKey_RequestObject()
        {
            // Snippet: UpdateSshPublicKey(UpdateSshPublicKeyRequest,CallSettings)
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
            };
            // Make the request
            SshPublicKey response = osLoginServiceClient.UpdateSshPublicKey(request);
            // End snippet
        }

    }
}
