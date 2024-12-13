// Copyright 2020 Google LLC
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

using Google.Cloud.Tools.Common;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class DetectNamingAnomaliesCommand : CommandBase
    {
        public DetectNamingAnomaliesCommand() : base("detect-naming-anomalies", "Detects oddities in API naming")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            var rootLayout = RootLayout.ForCurrentDirectory();
            var apiIndex = ApiIndex.V1.Index.LoadFromGoogleApis(rootLayout.Googleapis);
            foreach (var api in apiIndex.Apis)
            {
                ReportAnomalies(api);
            }
            return 0;
        }

        private static void ReportAnomalies(ApiIndex.V1.Api api)
        {
            var titleWords = GetTitleWords(api);

            var csharpNs = api.DeriveCSharpNamespace();

            // First detect the occasional problem of misconfiguration to "V1beta1" or "v1beta1" instead of "V1Beta1".
            if (Regex.IsMatch(csharpNs, @"\.V\d+[a-z][^.]*$") || Regex.IsMatch(csharpNs, @"\.v[^.]*"))
            {
                Console.WriteLine($"{api.Id} has bad version number in C# namespace {csharpNs}");
            }

            // Split the protobuf package into segments and see whether any segment matches multiple words
            // from the title.
            foreach (var segment in api.Id.Split('.'))
            {
                var sequence = FindTitleWordSequence(segment, titleWords);
                if (sequence is null)
                {
                    continue;
                }

                // Use the C# inferred namespace as an indication of whether this has been manually configured.
                // It's entirely possible for it to be *badly* configured, but that's slightly different and would
                // be harder to detect.
                var expectedUnconfiguredSegment = char.ToUpperInvariant(segment[0]) + segment[1..];
                if (csharpNs.Split('.').Contains(expectedUnconfiguredSegment))
                {
                    Console.WriteLine($"{api.Id} may need configuration: C# namespace is {csharpNs}");
                }
            }

            // Known false negatives:
            // - google/devtools/clouddebugger (Stackdriver Debugger API)
            // - google/devtools/cloudtrace (Stackdriver Trace API)
            // - google/cloud/security/privateca (Certificate Authority API)
            // - google/cloud/recommendationengine (Recommendations AI)
            // - google/cloud/managedidentities (Managed Service for Microsoft Active Directory API)
        }

        private static string[] FindTitleWordSequence(string packageSegment, string[] titleWords)
        {
            // Look for any sequence of multiple words which (when combined and lower-cased) matches the segment.
            for (int start = 0; start < titleWords.Length - 1; start++)
            {
                for (int end = start + 2; end <= titleWords.Length; end++)
                {
                    var sequence = titleWords[start..end];
                    string combined = string.Join("", sequence);
                    if (packageSegment == combined.ToLowerInvariant())
                    {
                        return sequence;
                    }
                }
            }
            return null;
        }

        private static string[] GetTitleWords(ApiIndex.V1.Api api)
        {
            string title = api.Title;
            if (title.EndsWith(" API"))
            {
                title = title[..^4];
            }
            // Replace all punctuation etc with spaces (e.g. Pub/Sub => Pub Sub)
            title = Regex.Replace(title, "[^A-Za-z0-9]", " ");
            // TODO: Work out how we want to treat words that include capitals. Examples:
            // - OS
            // - HomeGraph
            // - IoT
            // - BigQuery
            // - IAM
            // - reCAPTCHA
            // - AI

            // For the moment, split BigQuery and HomeGraph in a hard-coded way...
            title = title
                .Replace("BigQuery", "Big Query")
                .Replace("HomeGraph", "Home Graph");
            return title.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
