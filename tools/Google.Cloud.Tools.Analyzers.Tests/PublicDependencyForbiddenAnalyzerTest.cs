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
using Microsoft.CodeAnalysis.Diagnostics;
using TestHelper;
using Xunit;

namespace Google.Cloud.Tools.Analyzers.Tests
{
    public class PublicDependencyForbiddenAnalyzerTest : CodeFixVerifierWithOperations
    {
        [Fact]
        public void ConstructorCheck()
        {
            var test = @"
using Google.Apis.Foo;
using System;

public class A
{
    public A () {}
    public A (B b) {}
    internal A (B b) {}
}

namespace Google.Apis.Foo
{
    public class B
    {
        public B() {}
    }
}";
            var expected = CreateDiagnostic("Google.Apis.Foo.B", "Google.Apis.Foo", 8, 15);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void CustomEventCheck()
        {
            var test = @"
using Google.Apis.Foo;
using System;

public class A
{
    public event EventHandler<EventArgs> GoodEvent { add {} remove {} }
    public event EventHandler<GoogleEventArgs> BadEvent { add {} remove {} }
    internal event EventHandler<GoogleEventArgs> InternalEvent { add {} remove {} }
}

namespace Google.Apis.Foo
{
    public class GoogleEventArgs : EventArgs
    {
    }

    public class OtherType
    {
        public event EventHandler<GoogleEventArgs> NotChecked { add {} remove {} }
    }
}";
            var expected = CreateDiagnostic("System.EventHandler<Google.Apis.Foo.GoogleEventArgs>", "Google.Apis.Foo", 8, 18);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void EventCheck()
        {
            var test = @"
using Google.Apis.Foo;
using System;

public class A
{
    public event EventHandler<EventArgs> GoodEvent;
    public event EventHandler<GoogleEventArgs> BadEvent;
    internal event EventHandler<GoogleEventArgs> InternalEvent;
}

namespace Google.Apis.Foo
{
    public class GoogleEventArgs : EventArgs
    {
    }

    public class OtherType
    {
        public event EventHandler<GoogleEventArgs> NotChecked;
    }
}";
            var expected = CreateDiagnostic("System.EventHandler<Google.Apis.Foo.GoogleEventArgs>", "Google.Apis.Foo", 8, 18);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void FieldCheck()
        {
            var test = @"
using Google.Apis.Foo;

public class A
{
    public A _good_field;
    public B _bad_field;
    internal B _internal_field;
}

namespace Google.Apis.Foo
{
    public class B
    {
    }

    public class OtherType
    {
        public B _not_checked;
    }
}";
            var expected = CreateDiagnostic("Google.Apis.Foo.B", "Google.Apis.Foo", 7, 12);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void MethodParameterCheck()
        {
            var test = @"
using Google.Apis.Foo;

public class A
{
    public void GoodMethod(A a) { }
    public void BadMethod(B b) { }
    internal void InternalMethod(B b) { }
}

namespace Google.Apis.Foo
{
    public class B
    {
    }

    public class OtherType
    {
        public void NotChecked(B b) { }
    }
}";
            var expected = CreateDiagnostic("Google.Apis.Foo.B", "Google.Apis.Foo", 7, 27);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void MethodReturnTypeCheck()
        {
            var test = @"
using Google.Apis.Foo;

public class A
{
    public A GoodMethod() { return default(A); }
    public B BadMethod() { return default(B); }
    internal B InternalMethod() { return default(B); }
}

namespace Google.Apis.Foo
{
    public class B
    {
    }

    public class OtherType
    {
        public B NotChecked() { return default(B); }
    }
}";
            var expected = CreateDiagnostic("Google.Apis.Foo.B", "Google.Apis.Foo", 7, 12);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void PropertyCheck()
        {
            var test = @"
using Google.Apis.Foo;

public class A
{
    public A GoodProperty { get; set; }
    public B BadProperty { get; set; }
    internal B InternalProperty { get; set; }
}

namespace Google.Apis.Foo
{
    public class B
    {
    }

    public class OtherType
    {
        public B NotChecked { get; set; }
    }
}";
            var expected = CreateDiagnostic("Google.Apis.Foo.B", "Google.Apis.Foo", 7, 12);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void TypeBaseCheck()
        {
            var test = @"
using Google.Apis.Foo;

public class A : B { }

namespace Google.Apis.Foo
{
    public class B { }

    public class OtherType : B { }
}";
            var expected = CreateDiagnostic("A", "Google.Apis.Foo", 4, 16);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void TypeInterfaceCheck()
        {
            var test = @"
using Google.Apis.Foo;
using System;

public class A : IComparable<B> { }

namespace Google.Apis.Foo
{
    public class B { }

    public class OtherType : IComparable<B> { }
}";
            var expected = CreateDiagnostic("A", "Google.Apis.Foo", 5, 16);
            VerifyCSharpDiagnostic(test, expected);
        }

        private DiagnosticResult CreateDiagnostic(
            string typeName, string namespaceName, int line, int column) =>
                new DiagnosticResult
                {
                    Id = PublicDependencyForbiddenAnalyzer.DiagnosticId,
                    Message = $"The type '{typeName}' directly or indirectly depends on the forbidden namespace '{namespaceName}'",
                    Severity = DiagnosticSeverity.Hidden,
                    Locations = new[] { new DiagnosticResultLocation("Test0.cs", line, column) }
                };

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new PublicDependencyForbiddenAnalyzer();
        }
    }
}