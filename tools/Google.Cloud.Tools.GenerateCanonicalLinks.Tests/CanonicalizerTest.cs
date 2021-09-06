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

using Xunit;

namespace Google.Cloud.Tools.GenerateCanonicalLinks.Tests
{
    public class CanonicalizerTest
    {
        [Theory]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.Cloud.CloudBuild.V1.Artifacts.Types.ArtifactObjects.html", "Google.Cloud.CloudBuild.V1/latest/Google.Cloud.CloudBuild.V1.Artifacts.Types.ArtifactObjects")]
        [InlineData("Google.Cloud.CloudBuild.V1", "history.html", "Google.Cloud.CloudBuild.V1/latest/history")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.LongRunning.Operation-2.html", "Google.LongRunning/latest/Google.LongRunning.Operation-2")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.LongRunning.html", "Google.LongRunning/latest/Google.LongRunning")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Grpc.Core.html", "Grpc.Core/latest/Grpc.Core")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.Api.Gax.CloudRunPlatformDetails.html", "Google.Api.Gax/latest/Google.Api.Gax.CloudRunPlatformDetails")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.Api.Gax.Grpc.ApiCall-2.html", "Google.Api.Gax/latest/Google.Api.Gax.Grpc.ApiCall-2")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.Type.CalendarPeriod.html", "Google.Api.CommonProtos/latest/Google.Type.CalendarPeriod")]
        [InlineData("Google.Cloud.CloudBuild.V1", "api/Google.Api.Advice.html", "Google.Api.CommonProtos/latest/Google.Api.Advice")]
        [InlineData("Google.Cloud.Storage.V1", "api/Google.Cloud.Storage.V1.CreateNotificationOptions.html", "Google.Cloud.Storage.V1/latest/Google.Cloud.Storage.V1.CreateNotificationOptions")]
        [InlineData("Google.Apis.Auth", "api/Google.Apis.Auth.OAuth2.GoogleCredential.html", "Google.Apis/latest/Google.Apis.Auth.OAuth2.GoogleCredential")]
        [InlineData("Google.Cloud.Spanner.V1", "api/Google.Protobuf.ByteString.html", "Google.Protobuf/latest/Google.Protobuf.ByteString")]
        [InlineData("Google.Apis.Core", "api/Google.Apis.ISerializer.html", "Google.Apis/latest/Google.Apis.ISerializer")]
        [InlineData("Google.Apis", "api/Google.Apis.ETagAction.html", "Google.Apis/latest/Google.Apis.ETagAction")]
        [InlineData("Google.Apis", "api/Google.Apis.Download.DownloadStatus.html", "Google.Apis/latest/Google.Apis.Download.DownloadStatus")]
        [InlineData("Google.Cloud.Asset.V1", "api/Google.Cloud.Iam.V1.AuditConfigDelta.html", "Google.Cloud.Iam.V1/latest/Google.Cloud.Iam.V1.AuditConfigDelta")]
        [InlineData("Google.Cloud.Logging.V2", "api/Google.Cloud.Logging.Type.HttpRequest.html", "Google.Cloud.Logging.Type/latest/Google.Cloud.Logging.Type.HttpRequest")]
        [InlineData("Google.Cloud.Firestore", "api/Google.Cloud.Firestore.V1.Firestore.html", "Google.Cloud.Firestore.V1/latest/Google.Cloud.Firestore.V1.Firestore")]
        [InlineData("Google.Cloud.Asset.V1", "api/Google.Cloud.OrgPolicy.V1.Policy.html", "Google.Cloud.OrgPolicy.V1/latest/Google.Cloud.OrgPolicy.V1.Policy")]
        [InlineData("Google.Cloud.Asset.V1", "api/Google.Identity.AccessContextManager.Type.DeviceEncryptionStatus.html", "Google.Identity.AccessContextManager.Type/latest/Google.Identity.AccessContextManager.Type.DeviceEncryptionStatus")]
        [InlineData("Google.Cloud.Diagnostics.AspNetCore", "api/Google.Cloud.Diagnostics.Common.ContextTracerManager.html", "Google.Cloud.Diagnostics.Common/latest/Google.Cloud.Diagnostics.Common.ContextTracerManager")]
        [InlineData("Google.Cloud.Diagnostics.AspNetCore3", "api/Google.Cloud.Diagnostics.Common.ContextTracerManager.html", "Google.Cloud.Diagnostics.Common/latest/Google.Cloud.Diagnostics.Common.ContextTracerManager")]
        [InlineData("Google.Cloud.OsLogin.V1", "api/Google.Cloud.OsLogin.Common.OperatingSystemType.html", "Google.Cloud.OsLogin.Common/latest/Google.Cloud.OsLogin.Common.OperatingSystemType")]
        [InlineData("Google.Cloud.Debugger.V2", "api/Google.Cloud.DevTools.Source.V1.AliasContext.html", "Google.Cloud.DevTools.Common/latest/Google.Cloud.DevTools.Source.V1.AliasContext")]
        [InlineData("Google.Cloud.Filestore.V1", "api/Google.Cloud.Common.html", "Google.Cloud.Common/latest/Google.Cloud.Common")]
        [InlineData("Google.Cloud.Filestore.V1", "api/Google.Cloud.Common.OperationMetadata.html", "Google.Cloud.Common/latest/Google.Cloud.Common.OperationMetadata")]
        [InlineData("Google.LongRunning", "api/Google.Cloud.ExtendedOperationsExtensions.html", "Google.LongRunning/latest/Google.Cloud.ExtendedOperationsExtensions")]
        [InlineData("Google.LongRunning", "api/Google.Cloud.html", "Google.LongRunning/latest/Google.Cloud")]
        public void GetUrl(string package, string page, string expectedSuffix)
        {
            var actualUrl = Canonicalizer.GetUrl(package, page);
            Assert.NotNull(actualUrl);
            Assert.StartsWith(Canonicalizer.CloudSitePrefix, actualUrl);
            var actualSuffix = actualUrl[Canonicalizer.CloudSitePrefix.Length..];
            Assert.Equal(expectedSuffix, actualSuffix);
        }

        [Theory]
        [InlineData("Google.Area120.Tables.V1Alpha1", "api/Google.Area120.Tables.V1Alpha1.BatchCreateRowsRequest.html")]
        [InlineData("Google.Analytics.Data.V1Alpha", "api/Google.Analytics.Data.V1Alpha.AlphaAnalyticsData.html")]
        [InlineData("Google.Cloud.Debugger.V2", "api/toc.html")]
        [InlineData("Google.Apis.Storage.v1", "api/Google.Apis.Storage.v1.html")]
        [InlineData("Google.Apis.AdSense.v1_4", "api/Google.Apis.AdSense.v1_4.AccountsResource.html")]
        public void GetUrl_NotOnDevsite(string package, string page) =>
            Assert.Null(Canonicalizer.GetUrl(package, page));
    }
}
