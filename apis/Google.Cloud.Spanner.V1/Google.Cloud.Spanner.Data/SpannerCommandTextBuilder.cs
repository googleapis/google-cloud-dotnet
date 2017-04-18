// Copyright 2017 Google Inc. All Rights Reserved.
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

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public class SpannerCommandTextBuilder
    {
        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="databaseTable"></param>
        private SpannerCommandTextBuilder(OperationType type, string databaseTable)
        {
        }

        /// <summary>
        /// </summary>
        public OperationType OperationType
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateDeleteTextBuilder(string databaseTable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateInsertOrUpdateTextBuilder(string databaseTable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateInsertTextBuilder(string databaseTable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateSelectTextBuilder(string sqlQuery)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateUpdateTextBuilder(string databaseTable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder FromCommandText(string commandText)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}