This is to setup the docker container
```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=NotPassword@123" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

This is to list all images
```bash
docker image ls -a
```
This is to list all containers
```bash
docker container ls -a
```

```bash
docker stop container <container_hash>
```

```bash
docker start container <container_hash>
```

This is the connection string to connect to our MSSQL server

```bash
Server=localhost;User Id=sa;Password=NotPassword@123;TrustServerCertificate=true;
```