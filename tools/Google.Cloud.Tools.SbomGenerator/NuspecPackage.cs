// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System.Xml.Serialization;

namespace Google.Cloud.Tools.SbomGenerator;

/// <summary>
/// Metadata collected from a nupkg's XML nuspec.
/// </summary>
[XmlRoot("package", Namespace = "http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd")]
public class NuspecPackage
{
    [XmlElement("metadata")]
    public NuspecMetadata Metadata { get; set; }

    public class NuspecMetadata
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlIgnore]
        public string NameWithVersion => $"{Id}@{Version}";

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("projectUrl")]
        public string ProjectUrl { get; set; }

        [XmlElement("license")]
        public string License { get; set; }
    }
}
