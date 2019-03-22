// Copyright 2019 Google LLC
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

using Google.Cloud.ClientTesting;
using Google.Protobuf;
using System;
using Xunit;
using static Google.Cloud.WebRisk.V1Beta1.SearchHashesResponse.Types;
using static Google.Cloud.WebRisk.V1Beta1.SearchUrisResponse.Types;

namespace Google.Cloud.WebRisk.V1Beta1.Snippets
{
    [SnippetOutputCollector]
    public class WebRiskServiceV1Beta1ClientSnippets
    {
        [Fact]
        public void SearchUri()
        {
            // Sample: SearchUris
            WebRiskServiceV1Beta1Client client = WebRiskServiceV1Beta1Client.Create();
            SearchUrisResponse response = client.SearchUris(
                "http://testsafebrowsing.appspot.com/s/malware.html",
                new[] { ThreatType.Malware, ThreatType.SocialEngineering });
            ThreatUri threat = response.Threat;
            if (threat == null)
            {
                Console.WriteLine("No threat detected");
            }
            else
            {
                Console.WriteLine($"Threat types: {string.Join(", ", threat.ThreatTypes)}");
                Console.WriteLine($"Cache lifetime expiry: {threat.ExpireTime}");
            }
            // End sample
        }

        [Fact]
        public void SearchHashes()
        {
            // Sample: SearchHashes
            WebRiskServiceV1Beta1Client client = WebRiskServiceV1Beta1Client.Create();
            ByteString hashPrefix = ByteString.CopyFrom(new byte[] { 0x5b, 0x0b, 0x89, 0x75 });
            SearchHashesResponse response = client.SearchHashes(
                hashPrefix,
                new[] { ThreatType.Malware, ThreatType.SocialEngineering });

            if (response.NegativeExpireTime != null)
            {
                Console.WriteLine($"Cache expiry for negative response: {response.NegativeExpireTime}");
            }
            foreach (ThreatHash threat in response.Threats)
            {
                string hexHash = BitConverter.ToString(threat.Hash.ToByteArray()).Replace("-", "");
                Console.WriteLine($"Hash {hexHash}");
                Console.WriteLine($"Threat types: {string.Join(", ", threat.ThreatTypes)}");
                Console.WriteLine($"Cache lifetime expiry: {threat.ExpireTime}");
            }
            // End sample
        }
    }
}
