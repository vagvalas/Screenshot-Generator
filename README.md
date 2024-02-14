# Screenshot-date-time-Generator

Is a program for a specific (but can be adjusted to be multi-purpose) thats it's linked to this repo https://github.com/vagvalas/Reports-Creator as it has a 
relation to the final goal.

## Purpose
Is to use this software to create realistic screenshots of a class or a meeting (needed for logs) along a very big period of time, from a starting date till the end 
of a class. The software tries to re-create a zoom meeting or a teams meeting, by just changing the content of the presented-teacher screen and the time on right bottom
of Windows 10.

## Usage

It uses a "Segoe UI Semilight" font (that is the exact variation of Win10 to generate dd-mm-yyyy and hh-mm to print them on the png screenshot.
All other stuff is generally modifiable.

![εικόνα](https://github.com/vagvalas/Screenshot-Generator/assets/19560574/8db09d08-9081-447a-b5e3-e129c6f01a7f)

1. This will be a static image that will *NOT* irritate among /per day loops.
2. This folder will contain the source of base images (as per presenter window share screen view) and will go as 1-1 by per hour as along with dates.
    So for example a date from 10-01-2024 to 11-01-2024 from 10:00 to 12:00 with 3 screenshots/ day it will go like:
```
     The First alphabetically order png inside source (2) folder will go to 
      10-01-2024 10:00 Image1.png
      10-01-2024 11:00 Image2.png
      10-01-2024 12:00 Image3.png
      ...
      11-01-2024 12:00 Image6.png
```
3. Starting Date and Ending date is obvious
4. /PER DAY details
5. Irritations /per day, careful! For this example above this number must be 3! and the software itself will calculate that it needs to generate 3 screens at correct
   hours among /per day for *each* date.
GO!

## To be added

1. Ability that can also add mutliple image sets to be irritated among dates
2. The ending date must have a check to not be before start date (so the fields has to be linked)
3. Better UI maybe/ windows snapping on resing 🤓
4. BUG fixing
5. an app icon

## Known bugs

Don't mess a lot , it has no checks for logical errors, eg. dont click GO, or other buttons than corresponding order (that's gonna be fixed in v1.0)
1. If the range of source image (2) base images is more than irritations it will CRASH (also it will be fixed in v1.0)
