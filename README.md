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

```Bash
dotnet new webapp -o Bakery
```

### Adding a page
```Bash
dotnet new page --name About --namespace Bakery.Pages --output ./Bakery/Pages
```