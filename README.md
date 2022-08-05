# masstransit-saga-test
## Overview
A test project that creates a BuyItem saga and stores its data in PostgreSQL DB.
## How to run
- `cd docker` and `docker-compose up`. This will run containers with Rabbitmq and PostgreSQL.
- Open `MicroservicesWithSagas.sln` and run multiple projects, or you can execute 'dotnet run' for each project in the solution.
- Navigate to `http://localhost:5063/swagger` and send a buy request.
## ToDo
- Add a Docker image for each microservice and update docker-compose.yaml.
