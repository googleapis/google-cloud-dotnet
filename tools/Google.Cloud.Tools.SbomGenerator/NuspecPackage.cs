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

using System.Xml.Linq;

namespace Google.Cloud.Tools.SbomGenerator;

/// <summary>
/// Metadata collected from a nupkg's XML nuspec.
/// </summary>
public class NuspecPackage
{
    public NuspecMetadata Metadata { get; set; }

    public class NuspecMetadata
    {
        internal static NuspecMetadata FromElement(XElement element)
        {
            var ns = element.Name.Namespace;
            return new NuspecMetadata
            {
                Id = (string) element.Element(ns + "id"),
                Version = (string) element.Element(ns + "version"),
                Description = (string) element.Element(ns + "description"),
                ProjectUrl = (string) element.Element(ns + "projectUrl"),
                License = (string) element.Element(ns + "license")
            };
        }

        public string Id { get; set; }
        public string Version { get; set; }
        public string NameWithVersion => $"{Id}@{Version}";
        public string Description { get; set; }
        public string ProjectUrl { get; set; }
        public string License { get; set; }
    }

    public static NuspecPackage FromDocument(XDocument doc)
    {
        var root = doc.Root;
        if (root.Name.LocalName != "package")
        {
            throw new ArgumentException("Document root must be a package element");
        }
        var ns = root.Name.Namespace;
        var metadataElement = root.Element(ns + "metadata");
        if (metadataElement is null)
        {
            throw new ArgumentException("No metadata element");
        }
        return new NuspecPackage { Metadata = NuspecMetadata.FromElement(metadataElement) };
    }
}
