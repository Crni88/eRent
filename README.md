# eRent

Data Source=localhost, 1433;Initial Catalog=eRent; user=sa;Password=eRent123

--Install Docker Desktop

--Run following command

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=eRentdatabase" --name sqlserver -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest

