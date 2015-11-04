# Menu Item Sum Display
Written by John Hagan

Given a JSON string which describes a menu, calculate the SUM of the IDs of all "items", as long as a "label" exists for that item.

A console application written in C# using Visual Studio 2010. This also includes a testing project using NUnit.

Please press the download zip button to get the latest version of code. The solution file can be used to open the application in Visual Studio. In the properties of the Json Parser project you must add the file path of your json file in the command line arguments. After this has been added you can run the code and the Sums will be displayed on the console.

The way the code has been written right now it will display the sums of all ids menus in the json file, but is flexible enough to be able to implement your own display class and swap the new implementation out in the unity container.



