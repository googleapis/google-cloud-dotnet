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

using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.DocfxMetadata
{
    public class TocEntry
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public List<TocEntry> Items { get; set; }

        public static string CreateToc(IEnumerable<TocEntry> entries)
        {
            var serializer = new SerializerBuilder()
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var writer = new StringWriter();
            serializer.Serialize(writer, entries);
            return "### YamlMime:TableOfContent" + Environment.NewLine + writer.ToString();
        }
    }
}
