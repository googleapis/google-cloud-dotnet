{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

Common operations are exposed via the
[BigtableClient](obj/api/Google.Cloud.Bigtable.V2.BigtableClient.yml)
class.

# Client life-cycle management

For the alpha version, each client will create its own set of underlying
channels by default, so we advise you to reuse a single client object if
possible. In later versions, we plan to have clients share default
credentials by default, so it will be possible to create new clients cheaply
as needed.

# Sample code

[!code-cs[](obj/snippets/Google.Cloud.Bigtable.V2.BigtableClient.txt#Overview)]
