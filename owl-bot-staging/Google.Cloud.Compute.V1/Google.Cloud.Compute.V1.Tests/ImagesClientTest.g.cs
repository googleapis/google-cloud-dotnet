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
    public sealed class GeneratedImagesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetImageRequest request = new GetImageRequest
            {
                Image = "image225a8078",
                Project = "projectaa6ff846",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetImageRequest request = new GetImageRequest
            {
                Image = "image225a8078",
                Project = "projectaa6ff846",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Image>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Image responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetImageRequest request = new GetImageRequest
            {
                Image = "image225a8078",
                Project = "projectaa6ff846",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image response = client.Get(request.Project, request.Image);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetImageRequest request = new GetImageRequest
            {
                Image = "image225a8078",
                Project = "projectaa6ff846",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Image>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image responseCallSettings = await client.GetAsync(request.Project, request.Image, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Image responseCancellationToken = await client.GetAsync(request.Project, request.Image, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFromFamilyRequestObject()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetFromFamily(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image response = client.GetFromFamily(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFromFamilyRequestObjectAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetFromFamilyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Image>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image responseCallSettings = await client.GetFromFamilyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Image responseCancellationToken = await client.GetFromFamilyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFromFamily()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetFromFamily(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image response = client.GetFromFamily(request.Project, request.Family);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFromFamilyAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            Image expectedResponse = new Image
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseCodes =
                {
                    -3549522739643304114L,
                },
                SourceImage = "source_image5e9c0c38",
                SourceImageId = "source_image_id954b5e55",
                GuestOsFeatures =
                {
                    new GuestOsFeature(),
                },
                SourceSnapshotId = "source_snapshot_id008ab5dd",
                SourceSnapshot = "source_snapshot1fcf3da1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Image.Types.Status.Ready,
                ShieldedInstanceInitialState = new InitialStateConfig(),
                SourceSnapshotEncryptionKey = new CustomerEncryptionKey(),
                DiskSizeGb = 7103353205508136450L,
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Family = "family0bda3f0d",
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                ImageEncryptionKey = new CustomerEncryptionKey(),
                ArchiveSizeBytes = -1817962760933329403L,
                SourceImageEncryptionKey = new CustomerEncryptionKey(),
                Description = "description2cf9da67",
                SourceDisk = "source_disk0eec086f",
                SourceType = Image.Types.SourceType.UndefinedSourceType,
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawDisk = new RawDisk(),
                Deprecated = new DeprecationStatus(),
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetFromFamilyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Image>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Image responseCallSettings = await client.GetFromFamilyAsync(request.Project, request.Family, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Image responseCancellationToken = await client.GetFromFamilyAsync(request.Project, request.Family, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Resource, request.GlobalSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Resource, request.GlobalSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Resource, request.GlobalSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Images.ImagesClient> mockGrpcClient = new moq::Mock<Images.ImagesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
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
            ImagesClient client = new ImagesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
