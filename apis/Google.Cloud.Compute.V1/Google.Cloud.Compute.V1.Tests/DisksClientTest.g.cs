// Copyright 2021 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDisksClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "disk028b6875",
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Disk expectedResponse = new Disk
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Zone = "zone255f4ea8",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LastAttachTimestamp = "last_attach_timestamp4fe3fe94",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                ReplicaZones =
                {
                    "replica_zonesc1977354",
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                LastDetachTimestamp = "last_detach_timestampffef196b",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                Users = { "users2a5cc69b", },
                SourceSnapshot = "source_snapshot1fcf3da1",
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Disk.Types.Status.Deleting,
                ProvisionedIops = -3779563869670119518L,
                SourceStorageObject = "source_storage_object4e059972",
                DiskEncryptionKey = new CustomerEncryptionKey(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Options = "optionsa965da93",
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                PhysicalBlockSizeBytes = -7292518380745299537L,
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                SizeGb = -3653169847519542788L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Disk response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "disk028b6875",
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Disk expectedResponse = new Disk
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Zone = "zone255f4ea8",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LastAttachTimestamp = "last_attach_timestamp4fe3fe94",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                ReplicaZones =
                {
                    "replica_zonesc1977354",
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                LastDetachTimestamp = "last_detach_timestampffef196b",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                Users = { "users2a5cc69b", },
                SourceSnapshot = "source_snapshot1fcf3da1",
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Disk.Types.Status.Deleting,
                ProvisionedIops = -3779563869670119518L,
                SourceStorageObject = "source_storage_object4e059972",
                DiskEncryptionKey = new CustomerEncryptionKey(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Options = "optionsa965da93",
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                PhysicalBlockSizeBytes = -7292518380745299537L,
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                SizeGb = -3653169847519542788L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Disk>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Disk responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Disk responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "disk028b6875",
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Disk expectedResponse = new Disk
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Zone = "zone255f4ea8",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LastAttachTimestamp = "last_attach_timestamp4fe3fe94",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                ReplicaZones =
                {
                    "replica_zonesc1977354",
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                LastDetachTimestamp = "last_detach_timestampffef196b",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                Users = { "users2a5cc69b", },
                SourceSnapshot = "source_snapshot1fcf3da1",
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Disk.Types.Status.Deleting,
                ProvisionedIops = -3779563869670119518L,
                SourceStorageObject = "source_storage_object4e059972",
                DiskEncryptionKey = new CustomerEncryptionKey(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Options = "optionsa965da93",
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                PhysicalBlockSizeBytes = -7292518380745299537L,
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                SizeGb = -3653169847519542788L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Disk response = client.Get(request.Project, request.Zone, request.Disk);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "disk028b6875",
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Disk expectedResponse = new Disk
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Zone = "zone255f4ea8",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LastAttachTimestamp = "last_attach_timestamp4fe3fe94",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                ReplicaZones =
                {
                    "replica_zonesc1977354",
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                LastDetachTimestamp = "last_detach_timestampffef196b",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                Users = { "users2a5cc69b", },
                SourceSnapshot = "source_snapshot1fcf3da1",
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Disk.Types.Status.Deleting,
                ProvisionedIops = -3779563869670119518L,
                SourceStorageObject = "source_storage_object4e059972",
                DiskEncryptionKey = new CustomerEncryptionKey(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Options = "optionsa965da93",
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                PhysicalBlockSizeBytes = -7292518380745299537L,
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                SizeGb = -3653169847519542788L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Disk>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Disk responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.Disk, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Disk responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.Disk, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Zone, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Disks.DisksClient> mockGrpcClient = new moq::Mock<Disks.DisksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisksClient client = new DisksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
