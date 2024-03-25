# C#-learning
This repo contains code from [some basic C# training](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oULFjxrOagaERVAMbmG20Xe).

## Requirements
- Install dotnet
- Install C# devkit (in VSCode)

## Start projetc
In terminal, run:
```bash
dotnet new console
```
This will create the necessary files for a basic console project. Then, edit the code in ```Program.cs``` and
```bash
dotnet run
```
to compile and see the results in terminal.

## Strings
Strings are immutable (unless assigned). Using methods such as ```String.Replace``` will return a new string and the original will be intact. Some string methods explored: ```Trim``` and it's variants, ```Replace``` and ```Contain```.