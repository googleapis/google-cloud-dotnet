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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Channel.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=operations/**}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("Ih8vdjEve25hbWU9b3BlcmF0aW9ucy8qKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=operations/**}" }
                    proto::ByteString.FromBase64("KhgvdjEve25hbWU9b3BlcmF0aW9ucy8qKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=operations/**}" }
                    proto::ByteString.FromBase64("EhgvdjEve25hbWU9b3BlcmF0aW9ucy8qKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=operations}" }
                    proto::ByteString.FromBase64("EhUvdjEve25hbWU9b3BlcmF0aW9uc30=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return BillingAccountsReflection.Descriptor;
            yield return ChannelPartnerLinksReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return CustomersReflection.Descriptor;
            yield return EntitlementChangesReflection.Descriptor;
            yield return EntitlementsReflection.Descriptor;
            yield return OffersReflection.Descriptor;
            yield return OperationsReflection.Descriptor;
            yield return ProductsReflection.Descriptor;
            yield return ReportsServiceReflection.Descriptor;
            yield return RepricingReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return SubscriberEventReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
