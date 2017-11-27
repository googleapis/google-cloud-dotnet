# Versioning

## API versioning

API versions appear in the package names of some packages. See the
[package-names.md](package names) documentation for more details of
when this occurs.

The stable releases of APIs only have a major version number (e.g.
V1, V2). Changes made to these APIs within a major version are
always backward-compatible. New functionality is exposed via a new
version (typically minor) of the client library package.

When an API is made publicly available while it is not yet stable,
that is indicated by a suffix on the version number. If this is a
prerelease of a new major version of the API, it is indicated just
by the major version number and a "BetaX" suffix, e.g.
`Google.Cloud.ErrorReporting.V1Beta1`. If it is a prerelease for a minor update
to an existing GA API, this is indicated with both the point release
number and the beta revision of that point release. For example
`Google.Cloud.Vision.V1P1Beta1` is the first beta for the first
point release of the Vision V1 API.

## Package versioning

Packages follow [Semantic Versioning](http://semver.org) - which
sounds simpler than it really is, due to the difficulty of
determining exactly what counts as a breaking change. The rules for
what would count as a breaking change are difficult to document
exhaustively, but the general thrust is described below.

### Major versions

Code which compiles against version 1.0 may not compile against
version 2.0, and if it does, it may no longer work the same way.
Likewise, existing packages with a dependency on version 1.0 may not
work when version 2.0 is present at execution time.

Examples of changes which provoke a new major version:

- Updating a dependency to a new major version
- Adding a new dependency<sup>1</sup>
- Removing or renaming any publicly-accessible API surface member.
  (This includes renaming parameters.)

<sup>1</sup> One exception here is when the dependency is to a brand
new package. The reason that introducing a new dependency introduces
a new major version is that existing code may have a dependency on a
different major version of the same package. While this exception
violates *very strict* semantic versioning, it relieves the
inconvenience of introducing new major versions, with very little
risk of causing problems. Similarly, a new dependency on a system
package (e.g. `System.Threading.Tasks.Extensions`) can be introduced
without provoking a new major version. Both of these would cause a
minor version bump instead.

### Minor versions

Code which compiles aginst version 1.0 should compile against
version 1.1, with the exception of code which compiles but would
never work at execution time<sup>1</sup>. Likewise, existing
packages with a dependency on version 1.0 should work when version
1.1 is present at execution time.

Examples of changes which provoke a new minor version:

- Updating a dependency to a new minor version
- Adding new functionality via new types and type members
- Adding new enum values

<sup>1</sup> This exemption makes it easier to add overloads. A call
to `Foo(null)` can become ambiguous if an overload is added, but if
such code would always have caused an `ArgumentNullException`
anyway, we don't view this as a breaking change.

### Patch versions

Like minor versions, patch versions are backward-compatible - but
additionally, they are *forward-compatible*: code which compiles
against version 1.0.1 should also compile against version 1.0.0. The
dependency resolution of .NET is likely to ensure that this
compatibility is never exposed for packages (so a package with a
dependency on version 1.0.1 will never have to execute in an
environment where only 1.0.0 is present), but if that *does* occur,
that code should work too, unless it relies on the behavioral fixes
between the two patch versions.

Examples of changes which provoke a new minor version:

- Updating a dependency to a new patch version
- Purely internal bug fixes with no change to the exposed API
