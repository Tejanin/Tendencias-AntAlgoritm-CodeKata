


# End-User Document
## Index
 -   Installation and User's Manual


## Installation and User's Manual

**Windows**

1. Download .NET from the official .NET Core website.
2. Type "Edit environment variables" in the Windows search bar.
3. Then click on the "Environment Variables" button.
4. Edit the PATH variable to add the .NET SDK path. The path is: C:\Windows\Microsoft.NET\Framework64\v4.0.30319
5. Save the changes and open the command prompt (cmd).
6. Navigate to the directory where the Program.cs file of the app is located.
7. Run the command:


 

       csc Program.cs

 8. The program will compile and return the executable in the same directory.

**Mac**

Resuming from step 2:
2- After installing .NET, run the command::

    dotnet build

in the application directory to compile it.
3- Run the command 

    dotnet run
  to execute the .exe file.




