#!/bin/sh
set -e
dotnet restore
dotnet run --project tesseracs-template.csproj --no-restore
