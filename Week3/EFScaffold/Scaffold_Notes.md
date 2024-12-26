## To scaffold

1. Have EF dependencies.
2. To scaffold run
```bash
dotnet ef dbcontext scaffold "<ConnectionString>" Microsoft.EntityFrameworkCore.SqlServer
```
My example connection string: 
```bash
Server=localhost;User Id=sa;Password=NotPassword@123;Database=master;Initial Catalog=PetsDB;TrustServerCertificate=true;
```
Full command
```bash
dotnet ef dbcontext scaffold "Server=localhost;User Id=sa;Password=NotPassword@123;Database=master;Initial Catalog=PetsDB;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer
```