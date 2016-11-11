Step by Step MVC Project Creation

1. From Tools -> NuGet Packahe Manager -> Manage Nuget Packages for Solution we are downoading EntityFramework
2.In Model Folder we areate a file called Passenger with a class Passenger with several atributes.
3.In Model Folder we create a file called PassengerContext in which we make a context link with the database.
4.We manually create a database with the name PDB from View->SQL Server  Explorer and in the 
tab we open SQL Server -> localdb -> Databases. We right click on Dayabase and we select
Add New Database with the name PDB
5. We add a connecton string within the web.config file that is in the bottom of the solution(and not the one inside Views folder.
6. From Tools -> NuGet Packahe Manager we start NuGet Manager Console
7. In the bottom of the screen we wrie:
-Enable-Migrations
-Add-Migration <name>   (fex Add-Migration InIt)
-Update-Database
..in order to create the table Passengers based on PassengerContext DbSet<passenger> Passengers 
(Migration folder is being created with two files. Configuration.cs and <a big number>InIt.cs)
Now our database has an empty table called Passengers
8. We create HomeController.cs in Controller tab
9. We already have an Index.cshtml within views -> Home and we also create an About.cshtml

...Now just refer to step-by-step explaination within the files...
