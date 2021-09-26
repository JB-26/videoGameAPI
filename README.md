### The (all new) Video Game API!
I originally wrote the Video Game API in Python using the Flask framework in early 2021. It works well but I thought I could remake it on a platform that has
- plenty of documentation
- active community
- lots of support

So I went with .NET! This new Video Game API has been developed using .NET 5 in C#.

This repo has the API and a Postman collection so you can interact with it!

You can also view this via Swagger.

Once you have cloned the repo, run 'dotnet run' via the terminal and go to 'https://localhost:5001/swagger/index.html' to view the API!

### Introduction
The model for the API is a VideoGame class which contains the following properties:
- Name
- Publisher
- Developer
- Platform
- Release date
- ID

The Controller calls methods on the Service to add, update, delete and get video games in the API.
