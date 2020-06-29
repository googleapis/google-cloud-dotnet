# Devsite DocFX Templates

The output `toc.html` file should be renamed `_toc.yaml`.

The `docfx.json` file needs some extra config:

```
"globalMetadata": {
    "_appTitle": "Google.Cloud.Dialogflow.V2",
    "_disableContribution": true,
    "_appFooter": " ",
    "_disableNavbar": true,
    "_disableBreadcrumb": true,
    "_enableSearch": false,
    "_disableToc": true,
    "_disableSideFilter": true,
    "_disableAffix": true,
    "_disableFooter": true,
    "_rootPath": "/dotnet/docs/reference/dialogflow"
},
"template": [
    "default",
    "devsite_template"
],
```

Note: the `_appTitle` property and the last part of the `_rootPath` property
should be updated with the product. This is used to generate the TOC.

## Updating and diffs

This was based on the `default` template. You can export it by running
`docfx template export default`. Run `diff` on any files to see how they were
changed. A high level summary:

* The `docfx.json` config above disables many of the default features (e.g. the
  TOC on the left side of every page).
* Added the `devsite` attribute to the `html` element.
* Removed the `h1` titles from class and namespace pages.
* Bumped headers up one level (e.g. `h4` -> `h3`) for class and namespace pages.
  This makes the right nav work properly.
* `toc.html` actually results in YAML and should be renamed to `_toc.yaml`.

## Disclaimer

This may change at any time in backwards incompatible ways and is not intended
for general use.