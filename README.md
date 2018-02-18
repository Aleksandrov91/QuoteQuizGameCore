QuoteQuiz Game
The project is written on Asp.NET Core v.2.0.1
In solution contains 4 projects. It’s have class library projects for Database context, Database models and for web services. The last project is web project who contains Controllers and Views.
Database is created on model Code-First and contains 3 tables. One table for Question with Yes/No answer, and two for Question with more that one choice. In first table it’s stored questions with their text and author. In other table is stored answers with question Id (One to many relation).
Front end is base on JavaScript to show/hide buttons notifications and validate the question’s answer is right or not.
To run the project: 
1.	check Connection String in “appsettings.json” file of “QuoteQuiz.Web“ project.
2.	Open Package Manager Console and run “Update-Database” on “QuoteQuiz.Data” project to create database.
3.	Restore database from backup file.
4.	Start project (Ctrl + F5) 😊.
