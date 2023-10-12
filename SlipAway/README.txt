						2023-10-10 14:30 EST
Created the Repo
Created the README file
Choose the Name SlipAway for my products (Slippers)
Lets Go
-----------------------------------------------------

14:44 Comment out the port number in launchSetting.json as iam working in the computer lab

14:45 Checked out the website if its working by clicking CTRL F5 - the white Vanilla website is working, thats a good start

14:46 Updated the title of the project page to reflect my fictional company name

15:07 downloaded couple of pictures i can use commercially from pexels.com

15:09 Commented out the learn more - I might use it later

15:36 Been trying to add a background img but its not working, tried it in HTML and CSS

_____________________________________________________
                        2023-10-11
01:10 Background image worked, but I changed it so the user can see the footer menu
I belive the website already look better now- Im pushing the changes to github and will finish it tomorrow.

-----------------------------------------------------

12:50 cleaned the code, rebuild it and test it again. its working

12:57 Added the about us page controller to HomeController.cs
12:58 Adding the about us view under the home directory
13:04 Updating the Navigation bar
13:07 ERROR 404 on the about us page, and on the nav bar is showing home instead oh about us :s
13:16 I found the error message, it was a space in AboutUs 
13:19 Lets add the content of About us.
14:15 the web pages are ready to go, now we need to go to and seed the data

-----------------------------------------------------

14:22 Added the class product.cs to the Models Directory and defined the getters & Setters for the required 6 attributes ProductId, Name, Description, Price, Category, ImageUrl, and CustomerReview
14:26 Add NuGet Package using the following command Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.5
14:46 Defined the product Context by creating the product model abd new class called it SlipAwaycontext
14:48 Modifying the startup.cs with the necessary libraries using SlipAway.Data;  using Microsoft.EntityFrameworkCore;
14:50 Adding the configuration services method to startup.cs services.AddDbContext<SlipAwayContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("SlipAwayContext")));

14:59: added the connection to appsetting.json   "ConnectionStrings": {
    "SlipAwayContext": "Server=(localdb)\\mssqllocaldb;Database=SlipAwayContext-1;Trusted_Connection=True;MultipleActiveResultSets=true"
  }

15:16 scaffolded the SlipAway Pages
15:17 initiate the migration feature by entering the following commands Add-Migration InitialCreate
Update-Database

taking a break

-----------------------------------------------------

20:01 editing the startup file with the dependency injection
11:30 Creating Seed Data model 
12:00 still adding products and finding pictures i can use commercially :s

_____________________________________________________

                        2023-10-12
14:15 Adding new seeds
14:38 Finished seeding the data, and I got an unhandled exception occured - InvalidOperationException: The layout view 'Controllers/HomeController.cs' could not be located. The following locations were searched: /Views/Products/Controllers/HomeController.cs.cshtml /Views/Shared/Controllers/HomeController.cs.cshtml
14:46 Forgot to change the layout from the homeController to _layout. Done and now its working 
14:47 Experienced issues with startup.cs, the class can not access SeedData.cs Error CS0103 'SeedData' does not exist in the current context	SlipAway	Startup.cs	Line 58
14:56 Found the issue, I forgot to add SlipAway.Models library in the top
14:59 Product Page is working now but ofc Edit, Details and Delete buttons are not working, throw errors - InvalidOperationException: The layout view 'Controllers/HomeController.cs' could not be located. The following locations were searched:
/Views/Products/Controllers/HomeController.cs.cshtml
/Views/Shared/Controllers/HomeController.cs.cshtml

15:12 I need to change the layout again for the CRUD Pages  but its working, I edited and I deleted data from the database
17:07 Added the Product page to my navigation bar
18:12 Started adding the search feature to my website, just updated the index method inside the product controller. Spent 30 mins on an error with the db set. I typed context.SlipAway instead of context.Product :s




