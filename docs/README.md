## Generating the documentation

The documentation uses [docfx](https://github.com/dotnet/docfx) but
has some tweaks as well.

The documentation is hosted in GitHub Pages, at
https://googlecloudplatform.github.io/google-cloud-dotnet. This is
basically a served version of the
[`gh-pages` branch](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/tree/gh-pages)
of the main project repo.

# Installation

First install docfx, as per the
[getting started](http://dotnet.github.io/docfx/tutorial/docfx_getting_started.html)
page. We're using DNX (soon to be dotnet cli) so follow step 4 for
the moment.

# Build process

Start in the `docs` directory (the one containing this readme). On
Windows, you can now run `builddocs.bat`, which goes through the
following steps:

- Deletes temporary/output folders (`external`, `obj`, `_site`)
- Fetches source for external projects which should be documented in
  the same set of reference documentation (e.g. GAX)
- Extracts the metadata from the source code using `docfx`
- Extracts the snippets from the `snippets` directory for use in
  the site
- Builds the site into `_site`.

# Testing

Check that the site looks how you want it to by asking docfx to
serve it on your local machine:

```sh
docfx serve _site --port 12345
```

... then browse to http://localhost:12345 (or whatever port you
specified).

# Deployment

- Check out the `gh-pages` branch.
- Delete everything in it other than the `.git` directory.
- Copy the content of the `_site` directory.
- Commit all changes.
- Push to github.

(Of course, this requires push access to the repository.)

If you want to see how it looks in github but not affect the main
documentation yet, you can push to the `gh-pages` branch of your
clone, after going through the normal
[GitHub pages setup](https://pages.github.com/).
