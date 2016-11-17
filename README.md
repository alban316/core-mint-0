# core-mint-0
Testing dotnet core on Linux Mint 18

# Configuring DotNet Core on Mint 18 (Ubuntu 16.04)
The instructions for Linux at https://www.microsoft.com/net/core include instructions for RHEL only!!!
Nevertheless, the deb packages are referenced at: https://www.microsoft.com/net/download/linux.
The following instructions should work to get setup.

sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list' 

sudo apt-key adv --keyserver apt-mo.trafficmanager.net --recv-keys 417A0893 

sudo apt-get update

sudo apt-get install dotnet-dev-1.0.0-preview2-003175

# Getting Started on Linux
https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-with-xplat-cli

# Installing SQL on Linux 
Technically unrelated to this project, but see the following:
https://www.microsoft.com/en-us/sql-server/sql-server-vnext-including-Linux#resources
