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

using System.Reflection;
using Xunit;

namespace Google.Cloud.Vision.V1.IntegrationTests
{
    /// <summary>
    /// These tests are not Vision specific, they can be done with any of the gRPC clients.
    /// They are here just for convenience.
    /// </summary>
    public class JwtAccessTests
    {
        [Fact]
        public void JwtAccessToken_GrpcClient()
        {
            Image image = LoadResourceImage("vision_eiffel_tower.jpg");
            ImageAnnotatorClientBuilder builder = new ImageAnnotatorClientBuilder
            {
                // Making sure we have no scopes so that a JWT is sent.
                Scopes = new string[0]
            };

            var client = builder.Build();
            var result = client.DetectLandmarks(image);
            Assert.NotEmpty(result);
        }

        private static Image LoadResourceImage(string name)
        {
            var type = typeof(JwtAccessTests);
            using var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream($"{type.Namespace}.{name}");
            return Image.FromStream(stream);
        }
    }
}
