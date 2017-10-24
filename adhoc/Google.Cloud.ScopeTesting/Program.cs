// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Bigtable.Admin.V2;
using Google.Cloud.Bigtable.V2;
using Google.Cloud.Datastore.V1;
using Google.Cloud.Debugger.V2;
using Google.Cloud.Dlp.V2Beta1;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Cloud.Language.V1;
using Google.Cloud.Logging.V2;
using Google.Cloud.Monitoring.V3;
using Google.Cloud.PubSub.V1;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Admin.Instance.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Speech.V1;
using Google.Cloud.Trace.V1;
using Google.Cloud.Vision.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.ErrorReporting.V1Beta1.QueryTimeRange.Types;
using static Google.Cloud.Speech.V1.RecognitionConfig.Types;

namespace Google.Cloud.ScopeTesting
{
    /// <summary>
    /// Small test application to run a sample RPC against each gRPC API, three times.
    /// The first time, we use the default FooClient.Create call with null arguments.
    /// The second time, we use manually-loaded credentials, with no scopes.
    /// The third time, we use manually-loaded credentials, with the scopes advertised in DefaultScopes.
    /// </summary>
    static class Program
    {
        private static void Add<T>(this List<Api> apis, Action<T> test) => apis.Add(Api.Create(test));

        static void Main(string[] args)
        {
            var authFile = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
            if (string.IsNullOrEmpty(authFile))
            {
                Console.WriteLine("Please set the GOOGLE_APPLICATION_CREDENTIALS environment variable and rerun");
                return;
            }
            var projectId = Environment.GetEnvironmentVariable("TEST_PROJECT");
            if (string.IsNullOrEmpty(projectId))
            {
                Console.WriteLine("Please set the TEST_PROJECT environment variable and rerun");
                return;
            }

            var apis = new List<Api>
            {
                (BigtableInstanceAdminClient client) => client.ListInstances(new Bigtable.Admin.V2.ProjectName(projectId)),
                (BigtableClient client) => client.ReadRows(new ReadRowsRequest { TableName = "table" }),
                (DatastoreClient client) => client.AllocateIds(projectId, new[] { new Datastore.V1.Key() }),
                (Debugger2Client client) => client.ListDebuggees(projectId, "0.0"),
                (DlpServiceClient client) => client.ListRootCategories("en"),
                (ErrorStatsServiceClient client) => client.ListGroupStats(new ErrorReporting.V1Beta1.ProjectName(projectId),
                    new QueryTimeRange { Period = Period._30Days }).Count(),
                (LanguageServiceClient client) => client.AnalyzeSentiment(Document.FromPlainText("This is good")),
                (Logging​Service​V2Client client) => client.ListLogs(ParentNameOneof.From(new Logging.V2.ProjectName(projectId))).Count(),
                (MetricServiceClient client) => client.ListMetricDescriptors(new Monitoring.V3.ProjectName(projectId)).Count(),
                (PublisherClient client) => client.ListTopics(new PubSub.V1.ProjectName(projectId)),
                (SubscriberClient client) => client.ListSubscriptions(new PubSub.V1.ProjectName(projectId)),
                (DatabaseAdminClient client) => client.ListDatabases(new Spanner.Admin.Database.V1.InstanceName(projectId, "instance")).Count(),
                (InstanceAdminClient client) => client.ListInstances(new Spanner.Admin.Instance.V1.ProjectName(projectId)).Count(),
                (SpannerClient client) => client.GetSession(new SessionName(projectId, "instance", "database", "session")),
                (SpeechClient client) => client.Recognize(
                    new RecognitionConfig { Encoding = AudioEncoding.Linear16, SampleRateHertz = 16000, LanguageCode = LanguageCodes.English.UnitedStates },
                    RecognitionAudio.FromStorageUri("gs://nodatime/releases/NodaTime-1.0.0.zip")),
                (TraceServiceClient client) => client.ListTraces(projectId).Count(),
                (VideoIntelligence.V1Beta1.VideoIntelligenceServiceClient client) => client.AnnotateVideo(
                    new VideoIntelligence.V1Beta1.AnnotateVideoRequest { InputUri = "gs://cloudmleap/video/next/gbikes_dinosaur.mp4", Features = { VideoIntelligence.V1Beta1.Feature.LabelDetection } }),
                (VideoIntelligence.V1Beta2.VideoIntelligenceServiceClient client) => client.AnnotateVideo(
                    new VideoIntelligence.V1Beta2.AnnotateVideoRequest { InputUri = "gs://cloudmleap/video/next/gbikes_dinosaur.mp4", Features = { VideoIntelligence.V1Beta2.Feature.LabelDetection } }),
                (ImageAnnotatorClient client) => client.DetectText(Image.FromUri("https://cloud.google.com/images/devtools-icon-64x64.png")).Count()
            };

            foreach (var api in apis)
            {
                Console.WriteLine(api);
                Console.WriteLine($"Default: {api.TestDefaultCreate()}");
                Console.WriteLine($"Loaded credentials, no scopes: {api.TestWithCredentials(authFile)}");
                Console.WriteLine($"Loaded credentials, with scopes: {api.TestWithCredentialsAndScopes(authFile)}");
                Console.WriteLine();
            }
        }
    }
}
