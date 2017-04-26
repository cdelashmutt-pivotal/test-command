# test-command

An example project to show one way to pass arguments to a process pushed to Cloud Foundry

## Build

1. Clone this repository and `cd` to it.
1. `dotnet restore`
1. `dotnet publish -c release`

## Push the app
.\pushToCF.ps1 -appName foo -options '-c ".\test-command.exe --some args"'