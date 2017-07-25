{{title}}

`Google.Cloud.Spanner.Data` is the ADO.NET provider for Cloud Spanner. It is the recommended
package for regular Cloud Spanner database access from .NET.

The [Google.Cloud.Spanner.Admin.Instance.V1](../Google.Cloud.Spanner.Admin.Instance.V1/) package
should be used for Cloud Spanner instance administration, such as creating or deleting instances.

{{installation}}

{{auth}}

# Getting started

Operations generally follow ADO.NET conventions.
However Cloud Spanner does not support DDL (eg. "INSERT INTO ..."). Therefore you should
use the corresponding API on SpannerConnection to create ADO command objects instead
of setting CommandText manually.

See examples below:

# Sample code
Once you have created your Google Cloud Project and Spanner Instance using the web console,
you can start using the ADO.NET provider to create and modify a Cloud Spanner database.

## Creating a Database and Table

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#CreateDatabaseAsync)]

## DataAdapter support (.NET 4.5+ only)

Cloud Spanner supports a limited DataAdapter that provides basic CRUD operations on any table.
Create a SpannerDataAdapter with the target table and its primary keys.  You may replace any
commands provided by SpannerDataAdapter with your own custom commands.

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#DataAdapterAsync)]

## Inserting Data

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#InsertDataAsync)]

## Reading, Updating and Deleting Data

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#ReadUpdateDeleteAsync)]

## Transactions and Fault Handling
Cloud Spanner is fully ACID compliant.

Retries should be implemented at the transaction level (as opposed to individual call level)
because there is a chance in high stress situations that a Cloud Spanner session (transaction)
can be canceled due to causing a deadlock. In this case, the entire transaction should be
retried and run on a new session.

Use the extension method IsTransientSpannerFault() on Exception to create your detection
strategy for the TransientFaultApplication Block.

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#SpannerFaultDetectionStrategy)]

 You should execute the entire transaction within a RetryPolicy. Generally, we recommend
 using exponential backoff as shown below.

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#TransactionAsync)]

## TransactionScope support (.NET 4.5+, Single resource only)
In addition to supporting setting Transaction on individual commands, Spanner also supports
TransactionScope and implicit transactions given that only a single resource is involved.

Spanner does not support public two phase commit to commit multiple resources in a
single transaction.

[!code-cs[](obj/snippets/Google.Cloud.Spanner.Data.SpannerOverviews.cs.txt#TransactionScopeAsync)]


