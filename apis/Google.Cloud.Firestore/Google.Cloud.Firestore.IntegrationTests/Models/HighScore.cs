// Copyright 2017, Google Inc. All rights reserved.
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

using System;

namespace Google.Cloud.Firestore.IntegrationTests.Models
{
    [FirestoreData]
    public class HighScore : IEquatable<HighScore>
    {
        // Note: keep ordered by name, so we don't need to do that explicitly in tests.
        // The levels and names should be unique for the sake of testing; there can be multiple
        // high scores with the same score though.
        public static HighScore[] Data = new[]
        {
            new HighScore("Alice", 20, 100),
            new HighScore("Bob", 10, 90),
            new HighScore("Carol", 15, 110),
            new HighScore("Dalip", 25, 200),
            new HighScore("Erin", 30, 200)
        };

        /// <summary>
        /// Needed for deserialization.
        /// </summary>
        public HighScore()
        {
        }

        public HighScore(string name, int level, int score)
        {
            Name = name;
            Level = level;
            Score = score;
        }

        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public int Level { get; set; }

        [FirestoreProperty]
        public int Score { get; set; }

        public override int GetHashCode() => (Name?.GetHashCode() ?? 0) ^ Level.GetHashCode() ^ Score.GetHashCode();

        public override bool Equals(object obj) => Equals(obj as HighScore);

        public bool Equals(HighScore other) =>
            other != null &&
            Name == other.Name &&
            Level == other.Level &&
            Score == other.Score;
    }
}
