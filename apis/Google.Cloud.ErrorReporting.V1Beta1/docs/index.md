{{title}}

{{description}}

{{version}}

Support for automatic error reporting can be found in the
[`Google.Cloud.Diagnostics.AspNetCore`](../../Google.Cloud.Diagnostics.AspNetCore/latest)
and
[`Google.Cloud.Diagnostics.AspNetCore3`](../../Google.Cloud.Diagnostics.AspNetCore3/latest)
NuGet packages.

Those packages are generally preferred over using the Error
Reporting API directly.

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

## Sample code using the Error Reporting API directly

## Report an error

[!code-cs[](obj/snippets/Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceClient.txt#ReportErrorEvent)]

## List error groups with statistics

[!code-cs[](obj/snippets/Google.Cloud.ErrorReporting.V1Beta1.ErrorStatsServiceClient.txt#ListGroupStats)]
