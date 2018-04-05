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

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using TestHelper;
using Xunit;

namespace Google.Cloud.Tools.Analyzers.Tests
{
    public class DefaultLiteralTest : CodeFixVerifierWithOperations
    {
        [Fact]
        public void DefaultBool()
        {
            var test = @"
public class A
{
    public void B(bool x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultBoolLocal()
        {
            var test = @"
public class A
{
    public void B()
    {
        bool x = default;
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultEnum()
        {
            var test = @"
public class A
{
    public void B(System.DateTimeKind x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultInt()
        {
            var test = @"
public class A
{
    public void B(int x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultNullableBool()
        {
            var test = @"
public class A
{
    public void B(bool? x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultNullableBoolLocal()
        {
            var test = @"
public class A
{
    public void B()
    {
        bool? x = default;
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultNullableClass()
        {
            var test = @"
public class A
{
    public void B(object? x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }    

        [Fact]
        public void DefaultNullableEnum()
        {
            var test = @"
public class A
{
    public void B(System.DateTimeKind? x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultNullableInt()
        {
            var test = @"
public class A
{
    public void B(int? x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void DefaultNullableStruct()
        {
            var test = @"
public class A
{
    public void B(System.DateTime? x = default) { }
}";
            VerifyCSharpDiagnostic(test);
        }

        private DiagnosticResult CreateDiagnostic(string typeName, int line, int column) =>
            new DiagnosticResult
            {
                Id = DefaultLiteralAnalyzer.DiagnosticId,
                Message = $"The default literal expression results in a zero value, not 'null' as likely intended. Use 'default({typeName})' instead.",
                Severity = DiagnosticSeverity.Warning,
                Locations = new[] { new DiagnosticResultLocation("Test0.cs", line, column) }
            };

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new DefaultLiteralAnalyzer();
        }

        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new DefaultLiteralCodeFixProvider();
        }
    }
}
