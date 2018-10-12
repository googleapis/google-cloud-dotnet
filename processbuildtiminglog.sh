#!/bin/bash

echo ----------------
echo Build timing log
echo ----------------
dotnet run -p tools/Google.Cloud.Tools.ProcessBuildTimingLog -- build_timing_log.txt
