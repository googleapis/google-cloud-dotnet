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

[Verb("upload", HelpText = "upload file")]
public class UploadFileOptions
{
    [Option("documentation-path", Required = true)]
    public string DocumentationPath { get; set; }

    [Option("staging-bucket", Default = "docs-resources", HelpText = "The bucket to upload the staged documentation to.")]
    public string StagingBucket { get; set; }

    [Option("credentials", Required = false, HelpText = "Path to the credentials file to use for Google Cloud Storage.")]
    public string Credentials { get; set; }

    [Option("metadata-file", Required = false, HelpText = "Path to the docs.metadata file. The path must be relative to the CWD.")]
    public string? MetadataFile { get; set; }

    [Option("destination-prefix", HelpText = "Prefix to include when uploading tar file. A - will be added after the prefix, if there is one.")]
    public string? DestinationPrefix { get; set; }
}
