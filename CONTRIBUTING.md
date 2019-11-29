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
* Deploy the latest SDE from [fuzzworks](https://www.fuzzwork.co.uk/dump/postgres-schema-latest.dmp.bz2.md5)
    * Create a database in postgres called sde and restore the latest SDE
* Create a database called navigator
    * Apply the navigator context migration to setup the schema for the website DB to the navigator database
```bash
    dotnet ef database update --project Navigator\Navigator.csproj --context NavigatorContext
```
* Restore nuget packages and fire up

