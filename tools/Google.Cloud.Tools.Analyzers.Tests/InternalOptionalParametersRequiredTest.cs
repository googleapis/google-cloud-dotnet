using Google.Cloud.Tools.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using TestHelper;
using Xunit;

namespace Google.Cloud.Tools.Analyzers.Test
{
    public class InternalOptionalParametersRequiredTest : CodeFixVerifier
    {
        [Fact]
        public void CustomTypeNamesDontMatch()
        {
            var test = @"
public class A
{
    public void B(Options x)
    {
        C();
    }

    public void C(Options options = null)
    {
    }
}

public class Options
{
}";
            var expected = CreateDiagnostic("options", "x", 6, 10);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void PrimitiveTypeNamesMatch()
        {
            var test = @"
public class A
{
    public void B(string x)
    {
        C();
    }

    public void C(string x = ""value"")
    {
    }
}";
            var expected = CreateDiagnostic("x", "x", 6, 10);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void PrimitiveTypeNamesDontMatch()
        {
            var test = @"
public class A
{
    public void B(string x)
    {
        C();
    }

    public void C(string paramName = ""value"")
    {
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void OmittedArgumentBeforeNamedArgument()
        {
            var test = @"
public class A
{
    public void B(Options x)
    {
        OtherType.C(45, foo: ""def"");
    }
}

public class OtherType
{
    public static void C(int a, Options options = null, string foo = ""abc"")
    {
    }
}

public class Options
{
}";
            var expected = CreateDiagnostic("options", "x", 6, 20);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void InternallyVisibleCallsIgnored()
        {
            var test = @"
public class A
{
    public void B(Options x)
    {
        C();
        D();
    }

    internal void C(Options options = null)
    {
    }
}

internal class OtherType
{
    public static void D(Options options = null)
    {
    }
}

public class Options
{
}";
            VerifyCSharpDiagnostic(test);
        }

        private DiagnosticResult CreateDiagnostic(
            string parameterName, string suggestionName, int line, int column) =>
                new DiagnosticResult
                {
                    Id = InternalOptionalParametersRequired.DiagnosticId,
                    Message = $"The parameter '{parameterName}' should be specified, possibly with the local '{suggestionName}'",
                    Severity = DiagnosticSeverity.Warning,
                    Locations = new[] { new DiagnosticResultLocation("Test0.cs", line, column) }
                };

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new InternalOptionalParametersRequired();
        }
    }
}