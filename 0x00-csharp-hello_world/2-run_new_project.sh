#!/usr/bin/env bash
#creates, builds, and runs new c# project
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run 2-new_project
