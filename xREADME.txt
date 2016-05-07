# Expanse
**A VR Desktop Visualizer**

Group 13 | Andrew Chan, Allen Tung, Anthony Wong, Dima Koz, Joshua Chan, Marc Tabago, Yue Yang
Software Engineering | Professor Marsic | Rutgers University

---

### Introduction

__Expanse__ is a program for virtualizing your desktop windows in a 3-D, immersive environment. A program on the host computer grabs window screens from your computer, starts a server and allows you to access a 3-d scene with your windows rendered by Three.JS. We currently use the Google Cardboard & a phone as the HMD.

---

### CODE

Expanse is comprised of four subsystems - **Virtualization**, **Window Capture**, **Server**, and **Gesture Capture**. These subsystems have been built in parallel and as of *04.01.2016* are not fully integrated. As such, the code for each subsystem must be run by themselves.

#### Virtualization

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

#### Server (GUI only)

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

---

#### Window Capture

The window capture program is an executable file, which will send streams of data to a server that it successfully connects to. Simply open Win32Project3.exe under the expanse-report/1_code/expanse-window-capture/Debug/ directory.
	
A simple UI will appear, and there will be a text box to input the IP of the server. If the box is left blank, then the program will default to a localhost server. Once the connect button is clicked, streams will be created; one for every window. Each of these streams will be updated every 50 milliseconds, and the data will be sent to the server synchronously. Once the stop button is clicked, no more action may be taken, and the program must be restarted to connect to the server again. 

#### Gesture Tracking

---

### DOCUMENTATION

In the `/documentation` folder, we have included the User Manual, Reports 1-3, our Demo Slides and Brochure, as well as some technical manuals an documenation on specific parts of our code.

---

### TESTS

### UNIT

#### Virtualization

RPCTest.cs, NetworkMenu.cs, and Accelerometer.cs are all built under Unity’s high-level network api.  Thus, many of the small units that a server-client system is built upon such as opening sockets for connecting, testing for client disconnects, thread synchronization are all handled.

Instead these test for proper message sending anyeahd connection.
These scripts can only be run with Unity installed as the debug message will only appear in the unity console.

To run these test, one can load the unity project contained in  `3_integration_testing/NetworkTest` and run the code in the console.  The output of these test should appear in the console in Unity.

RPCTest.cs outputs the rotation matrices passed by the client.  This is used to test proper message passing and retrieval.

NetworkMenu.cs uses Unity’s legacy network build to create and establish and simple server client connection. On a successful connection, the connections count should increment by 1.

Acelerometer.cs reads accelerometer data from the phone and outputs the data on the console similar to RPCTest, however it does not use an RPC call but instead using Unity’s Unet networking system.  Testing both the legacy and Unet systems were necessary to determine the system with the better latency and overhead.


#### Server

We have outlined several cases we want to cover under `3_unit_testing/Server/`, and written a simple test script for connecting to & starting TCP sockets.


### Window Capture

The window capture code contains a debugging functionality built in, to save each window capture as a jpg to the file system in real time. The test would simply by to visually inspect each captured image, and compare it to the user's currently open windows manually. It has been currently disabled, but this functionality has been used to ensure that the correct data is indeed being sent over the stream.

No automated unit tests have been written, but the user may simply test by opening several windows and comparing the pictures generated in the pictures folder to the windows they have open. 

Several test cases may include: 
Opening maximized windows along with minimized windows.
Opening videos. 
Changing window content while the program is running.
Creating overlapping windows.
Minimizing windows, and seeing that the saved picture disappears, as it is supposed to.

A test server has been included, server.js. The streaming functionality may be further tested by starting this server with the console command, "node server.js" while in the unit test directory, assuming node server packages have been installed. Once the server is up, connecting to localhost with the windows snipping application will begin logging on the server side.

### INTEGRATION

#### Virtualization

The folder NetworkTest contains the scripts and assets used to test the cross-system phone-desktop platform we are building on.  To run the tests requires a desktop with Windows Operating System and an Android Phone; no additional software is needed to run the test.

1. Get Android Phone and Desktop connected to the same network.

**On Desktop**
1. Acquire the IPv4 address by running ipconfig
2. Under `NetworkTest/Build/Windows` run Sync.exe
3. In textfield with `localhost` replace with IPv4 address
4. Click on Lan Server Only(S) to start the server

**On Phone**
1. Under `Network/Build/Android/` copy demo0.apk to phone
2. Run the application when the transfer is complete
3. Under the `localhost` textfield replace with the same IPv4 address found on the desktop
4. Click on Lan Client(c) to connect to the server

The virtual scene should appear and the phone tilt data should be able to control the camera in the scene.

#### Server (GUI only)

tcpserver.js is an application written in Node.js to test reliable data sending and recieving between our client subsystems and our web server application.

To run tcpserver.js:
1. You first must have node.js and its subsequent packages that is mentioned in the main readme.txt file
2. To run, type node tcpserver.js in the command line if on Windows.

#### Window Capture

Currently, no integration tests have been written for the window capture program. However, we have outlined several cases we want to cover under `3_integration_testing/WindowCapture/`. 
There are few integration tests for Window Capture in particular, as this subsection does not take input from the other sections. Rather, this subsection only outputs streams of each window.

#### Gesture Tracking

Currently, no integration tests have been written for the gesture tracking program. However, we have outlined several cases we want to cover under `3_integration_testing/GestureTracking/`.


---

### DATA

Our system did not use need any persistent data storage.

---

### Licensing & Copyright

MIT
