# Contributing

This document will outline what is needed on a machine to start working on Eve Navigator.

# Software

Versions are correct at time of writing

* Install [Postgres](https://www.postgresql.org/download/) V 12.0.1
* [Create](https://developers.eveonline.com/applications/create) a developer key on the eve developer site
* Create a secrets.json with the following format alongside the Navigator.csproj

```json
{
  "ClientID": "***YOURCLIENTID***",
  "SecretKey": "***YOURSECRETKEY***",
  "SdeConnectionString": "User ID=postgres;Password=PASSWORD;Host=localhost;Port=5432;Database=sde;Pooling=true;",
  "NavigatorConnectionString": "User ID=postgres;Password=PASSWORD;Host=localhost;Port=5432;Database=navigator;Pooling=true;"
}
```
* Deploy the latest SDE from [fuzzworks](https://www.fuzzwork.co.uk/dump/postgres-schema-latest.dmp.bz2)
    * Create a database in postgres called sde and restore the latest SDE
* Create a database called navigator
    * Apply the navigator context migration to setup the schema for the website DB to the navigator database
```bash
    dotnet ef database update --project Navigator\Navigator.csproj --context NavigatorContext
```
* Restore nuget packages and fire up

# Updating SDE

When CCP releases a new version of the SDE, you will need to update the database in postgres and _potentially_ 
update the DAL.

```sql
	DROP DATABASE sde
```

Rebuild the models

```bash
dotnet ef dbcontext scaffold "Host=localhost;Database=sde;Username=USERNAME;Password=PASSWORD" Npgsql.EntityFrameworkCore.PostgreSQL -o SDE --project Navigator.DAL\Navigator.DAL.csproj --context-dir . -f -c TranquilityContext                    
```

Once the models have been rebuilt, carefully check the change set as the TranquilityContext will need to be adjusted after the scaffolding has run

# Altering Navigator Models 

Create the entities you want to store in Navigatoor.DAL\Navigator folder

From the repository root at the command line:

```bash
dotnet ef migrations add SOMENAME -s Navigator\Navigator.csproj -p Navigator.Migrations\Navigator.Migrations.csproj --context NavigatorContext  
dotnet ef database update -s Navigator\Navigator.csproj --context NavigatorContext  
```