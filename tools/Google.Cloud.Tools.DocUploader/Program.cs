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
        Version = options.version,
        Language = options.Language,
        DistributionName = options.DistributionName,
        ProductPage = options.ProductPage,
        GithubRepository = options.GitHubRepo,
        IssueTracker = options.IssueTracker,
        Stem = options.Stem,
    };
    metadata.Xrefs.Add(options.Xrefs);
    metadata.XrefServices.Add(options.XrefServices);

    File.WriteAllText(options.Destination, metadata.ToString());
}

// Uploads the zip file to the specified storage bucket.
void CompressAndUploadFile(UploadFileOptions options)
{
    string tempFileName = "temp.tar.gz";
    CompressDirectory(options.DocumentationPath, tempFileName);
    UploadFile(tempFileName, GetFilenameFromMetadata(), options.StagingBucket, options.Credentials);

    string GetFilenameFromMetadata()
    {
        string metadataFilePath = string.IsNullOrEmpty(options.MetadataFile) ? Path.Combine(options.DocumentationPath, "docs.metadata.json") : options.MetadataFile;
        var metadata = GetMetadataFromJsonFile(metadataFilePath);
        string destinationFileName = $"{metadata.Language}-{metadata.Name}-{metadata.Version}.tar.gz";
        destinationFileName = string.IsNullOrEmpty(destinationFileName) ? destinationFileName : options.DestinationPrefix + "-" + destinationFileName;
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
        throw new FileNotFoundException("You need metadata to upload the docs.You can generate it with docuploader create-metadata");
    }

    var metadataText = File.ReadAllText(metadataFilePath);
    var parser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
    var metadata = parser.Parse<Metadata>(metadataText);
    return metadata;
}

/// <summary>
/// Uploads the given file to the Google Cloud Storage.
/// </summary>
void UploadFile(string source, string destination, string bucketName, string credentialsPath)
{
    // Create a new Storage client.
    var client = StorageClient.Create(GoogleCredential.FromFile(credentialsPath));
    using var filestream = File.OpenRead(source);
    client.UploadObject(bucketName, destination, null, filestream);
}

/// <summary>
/// Compress the given directory into tar.gz file.
/// </summary>
void CompressDirectory(string directory, string destination)
{
    if (Directory.EnumerateFiles(directory).Count() == 0)
    {
        throw new InvalidOperationException($"The documentation path `{directory}` is empty");
    }

    using var archive = TarArchive.Create();
    archive.AddAllFromDirectory(directory);
    var twopt = new TarWriterOptions(CompressionType.GZip, finalizeArchiveOnClose: true);
    archive.SaveTo(destination, twopt);
}
