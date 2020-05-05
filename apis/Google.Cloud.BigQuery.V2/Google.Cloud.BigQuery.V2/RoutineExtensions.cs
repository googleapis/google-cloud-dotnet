// Copyright 2020 Google LLC
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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods for making it easier to work with <see cref="Routine"/>
    /// </summary>
    public static class RoutineExtensions
    {
        private const string UnspecifiedRoutineType = "ROUTINE_TYPE_UNSPECIFIED";
        private const string UnspecifiedLanguage = "LANGUAGE_UNSPECIFIED";

        /// <summary>
        /// Gets this routine's type.
        /// </summary>
        public static RoutineType? GetRoutineType(this Routine routine) =>
            GaxPreconditions.CheckNotNull(routine, nameof(routine)).RoutineType switch
            { 
                null => null,
                UnspecifiedRoutineType => null,
                _ => EnumMap<RoutineType>.ToValue(routine.RoutineType, nameof(routine.RoutineType))
            };

        /// <summary>
        /// Sets this routine's type.
        /// </summary>
        public static void SetRoutineType(this Routine routine, RoutineType? type) =>
            GaxPreconditions.CheckNotNull(routine, nameof(routine)).RoutineType = type switch
            { 
                null => null,
                _ => EnumMap.ToApiValue(type.Value, nameof(type))
            };

        /// <summary>
        /// Gets this routine's language.
        /// </summary>
        public static RoutineLanguage? GetRoutineLanguage(this Routine routine) =>
            GaxPreconditions.CheckNotNull(routine, nameof(routine)).Language switch
            {
                null => null,
                UnspecifiedLanguage => null,
                _ => EnumMap<RoutineLanguage>.ToValue(routine.Language, nameof(routine.Language))
            };

        /// <summary>
        /// Sets this routine's language.
        /// </summary>
        public static void SetRoutineLanguage(this Routine routine, RoutineLanguage? language) =>
            GaxPreconditions.CheckNotNull(routine, nameof(routine)).Language = language switch
            {
                null => null,
                _ => EnumMap.ToApiValue(language.Value, nameof(language))
            };

        /// <summary>
        /// Determines whether two <see cref="RoutineReference"/> refer to the same <see cref="Routine"/>,
        /// that is if the project ID, dataset ID and the routine ID are the same.
        /// </summary>
        /// <param name="routineReference1">The first routine reference to compare. Must not be null.</param>
        /// <param name="routineReference2">The second routine reference to compare. Must not be null.</param>
        /// <returns>true if the specified routine references refer to the same routine, false otherwise.</returns>
        internal static bool ReferencesSameAs(this RoutineReference routineReference1, RoutineReference routineReference2)
        {
            GaxPreconditions.CheckNotNull(routineReference1, nameof(routineReference1));
            GaxPreconditions.CheckNotNull(routineReference2, nameof(routineReference2));

            return routineReference1.ProjectId == routineReference2.ProjectId &&
                routineReference1.DatasetId == routineReference2.DatasetId &&
                routineReference1.RoutineId == routineReference2.RoutineId;
        }
    }
}
