# MYSQL_ScriptExec
Utility to execute MySQL scripts or multiple scripts from text file.

[Screenshot](ScreenShots/Main.PNG)

Initially, a connection must be established to and database.  You can optionally specify a database that does not
exist, and by checking the 'created if does not exist' checkbox, the system will created and empty database.  Otherwise, a non-existent database will
result in an error message.

[Screenshot](ScreenShots/Login.PNG)

If desired, MySQL_ScriptExec runs can be logged to a table for review in the LogMaintenance page:
[Screenshot](ScreenShots/LogMaintenance.PNG)

Options are set on the options page:
[Screenshot](ScreenShots/Options.PNG)



This utility is based on a SQL Server utility created by [Roman Rehak](http://sqlblog.com/blogs/roman_rehak/).



Example folder contains sample text files and scripts to demonstrate how to format them for execution.   The samples use the MySQL 'world' schema.
