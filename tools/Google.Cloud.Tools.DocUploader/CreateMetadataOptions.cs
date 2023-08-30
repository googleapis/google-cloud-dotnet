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

// The nullability of the properties reflects whether or not they're
// required/defaulted; we rely on the library to ensure they're actually non-null.
#nullable enable annotations
#nullable disable warnings

using CommandLine;
using Google.Protobuf.WellKnownTypes;

[Verb("create-metadata", HelpText = "create metadata file")]
internal class CreateMetadataOptions
{
    [Option("name", Required = true)]
    public string PackageName { get; set; }

    [Option("version", Required = true)]
    public string Version { get; set; }

    [Option("language", Required = true)]
    public string Language { get; set; }

    [Option("distribution-name", Required = false, Default = "")]
    public string? DistributionName { get; set; }

    [Option("product-page", Required = false, Default = "")]
    public string? ProductPage { get; set; }

    [Option("github-repository", Required = false, Default = "")]
    public string? GitHubRepo { get; set; }

    [Option("issue-tracker", Required = false, Default = "")]
    public string? IssueTracker { get; set; }

    [Option("stem", Required = false, Default = "")]
    public string? Stem { get; set; }

    [Option("serving-path", Required = false, Default = "")]
    public string? ServingPath { get; set; }

    [Option("xrefs", Required = false, Separator = ',')]
    public IList<string>? Xrefs { get; set; }

    [Option("xref-services", Required = false, Separator = ',')]
    public IList<string>? XrefServices { get; set; }

    [Option("destination", Default = "docs.metadata.json")]
    public string Destination { get; set; }
}
