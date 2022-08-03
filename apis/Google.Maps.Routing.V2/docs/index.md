{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

Some methods within this API require a *field mask* header in each
request, to select which fields should be returned. The value `*`
can be used to return all fields. In the .NET client library, the
header can be added using a `CallSettings` object, as shown in the
example below.

{{sample:RoutesClient.GettingStarted}}
