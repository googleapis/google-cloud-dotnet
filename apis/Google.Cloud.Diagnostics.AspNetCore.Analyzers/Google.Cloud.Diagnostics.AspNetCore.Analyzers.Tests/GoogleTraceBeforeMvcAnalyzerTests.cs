// Copyright 2018 Google LLC
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

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Linq;
using System.Reflection;
using TestHelper;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Analyzers.Tests
{
    public class GoogleTraceBeforeMvcAnalyzerTests : CodeFixVerifier
    {
        private static readonly MetadataReference s_runtimeReference =
            MetadataReference.CreateFromFile(Assembly.Load("System.Runtime, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a").Location);
        private static readonly MetadataReference s_aspNetCoreBuilderReference =
            MetadataReference.CreateFromFile(typeof(IApplicationBuilder).Assembly.Location);
        private static readonly MetadataReference s_aspNetCoreRoutingReference =
            MetadataReference.CreateFromFile(typeof(IRouteBuilder).Assembly.Location);
        private static readonly MetadataReference s_builderExtensionsReference =
            MetadataReference.CreateFromFile(typeof(MvcApplicationBuilderExtensions).Assembly.Location);

        [Fact]
        public void CorrectOrderChained()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseGoogleTrace()
           .UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";

            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void CorrectOrderChainedSeparated()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseGoogleTrace()
           .SomethingElse()
           .UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder SomethingElse(this IApplicationBuilder app) { return app; }
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";

            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void CorrectOrderStatements()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseGoogleTrace();
        app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void CorrectOrderStatementsSeparated()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseGoogleTrace();
        app.SomethingElse();
        app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder SomethingElse(this IApplicationBuilder app) { return app; }
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void IncorrectOrderChained()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           })
           .UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 15, 13);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void IncorrectOrderChainedSeparated()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseMvc()
           .SomethingElse()
           .UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder SomethingElse(this IApplicationBuilder app) { return app; }
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 11, 13);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void IncorrectOrderStatements()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseMvcWithDefaultRoute();
        app.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvcWithDefaultRoute", 10, 13);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void IncorrectOrderStatementsSeparated()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B()
    {
        IApplicationBuilder app = null;
        app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
        app.SomethingElse();
        app.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder SomethingElse(this IApplicationBuilder app) { return app; }
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 17, 13);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void IncorrectOrderStatementsChained()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.SomethingElse().UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
        app.SomethingElse().UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder SomethingElse(this IApplicationBuilder app) { return app; }
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 15, 29);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void CallsAcrossLambdasNotChecked()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;
using System;

class A
{
    public static void B(IApplicationBuilder app)
    {
        Action addMvc = () =>
        {
            app.UseMvc();
        };

        app.UseGoogleTrace();
        addMvc();
    }

    public static void C(IApplicationBuilder app)
    {
        Action<int> addMvc = x =>
        {
            app.UseMvc();
        };

        addMvc(5);
        app.UseGoogleTrace();
    }

    public static void D(IApplicationBuilder app)
    {
        Action addMvc = () =>
        {
            app.UseMvc();
        };

        Action addGoogleTrace = () =>
        {
            app.UseMvc();
        };

        addMvc();
        addGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void CallsWithinLambdasAreChecked()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;
using System;

class A
{
    public static void B(IApplicationBuilder app)
    {
        Action addBoth = () =>
        {
            app.UseMvc();
            app.UseGoogleTrace();
        };

        addBoth();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 13, 17);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void CallsAcrossLocalFunctionsNotChecked()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        AddGoogleTrace();
        app.UseMvc();

        void AddGoogleTrace()
        {
            app.UseGoogleTrace();
        }
    }

    public static void C(IApplicationBuilder app)
    {
        app.UseMvc();
        AddGoogleTrace();

        void AddGoogleTrace()
        {
            app.UseGoogleTrace();
        }
    }

    public static void D(IApplicationBuilder app)
    {
        AddMvc();
        AddGoogleTrace();

        void AddMvc()
        {
            app.UseMvc();
        }

        void AddGoogleTrace()
        {
            app.UseGoogleTrace();
        }
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void CallsWithinLocalFunctionsAreChecked()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        AddBoth();

        void AddBoth()
        {
            app.UseMvc();
            app.UseGoogleTrace();
        }
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 14, 17);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void SeparateChecksInSeparateScopes()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;
using System;

class A
{
    public static void B(IApplicationBuilder app)
    {
        void AddBoth()
        {
            app.UseMvc();
            app.UseGoogleTrace();
        }

        Action addBoth = delegate()
        {
            app.UseMvcWithDefaultRoute();
            app.UseGoogleTrace();
        };
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected1 = CreateDiagnostic("UseMvc", 13, 17);
            var expected2 = CreateDiagnostic("UseMvcWithDefaultRoute", 19, 17);
            VerifyCSharpDiagnostic(test, expected1, expected2);
        }

        [Fact]
        public void NonApplicationBuilderIgnored()
        {
            var test = @"
class A
{
    public static void B(A a)
    {
        a.UseMvc().UseGoogleTrace();
    }
}

static class Extension
{
    public static A UseMvc(this A a) { return a; }
    public static A UseGoogleTrace(this A a) { return a; }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void InSourceSuppression()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseMvcWithDefaultRoute();
#pragma warning disable GCP0005
        app.UseGoogleTrace();
#pragma warning restore GCP0005
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void InSourceSuppressionInWrongLocation()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
#pragma warning disable GCP0005
        app.UseMvc();
#pragma warning restore GCP0005
        app.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 12, 13);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void FieldAccessSameScope()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder _app;

    public void B()
    {
        _app.UseMvc();
        _app.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 12, 14);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void FieldAccessDifferentScope()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder _app;

    public void B()
    {
        _app.UseMvc();
    }

    public void C()
    {
        _app.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void FieldAccessDifferentFile()
        {
            var test1 = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

partial class A
{
    private IApplicationBuilder _app;

    public void B()
    {
        _app.UseGoogleTrace();
    }
}";
            var test2 = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

partial class A
{
    public void C()
    {
        _app.UseMvc();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";

            VerifyCSharpDiagnostic(new[] { test1, test2 });
        }

        [Fact]
        public void FieldAccessNotInMethodCorrectOrder()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder _app;
    private IApplicationBuilder _app2 = _app.UseGoogleTrace().UseMvc();
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void FieldAccessNotInMethodIncorrectOrder()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder _app;
    private IApplicationBuilder _app2 = _app.UseMvc().UseGoogleTrace();
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 8, 55);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void FieldAccessNotInMethodSeparateScopes()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder _app;
    private IApplicationBuilder _app2 = _app.UseMvc();
}

class B
{
    private IApplicationBuilder _app;
    private IApplicationBuilder _app2 = _app.UseGoogleTrace();
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void PropertyAccessSameScope()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder App { get; set; }

    public void B()
    {
        App.UseMvc();
        App.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var expected = CreateDiagnostic("UseMvc", 12, 13);
            VerifyCSharpDiagnostic(test, expected);
        }

        [Fact]
        public void PropertyAccessDifferentScope()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    private IApplicationBuilder App { get; set; }

    public void B()
    {
        App.UseMvc();
    }

    public void C()
    {
        App.UseGoogleTrace();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            VerifyCSharpDiagnostic(test);
        }

        [Fact]
        public void PropertyAccessDifferentFile()
        {
            var test1 = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

partial class A
{
    private IApplicationBuilder App { get; set; }

    public void B()
    {
        App.UseGoogleTrace();
    }
}";
            var test2 = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

partial class A
{
    public void C()
    {
        App.UseMvc();
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";

            VerifyCSharpDiagnostic(new[] { test1, test2 });
        }

        [Fact]
        public void SymbolInfoTableCleanedUp()
        {
            var test = @"
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;

class A
{
    public static void B(IApplicationBuilder app)
    {
        app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           })
           .UseGoogleTrace();
    }

    public static void C(IApplicationBuilder app)
    {
        app.UseGoogleTrace()
           .UseMvc(routes =>
           {
               routes.MapRoute(
                   name: ""default"",
                   template: ""{controller=Main}/{action=Index}/{id}"");
           });
    }
}

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class CloudTraceExtension
    {
        public static IApplicationBuilder UseGoogleTrace(this IApplicationBuilder app) { return app; }
    }
}";
            var table = GoogleTraceBeforeMvcAnalyzer._applicationBuilderSymbolInfos;

            GC.Collect();
            bool inNoGCRegion = GC.TryStartNoGCRegion(16_000_000);
            try
            {
                var expected = CreateDiagnostic("UseMvc", 15, 13);
                VerifyCSharpDiagnostic(test, expected);

                Assert.NotEqual(0, table.Count());
            }
            finally
            {
                if (inNoGCRegion)
                {
                    GC.EndNoGCRegion();
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();


            // I believe this should never happen, but just to be sure, make sure anything from the value
            // in the table doesn't root the key, preventing it (and the value) from being collected.
            Assert.Equal(0, table.Count());
        }

        private DiagnosticResult CreateDiagnostic(string useMvcName, int line, int column) =>
            new DiagnosticResult
            {
                Id = GoogleTraceBeforeMvcAnalyzer.RuleId,
                Message = $"UseGoogleTrace should be used before {useMvcName} so requests can be traced",
                Severity = DiagnosticSeverity.Warning,
                Locations = new[] { new DiagnosticResultLocation("Test0.cs", line, column) }
            };

        protected override CodeFixProvider GetCSharpCodeFixProvider() => null;

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer() =>
            new GoogleTraceBeforeMvcAnalyzer();

        protected override void FinalizeSolution(ProjectId projectId, ref Solution solution)
        {
            solution = solution
                .AddMetadataReference(projectId, s_runtimeReference)
                .AddMetadataReference(projectId, s_aspNetCoreBuilderReference)
                .AddMetadataReference(projectId, s_aspNetCoreRoutingReference)
                .AddMetadataReference(projectId, s_builderExtensionsReference);
            base.FinalizeSolution(projectId, ref solution);
        }
    }
}
