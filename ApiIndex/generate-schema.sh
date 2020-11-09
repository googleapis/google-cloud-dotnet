#!/bin/bash

# TODO: Install protoc instead of relying on it being installed
# already.
$PROTOC -I. --csharp_out=. index.proto
