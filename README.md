First set src/Infrastructure as default project in Package Manager Console
Add-Migration InitialApp -OutputDir Data/Migrations -context Infrastructure.Data.AppDbContext -StartupProject Web
update-database -context AppDbContext

Add-Migration InitialIdentity -OutputDir Identity/Migrations -context Infrastructure.Identity.AppIdentityDbContext -StartupProject Web
update-database -context Infrastructure.Identity.AppIdentityDbContext

#Scaffold Identity Through CommandLine
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator identity -dc Infrastructure.Identity.AppIdentityDbContext --files "Account.Register;Account.Login"