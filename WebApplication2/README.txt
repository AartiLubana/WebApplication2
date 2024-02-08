2024-01-18
1402

Project

Steps
Part 1 : Get started
I created a ASP.NET Core Mvc Project.
Part 2 : Add Controller
I learned about controllers ASP.NET Core MVC and follow the steps to create and add a controller to my project.
Part 3 : Add a view
I learned the role of views in MVC architecture and follows the steps to create and integrate a view into my application

Part 4:
Added model
20240125183554_InitialCreate.
I learned about models and how to add them to my MVC application. Models represent the data and businesslogic of an application.
 2024-01-19
2308

Part 5: Work with a Database
I delved into database interactions in ASP.NET Core MVC, connecting the application to a database and performing CRUD operations.

Part 6: Controller Actions and Views
I dived deeper into controller actions and views. I understood how to handle user requests, process data, and display the appropriate views.

##Part 7: Add Search to filter:
I added search button to check records by filter.
Then Navigated to /Movies/Index to displayed filtered movies.
Opened the Views/Movies/Index.cshtml file, and added the form markup to get Title filter option for easy search.

2024-01-26
1530
##Part 8: Add a New Field named Rating:
First I Added the rating Property in Models/Movie.cs. 
Then, Edited the /Views/Movies/Index.cshtml file and add a Rating field inside view templates in order to display.
Updated the SeedData class so that it provides a value in between the genre and price field for the column Rating = "R",
From the Tools menu, selected NuGet Package Manager > Package Manager Console In the PMC, enter the commands : Add-Migration Rating
Update-Database to examine the current Movie model.

Then I have varied the functionality of filter option by filtering bollywoord movies name, rating and genre.

2024-01-31
2110
##Part 9: Add Validation:
I have applied validation to confirm data accuracy by ensuring user input and handling validation errors.
to examine the current Movie model.
Confirmed that in the Movie class, attributes such as Required, StringLength, RegularExpression, Range and the DataType exist.
In Next step I updated existing movie list with my 2 top most favorite Bollywood pictures.

2024-01-31
2158
##Part 10: Examine Details and Delete methods:
To ensure data accuracy, I applied validation by adding attributes such as Required, StringLength, RegularExpression, Range, and DataType to the Movie class.
I updated the movie list with my top two favorite Bollywood pictures. 



Part 10: Examine Details and Delete:
I explored the details view and deletion functionality, understanding how to display detailed information and allow users to delete records.
I also verified the filter options by filtering Bollywood movies based on name, rating, and genre.

