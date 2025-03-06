// Copyright 2025 Google Inc. All Rights Reserved.
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

using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoFunctions;

/// <summary>
/// Cloud Function to read todo items in the Todo Application
/// </summary>
public class ReadTodos : AbstractTodoFunction
{
    protected override bool ValidateRequest(TodoData todoData)
    {
        string userId = todoData.UserId;
        string taskId = todoData.TaskId;
        int? priority = todoData.Priority;

        // UserId should not be null or empty. TaskId, if provided, should not be empty. Priority should be an integer between 1 to 5.
        return userId is not null
            && userId != ""
            && (taskId is null || taskId != "")
            && (priority is null || (1 <= priority && priority <= 5));
    }

    protected override async Task<string> PerformOperation(TodoData todoData)
    {

        // Create a filter for the query based on the request
        List<Filter> filterList = new() {
            Filter.EqualTo("userId", todoData.UserId)
        };
        if (todoData.TaskId != null)
        {
            filterList.Add(Filter.EqualTo("taskId", todoData.TaskId));
        }
        if (todoData.Priority != null)
        {
            filterList.Add(Filter.EqualTo("priority", todoData.Priority));
        }
        if (todoData.Status != null)
        {
            filterList.Add(Filter.EqualTo("status", todoData.Status.ToString()));
        }

        // Query the collection
        Query query = TodoItemsCollection.Where(Filter.And(filterList.ToArray()));
        QuerySnapshot querySS = await query.GetSnapshotAsync();

        // Serialize the results
        StringBuilder output = new StringBuilder();
        foreach (DocumentSnapshot document in querySS.Documents)
        {
            output.Append(JsonSerializer.Serialize(document.ConvertTo<TodoData>(), SerializerOptions));
            output.Append('\n');
        }

        // Build the results into a string and return
        return output.ToString();
    }
}
