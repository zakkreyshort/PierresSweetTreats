# _Pierres Bakery_

#### _Epicodus independent project week 5_, _27 March 2020_

#### By _**Zakkrey Short**_

## Description

_This website is for bakery manager to add products to their list of treats, then add flavors. Clients can go in and view types of treats with their concurrent flavors._

## Specifications: 

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates instance of an Treat object | Treat newTreat = new Treat(name) | new Treat object created |
| Application saves all new treats in database table named treats | new treat object instantiated | new treat object saved as row in database table |
| If user visits '/' root route, applications displays splash page with link to '/treats' | user visits '/' route | displays homepage |
| If user visits '/treats' route, applications displays all treats in database, each with a link to view more details about the treat and ordered alphabetically by type | user visits '/treats' route | displays list of treats |
| If user clicks "add new treat" button, application redirects to new treat form | user clicks "add new treat" button | application redirects to new treat form |
| If user visits '/treats/new', application shows new treat form | user visits '/treats/new' | application displays form for adding new treat |
| If user visits submits new treat form, application adds new treat to database and redirects to '/treats' | user submits form | application adds new treat to database and redirects to page showing all treats in database |
| If user visits '/treats/{id}', application displays details for that treat | user clicks on specific treat in treats list | application redirects to display details about that treat |
| Website will ask for authorization when visiting '/flavors/add' | User selects view flavor | Website will redirect to authorization sequence |
| If user visits '/register/', website will go to create account|User clicks create account  | Website will bring up registration form for admin |
| If user enters info and is authorized, will redirect to '/flavors/add'| User entered in correct login info | Website redirects to add flavors |
## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd PierresSweetTreats``

_Confirm that you have navigated to the PierresSweetTreats directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd Pierres``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef migrations add Initial``
* ``dotnet ef database update``
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC 2.2_
* _dotnet script_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Zakkrey Short_**