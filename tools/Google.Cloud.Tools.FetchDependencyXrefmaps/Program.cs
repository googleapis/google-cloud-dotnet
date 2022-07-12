// Copyright 2022 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Tool to fetch the external dependencies we need as xrefmap.yml files.
// The files are in GCS, but there are multiple versions of them, so
// we need to make sure we get the latest.

using Google.Cloud.Storage.V1;
using Google.Cloud.Tools.Common;

var client = StorageClient.Create();
var root = DirectoryLayout.DetermineRootDirectory();

string[] dependencies =
{
    "Grpc.Core",
    "Google.Apis",
    "Google.Api.CommonProtos",
    "Google.Api.Gax",
    "Google.Protobuf"
};

const string bucket = "docs-staging-v2";
const string suffix = ".tar.gz.yml";

foreach (var dependency in dependencies)
{
    string prefix = $"xrefs/dotnet-{dependency}-";
    var list = client.ListObjects(bucket, prefix);
    var latestVersion = list.Select(item => item.Name[prefix.Length..^suffix.Length]).MaxBy(StructuredVersion.FromString);
    string name = $"{prefix}{latestVersion}{suffix}";
    Console.WriteLine($"Downloading {dependency} version {latestVersion}");
    using var output = File.Create(Path.Combine(root, "docs", "dependencies", $"{dependency}.xrefmap.yml"));
    client.DownloadObject(bucket, name, output);
}
