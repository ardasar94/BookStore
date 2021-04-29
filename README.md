First set src/Infrastructure as default project in Package Manager Console
Add-Migration InitialApp -OutputDir Data/Migrations -context Infrastructure.Data.AppDbContext -StartupProject Web
update-database -context AppDbContext

Add-Migration InitialIdentity -OutputDir Identity/Migrations -context Infrastructure.Identity.AppIdentityDbContext -StartupProject Web
update-database -context Infrastructure.Identity.AppIdentityDbContext