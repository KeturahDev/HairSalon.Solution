# Hair Salon
### By **Keturah Howard**  March 20th 2020

ASP.NET core MVC application using Entity Framework Core and MySQL for a hair salon owner to keep track of their employees and clients. Search for the Stylists working at the Salon and see clients per each stylist. Practice with ASP.NET core MVC with Entity Framework Core and MySQL.

## Specifications:


| Specification | Example Input | Example Output |
| :------------- |:-------------| :-------------------|
| Application opens to a spash page| in terminal of project: *click http://localhost:5000* | browser: *splash page* |
| Ability to Add a new stylist | on splash: *click [Add new stylist]* | browser: *Stylist form displays* |
| List of stylists displays on stylist-form-submit | on form: *click [submit]* | browser: *list of stylists display* |
| Stylists on list page are clickable- show details | on list: *click [stylist]* | browser: *stylist info displays* |
| Ability to Add a new client to stylist | on stylist details: *click [add client]* | browser: *client form displays* |
| clients get added to stylists details | on client form: *click [submit]* | browser: *stylist info displays with new client added to clients list of stylist* |

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/jamisoncozart/Bestaurants
    ```
2. Change directories into the project working directory:
    ```
    cd Bestaurants/Bestaurants
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```

#### Setup Database

4. Run the following commands in MySQL to setup this project Database
    ```
    

    ```
5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* MySQL + MySQL Workbench 8.0.15
* RESTful Routing
* CRUD Functionality
* Git

## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.

## License

Licensed under the MIT license.

&copy; 2020 Keturah Howard.