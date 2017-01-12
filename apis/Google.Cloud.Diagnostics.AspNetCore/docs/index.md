# Google.Cloud.Diagnostics.AspNetCore

`Google.Cloud.Diagnostics.AspNetCore` is an ASP.NET Core instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNetCore` currently supports Stackdriver Error Reporting and Stackdriver Logging.

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth application-default login
```

# Getting started

## Registering Error Reporting

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#ReportUnandledExceptions)]

## Initializing Logging

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#RegisterGoogleLogger)]

## Log

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#UseGoogleLogger)]