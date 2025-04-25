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

using CommandLine;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Google.Cloud.Tools.DocUploader;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using SharpCompress.Archives;
using SharpCompress.Archives.Tar;
using SharpCompress.Common;
using SharpCompress.Writers.Tar;

Parser.Default.ParseArguments<CreateMetadataOptions, UploadFileOptions>(args)
    .WithParsed<CreateMetadataOptions>(options => CreateMetadata(options))
    .WithParsed<UploadFileOptions>(options => CompressAndUploadFile(options));

// Creates the Metadata object based on the specified options and then store at options.Destination.
void CreateMetadata(CreateMetadataOptions options)
{
    var metadata = new Metadata
    {
        UpdateTime = Timestamp.FromDateTimeOffset(DateTimeOffset.UtcNow),
        Name = options.PackageName,
        Version = options.Version,
        Language = options.Language,
        DistributionName = options.DistributionName,
        ProductPage = options.ProductPage,
        GithubRepository = options.GitHubRepo,
        IssueTracker = options.IssueTracker,
        Stem = options.Stem,
        Xrefs = { options.Xrefs },
        XrefServices = { options.XrefServices },
    };

    var formatter = new JsonFormatter(JsonFormatter.Settings.Default.WithIndentation());
    File.WriteAllText(options.Destination, formatter.Format(metadata));
}

// Uploads the zip file to the specified storage bucket.
void CompressAndUploadFile(UploadFileOptions options)
{
    var sourceStream = CompressDirectory(options.DocumentationPath);
    UploadFile(sourceStream, GetFilenameFromMetadata(), options.StagingBucket, options.Credentials);

    string GetFilenameFromMetadata()
    {
        string metadataFilePath = options.MetadataFile ?? Path.Combine(options.DocumentationPath, "docs.metadata.json");
        var metadata = GetMetadataFromJsonFile(metadataFilePath);
        string destinationFileName = $"{metadata.Language}-{metadata.Name}-{metadata.Version}.tar.gz";
        destinationFileName = string.IsNullOrEmpty(options.DestinationPrefix) ? destinationFileName : options.DestinationPrefix + "-" + destinationFileName;
        return destinationFileName;
    }
}

/// <summary>
/// Creates an instance of <see cref="Metadata"/> from json file.
/// </summary>
Metadata GetMetadataFromJsonFile(string metadataFilePath)
{
    if (!File.Exists(metadataFilePath))
    {
        throw new Exception($"Unable to load metadata file '{metadataFilePath}`. Metadata is required for upload; this can be generated using the create-metadata option.");
    }

    var metadataText = File.ReadAllText(metadataFilePath);
    var parser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
    var metadata = parser.Parse<Metadata>(metadataText);
    return metadata;
}

/// <summary>
/// Uploads the given memory steam object to the Google Cloud Storage.
/// </summary>
void UploadFile(MemoryStream memoryStream, string destination, string bucketName, string credentialsPath)
{
    // Create a new Storage client.
    StorageClient client = string.IsNullOrWhiteSpace(credentialsPath)
        ? StorageClient.Create()
        : StorageClient.Create(GoogleCredential.FromFile(credentialsPath));
    client.UploadObject(bucketName, destination, null, memoryStream);
}

/// <summary>
/// Compress the given directory into tar.gz file(in- memory).
/// </summary>
MemoryStream CompressDirectory(string directory)
{
    if (Directory.EnumerateFiles(directory).Count() == 0)
    {
        throw new InvalidOperationException($"The documentation path `{directory}` is empty");
    }

    using var archive = TarArchive.Create();
    archive.AddAllFromDirectory(directory);
    var writerOptions = new TarWriterOptions(CompressionType.GZip, finalizeArchiveOnClose: true);
    var memoryStream = new MemoryStream();
    archive.SaveTo(memoryStream, writerOptions);
    memoryStream.Position = 0;
    return memoryStream;
}
