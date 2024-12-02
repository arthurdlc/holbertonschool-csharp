#!/bin/bash

# Check if the folder 0-new_project already exists
if [ -d "0-new_project" ]; then
    echo "The folder '0-new_project' already exists. Please remove or rename it and try again."
    exit 1
fi

# Create a new console application project
dotnet new console -o 0-new_project

# Check if the project creation succeeded
if [ $? -eq 0 ]; then
    echo "The project was created successfully."
else
    echo "Failed to create the project."
    exit 1
fi
