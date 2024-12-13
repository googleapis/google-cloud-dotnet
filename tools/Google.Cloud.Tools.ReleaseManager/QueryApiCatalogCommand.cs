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
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public class QueryApiCatalogCommand : CommandBase
{
    internal const string CommandName = "query-api-catalog";

    public QueryApiCatalogCommand() : base(CommandName, "Performs a query against the API catalog", 1, 4, "(get-field id field [default-value] | list [test-field]))")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var type = args[0];
        var remainingArgs = args.Skip(1).ToArray();
        return type switch
        {
            "get-field" => ExecuteGetField(remainingArgs),
            "list" => ExecuteList(remainingArgs),
            _ => throw new UserErrorException("Expected query type of 'get-field' or 'list'")
        };
    }

    private int ExecuteGetField(string[] args)
    {
        if (args.Length < 2)
        {
            throw new UserErrorException("Please specify an API ID and field name.");
        }
        string id = args[0];
        string field = args[1];
        string defaultValue = args.Length == 3 ? args[2] : null;

        var catalog = ApiCatalog.Load(RootLayout);
        if (!catalog.TryGetApi(id, out var api))
        {
            throw new UserErrorException($"No such API {id}");
        }

        var result = api.Json.TryGetValue(field, StringComparison.Ordinal, out var value)
            ? (string) value
            : defaultValue ?? throw new UserErrorException($"API {id} has no field {field}");
        Console.WriteLine(result);
        return 0;
    }

    private int ExecuteList(string[] args)
    {
        var catalog = ApiCatalog.Load(RootLayout);
        var apis = catalog.Apis.AsEnumerable();
        if (args.Length >= 1)
        {
            var field = args[0];
            apis = apis.Where(api => api.Json.ContainsKey(field));
        }
        Console.WriteLine(string.Join(" ", apis.Select(api => api.Id)));
        return 0;
    }
}
