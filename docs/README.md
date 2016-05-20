## Generating the documentation

The documentation uses [docfx](https://github.com/dotnet/docfx) but
has some tweaks as well.

The documentation is hosted in GitHub Pages, at
https://googlecloudplatform.github.io/gcloud-dotnet. This is
basically a served version of the
[`gh-pages` branch](https://github.com/GoogleCloudPlatform/gcloud-dotnet/tree/gh-pages)
of the main project repo.

# Installation

First install docfx, as per the
[getting started](http://dotnet.github.io/docfx/tutorial/docfx_getting_started.html)
page. We're using DNX (soon to be dotnet cli) so follow step 4 for
the moment.

# Build process

Start in the `docs` directory (the one containing this readme).

- Delete the `site_` directory if it already exists. This is where
  you will end up with output.
- Run `docfx metadata -f`   
  This extracts the XML comment files from
  the projects in the `src` root folder, and builds YAML files in
  `obj/api`.
- Run `dnx -p ../tools/Google.GCloud.Tools.GenerateSnippetMarkdown
run`  
  This finds snippets in the projects in the `snippets` root folder,
  extracts them to text files (in `obj/snippets`) and also generates
  markdown files linking the snippets to the YAML files generated in
  the previous step, so that the API documentation can use the
  snippets as examples.
- Run `docfx build`  
  This builds the `_site` directory from the manually-written content
  (`toc.yml`, `index.md`, `articles/*.md`) and the API documentation.

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
