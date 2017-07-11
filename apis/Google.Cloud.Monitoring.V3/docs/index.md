{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

There are two client classes to be aware of:

- [GroupServiceClient](obj/api/Google.Cloud.Monitoring.V3.GroupServiceClient.yml)
- [MetricServiceClient](obj/api/Google.Cloud.Monitoring.V3.MetricServiceClient.yml)

In each case, create an instance using the static `Create` method,
optionally specifying a service endpoint and settings.

# Sample code

## List metric descriptors

[!code-cs[](obj/snippets/Google.Cloud.Monitoring.V3.MetricServiceClient.txt#ListMetricDescriptors)]

## List groups

[!code-cs[](obj/snippets/Google.Cloud.Monitoring.V3.GroupServiceClient.txt#ListGroups)]
