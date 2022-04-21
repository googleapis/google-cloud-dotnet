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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSslCertificatesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<SslCertificates.SslCertificatesClient> mockGrpcClient = new moq::Mock<SslCertificates.SslCertificatesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslCertificateRequest request = new GetSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SslCertificatesClient client = new SslCertificatesClientImpl(mockGrpcClient.Object, null, null);
            SslCertificate response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<SslCertificates.SslCertificatesClient> mockGrpcClient = new moq::Mock<SslCertificates.SslCertificatesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslCertificateRequest request = new GetSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SslCertificatesClient client = new SslCertificatesClientImpl(mockGrpcClient.Object, null, null);
            SslCertificate responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslCertificate responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<SslCertificates.SslCertificatesClient> mockGrpcClient = new moq::Mock<SslCertificates.SslCertificatesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslCertificateRequest request = new GetSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SslCertificatesClient client = new SslCertificatesClientImpl(mockGrpcClient.Object, null, null);
            SslCertificate response = client.Get(request.Project, request.SslCertificate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<SslCertificates.SslCertificatesClient> mockGrpcClient = new moq::Mock<SslCertificates.SslCertificatesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslCertificateRequest request = new GetSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SslCertificatesClient client = new SslCertificatesClientImpl(mockGrpcClient.Object, null, null);
            SslCertificate responseCallSettings = await client.GetAsync(request.Project, request.SslCertificate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslCertificate responseCancellationToken = await client.GetAsync(request.Project, request.SslCertificate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
