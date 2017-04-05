As suggested by the name of this package, this contains experimental
features. The namespace of all the types in this package is the
same as the namespace of the types in the stable
`Google.Cloud.Language.V1` package; the expectation is that users
will only use this package if they wish to use experimental
features. You should *not* depend on both this package and the
non-experimental one.

Code which worked with the non-experimental package should be valid
for the experimental package. As new features become mature and the API
is stabled, the non-experimental package will gain those features...
but there may be changes to experimental features either between
versions of the experimental package or as the features move into
the non-experimental package.

This package will *always* be a prerelease package, to make this
potential API instability clear.

Note: the very existence of this package is also somewhat unstable.
We are still experimenting with the best way of giving early access
to new API features.
