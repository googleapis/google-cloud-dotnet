This directory contains integration tests for classes in Google.Cloud.Spanner.V1.
Tests should be in the Google.Cloud.Spanner.V1.IntegrationTests namespace.

While it's slightly odd that they're here rather than under
Google.Cloud.Spanner.V1/Google.Cloud.Spanner.V1.IntegrationTests, it makes things significantly simpler:

- It means we can have all our common test infrastructure in Google.Cloud.Spanner.Data
- It means fewer test projects to keep track of
- It means we can work in the Google.Cloud.Spanner.Data solution but still modify the tests appropriately

Realistically, we do most development in the Google.Cloud.Spanner.Data solution, so this
is a pragmatic choice. It doesn't affect the production code at all.
