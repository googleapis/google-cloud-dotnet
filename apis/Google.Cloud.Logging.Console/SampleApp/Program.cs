// Copyright 2022 Google LLC
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


// Import the namespace required for the AddGoogleCloudConsole extension method
using Google.Cloud.Logging.Console;

var builder = WebApplication.CreateBuilder(args);

// Add the GoogleCloudConsoleFormatter
builder.Logging.AddGoogleCloudConsole(options => options.IncludeScopes = true);

var app = builder.Build();

// Configure various sample URLs
app.MapGet("/simple", (ILogger<Program> logger) =>
{
    logger.LogInformation("This is a simple message");
    return "I've logged a simple message";
});

app.MapGet("/complex", (ILogger<Program> logger) =>
{
    logger.LogInformation("This is a message with a parameter: {p}", "Parameter value");
    return "I've logged a message with a parameter";
});


app.MapGet("/error", () =>
{
    // This will automatically get logged.
    throw new Exception("Bang!");
});

app.MapGet("/scopes", (ILogger<Program> logger) =>
{
    using var scope1 = logger.BeginScope("Outer scope");
    using var scope2 = logger.BeginScope("Inner scope");
    logger.LogInformation("This is a message in two scopes");
    return "I've logged a message in two scopes";
});

// Use the PORT environment variable provided by Cloud Run
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
app.Run(url);
