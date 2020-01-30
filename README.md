# bakery-app
A dotnetcore app

<https://www.learnrazorpages.com/> Is the source for this side project

The intent is to walk me through how DotNetCore is working as well as sharpen my skills with Docker

The Docker Content is my own and is used to help with the speed of testing

## Using this repo

I have included a `Dockerfile` and a `docker-compose.yaml`.

All you have to do is make sure you have Docker Desktop for your platform installed

Clone this Repo and run 
```bash
 docker-compose up --build -d
 ```
Then navigate to `http://localhost:8080` and view the page

 To stop the app run

 ```bash
 docker-compose down
 ```


## Createing  web app steps

### Starting with a blank repo 

Will make a new web app with the most recent release of .NetCoreApp which here is v3.0
```Bash
dotnet new webapp -o Bakery
```

You will have to install Entity Framework too 
```Bash
dotnet tool install --global dotnet-ef --version 2.1
```

### Adding a page
```Bash
dotnet new page --name About --namespace Bakery.Pages --output ./Bakery/Pages
```

## Adding a model

You will need to make a new Directory at the root of the project

```Bash
mkdir Models
```
Then you will have to manually add a new C# class inside that new folder 

* PROTIP: you will also have to install the C# Extensions in VSCode


## Installing Entity Framework Core

While SQLLite is a good option,  I like to use more production like systems 

Here we will be using MySQL as the data base

```Bash
dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.18
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet restore
```

## Adding and Registring a Context (DbContext)

* Make a new folder at the root of the project called `Data`
* Make a new Class called `BakeryContext.cs`

## Configure the model

* Make a new folder inside `Data` and name it `Configurations`
* Here is a really importnat thing to remember: If you want to use EntityFramework at RUNTIME in a container you will have to include

```Bash
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.3
```