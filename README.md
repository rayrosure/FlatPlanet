# FlatPlanet

SCENARIO : 
“Please write an MVC web application that will have one button, which upon clicking would increase a counter visible on the screen. The user should not be able to increase the count beyond 10. You will need to store the counter information in an SQL database. Please provide all the files/artefacts you produced while working on this application. Please provide all the files/artefacts necessary for successful installation and running of this application.

NOTE: 
Initial load will make database file (.mdf and .ldf) and will take a short while before loading the page. It uses EF Code first approach.

DELETE DATABASE:

To delete the database for testing purposes, please run the following command in command prompt:

sqlcmd -S (localdb)\MSSQLLocalDB -E -d master -Q "DROP DATABASE [FlatPlanet]"

then re run the application will create a new database files.
