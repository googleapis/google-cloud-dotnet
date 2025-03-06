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
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TodoFunctions;

[FirestoreData]
public class TodoData
{
    private const int TaskIdLength = 8;

    [FirestoreProperty("userId")]
    [JsonPropertyName("userId")]
    public string UserId { get; set; }

    [FirestoreProperty("taskId")]
    [JsonPropertyName("taskId")]
    public string TaskId { get; set; }

    [FirestoreProperty("title")]
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [FirestoreProperty("description")]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [FirestoreProperty("priority")]
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [FirestoreProperty("status")]
    [JsonPropertyName("status")]
    public TodoStatus? Status { get; set; }

    [FirestoreDocumentCreateTimestamp]
    [JsonPropertyName("createdTime")]
    public Timestamp? CreatedTime { get; set; }

    [FirestoreDocumentUpdateTimestamp]
    [JsonPropertyName("lastUpdatedTime")]
    public Timestamp? LastUpdatedTime { get; set; }

    [JsonPropertyName("idToken")]
    public string IdToken { get; set; }

    public TodoData() { }

    /// <summary>
    /// Convert object to dictionary for the update operation, omitting null values
    /// </summary>
    /// <returns>Dictionary representing the TodoData</returns>
    public Dictionary<string, object> PrepareForUpdate()
    {
        Dictionary<string, object> res = new() { };
        if (Title != null)
        {
            res["title"] = Title;
        }
        if (Description != null)
        {
            res["description"] = Description;
        }
        if (Priority != null)
        {
            res["priority"] = Priority;
        }
        if (Status != null)
        {
            res["status"] = Status.ToString();
        }
        return res;
    }

    /// <summary>
    /// Prepare the object for creation
    /// </summary>
    /// <returns>self (same instance of the object)</returns>
    public TodoData PrepareForCreate()
    {
        TaskId = Guid.NewGuid().ToString().Replace("-", "")[..TaskIdLength];
        // set priority and status to default values if not provided
        Priority ??= 5;
        Status ??= TodoStatus.NotStarted;
        return this;
    }
}

[FirestoreData(ConverterType = typeof(FirestoreEnumNameConverter<TodoStatus>))]
public enum TodoStatus
{
    NotStarted,
    InProgress,
    Completed
}
