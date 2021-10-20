# Dr. Sillystringz Factory

#### An application that allows the user to log engineers and machines in a made up factory.

#### Created By: Brandon Eads

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* EF Core

## Description

This application allows the user to create a database of engineers and machines in a factory. The application represents a many to many relationship in which you are able to assign multiple engineers to the same machine and vice versa. The home page displays a list of all current engineers and machines that are being logged in the database. There are also options to view the lists serparately and edit each entity.


## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/beads89/factory-project) repository, or download and open the Zip on your local machine
* Open the Factory.Solutions folder in your preferred text editor
* To install required packages, navigate to the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef
* Create a file named "appsettings.json" in the Factory directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=brandon_eads;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database, navigate to the terminal and type the following command:
  - dotnet ef database update
* To Restore, build, and run the project:
  - Navigate to the Factory.Solutions/Factory folder in the command line or terminal
    - Run the command "dotnet restore" to restore the project dependencies
    - Run the command "dotnet build" to build and compile the project
    - Run the command "dotnet run" to build and compile the project

## Known Bugs

* no known bugs

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Brandon Eads

## Support and contact details

* [Brandon Eads](github.com/beads89) <Brandon181989@hotmail.com>