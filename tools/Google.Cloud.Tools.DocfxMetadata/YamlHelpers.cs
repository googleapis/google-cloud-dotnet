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

using System.IO;
using YamlDotNet.Serialization;

namespace Google.Cloud.Tools.DocfxMetadata
{
    internal class YamlHelpers
    {
        internal static string LoadYamlAsJson(string file)
        {
            using var reader = File.OpenText(file);
            var deserializer = new Deserializer();
            var yamlObject = deserializer.Deserialize(reader);

            // now convert the object to JSON. Simple!
            var serializer = new SerializerBuilder().JsonCompatible().Build();

            var writer = new StringWriter();
            serializer.Serialize(writer, yamlObject);
            return writer.ToString();
        }
    }
}
