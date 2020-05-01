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

using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// The content of an individual service config file, as stored in YAML.
    /// </summary>
    public class ServiceConfig
    {
        public string File { get; set; }
        public string Type { get; set; }
        public int ConfigVersion { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public ServiceConfigDocumentation Documentation { get; set; }
        public List<ServiceConfigApi> Apis { get; set; }

        internal static ServiceConfig TryLoadFile(string file)
        {
            var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().WithNamingConvention(UnderscoredNamingConvention.Instance).Build();
            using (var reader = System.IO.File.OpenText(file))
            {
                var config = deserializer.Deserialize<ServiceConfig>(reader);
                config.File = file;
                return config.Type == "google.api.Service" ? config : null;
            }
        }
    }

    public class ServiceConfigApi
    {
        public string Name { get; set; }
    }

    public class ServiceConfigDocumentation
    {
        public string Summary { get; set; }
        public string Overview { get; set; }
    }
}
