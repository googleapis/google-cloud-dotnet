// Copyright 2023, Google Inc. All rights reserved.
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

namespace Google.Cloud.Firestore.IntegrationTests.Models;

[FirestoreData]
public class Students : IEquatable<Students>
{
    // Note: Keep ordered by name, so we don't need to do that explicitly in tests.
    // All names have distinct values.
    // "mathScore" has decimal values, "englishScore" has double.NaN value.
    public static Students[] Data = new[]
    {
        new Students("AD", 10, 87.2, double.NaN),
        new Students("AS", 20, 98.5, 90),
        new Students("GP", 15, 99, 95),
        new Students("HV", 25, 88, 100),
        new Students("RV", 30, 100, 80),
        new Students("SG", 30, 80.4, 85)
    };

    /// <summary>
    /// Needed for deserialization.
    /// </summary>
    public Students()
    {
    }

    public Students(string name, int level, double mathScore, double englishScore)
    {
        Name = name;
        Level = level;
        MathScore = mathScore;
        EnglishScore = englishScore;
    }

    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public int Level { get; set; }

    [FirestoreProperty]
    public double MathScore { get; set; }

    [FirestoreProperty]
    public double EnglishScore { get; set; }

    public override int GetHashCode() => (Name?.GetHashCode() ?? 0) ^ Level.GetHashCode() ^ MathScore.GetHashCode() ^ EnglishScore.GetHashCode();

    public override bool Equals(object obj) => Equals(obj as Students);

    public bool Equals(Students other) =>
        other != null &&
        Name == other.Name &&
        Level == other.Level &&
        MathScore == other.MathScore &&
        EnglishScore == other.EnglishScore;
}
