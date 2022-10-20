ToyRobot Kata by Ian Richards

The application is a simulation of a toy robot moving on a square table top, of dimensions 5 units x 5 units. There are no
other obstructions on the table surface. The robot is free to roam around the surface of the table, but must be prevented
from falling to destruction. Any movement that would result in the robot falling from the table must be prevented,
however further valid movement commands must still be allowed.

Create a console application that can read in commands of the following form -

- PLACE X,Y,F
- MOVE
- LEFT
- RIGHT
- REPORT

PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST. The origin (0,0)
can be considered to be the SOUTH WEST most corner. It is required that the first command to the robot is a PLACE
command, after that, any sequence of commands may be issued, in any order, including another PLACE command. The
application should discard all commands in the sequence until a valid PLACE command has been executed.

MOVE will move the toy robot one unit forward in the direction it is currently facing.

LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.

REPORT will announce the X,Y and F of the robot. This can be in any form, but standard output is sufficient.

A robot that is not on the table can choose to ignore the MOVE, LEFT, RIGHT and REPORT commands.

Input can be from a file, or from standard input, as the developer chooses.

Provide test data to exercise the application.

It is not required to provide any graphical output showing the movement of the toy robot.

The application should handle error states appropriately and be robust to user input.

# Constraints:

The toy robot must not fall off the table during movement. This also includes the initial placement of the toy robot. Any
move that would cause the robot to fall must be ignored.

# Instructions:

This project has been developed using [dotnet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
You will need to download and install the dotnet 6 runtime and sdk if you wish to run and/or develop the kata further

The main project and tests can be found in the solution folder.

To run the tests you should be able to load up the project in your chosen IDE and run the tests from the Game_Tests file using a test runner that runs NUnit test. I would recommend Visual Studio 2022 as this has support for dotnet 6.

I have use NUnit for testing as this is a testing framework I am familiar with.

To run the project you must first build this project using an IDE of your choice (or Visual Studio 2022) that supports C# .Net and dotnet 6.

Once built you can either run the project using your IDE of choice or via the EXE the can be found within the solution at this location - ToyRobot\ToyRobot\bin\Debug\net6.0
