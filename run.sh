#! /bin/bash

dotnet test tests/dotnetcore-tests/dotnetcore-tests.csproj --logger:trx --results-directory /testresults
exit 0

# keep running for now
#tail -f /dev/null

