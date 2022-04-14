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

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Grafeas.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGrafeasClientTest
    {
        [xunit::FactAttribute]
        public void GetOccurrenceRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.GetOccurrence(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOccurrenceRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.GetOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.GetOccurrenceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOccurrence()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.GetOccurrence(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOccurrenceAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.GetOccurrenceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.GetOccurrenceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOccurrenceResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.GetOccurrence(request.OccurrenceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOccurrenceResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.GetOccurrenceAsync(request.OccurrenceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.GetOccurrenceAsync(request.OccurrenceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteOccurrenceRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteOccurrence(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteOccurrenceRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteOccurrenceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteOccurrence()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteOccurrence(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteOccurrenceAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOccurrenceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteOccurrenceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteOccurrenceResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteOccurrence(request.OccurrenceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteOccurrenceResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOccurrenceAsync(request.OccurrenceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteOccurrenceAsync(request.OccurrenceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateOccurrenceRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.CreateOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.CreateOccurrence(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateOccurrenceRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.CreateOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.CreateOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.CreateOccurrenceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateOccurrence()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.CreateOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.CreateOccurrence(request.Parent, request.Occurrence);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateOccurrenceAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.CreateOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.CreateOccurrenceAsync(request.Parent, request.Occurrence, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.CreateOccurrenceAsync(request.Parent, request.Occurrence, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateOccurrenceResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.CreateOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.CreateOccurrence(request.ParentAsProjectName, request.Occurrence);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateOccurrenceResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.CreateOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.CreateOccurrenceAsync(request.ParentAsProjectName, request.Occurrence, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.CreateOccurrenceAsync(request.ParentAsProjectName, request.Occurrence, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateOccurrencesRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse
            {
                Occurrences = { new Occurrence(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateOccurrences(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse response = client.BatchCreateOccurrences(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateOccurrencesRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse
            {
                Occurrences = { new Occurrence(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateOccurrencesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateOccurrencesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse responseCallSettings = await client.BatchCreateOccurrencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateOccurrencesResponse responseCancellationToken = await client.BatchCreateOccurrencesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateOccurrences()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse
            {
                Occurrences = { new Occurrence(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateOccurrences(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse response = client.BatchCreateOccurrences(request.Parent, request.Occurrences);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateOccurrencesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse
            {
                Occurrences = { new Occurrence(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateOccurrencesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateOccurrencesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse responseCallSettings = await client.BatchCreateOccurrencesAsync(request.Parent, request.Occurrences, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateOccurrencesResponse responseCancellationToken = await client.BatchCreateOccurrencesAsync(request.Parent, request.Occurrences, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateOccurrencesResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse
            {
                Occurrences = { new Occurrence(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateOccurrences(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse response = client.BatchCreateOccurrences(request.ParentAsProjectName, request.Occurrences);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateOccurrencesResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse
            {
                Occurrences = { new Occurrence(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateOccurrencesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateOccurrencesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse responseCallSettings = await client.BatchCreateOccurrencesAsync(request.ParentAsProjectName, request.Occurrences, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateOccurrencesResponse responseCancellationToken = await client.BatchCreateOccurrencesAsync(request.ParentAsProjectName, request.Occurrences, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateOccurrenceRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new wkt::FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.UpdateOccurrence(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateOccurrenceRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new wkt::FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.UpdateOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.UpdateOccurrenceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateOccurrence()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new wkt::FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.UpdateOccurrence(request.Name, request.Occurrence, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateOccurrenceAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new wkt::FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.UpdateOccurrenceAsync(request.Name, request.Occurrence, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.UpdateOccurrenceAsync(request.Name, request.Occurrence, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateOccurrenceResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new wkt::FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.UpdateOccurrence(request.OccurrenceName, request.Occurrence, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateOccurrenceResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new wkt::FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resource_uri7af9ce14",
                NoteName = "note_name1f6be6eb",
                Kind = NoteKind.Upgrade,
                Remediation = "remediation325aa33d",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Vulnerability = new VulnerabilityOccurrence(),
                Build = new BuildOccurrence(),
                Image = new ImageOccurrence(),
                Package = new PackageOccurrence(),
                Deployment = new DeploymentOccurrence(),
                Discovery = new DiscoveryOccurrence(),
                Attestation = new AttestationOccurrence(),
                Upgrade = new UpgradeOccurrence(),
                Compliance = new ComplianceOccurrence(),
                DsseAttestation = new DSSEAttestationOccurrence(),
                Envelope = new Envelope(),
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Occurrence>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence responseCallSettings = await client.UpdateOccurrenceAsync(request.OccurrenceName, request.Occurrence, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Occurrence responseCancellationToken = await client.UpdateOccurrenceAsync(request.OccurrenceName, request.Occurrence, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOccurrenceNoteRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetOccurrenceNote(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOccurrenceNoteRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.GetOccurrenceNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.GetOccurrenceNoteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOccurrenceNote()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetOccurrenceNote(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOccurrenceNoteAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.GetOccurrenceNoteAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.GetOccurrenceNoteAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOccurrenceNoteResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetOccurrenceNote(request.OccurrenceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOccurrenceNoteResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.GetOccurrenceNoteAsync(request.OccurrenceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.GetOccurrenceNoteAsync(request.OccurrenceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNoteRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetNote(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNoteRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.GetNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.GetNoteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNote()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetNote(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNoteAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.GetNoteAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.GetNoteAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNoteResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetNote(request.NoteName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNoteResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.GetNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.GetNoteAsync(request.NoteName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.GetNoteAsync(request.NoteName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNoteRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteNote(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNoteRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNoteAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNote()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteNote(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNoteAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNoteAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNoteAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNoteResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteNote(request.NoteName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNoteResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNoteAsync(request.NoteName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNoteAsync(request.NoteName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNoteRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "note_id3b811521",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.CreateNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.CreateNote(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNoteRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "note_id3b811521",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.CreateNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.CreateNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.CreateNoteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNote()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "note_id3b811521",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.CreateNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.CreateNote(request.Parent, request.NoteId, request.Note);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNoteAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "note_id3b811521",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.CreateNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.CreateNoteAsync(request.Parent, request.NoteId, request.Note, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.CreateNoteAsync(request.Parent, request.NoteId, request.Note, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNoteResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "note_id3b811521",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.CreateNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.CreateNote(request.ParentAsProjectName, request.NoteId, request.Note);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNoteResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "note_id3b811521",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.CreateNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.CreateNoteAsync(request.ParentAsProjectName, request.NoteId, request.Note, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.CreateNoteAsync(request.ParentAsProjectName, request.NoteId, request.Note, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateNotesRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes =
                {
                    {
                        "key8a0b6e3c",
                        new Note()
                    },
                },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse { Notes = { new Note(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateNotes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse response = client.BatchCreateNotes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateNotesRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes =
                {
                    {
                        "key8a0b6e3c",
                        new Note()
                    },
                },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse { Notes = { new Note(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateNotesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateNotesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse responseCallSettings = await client.BatchCreateNotesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateNotesResponse responseCancellationToken = await client.BatchCreateNotesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateNotes()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes =
                {
                    {
                        "key8a0b6e3c",
                        new Note()
                    },
                },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse { Notes = { new Note(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateNotes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse response = client.BatchCreateNotes(request.Parent, request.Notes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateNotesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes =
                {
                    {
                        "key8a0b6e3c",
                        new Note()
                    },
                },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse { Notes = { new Note(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateNotesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateNotesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse responseCallSettings = await client.BatchCreateNotesAsync(request.Parent, request.Notes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateNotesResponse responseCancellationToken = await client.BatchCreateNotesAsync(request.Parent, request.Notes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateNotesResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes =
                {
                    {
                        "key8a0b6e3c",
                        new Note()
                    },
                },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse { Notes = { new Note(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateNotes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse response = client.BatchCreateNotes(request.ParentAsProjectName, request.Notes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateNotesResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes =
                {
                    {
                        "key8a0b6e3c",
                        new Note()
                    },
                },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse { Notes = { new Note(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateNotesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateNotesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse responseCallSettings = await client.BatchCreateNotesAsync(request.ParentAsProjectName, request.Notes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateNotesResponse responseCancellationToken = await client.BatchCreateNotesAsync(request.ParentAsProjectName, request.Notes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNoteRequestObject()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new wkt::FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.UpdateNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.UpdateNote(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNoteRequestObjectAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new wkt::FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.UpdateNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.UpdateNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.UpdateNoteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNote()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new wkt::FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.UpdateNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.UpdateNote(request.Name, request.Note, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNoteAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new wkt::FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.UpdateNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.UpdateNoteAsync(request.Name, request.Note, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.UpdateNoteAsync(request.Name, request.Note, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNoteResourceNames()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new wkt::FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.UpdateNote(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.UpdateNote(request.NoteName, request.Note, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNoteResourceNamesAsync()
        {
            moq::Mock<Grafeas.GrafeasClient> mockGrpcClient = new moq::Mock<Grafeas.GrafeasClient>(moq::MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new wkt::FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                ShortDescription = "short_descriptionc10c6633",
                LongDescription = "long_description1b5f6e1a",
                Kind = NoteKind.Upgrade,
                RelatedUrl = { new RelatedUrl(), },
                ExpirationTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                RelatedNoteNames =
                {
                    "related_note_names7289d354",
                },
                Vulnerability = new VulnerabilityNote(),
                Build = new BuildNote(),
                Image = new ImageNote(),
                Package = new PackageNote(),
                Deployment = new DeploymentNote(),
                Discovery = new DiscoveryNote(),
                Attestation = new AttestationNote(),
                Upgrade = new UpgradeNote(),
                Compliance = new ComplianceNote(),
                DsseAttestation = new DSSEAttestationNote(),
            };
            mockGrpcClient.Setup(x => x.UpdateNoteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Note>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note responseCallSettings = await client.UpdateNoteAsync(request.NoteName, request.Note, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Note responseCancellationToken = await client.UpdateNoteAsync(request.NoteName, request.Note, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
