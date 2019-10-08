#!/bin/bash

set -e

sed -i 's/new LocationName/new V2.LocationName/g' Google.Cloud.Bigtable.Admin.V2.Tests/BigtableInstanceAdminClientTest.g.cs
