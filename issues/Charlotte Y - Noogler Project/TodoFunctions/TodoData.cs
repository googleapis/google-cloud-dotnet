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

public class TodoData
{
    private const int TaskIdLength = 8;

    [JsonPropertyName("userId")]
    public string UserId { get; set; }

    [JsonPropertyName("taskId")]
    public string TaskId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TodoStatus? Status { get; set; }

    [JsonPropertyName("createdTime")]
    [JsonConverter(typeof(FirestoreTimestampConverter))]
    public Timestamp? CreatedTime { get; set; }

    [JsonPropertyName("lastUpdatedTime")]
    [JsonConverter(typeof(FirestoreTimestampConverter))]
    public Timestamp? LastUpdatedTime { get; set; }

    [JsonPropertyName("idToken")]
    public string IdToken { get; set; }

    public TodoData() { }

    /// <summary>
    /// Convert object to dictionary while ignoring null values
    /// </summary>
    /// <returns>Dictionary representing the TodoData</returns>
    public Dictionary<string, object> ToDictionary()
    {
        Dictionary<string, object> res = new() { };
        if (UserId != null)
        {
            res["userId"] = UserId;
        }
        if (TaskId != null)
        {
            res["taskId"] = TaskId;
        }
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
        if (CreatedTime != null)
        {
            res["createdTime"] = CreatedTime;
        }
        if (LastUpdatedTime != null)
        {
            res["lastUpdatedTime"] = LastUpdatedTime;
        }
        return res;
    }

    /// <summary>
    /// Prepare the object for the given DB operation
    /// </summary>
    /// <param name="operation">DB operation to be performed</param>
    /// <returns>self (same instance of the object)</returns>
    public TodoData Prepare(Operation operation)
    {
        switch (operation)
        {
            case Operation.Create:
                // assign a new task ID
                TaskId = Guid.NewGuid().ToString().Replace("-", "")[..TaskIdLength];
                // set created and updated times
                CreatedTime = Timestamp.GetCurrentTimestamp();
                LastUpdatedTime = CreatedTime;
                // set priority and status to default values if not provided
                Priority ??= 5;
                Status ??= TodoStatus.NotStarted;
                break;
            case Operation.Update:
                // null out the UserId, TaskId, and CreatedTime because these values will never change
                UserId = null;
                TaskId = null;
                CreatedTime = null;
                // set updated time
                LastUpdatedTime = Timestamp.GetCurrentTimestamp();
                break;
        }
        return this;
    }
}

public enum TodoStatus
{
    NotStarted,
    InProgress,
    Completed
}

public enum Operation
{
    Create,
    Update,
}
