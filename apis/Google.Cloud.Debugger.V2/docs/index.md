{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

The main entry point for the API is the [Debugger2Client](obj/api/Google.Cloud.Debugger.V2.Debugger2Client.yml) and
the [Controller2Client](obj/api/Google.Cloud.Debugger.V2.Controller2Client.yml).
Create an instance using the static `Create` method, optionally specifying a service endpoint and settings.

# Sample code

## Register Debuggee

[!code-cs[](obj/snippets/Google.Cloud.Debugger.V2.Controller2Client.txt#RegisterDebuggee)]