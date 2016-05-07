    -	
    |
    +--+--> 1_code          // project code
       |
       +-------> GestureTracking     // GestureTracking Source Code
       |
       +-------> Server  // Server Source Code
       |
       +-------> Virtualization   // Virtualization Source Code
       |
       +--+--> WindowCapture      // WindowCapture Source Code
       |
       +--+--> Win32Project3          // project code
       	  |
          +--+--> Win32Project3          // project code
       	     |
             +-------> Win32Project3  // .cpp source code files. Main program win32project3.cpp
    	     |
             +-------> Debug   //Contains Debug files and executable for debugging  
    |
    +-----> 2_unit_testing        // unit tests for the project code (and any other tests)
    |
    |
    +-----> 3_integration_testing  // integration tests for the project code (and any other tests)
    |
    +-----> 5_documentation        // documentation plus Report #3, presentation slides, etc.
    
    Expanse is comprised of four subsystems - **Virtualization**, **Window Capture**, **Server**, and **Gesture Capture**. These subsystems have been built in parallel and as of *04.01.2016* are not fully integrated. As such, the code for each subsystem must be run by themselves.

---

### Virtualization

The virtualization engine is a web-app accessible from mobile browsers, powered by [three.js](http://threejs.org). It requires a bare-bones server infrastructure to run.

You'll need [Node.JS and NPM](https://nodejs.org/en/) to run this subsystem. Make sure those are installed on your system (v4.4.2+ LTS or v5.0.0+ are fine), then follow the steps below. You will be working in the terminal.

1. Open a terminal (or command prompt) in the `1_code/Virtualization` folder.

2. Install the required packages by running:
```
$ npm install
...
$ bower install
```
	Grant the permissions necessary if you've been asked - the packages will be installed locally under the `node_modules` directory, not to any system-wide folder like `usr/local` or `C:\Program Files\`. 
	
3. Run the server:
```
$ npm start
```
	This will start the server. It should start the server on `0.0.0.0:3000`, where the `0.0.0.0` means it is publicly accessible (from a device other than itself) and where `3000` is the specific port of that application.

4. Identify your external ip address.

	There are many ways to do this, but the simplest is to google *"what is my ip"*, and Google will tell you what your external IP address is.
	
5. Access the web-app.

	On your phone, navigate to `your.ip.addr.ess:3000` to see the virtualization engine running. If you have a Google Cardboard, this is the time you would slot it in. Otherwise, you can move your phone around and pretend it's a viewfiender, and you should be able to see the scene change as you manipulate your phone.

---

### Server (

As of *04.01.2016*, the only functional component of the server is the GUI.
Update: As of 05.07.2016, the server is functional and requires a new package [socket.io]

You'll need [Node.JS and NPM](https://nodejs.org/en/) to run this subsystem. Make sure those are installed on your system (v4.4.2+ LTS or v5.0.0+ are fine), then follow the steps below. You will be working in the terminal.

1. Open a terminal (or command prompt) in the `1_code/Server` folder.

2. Install the required packages by running:
```
$ npm install
```
	Grant the permissions necessary if you've been asked - the packages will be installed locally under the `node_modules` directory, not to any system-wide folder like `usr/local` or `C:\Program Files\`. 
	
3. Run the program:
```
$ npm start
```
	This will start the server GUI. You should see a black goggle icon in the System Tray on Windows or in the Menu bar of OSX - it may blend into the background if you're using a dark theme.
	
You can use the program by right-clicking on the icon, which will display a menu. Clicking on any of the corresponding menu items will create the window if it doesn't exist, or focus the window if it does. None of the controls are functional, but the layout is mostly complete.

Installing Socket.io
1. After performing the above and ensuring node.js is installed one can begin installing the Socket.io package
2. To install Socket.io simply type npm install socket.io in the command line
---

### Window Capture

The window capture program is an executable file, which will send streams of data to a server that it successfully connects to. Simply open Win32Project3.exe under the expanse-report/1_code/expanse-window-capture/Debug/ directory.
	
A simple UI will appear, and there will be a text box to input the IP of the server. If the box is left blank, then the program will default to a localhost server. Once the connect button is clicked, streams will be created; one for every window. Each of these streams will be updated every 50 milliseconds, and the data will be sent to the server synchronously. Once the stop button is clicked, no more action may be taken, and the program must be restarted to connect to the server again. 

---

### Gesture Tracking
