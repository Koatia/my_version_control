#!/bin/bash
for dir in "Example001" "Example002" "Example003" "Example004" "Example005" "HomeWork"; do
    if [ ! -d "$dir" ]; then
        mkdir "$dir"
    fi
    pushd "$dir"
    dotnet new console
    popd
done