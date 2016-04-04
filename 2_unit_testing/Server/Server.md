# Expanse/Server | Group 13
## UNIT TESTS

As of *04.01.2016* the server component of expanse does not have any integration tests written. However, we have laid out several cases that we would like to specify when we do write tests.

#### API Route Verification

1. The server should have three routes defined: the app route, a debug app route, and a server debug route.

2. If the app url is requested with a GET request, it should return the web-app files

3. If the debug app route is requested with a GET request, it should return the web-app file with 

#### GUI Specification Verification

1. The system tray/menubar icon should appear when the program is started

2. The system tray/menubar icon should produce a menu with four options when clicked: **Windows**, **Gestures**, **Options**, and **Exit**.

3. The exit option should quit the program

4. Any of the other options should produce a singleton window
