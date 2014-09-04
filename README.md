##Doctor-Who-Wallpaper-Changer

============================



C# program that changes wallpaper every hour to represent the doctor that relates to the hour.



###How to use

----------



The program does not run by it's self and requires a windows task to be created in order to change the wallpaper on time.


To do this, Download the zip file in the [dist](dist/) folder of the repository. Extract the folder somewhere on your computer and note where it was extracted.

open the Control Panel and select *Adminstrative Tools* then *Task Scheduler*.

On the right, under the Actions menu double click the *Create Task* item.

Enter a name for the task and set the radio button in the security options group to *Run whether user is logged on or not*.

Go to the Triggers tab. Select *New...* and set the task as follows...

- Daily
- Start date (default)
- Time (set to next hour so it runs from then. NOTE: Add a minute or two to make sure it runs within the hour, else it won't change correctly.)
- Repeat task every 1 hour
- Indefinetly

Select *Ok* and move to the Actions tab.

Select *New...* and browse to the exe location from the zip file. If you want to include the War Doctor in the wallpaper (always dim) add the argument `-WarDoctor` to the arguments box.

Select *Ok* and then select *Ok* on the create task window and your task should be created!!


#####To Do:
Create propper documentation with visual aids.
Add command line flag for wallpaper style (stretch, fill, e.t.c.)
