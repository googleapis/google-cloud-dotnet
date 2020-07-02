#!/bin/bash

set -e

echo ""
echo "====================="
echo "Before dotnet"
echo "====================="
echo ""

echo "TERM=$TERM"
echo "First run"
dotnet run -p foo

export TERM=dumb
echo "Second run"
dotnet run -p foo

export TERM=xterm-256color
echo "Third run"
dotnet run -p foo

echo ""
echo "============================================="
echo "After dotnet"
echo "============================================="
echo ""
