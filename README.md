This application can be used when exploring dll injection with a fat client application.
When trying to exploit a dll injection one has to find writable folders on the machine.
Traditionally you"ll open Process Monitor from sysinternals to figuere out in which directories/folders the application tries to load load certain DLL"s.
Usually you'l do that by filtering on those events that have a result'PATH NOT FOUND'.
Export all the folders from Process monitors with 'path not found' to a CSV file and open this one in Excel. In Excel, select the column containing all the folders and paste them in the textbox of the 'CheckWritableDirs.exe" application. 
Hit the start button to see the results.
