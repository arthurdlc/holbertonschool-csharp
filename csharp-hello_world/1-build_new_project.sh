#!/usr/bin/env bash

#check if the project 1-new_project already exists
if [ -d "1-new_project" ]; then
    echo "The folder '1-new_project' already exists. Please remove or rename it and try again."
    exit 1
fi

# Create a new console application project
dotnet new console -o 1-new_project