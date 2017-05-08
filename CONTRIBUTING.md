Contributing
============

1. **Please sign one of the contributor license agreements below.**
1. Fork the repo, develop and test your code changes, add docs.
1. Make sure that your commit messages clearly describe the changes.
1. Send a pull request.

Contributor License Agreements
------------------------------

Before we can accept your pull requests you'll need to sign a Contributor
License Agreement (CLA):

- **If you are an individual writing original source code** and **you own the intellectual property**,
then you'll need to sign an [individual CLA][individual-cla].
- **If you work for a company that wants to allow you to contribute your work**,
then you'll need to sign a [corporate CLA][corporate-cla].

You can sign these electronically (just scroll to the bottom). After that,
we'll be able to accept your pull requests.

[individual-cla]: https://developers.google.com/open-source/cla/individual
[corporate-cla]: https://developers.google.com/open-source/cla/corporate

Code Layout
===

The source code is divided into two top-level directories:

- `apis` - main code
- `tools` - tools related to build procedures etc

Within each directory in `apis`, there are potential several subdirectories.

Taking an API of `Google.Foo.V1` as a sample API name, there might be:

- `Google.Foo.V1`: The main client library code
- `Google.Foo.V1.Tests`: Unit tests
- `Google.Foo.V1.IntegrationTests`: Integration tests (calling the real API)
- `Google.Foo.V1.Snippets`: Documentation snippets which are merged with the XML
  documentation when creating the API reference; written as integration tests
- Other tools (e.g. for cleaning test data)

Not all directories will be present for every API.

Running the tests
---

As noted above, there can be several locations for tests of different flavors.
All tests use [xUnit.Net](http://xunit.github.io/). Unit tests do not require
any access to Google Cloud Platform, but the integration tests
and snippet tests require a Google Cloud Platform project with
billing enabled.

**Please note that running the tests exercises the real API
against real Google Cloud Platform projects.** The tests are
designed not to require too much in the way of resources, but you
should be aware that there *is* a cost to exercising APIs. In future
we may run tests against emulators where available. We **strongly**
advise you to use a dedicated testing project (rather than a
project relied on by production systems) to avoid any possible data loss.

To run integration tests with your project, you need to perform some
set-up steps:

- Ensure that your project has the corresponding API enabled in
  the [API Manager](https://console.developers.google.com/apis/library)
- Download and install the [Cloud SDK](https://cloud.google.com/sdk/)
- Run `gcloud auth application-default login` to set up default application credentials,
  or set the `GOOGLE_APPLICATION_CREDENTIALS` environment variable to refer
  to a service account JSON file
- Set the `TEST_PROJECT` environment variable to the name of your project.
  To run the tests from a command line, you can just set them directly
  and run the tests. To run the tests from Visual Studio, you should set
  the environment variable permanently, and restart Visual Studio if
  it's already running.
- Build all the code, either from Visual Studio, or from the command line
  with `dotnet test`

The tests can be run from Visual Studio's built-in test runner
(under the "Test" menu, select "Run" then "All Tests"), or
third-party test tools such as ReSharper and CodeRush, or from the
command line. To run from the command line, change to the project
directory and simply run

    dotnet test

Snippet extraction
---

Code in snippets directories can be marked up to be used in the
API reference documentation. The
`Google.Google.Cloud.Tools.GenerateSnippetMarkdown` tool (in the `tools`
directory) extracts snippets from snippet projects underneath `snippets`.
See the source code (and examples in the snippets) for more details.

Generating documentation
---

See [docs/README.md](docs/README.md).

Code Style
==========

Goals
-----

**Provide idiomatic .NET support for a subset of Google Cloud Platform Services**

The approach taken is client-code-first: "if I wanted to perform a particular
task in C# using Google Cloud Services and I could make the implementation do
whatever I want, what would the API look like?"

This extends to making it as simple as humanly possible to accomplish simple
tasks. More complex or unusual tasks may be harder or even impossible, but we're
heavily biased towards common use cases.

The Google Cloud Services are designed around REST and RPC
principles which allow a lot of flexibility for all scenarios, but
aren't necessarily the simplest way of expressing common goals. The
Google Cloud Libraries for .NET are designed to hide this from
callers, sometimes aggregating multiple requests behind a single
method call.

The libraries often supply several different abstraction layers,
depending on client needs. They are designed to allow application
code to fall back from a higher level abstraction to a lower level
one where more fine-grained control is required. This is usually at
the expense of some of the convenience provided by the higher level
abstraction, but can be performed in a piecemeal way: application
code should be able to use the various abstraction layers together
without ever feeling like changing from one to another is falling
off a usability cliff.
