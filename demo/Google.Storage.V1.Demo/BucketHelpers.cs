// Copyright 2015 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;

namespace Google.Storage.V1.Demo
{
    public static class BucketHelper
    {
        public const char Delimiter = '/';
        public static IEnumerable<string> Folders(this StorageClient client, string bucket, string parentFolder = "")
        {
            if (client == null) { throw new ArgumentNullException("this"); }
            if (string.IsNullOrWhiteSpace(bucket)) { throw new ArgumentOutOfRangeException("bucket must be non-empty"); }
            if (!string.IsNullOrEmpty(parentFolder) && !parentFolder.EndsWith(Delimiter.ToString())) { throw new ArgumentException("parentFolder must end in " + Delimiter); }
            if (!string.IsNullOrEmpty(parentFolder) && parentFolder == Delimiter.ToString()) { throw new ArgumentException("root folder is \"\", not " + Delimiter); }

            var prefix = parentFolder ?? "";
            return client
              .ListObjects(bucket, prefix)
              .Select(o => o.Name.Substring(prefix.Length))
              .Where(n => n.Contains(Delimiter))
              .Select(n => n.Split(Delimiter).First())
              .Distinct()
              .Select(n => prefix + n + Delimiter);
        }

        public static IEnumerable<Google.Apis.Storage.v1.Data.Object> Files(this StorageClient client, string bucket, string parentFolder = "")
        {
            if (client == null) { throw new ArgumentNullException("this"); }
            if (string.IsNullOrWhiteSpace(bucket)) { throw new ArgumentOutOfRangeException("bucket must be non-empty"); }
            if (!string.IsNullOrEmpty(parentFolder) && !parentFolder.EndsWith(Delimiter.ToString())) { throw new ArgumentException("parentFolder must end in " + Delimiter); }
            if (!string.IsNullOrEmpty(parentFolder) && parentFolder == Delimiter.ToString()) { throw new ArgumentException("root folder is \"\", not " + Delimiter); }

            var prefix = parentFolder ?? "";
            return client
              .ListObjects(bucket, prefix, new ListObjectsOptions { Delimiter = Delimiter.ToString() })
              .Where(o => !o.Name.EndsWith(Delimiter.ToString()));
        }

        public static string ShortName(string name)
        {
            if (name == null) { throw new ArgumentNullException("name"); }
            return name.Split(new char[] { Delimiter }, StringSplitOptions.RemoveEmptyEntries).Last();
        }

        public static string ShortName(this Google.Apis.Storage.v1.Data.Object obj)
        {
            if (obj == null) { throw new ArgumentNullException("this"); }
            return ShortName(obj.Name);
        }
    }

}