// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Rest;
using Google.Cloud.Language.V1;

Test(new LanguageServiceClientBuilder { UseJwtAccessWithScopes = true });
Test(new LanguageServiceClientBuilder { UseJwtAccessWithScopes = false });
Test(new LanguageServiceClientBuilder { GrpcAdapter = RestGrpcAdapter.Default, UseJwtAccessWithScopes = true });
Test(new LanguageServiceClientBuilder { GrpcAdapter = RestGrpcAdapter.Default, UseJwtAccessWithScopes = false });
Test(new LanguageServiceClientBuilder { GrpcAdapter = GrpcCoreAdapter.Instance, UseJwtAccessWithScopes = true });
Test(new LanguageServiceClientBuilder { GrpcAdapter = GrpcCoreAdapter.Instance, UseJwtAccessWithScopes = false });

void Test(LanguageServiceClientBuilder builder)
{
    Console.WriteLine($"GrpcAdapter: {builder.GrpcAdapter?.ToString() ?? "default"}");
    Console.WriteLine($"UseJwtAccessWithScopes: {builder.UseJwtAccessWithScopes}");
    Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}Z Test starting");
    try
    {
        var client = builder.Build();
        var response = client.AnalyzeSyntax(Document.FromPlainText("It is raining"));
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}Z Call succeeded");
    }
    catch (Exception e)
    {
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}Z Failure: {e}");
    }
    Console.WriteLine();
}
