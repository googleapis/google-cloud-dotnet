# Package names

The package names for the Google Cloud Client Libraries for .NET take
multiple forms. Here are a few examples:

- Google.Cloud.Datastore.V1
- Google.Cloud.Firestore
- Google.Cloud.Logging.Type
- Google.Cloud.Logging.Log4Net

It's somewhat unusual to see a version number in a NuGet package
name, as in the Datastore example. There's a reason though: this is
a package for that specific version of the Datastore API. We
distinguish between the *API* (exposed by Google servers, used by
multiple languages) and the *package* (the .NET-specific NuGet
package).

The version number in the package name is the API version number.
Separately, that package can go through multiple versions. A change
to the API will always mean a new package version, but the reverse
isn't true: sometimes we may improve the package even without the
API changing. (For example, adding more convenience methods.)

Having the version number in the package name gives the advantage
that if you want to migrate from one major API version to another,
you don't have to do that for your whole codebase in a single step.
You can take a dependency on Google.Cloud.AwesomeApi.V1 and
Google.Cloud.AwesomeApi.V2 in the same project, migrating your code
piecemeal.

It also means that a single application can use libraries
which depend on different versions of the API - or your own code can
use one version of the API, but still depend on code that depends on
a different version. (There are still potential issues if you have
dependencies on different major *package* versions of the same API
version, but that's less likely to happen.)

The rest of the examples given *don't* have API version numbers in
their package names. They are of slightly different forms though:

Google.Cloud.Firestore is a layer over the Firestore API that
attempts to isolate users from the underlying protocol as far as
possible. You never need to use the protocol buffer messages from
the API, for example. A change to which underlying API version the
package depends on will cause a version bump for the package, but
your code shouldn't need to change unless you've deliberately used
the escape hatch of going down to the version-specific client.

Google.Cloud.Logging.Log4Net is similar in terms of being
version-agnostic, but is intended as an integration point with
Log4Net. Similarly, Google.Cloud.Spanner.Data is an integration
point with ADO.NET.

Google.Cloud.Logging.Type is slightly different: it only contains a
set of "version-agnostic" protocol buffer messages, which we'd
expect to be a dependency of Google.Cloud.Logging.V*n* for any value
of *n*. Packages of this form are relatively rare.
