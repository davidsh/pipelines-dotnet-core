#! /bin/bash

dotnet test tests/dotnetcore-tests/dotnetcore-tests.csproj --logger:trx --results-directory /testresults

# keep running for now
tail -f /dev/null

