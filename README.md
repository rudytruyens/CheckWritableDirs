This application can be used when exploring dll injection on a fat client application.

If you have acquired a list of folders that you want to check for write permissions for the current user, then paste them in the first textbox of this application and hit start.

Get a list of directories/folders using Procmon.exe:
When trying to exploit a dll injection one has to find writable folders on the machine.
Traditionally you'll open "Process Monitor" (procmon.exeà from Sysinternals to figure out in which directories/folders the application tries to load certain DLL's.
Usually you'll do that by filtering on those events that have a result 'PATH NOT FOUND'.
Export all the folders from procmon with 'path not found' to a CSV file and open this csv in Excel. In Excel, select the column containing all the folders and paste them in the textbox of the 'CheckWritableDirs.exe" application. 
Hit the start button to see the results.


