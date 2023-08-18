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

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.ReleaseProgressReporter;

// Note: CommandLineParser has not been used here for the sake of simplicity.
if (args.Length < 1)
{
    throw new UserErrorException("Please specify the publisher API name `start` or `finish`.");
}

var api = args[0];

string githubToken = Environment.GetEnvironmentVariable("GITHUB_TOKEN") ?? "";
string pr = Environment.GetEnvironmentVariable("AUTORELEASE_PR") ?? "";
string appIdPath = Environment.GetEnvironmentVariable("APP_ID_PATH") ?? "";
string installationIdPath = Environment.GetEnvironmentVariable("INSTALLATION_ID_PATH") ?? "";
string privateKeyPath = Environment.GetEnvironmentVariable("GITHUB_PRIVATE_KEY_PATH") ?? "";

var appId = File.ReadAllText(appIdPath);
var installationId = File.ReadAllText(installationIdPath);

PublishReporter reporter = new PublishReporter(appId, pr, installationId, privateKeyPath, githubToken);

if (api == "start")
{
    await reporter.StartAsync();
}
else if (api == "finish")
{
    bool status = Convert.ToBoolean(args[1]);
    string publishDetails = Environment.GetEnvironmentVariable("PUBLISH_DETAILS") ?? "";
    await reporter.FinishAsync(status, publishDetails);
}
else
{
    throw new UserErrorException("Incorrect API is passed available options are (start, finish)");
}
