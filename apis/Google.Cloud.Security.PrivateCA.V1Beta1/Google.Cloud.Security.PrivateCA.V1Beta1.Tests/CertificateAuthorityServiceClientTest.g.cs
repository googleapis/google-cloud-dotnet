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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Security.PrivateCA.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCertificateAuthorityServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.CreateCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.CreateCertificate(request.Parent, request.Certificate, request.CertificateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request.Parent, request.Certificate, request.CertificateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request.Parent, request.Certificate, request.CertificateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCertificateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.CreateCertificate(request.ParentAsCertificateAuthorityName, request.Certificate, request.CertificateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request.ParentAsCertificateAuthorityName, request.Certificate, request.CertificateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request.ParentAsCertificateAuthorityName, request.Certificate, request.CertificateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.GetCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.GetCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.GetCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request.CertificateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request.CertificateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RevokeCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                Reason = RevocationReason.Superseded,
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.RevokeCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                Reason = RevocationReason.Superseded,
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.RevokeCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.RevokeCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RevokeCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.RevokeCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.RevokeCertificateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.RevokeCertificateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RevokeCertificateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.RevokeCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.RevokeCertificateAsync(request.CertificateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.RevokeCertificateAsync(request.CertificateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.UpdateCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.UpdateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.UpdateCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.UpdateCertificate(request.Certificate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate
                {
                    CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                    PemCsr = "pem_csr6e61aeb4",
                    Config = new CertificateConfig
                    {
                        SubjectConfig = new CertificateConfig.Types.SubjectConfig
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        ReusableConfig = new ReusableConfigWrapper
                        {
                            ReusableConfig = "reusable_configae98ae10",
                            ReusableConfigValues = new ReusableConfigValues
                            {
                                KeyUsage = new KeyUsage
                                {
                                    BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                    {
                                        DigitalSignature = false,
                                        ContentCommitment = false,
                                        KeyEncipherment = true,
                                        DataEncipherment = false,
                                        KeyAgreement = true,
                                        CertSign = false,
                                        CrlSign = false,
                                        EncipherOnly = false,
                                        DecipherOnly = false,
                                    },
                                    ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                    {
                                        ServerAuth = false,
                                        ClientAuth = false,
                                        CodeSigning = false,
                                        EmailProtection = true,
                                        TimeStamping = true,
                                        OcspSigning = false,
                                    },
                                    UnknownExtendedKeyUsages =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                },
                                CaOptions = new ReusableConfigValues.Types.CaOptions
                                {
                                    IsCa = false,
                                    MaxIssuerPathLength = 1013168332,
                                },
                                PolicyIds =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                                AiaOcspServers =
                                {
                                    "aia_ocsp_servers8af8fe42",
                                },
                                AdditionalExtensions =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                    },
                    Lifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RevocationDetails = new Certificate.Types.RevocationDetails
                    {
                        RevocationState = RevocationReason.CessationOfOperation,
                        RevocationTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    PemCertificate = "pem_certificate5c1b61ff",
                    CertificateDescription = new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                    PemCertificateChain =
                    {
                        "pem_certificate_chain1eff25c5",
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                RevocationDetails = new Certificate.Types.RevocationDetails
                {
                    RevocationState = RevocationReason.CessationOfOperation,
                    RevocationTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription
                {
                    SubjectDescription = new CertificateDescription.Types.SubjectDescription
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        Lifetime = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotBeforeTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        NotAfterTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    ConfigValues = new ReusableConfigValues
                    {
                        KeyUsage = new KeyUsage
                        {
                            BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                            {
                                DigitalSignature = false,
                                ContentCommitment = false,
                                KeyEncipherment = true,
                                DataEncipherment = false,
                                KeyAgreement = true,
                                CertSign = false,
                                CrlSign = false,
                                EncipherOnly = false,
                                DecipherOnly = false,
                            },
                            ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                            {
                                ServerAuth = false,
                                ClientAuth = false,
                                CodeSigning = false,
                                EmailProtection = true,
                                TimeStamping = true,
                                OcspSigning = false,
                            },
                            UnknownExtendedKeyUsages =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                        },
                        CaOptions = new ReusableConfigValues.Types.CaOptions
                        {
                            IsCa = false,
                            MaxIssuerPathLength = 1013168332,
                        },
                        PolicyIds =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                        AiaOcspServers =
                        {
                            "aia_ocsp_servers8af8fe42",
                        },
                        AdditionalExtensions =
                        {
                            new X509Extension
                            {
                                ObjectId = new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                                Critical = false,
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                    SubjectKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    AuthorityKeyId = new CertificateDescription.Types.KeyId
                    {
                        KeyId_ = "key_id2691f630",
                    },
                    CrlDistributionPoints =
                    {
                        "crl_distribution_pointsb1c6ae8c",
                    },
                    AiaIssuingCertificateUrls =
                    {
                        "aia_issuing_certificate_urlsc1dac48a",
                    },
                    CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                    {
                        Sha256Hash = "sha256_hashbc0df779",
                    },
                },
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.UpdateCertificateAsync(request.Certificate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.UpdateCertificateAsync(request.Certificate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCertificateAuthorityCsrRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse responseCallSettings = await client.FetchCertificateAuthorityCsrAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCertificateAuthorityCsrResponse responseCancellationToken = await client.FetchCertificateAuthorityCsrAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCertificateAuthorityCsr()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse responseCallSettings = await client.FetchCertificateAuthorityCsrAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCertificateAuthorityCsrResponse responseCancellationToken = await client.FetchCertificateAuthorityCsrAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCertificateAuthorityCsrResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request.CertificateAuthorityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse responseCallSettings = await client.FetchCertificateAuthorityCsrAsync(request.CertificateAuthorityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCertificateAuthorityCsrResponse responseCancellationToken = await client.FetchCertificateAuthorityCsrAsync(request.CertificateAuthorityName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateAuthorityRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec
                {
                    CloudKmsKeyVersion = "cloud_kms_key_versiona51c7572",
                    Algorithm = CertificateAuthority.Types.SignHashAlgorithm.EcP256Sha256,
                },
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy
                {
                    AllowedConfigList = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedConfigList
                    {
                        AllowedConfigValues =
                        {
                            new ReusableConfigWrapper
                            {
                                ReusableConfig = "reusable_configae98ae10",
                                ReusableConfigValues = new ReusableConfigValues
                                {
                                    KeyUsage = new KeyUsage
                                    {
                                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                        {
                                            DigitalSignature = false,
                                            ContentCommitment = false,
                                            KeyEncipherment = true,
                                            DataEncipherment = false,
                                            KeyAgreement = true,
                                            CertSign = false,
                                            CrlSign = false,
                                            EncipherOnly = false,
                                            DecipherOnly = false,
                                        },
                                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                        {
                                            ServerAuth = false,
                                            ClientAuth = false,
                                            CodeSigning = false,
                                            EmailProtection = true,
                                            TimeStamping = true,
                                            OcspSigning = false,
                                        },
                                        UnknownExtendedKeyUsages =
                                        {
                                            new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                        },
                                    },
                                    CaOptions = new ReusableConfigValues.Types.CaOptions
                                    {
                                        IsCa = false,
                                        MaxIssuerPathLength = 1013168332,
                                    },
                                    PolicyIds =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                    AiaOcspServers =
                                    {
                                        "aia_ocsp_servers8af8fe42",
                                    },
                                    AdditionalExtensions =
                                    {
                                        new X509Extension
                                        {
                                            ObjectId = new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                            Critical = false,
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    OverwriteConfigValues = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    AllowedLocationsAndOrganizations =
                    {
                        new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                    },
                    AllowedCommonNames =
                    {
                        "allowed_common_names20a07597",
                    },
                    AllowedSans = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedSubjectAltNames
                    {
                        AllowedDnsNames =
                        {
                            "allowed_dns_namesbd1651bf",
                        },
                        AllowedUris =
                        {
                            "allowed_uris55af3417",
                        },
                        AllowedEmailAddresses =
                        {
                            "allowed_email_addresses87a48b52",
                        },
                        AllowedIps =
                        {
                            "allowed_ips1f40f00a",
                        },
                        AllowGlobbingDnsWildcards = false,
                        AllowCustomSans = false,
                    },
                    MaximumLifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AllowedIssuanceModes = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.IssuanceModes
                    {
                        AllowCsrBasedIssuance = false,
                        AllowConfigBasedIssuance = false,
                    },
                },
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions
                {
                    IncludeCaCertUrl = false,
                    IncludeCrlAccessUrl = false,
                },
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls
                {
                    CaCertificateAccessUrl = "ca_certificate_access_url230b73f2",
                    CrlAccessUrl = "crl_access_url9b3819c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig
                {
                    CertificateAuthority = "certificate_authority8dcf4a45",
                    PemIssuerChain = new SubordinateConfig.Types.SubordinateConfigChain
                    {
                        PemCertificates =
                        {
                            "pem_certificatesca244b45",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority response = client.GetCertificateAuthority(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec
                {
                    CloudKmsKeyVersion = "cloud_kms_key_versiona51c7572",
                    Algorithm = CertificateAuthority.Types.SignHashAlgorithm.EcP256Sha256,
                },
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy
                {
                    AllowedConfigList = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedConfigList
                    {
                        AllowedConfigValues =
                        {
                            new ReusableConfigWrapper
                            {
                                ReusableConfig = "reusable_configae98ae10",
                                ReusableConfigValues = new ReusableConfigValues
                                {
                                    KeyUsage = new KeyUsage
                                    {
                                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                        {
                                            DigitalSignature = false,
                                            ContentCommitment = false,
                                            KeyEncipherment = true,
                                            DataEncipherment = false,
                                            KeyAgreement = true,
                                            CertSign = false,
                                            CrlSign = false,
                                            EncipherOnly = false,
                                            DecipherOnly = false,
                                        },
                                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                        {
                                            ServerAuth = false,
                                            ClientAuth = false,
                                            CodeSigning = false,
                                            EmailProtection = true,
                                            TimeStamping = true,
                                            OcspSigning = false,
                                        },
                                        UnknownExtendedKeyUsages =
                                        {
                                            new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                        },
                                    },
                                    CaOptions = new ReusableConfigValues.Types.CaOptions
                                    {
                                        IsCa = false,
                                        MaxIssuerPathLength = 1013168332,
                                    },
                                    PolicyIds =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                    AiaOcspServers =
                                    {
                                        "aia_ocsp_servers8af8fe42",
                                    },
                                    AdditionalExtensions =
                                    {
                                        new X509Extension
                                        {
                                            ObjectId = new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                            Critical = false,
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    OverwriteConfigValues = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    AllowedLocationsAndOrganizations =
                    {
                        new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                    },
                    AllowedCommonNames =
                    {
                        "allowed_common_names20a07597",
                    },
                    AllowedSans = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedSubjectAltNames
                    {
                        AllowedDnsNames =
                        {
                            "allowed_dns_namesbd1651bf",
                        },
                        AllowedUris =
                        {
                            "allowed_uris55af3417",
                        },
                        AllowedEmailAddresses =
                        {
                            "allowed_email_addresses87a48b52",
                        },
                        AllowedIps =
                        {
                            "allowed_ips1f40f00a",
                        },
                        AllowGlobbingDnsWildcards = false,
                        AllowCustomSans = false,
                    },
                    MaximumLifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AllowedIssuanceModes = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.IssuanceModes
                    {
                        AllowCsrBasedIssuance = false,
                        AllowConfigBasedIssuance = false,
                    },
                },
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions
                {
                    IncludeCaCertUrl = false,
                    IncludeCrlAccessUrl = false,
                },
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls
                {
                    CaCertificateAccessUrl = "ca_certificate_access_url230b73f2",
                    CrlAccessUrl = "crl_access_url9b3819c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig
                {
                    CertificateAuthority = "certificate_authority8dcf4a45",
                    PemIssuerChain = new SubordinateConfig.Types.SubordinateConfigChain
                    {
                        PemCertificates =
                        {
                            "pem_certificatesca244b45",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateAuthority()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec
                {
                    CloudKmsKeyVersion = "cloud_kms_key_versiona51c7572",
                    Algorithm = CertificateAuthority.Types.SignHashAlgorithm.EcP256Sha256,
                },
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy
                {
                    AllowedConfigList = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedConfigList
                    {
                        AllowedConfigValues =
                        {
                            new ReusableConfigWrapper
                            {
                                ReusableConfig = "reusable_configae98ae10",
                                ReusableConfigValues = new ReusableConfigValues
                                {
                                    KeyUsage = new KeyUsage
                                    {
                                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                        {
                                            DigitalSignature = false,
                                            ContentCommitment = false,
                                            KeyEncipherment = true,
                                            DataEncipherment = false,
                                            KeyAgreement = true,
                                            CertSign = false,
                                            CrlSign = false,
                                            EncipherOnly = false,
                                            DecipherOnly = false,
                                        },
                                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                        {
                                            ServerAuth = false,
                                            ClientAuth = false,
                                            CodeSigning = false,
                                            EmailProtection = true,
                                            TimeStamping = true,
                                            OcspSigning = false,
                                        },
                                        UnknownExtendedKeyUsages =
                                        {
                                            new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                        },
                                    },
                                    CaOptions = new ReusableConfigValues.Types.CaOptions
                                    {
                                        IsCa = false,
                                        MaxIssuerPathLength = 1013168332,
                                    },
                                    PolicyIds =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                    AiaOcspServers =
                                    {
                                        "aia_ocsp_servers8af8fe42",
                                    },
                                    AdditionalExtensions =
                                    {
                                        new X509Extension
                                        {
                                            ObjectId = new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                            Critical = false,
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    OverwriteConfigValues = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    AllowedLocationsAndOrganizations =
                    {
                        new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                    },
                    AllowedCommonNames =
                    {
                        "allowed_common_names20a07597",
                    },
                    AllowedSans = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedSubjectAltNames
                    {
                        AllowedDnsNames =
                        {
                            "allowed_dns_namesbd1651bf",
                        },
                        AllowedUris =
                        {
                            "allowed_uris55af3417",
                        },
                        AllowedEmailAddresses =
                        {
                            "allowed_email_addresses87a48b52",
                        },
                        AllowedIps =
                        {
                            "allowed_ips1f40f00a",
                        },
                        AllowGlobbingDnsWildcards = false,
                        AllowCustomSans = false,
                    },
                    MaximumLifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AllowedIssuanceModes = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.IssuanceModes
                    {
                        AllowCsrBasedIssuance = false,
                        AllowConfigBasedIssuance = false,
                    },
                },
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions
                {
                    IncludeCaCertUrl = false,
                    IncludeCrlAccessUrl = false,
                },
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls
                {
                    CaCertificateAccessUrl = "ca_certificate_access_url230b73f2",
                    CrlAccessUrl = "crl_access_url9b3819c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig
                {
                    CertificateAuthority = "certificate_authority8dcf4a45",
                    PemIssuerChain = new SubordinateConfig.Types.SubordinateConfigChain
                    {
                        PemCertificates =
                        {
                            "pem_certificatesca244b45",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority response = client.GetCertificateAuthority(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec
                {
                    CloudKmsKeyVersion = "cloud_kms_key_versiona51c7572",
                    Algorithm = CertificateAuthority.Types.SignHashAlgorithm.EcP256Sha256,
                },
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy
                {
                    AllowedConfigList = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedConfigList
                    {
                        AllowedConfigValues =
                        {
                            new ReusableConfigWrapper
                            {
                                ReusableConfig = "reusable_configae98ae10",
                                ReusableConfigValues = new ReusableConfigValues
                                {
                                    KeyUsage = new KeyUsage
                                    {
                                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                        {
                                            DigitalSignature = false,
                                            ContentCommitment = false,
                                            KeyEncipherment = true,
                                            DataEncipherment = false,
                                            KeyAgreement = true,
                                            CertSign = false,
                                            CrlSign = false,
                                            EncipherOnly = false,
                                            DecipherOnly = false,
                                        },
                                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                        {
                                            ServerAuth = false,
                                            ClientAuth = false,
                                            CodeSigning = false,
                                            EmailProtection = true,
                                            TimeStamping = true,
                                            OcspSigning = false,
                                        },
                                        UnknownExtendedKeyUsages =
                                        {
                                            new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                        },
                                    },
                                    CaOptions = new ReusableConfigValues.Types.CaOptions
                                    {
                                        IsCa = false,
                                        MaxIssuerPathLength = 1013168332,
                                    },
                                    PolicyIds =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                    AiaOcspServers =
                                    {
                                        "aia_ocsp_servers8af8fe42",
                                    },
                                    AdditionalExtensions =
                                    {
                                        new X509Extension
                                        {
                                            ObjectId = new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                            Critical = false,
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    OverwriteConfigValues = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    AllowedLocationsAndOrganizations =
                    {
                        new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                    },
                    AllowedCommonNames =
                    {
                        "allowed_common_names20a07597",
                    },
                    AllowedSans = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedSubjectAltNames
                    {
                        AllowedDnsNames =
                        {
                            "allowed_dns_namesbd1651bf",
                        },
                        AllowedUris =
                        {
                            "allowed_uris55af3417",
                        },
                        AllowedEmailAddresses =
                        {
                            "allowed_email_addresses87a48b52",
                        },
                        AllowedIps =
                        {
                            "allowed_ips1f40f00a",
                        },
                        AllowGlobbingDnsWildcards = false,
                        AllowCustomSans = false,
                    },
                    MaximumLifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AllowedIssuanceModes = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.IssuanceModes
                    {
                        AllowCsrBasedIssuance = false,
                        AllowConfigBasedIssuance = false,
                    },
                },
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions
                {
                    IncludeCaCertUrl = false,
                    IncludeCrlAccessUrl = false,
                },
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls
                {
                    CaCertificateAccessUrl = "ca_certificate_access_url230b73f2",
                    CrlAccessUrl = "crl_access_url9b3819c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig
                {
                    CertificateAuthority = "certificate_authority8dcf4a45",
                    PemIssuerChain = new SubordinateConfig.Types.SubordinateConfigChain
                    {
                        PemCertificates =
                        {
                            "pem_certificatesca244b45",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateAuthorityResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec
                {
                    CloudKmsKeyVersion = "cloud_kms_key_versiona51c7572",
                    Algorithm = CertificateAuthority.Types.SignHashAlgorithm.EcP256Sha256,
                },
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy
                {
                    AllowedConfigList = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedConfigList
                    {
                        AllowedConfigValues =
                        {
                            new ReusableConfigWrapper
                            {
                                ReusableConfig = "reusable_configae98ae10",
                                ReusableConfigValues = new ReusableConfigValues
                                {
                                    KeyUsage = new KeyUsage
                                    {
                                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                        {
                                            DigitalSignature = false,
                                            ContentCommitment = false,
                                            KeyEncipherment = true,
                                            DataEncipherment = false,
                                            KeyAgreement = true,
                                            CertSign = false,
                                            CrlSign = false,
                                            EncipherOnly = false,
                                            DecipherOnly = false,
                                        },
                                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                        {
                                            ServerAuth = false,
                                            ClientAuth = false,
                                            CodeSigning = false,
                                            EmailProtection = true,
                                            TimeStamping = true,
                                            OcspSigning = false,
                                        },
                                        UnknownExtendedKeyUsages =
                                        {
                                            new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                        },
                                    },
                                    CaOptions = new ReusableConfigValues.Types.CaOptions
                                    {
                                        IsCa = false,
                                        MaxIssuerPathLength = 1013168332,
                                    },
                                    PolicyIds =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                    AiaOcspServers =
                                    {
                                        "aia_ocsp_servers8af8fe42",
                                    },
                                    AdditionalExtensions =
                                    {
                                        new X509Extension
                                        {
                                            ObjectId = new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                            Critical = false,
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    OverwriteConfigValues = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    AllowedLocationsAndOrganizations =
                    {
                        new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                    },
                    AllowedCommonNames =
                    {
                        "allowed_common_names20a07597",
                    },
                    AllowedSans = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedSubjectAltNames
                    {
                        AllowedDnsNames =
                        {
                            "allowed_dns_namesbd1651bf",
                        },
                        AllowedUris =
                        {
                            "allowed_uris55af3417",
                        },
                        AllowedEmailAddresses =
                        {
                            "allowed_email_addresses87a48b52",
                        },
                        AllowedIps =
                        {
                            "allowed_ips1f40f00a",
                        },
                        AllowGlobbingDnsWildcards = false,
                        AllowCustomSans = false,
                    },
                    MaximumLifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AllowedIssuanceModes = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.IssuanceModes
                    {
                        AllowCsrBasedIssuance = false,
                        AllowConfigBasedIssuance = false,
                    },
                },
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions
                {
                    IncludeCaCertUrl = false,
                    IncludeCrlAccessUrl = false,
                },
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls
                {
                    CaCertificateAccessUrl = "ca_certificate_access_url230b73f2",
                    CrlAccessUrl = "crl_access_url9b3819c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig
                {
                    CertificateAuthority = "certificate_authority8dcf4a45",
                    PemIssuerChain = new SubordinateConfig.Types.SubordinateConfigChain
                    {
                        PemCertificates =
                        {
                            "pem_certificatesca244b45",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority response = client.GetCertificateAuthority(request.CertificateAuthorityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig
                {
                    SubjectConfig = new CertificateConfig.Types.SubjectConfig
                    {
                        Subject = new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                        CommonName = "common_name73a7a6f0",
                        SubjectAltName = new SubjectAltNames
                        {
                            DnsNames =
                            {
                                "dns_namesf5a1fc4c",
                            },
                            Uris = { "uris9aee097b", },
                            EmailAddresses =
                            {
                                "email_addressese25c4981",
                            },
                            IpAddresses =
                            {
                                "ip_addresses8ee2821f",
                            },
                            CustomSans =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    ReusableConfig = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    PublicKey = new PublicKey
                    {
                        Type = PublicKey.Types.KeyType.Unspecified,
                        Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                    },
                },
                Lifetime = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec
                {
                    CloudKmsKeyVersion = "cloud_kms_key_versiona51c7572",
                    Algorithm = CertificateAuthority.Types.SignHashAlgorithm.EcP256Sha256,
                },
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy
                {
                    AllowedConfigList = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedConfigList
                    {
                        AllowedConfigValues =
                        {
                            new ReusableConfigWrapper
                            {
                                ReusableConfig = "reusable_configae98ae10",
                                ReusableConfigValues = new ReusableConfigValues
                                {
                                    KeyUsage = new KeyUsage
                                    {
                                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                        {
                                            DigitalSignature = false,
                                            ContentCommitment = false,
                                            KeyEncipherment = true,
                                            DataEncipherment = false,
                                            KeyAgreement = true,
                                            CertSign = false,
                                            CrlSign = false,
                                            EncipherOnly = false,
                                            DecipherOnly = false,
                                        },
                                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                        {
                                            ServerAuth = false,
                                            ClientAuth = false,
                                            CodeSigning = false,
                                            EmailProtection = true,
                                            TimeStamping = true,
                                            OcspSigning = false,
                                        },
                                        UnknownExtendedKeyUsages =
                                        {
                                            new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                        },
                                    },
                                    CaOptions = new ReusableConfigValues.Types.CaOptions
                                    {
                                        IsCa = false,
                                        MaxIssuerPathLength = 1013168332,
                                    },
                                    PolicyIds =
                                    {
                                        new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                    },
                                    AiaOcspServers =
                                    {
                                        "aia_ocsp_servers8af8fe42",
                                    },
                                    AdditionalExtensions =
                                    {
                                        new X509Extension
                                        {
                                            ObjectId = new ObjectId
                                            {
                                                ObjectIdPath = { -506236152, },
                                            },
                                            Critical = false,
                                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                        },
                                    },
                                },
                            },
                        },
                    },
                    OverwriteConfigValues = new ReusableConfigWrapper
                    {
                        ReusableConfig = "reusable_configae98ae10",
                        ReusableConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    AllowedLocationsAndOrganizations =
                    {
                        new Subject
                        {
                            CountryCode = "country_code8debec55",
                            Organization = "organization8c94c1b4",
                            OrganizationalUnit = "organizational_unitb35babd4",
                            Locality = "locality2082e309",
                            Province = "province39d6aa53",
                            StreetAddress = "street_address4a56078b",
                            PostalCode = "postal_code51d301e6",
                        },
                    },
                    AllowedCommonNames =
                    {
                        "allowed_common_names20a07597",
                    },
                    AllowedSans = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.AllowedSubjectAltNames
                    {
                        AllowedDnsNames =
                        {
                            "allowed_dns_namesbd1651bf",
                        },
                        AllowedUris =
                        {
                            "allowed_uris55af3417",
                        },
                        AllowedEmailAddresses =
                        {
                            "allowed_email_addresses87a48b52",
                        },
                        AllowedIps =
                        {
                            "allowed_ips1f40f00a",
                        },
                        AllowGlobbingDnsWildcards = false,
                        AllowCustomSans = false,
                    },
                    MaximumLifetime = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AllowedIssuanceModes = new CertificateAuthority.Types.CertificateAuthorityPolicy.Types.IssuanceModes
                    {
                        AllowCsrBasedIssuance = false,
                        AllowConfigBasedIssuance = false,
                    },
                },
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions
                {
                    IncludeCaCertUrl = false,
                    IncludeCrlAccessUrl = false,
                },
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription
                    {
                        SubjectDescription = new CertificateDescription.Types.SubjectDescription
                        {
                            Subject = new Subject
                            {
                                CountryCode = "country_code8debec55",
                                Organization = "organization8c94c1b4",
                                OrganizationalUnit = "organizational_unitb35babd4",
                                Locality = "locality2082e309",
                                Province = "province39d6aa53",
                                StreetAddress = "street_address4a56078b",
                                PostalCode = "postal_code51d301e6",
                            },
                            CommonName = "common_name73a7a6f0",
                            SubjectAltName = new SubjectAltNames
                            {
                                DnsNames =
                                {
                                    "dns_namesf5a1fc4c",
                                },
                                Uris = { "uris9aee097b", },
                                EmailAddresses =
                                {
                                    "email_addressese25c4981",
                                },
                                IpAddresses =
                                {
                                    "ip_addresses8ee2821f",
                                },
                                CustomSans =
                                {
                                    new X509Extension
                                    {
                                        ObjectId = new ObjectId
                                        {
                                            ObjectIdPath = { -506236152, },
                                        },
                                        Critical = false,
                                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                    },
                                },
                            },
                            HexSerialNumber = "hex_serial_number8e6f08bd",
                            Lifetime = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotBeforeTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            NotAfterTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                        ConfigValues = new ReusableConfigValues
                        {
                            KeyUsage = new KeyUsage
                            {
                                BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                                {
                                    DigitalSignature = false,
                                    ContentCommitment = false,
                                    KeyEncipherment = true,
                                    DataEncipherment = false,
                                    KeyAgreement = true,
                                    CertSign = false,
                                    CrlSign = false,
                                    EncipherOnly = false,
                                    DecipherOnly = false,
                                },
                                ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                                {
                                    ServerAuth = false,
                                    ClientAuth = false,
                                    CodeSigning = false,
                                    EmailProtection = true,
                                    TimeStamping = true,
                                    OcspSigning = false,
                                },
                                UnknownExtendedKeyUsages =
                                {
                                    new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                },
                            },
                            CaOptions = new ReusableConfigValues.Types.CaOptions
                            {
                                IsCa = false,
                                MaxIssuerPathLength = 1013168332,
                            },
                            PolicyIds =
                            {
                                new ObjectId
                                {
                                    ObjectIdPath = { -506236152, },
                                },
                            },
                            AiaOcspServers =
                            {
                                "aia_ocsp_servers8af8fe42",
                            },
                            AdditionalExtensions =
                            {
                                new X509Extension
                                {
                                    ObjectId = new ObjectId
                                    {
                                        ObjectIdPath = { -506236152, },
                                    },
                                    Critical = false,
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                        PublicKey = new PublicKey
                        {
                            Type = PublicKey.Types.KeyType.Unspecified,
                            Key = proto::ByteString.CopyFromUtf8("key8a0b6e3c"),
                        },
                        SubjectKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        AuthorityKeyId = new CertificateDescription.Types.KeyId
                        {
                            KeyId_ = "key_id2691f630",
                        },
                        CrlDistributionPoints =
                        {
                            "crl_distribution_pointsb1c6ae8c",
                        },
                        AiaIssuingCertificateUrls =
                        {
                            "aia_issuing_certificate_urlsc1dac48a",
                        },
                        CertFingerprint = new CertificateDescription.Types.CertificateFingerprint
                        {
                            Sha256Hash = "sha256_hashbc0df779",
                        },
                    },
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls
                {
                    CaCertificateAccessUrl = "ca_certificate_access_url230b73f2",
                    CrlAccessUrl = "crl_access_url9b3819c5",
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DeleteTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig
                {
                    CertificateAuthority = "certificate_authority8dcf4a45",
                    PemIssuerChain = new SubordinateConfig.Types.SubordinateConfigChain
                    {
                        PemCertificates =
                        {
                            "pem_certificatesca244b45",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request.CertificateAuthorityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request.CertificateAuthorityName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationListRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate
                    {
                        Certificate = "certificateef0cd3e0",
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        RevocationReason = RevocationReason.Unspecified,
                    },
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate
                    {
                        Certificate = "certificateef0cd3e0",
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        RevocationReason = RevocationReason.Unspecified,
                    },
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationList()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate
                    {
                        Certificate = "certificateef0cd3e0",
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        RevocationReason = RevocationReason.Unspecified,
                    },
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate
                    {
                        Certificate = "certificateef0cd3e0",
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        RevocationReason = RevocationReason.Unspecified,
                    },
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationListResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate
                    {
                        Certificate = "certificateef0cd3e0",
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        RevocationReason = RevocationReason.Unspecified,
                    },
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request.CertificateRevocationListName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate
                    {
                        Certificate = "certificateef0cd3e0",
                        HexSerialNumber = "hex_serial_number8e6f08bd",
                        RevocationReason = RevocationReason.Unspecified,
                    },
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request.CertificateRevocationListName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request.CertificateRevocationListName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReusableConfigRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues
                {
                    KeyUsage = new KeyUsage
                    {
                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                        {
                            DigitalSignature = false,
                            ContentCommitment = false,
                            KeyEncipherment = true,
                            DataEncipherment = false,
                            KeyAgreement = true,
                            CertSign = false,
                            CrlSign = false,
                            EncipherOnly = false,
                            DecipherOnly = false,
                        },
                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                        {
                            ServerAuth = false,
                            ClientAuth = false,
                            CodeSigning = false,
                            EmailProtection = true,
                            TimeStamping = true,
                            OcspSigning = false,
                        },
                        UnknownExtendedKeyUsages =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                    },
                    CaOptions = new ReusableConfigValues.Types.CaOptions
                    {
                        IsCa = false,
                        MaxIssuerPathLength = 1013168332,
                    },
                    PolicyIds =
                    {
                        new ObjectId
                        {
                            ObjectIdPath = { -506236152, },
                        },
                    },
                    AiaOcspServers =
                    {
                        "aia_ocsp_servers8af8fe42",
                    },
                    AdditionalExtensions =
                    {
                        new X509Extension
                        {
                            ObjectId = new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                            Critical = false,
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig response = client.GetReusableConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReusableConfigRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues
                {
                    KeyUsage = new KeyUsage
                    {
                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                        {
                            DigitalSignature = false,
                            ContentCommitment = false,
                            KeyEncipherment = true,
                            DataEncipherment = false,
                            KeyAgreement = true,
                            CertSign = false,
                            CrlSign = false,
                            EncipherOnly = false,
                            DecipherOnly = false,
                        },
                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                        {
                            ServerAuth = false,
                            ClientAuth = false,
                            CodeSigning = false,
                            EmailProtection = true,
                            TimeStamping = true,
                            OcspSigning = false,
                        },
                        UnknownExtendedKeyUsages =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                    },
                    CaOptions = new ReusableConfigValues.Types.CaOptions
                    {
                        IsCa = false,
                        MaxIssuerPathLength = 1013168332,
                    },
                    PolicyIds =
                    {
                        new ObjectId
                        {
                            ObjectIdPath = { -506236152, },
                        },
                    },
                    AiaOcspServers =
                    {
                        "aia_ocsp_servers8af8fe42",
                    },
                    AdditionalExtensions =
                    {
                        new X509Extension
                        {
                            ObjectId = new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                            Critical = false,
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReusableConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig responseCallSettings = await client.GetReusableConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReusableConfig responseCancellationToken = await client.GetReusableConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReusableConfig()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues
                {
                    KeyUsage = new KeyUsage
                    {
                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                        {
                            DigitalSignature = false,
                            ContentCommitment = false,
                            KeyEncipherment = true,
                            DataEncipherment = false,
                            KeyAgreement = true,
                            CertSign = false,
                            CrlSign = false,
                            EncipherOnly = false,
                            DecipherOnly = false,
                        },
                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                        {
                            ServerAuth = false,
                            ClientAuth = false,
                            CodeSigning = false,
                            EmailProtection = true,
                            TimeStamping = true,
                            OcspSigning = false,
                        },
                        UnknownExtendedKeyUsages =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                    },
                    CaOptions = new ReusableConfigValues.Types.CaOptions
                    {
                        IsCa = false,
                        MaxIssuerPathLength = 1013168332,
                    },
                    PolicyIds =
                    {
                        new ObjectId
                        {
                            ObjectIdPath = { -506236152, },
                        },
                    },
                    AiaOcspServers =
                    {
                        "aia_ocsp_servers8af8fe42",
                    },
                    AdditionalExtensions =
                    {
                        new X509Extension
                        {
                            ObjectId = new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                            Critical = false,
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig response = client.GetReusableConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReusableConfigAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues
                {
                    KeyUsage = new KeyUsage
                    {
                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                        {
                            DigitalSignature = false,
                            ContentCommitment = false,
                            KeyEncipherment = true,
                            DataEncipherment = false,
                            KeyAgreement = true,
                            CertSign = false,
                            CrlSign = false,
                            EncipherOnly = false,
                            DecipherOnly = false,
                        },
                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                        {
                            ServerAuth = false,
                            ClientAuth = false,
                            CodeSigning = false,
                            EmailProtection = true,
                            TimeStamping = true,
                            OcspSigning = false,
                        },
                        UnknownExtendedKeyUsages =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                    },
                    CaOptions = new ReusableConfigValues.Types.CaOptions
                    {
                        IsCa = false,
                        MaxIssuerPathLength = 1013168332,
                    },
                    PolicyIds =
                    {
                        new ObjectId
                        {
                            ObjectIdPath = { -506236152, },
                        },
                    },
                    AiaOcspServers =
                    {
                        "aia_ocsp_servers8af8fe42",
                    },
                    AdditionalExtensions =
                    {
                        new X509Extension
                        {
                            ObjectId = new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                            Critical = false,
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReusableConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig responseCallSettings = await client.GetReusableConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReusableConfig responseCancellationToken = await client.GetReusableConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReusableConfigResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues
                {
                    KeyUsage = new KeyUsage
                    {
                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                        {
                            DigitalSignature = false,
                            ContentCommitment = false,
                            KeyEncipherment = true,
                            DataEncipherment = false,
                            KeyAgreement = true,
                            CertSign = false,
                            CrlSign = false,
                            EncipherOnly = false,
                            DecipherOnly = false,
                        },
                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                        {
                            ServerAuth = false,
                            ClientAuth = false,
                            CodeSigning = false,
                            EmailProtection = true,
                            TimeStamping = true,
                            OcspSigning = false,
                        },
                        UnknownExtendedKeyUsages =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                    },
                    CaOptions = new ReusableConfigValues.Types.CaOptions
                    {
                        IsCa = false,
                        MaxIssuerPathLength = 1013168332,
                    },
                    PolicyIds =
                    {
                        new ObjectId
                        {
                            ObjectIdPath = { -506236152, },
                        },
                    },
                    AiaOcspServers =
                    {
                        "aia_ocsp_servers8af8fe42",
                    },
                    AdditionalExtensions =
                    {
                        new X509Extension
                        {
                            ObjectId = new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                            Critical = false,
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig response = client.GetReusableConfig(request.ReusableConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReusableConfigResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues
                {
                    KeyUsage = new KeyUsage
                    {
                        BaseKeyUsage = new KeyUsage.Types.KeyUsageOptions
                        {
                            DigitalSignature = false,
                            ContentCommitment = false,
                            KeyEncipherment = true,
                            DataEncipherment = false,
                            KeyAgreement = true,
                            CertSign = false,
                            CrlSign = false,
                            EncipherOnly = false,
                            DecipherOnly = false,
                        },
                        ExtendedKeyUsage = new KeyUsage.Types.ExtendedKeyUsageOptions
                        {
                            ServerAuth = false,
                            ClientAuth = false,
                            CodeSigning = false,
                            EmailProtection = true,
                            TimeStamping = true,
                            OcspSigning = false,
                        },
                        UnknownExtendedKeyUsages =
                        {
                            new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                        },
                    },
                    CaOptions = new ReusableConfigValues.Types.CaOptions
                    {
                        IsCa = false,
                        MaxIssuerPathLength = 1013168332,
                    },
                    PolicyIds =
                    {
                        new ObjectId
                        {
                            ObjectIdPath = { -506236152, },
                        },
                    },
                    AiaOcspServers =
                    {
                        "aia_ocsp_servers8af8fe42",
                    },
                    AdditionalExtensions =
                    {
                        new X509Extension
                        {
                            ObjectId = new ObjectId
                            {
                                ObjectIdPath = { -506236152, },
                            },
                            Critical = false,
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReusableConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig responseCallSettings = await client.GetReusableConfigAsync(request.ReusableConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReusableConfig responseCancellationToken = await client.GetReusableConfigAsync(request.ReusableConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
