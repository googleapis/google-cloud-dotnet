{{title}}

`Google.Cloud.EntityFrameworkCore.Spanner` is the EF Core provider for Cloud Spanner.

{{version}}

{{installation}}

{{auth}}

# Getting started

The Entity Framework Core provider allows you to use the Entity Framework
to create your database, query and update data. To get started, install
the nuget package for EntityFrameworkCore Spanner and call the "UseSpanner"
method extension to configure your DbContext with Spanner support.

# Sample code
{{sample:SpannerDbContextOptionsExtensions.UseSpanner}}

# Query Limitations
* The EFCore provider for Spanner defaults its timezone to GMT

# Update Limitations
* Mutiple code blocks executed within a single transaction do not support
read your own writes.  For example, a newly written row will not be returned
in a query until the transaction is committed. 
* Cloud Spanner does not have database value generators or constraints.
Instead, you may use a client side Guid generator for a primary key.

# Migration Limitations
* Only has very basic Create + Delete support for migration.
* No support for altering an existing schema nor history.
* Ddl commands are not executed within a transaction. Therefore,
complex schemas may be partially committed if interrupted.
