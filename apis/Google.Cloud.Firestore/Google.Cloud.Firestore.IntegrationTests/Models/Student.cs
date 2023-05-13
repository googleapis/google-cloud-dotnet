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

using Google.Api.Gax;
using System;

namespace Google.Cloud.Firestore.IntegrationTests.Models;

[FirestoreData]
public class Student : IEquatable<Student>
{
    // Note: Keep ordered by name, so we don't need to do that explicitly in tests.
    // All names have distinct values.
    // "mathScore" has decimal values, "englishScore" has double.NaN value.
    public static Student[] Data = new[]
    {
        new Student("Andy", 10, 87.2, double.NaN),
        new Student("Bharati", 20, 98.5, 90),
        new Student("Colin", 15, 99, 95),
        new Student("Deborah", 25, 88, 100),
        new Student("Edward", 30, 100, 80),
        new Student("Faisal", 30, 80.4, 85)
    };

    /// <summary>
    /// Needed for deserialization.
    /// </summary>
    public Student()
    {
    }

    public Student(string name, int level, double mathScore, double englishScore)
    {
        Name = name;
        Level = level;
        MathScore = mathScore;
        EnglishScore = englishScore;
        Nested = new NestedScores { Math = mathScore, English = englishScore };
    }

    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public int Level { get; set; }

    [FirestoreProperty]
    public double MathScore { get; set; }

    [FirestoreProperty]
    public double EnglishScore { get; set; }

    /// <summary>
    /// A nested representation of the scores, used to test aggregation with dotted field
    /// paths. The values in here are constructed to be the same as MathScore and EnglishScore.
    /// </summary>
    [FirestoreProperty]
    public NestedScores Nested { get; set; }

    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(
            Name?.GetHashCode() ?? 0,
            Level.GetHashCode(),
            MathScore.GetHashCode(),
            EnglishScore.GetHashCode(),
            Nested?.GetHashCode() ?? 0);

    public override bool Equals(object obj) => Equals(obj as Student);

    public bool Equals(Student other) =>
        other is not null &&
        Name == other.Name &&
        Level == other.Level &&
        MathScore == other.MathScore &&
        EnglishScore == other.EnglishScore &&
        Equals(Nested, other.Nested);
}

[FirestoreData]
public class NestedScores : IEquatable<NestedScores>
{
    [FirestoreProperty]
    public double English { get; set; }

    [FirestoreProperty]
    public double Math { get; set; }

    public override int GetHashCode() =>
        GaxEqualityHelpers.CombineHashCodes(English.GetHashCode(), Math.GetHashCode());

    public override bool Equals(object obj) => Equals(obj as NestedScores);

    public bool Equals(NestedScores other) =>
        other is not null &&
        Math == other.Math &&
        English == other.English;
}
