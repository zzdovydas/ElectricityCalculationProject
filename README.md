# ElectricityCalculationProject

**Electricity Calculation Project**. This project contains an API that gets the latest consumer electricity usage datasets from [**data.gov.lt**](https://data.gov.lt/dataset/siame-duomenu-rinkinyje-pateikiami-atsitiktinai-parinktu-1000-buitiniu-vartotoju-automatizuotos-apskaitos-elektriniu-valandiniai-duomenys/) and displays electricity usage data to the user through API endpoints. It contains one endpoint that displays all of the data and two more endpoints which return filtered data (by building type and electricity consumption). API also generates database (.db) file, which contains all of the filtered data (plus difference between used electricity and generated), that was returned to the user.

## Technologies used
* .NET 6 Web API
* EF Core
* Sqlite
* Serilog (logging)
* CSVHelper (to process .csv files from data.gov.lt site)
* Swagger (for easy API navigation)

## In future
* Need to write unit and integration tests
* Refactoring
* More in-depth logging
