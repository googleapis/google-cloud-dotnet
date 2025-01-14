// Copyright 2019 Google LLC
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

using Google.Cloud.Tools.VersionCompat.CecilUtils;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat
{
    public class Diff
    {
        public static Diff Major(Cause cause, FormattableString msg) => new Diff(Level.Major, cause, msg);
        public static Diff Minor(Cause cause, FormattableString msg) => new Diff(Level.Minor, cause, msg);
        public static Diff Create(Level level, Cause cause, FormattableString msg) => new Diff(level, cause, msg);

        private Diff(Level level, Cause cause, FormattableString msg) => (Level, Cause, Msg) = (level, cause, msg);

        public Level Level { get; }
        public Cause Cause { get; }
        public FormattableString Msg { get; }

        public override string ToString() => ToString(FormatDetail.Full);

        public string ToString(FormatDetail detail) =>
            FormatReplacements(Msg, detail);

        private string FormatReplacements(FormattableString fs, FormatDetail detail) =>
            string.Format(fs.Format, fs.GetArguments().Select(arg => Transform(arg, detail)).ToArray());

        private object Transform(object arg, FormatDetail detail)
        {
            switch (arg)
            {
                case FormattableString fs: return FormatReplacements(fs, detail);
                case TypeReference tr: return tr.Show(detail);
                case PropertyDefinition pd: return pd.Show(detail);
                case MethodDefinition md: return md.Show(detail);
                default: return arg;
            }
        }
    }
}
