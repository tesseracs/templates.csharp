#!/bin/sh
set -e
dotnet restore
dotnet run --no-restore
