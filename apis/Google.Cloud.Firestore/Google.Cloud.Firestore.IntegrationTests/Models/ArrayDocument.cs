// Copyright 2018, Google LLC
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

using System;
using System.Collections.Generic;

namespace Google.Cloud.Firestore.IntegrationTests.Models
{
    [FirestoreData]
    public class ArrayDocument
    {
        public static ArrayDocument[] Data = new[]
        {
            new ArrayDocument("empty"),
            new ArrayDocument("string-x,y") { StringArray = { "x", "y" } },
            new ArrayDocument("int64-1,2") { Int64Array = { 1, 2 } },
            new ArrayDocument("double-1.5,2.5") { DoubleArray = { 1.5, 2.5 } },
            new ArrayDocument("highscore-alice,bob")
            {
                HighScoreArray = { new HighScore("alice", 1, 2), new HighScore("bob", 3, 4) }
            },
            new ArrayDocument("timestamp-2000")
            {
                TimestampArray = { Timestamp.FromDateTime(new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc)) }
            },
            new ArrayDocument("mixed")
            {
                StringArray = { "x" },
                Int64Array = { 2 },
                DoubleArray = { 3.5 }
            }
        };

        /// <summary>
        /// Needed for deserialization.
        /// </summary>
        public ArrayDocument()
        {
        }

        public ArrayDocument(string name)
        {
            Name = name;
        }

        // This is effectively an ID, but unrelated to the DocumentReference ID.
        // It's handy for identifying the expected documents returned from queries.
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public List<string> StringArray { get; set; } = new List<string>();

        [FirestoreProperty]
        public List<long> Int64Array { get; set; } = new List<long>();

        [FirestoreProperty]
        public List<double> DoubleArray { get; set; } = new List<double>();

        [FirestoreProperty]
        public List<HighScore> HighScoreArray { get; set; } = new List<HighScore>();

        [FirestoreProperty]
        public List<Timestamp> TimestampArray { get; set; } = new List<Timestamp>();
    }
}
