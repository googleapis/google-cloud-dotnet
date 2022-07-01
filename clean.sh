#!/bin/bash

source toolversions.sh

log_build_action "(Start) Cleaning build output"
find apis -name bin | xargs rm -rf
find apis -name obj | xargs rm -rf
log_build_action "(End) Cleaning build output"

log_build_action "(Start) Cleaning docs output"
rm -rf docs/output
log_build_action "(End) Cleaning docs output"