# bakery-app
A dotnetcore app

## Using this repo

I have included a `Dockerfile` and a `docker-compose.yaml`.

All you have to do is make sure you have Docker Desktop for you platform installed

Clone this Repo and run 
```bash
 docker-compose up --build -d
 ```

 To stop the app run

 ```bash
 docker-compose down
 ```


## Create web app

```Bash
dotnet new webapp -o Bakery
```