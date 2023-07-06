## info about the Reactivities project components
## ----------------------------------------------

## Domain Project: Contains the entities of Reactivities.

## Persistence Project: Implements the EntityFramework Core to manipulate the entities of the Domain.

## Application Project: Contains the business logic of the applciation.
# Using MediatR tool (NuGet) to implement mediator pattern.
# Gets requests from the API, calculate data from DB using DataContext of the Persistence, and sends the results as response back to the API.

## API Project: Contains the controllers which get used to send requests to out Application.
# Using MediatR tool to send requests to our Application.

## client-app: React project which sends requests to read and manipulate domain entities only using the API, which will start the process of getting and setting the data.
# Shows the relevant data to the endpoint user as a SPA (Single Page Applciation).


## Workflow:
# Client (Request) > API (mediatR) > Application (DataContext) > Persistence (EntityFramework Core) > DB (Domain)