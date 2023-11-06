# Sample MVC

## dotnet ef

Model クラスを自動生成する。

```shell
dotnet ef dbcontext scaffold "Server=localhost,1433;TrustServerCertificate=True;Database=mvcdb;User ID=sa;Password=yourStrong@Password" Microsoft.EntityFrameworkCore.SqlServer -o Models
```