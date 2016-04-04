# Expanse | Group 13
## UNIT TESTING

Expanse is comprised of four subsystems - **Virtualization**, **Window Capture**, **Server**, and **Gesture Capture**. These subsystems have been built in parallel and as of *04.01.2016* are not fully integrated.

---

### Virtualization

RPCTest.cs, NetworkMenu.cs, and Accelerometer.cs are all built under Unity’s high-level network api.  Thus, many of the small units that a server-client system is built upon such as opening sockets for connecting, testing for client disconnects, thread synchronization are all handled.

Instead these test for proper message sending and connection.
These scripts can only be run with Unity installed as the debug message will only appear in the unity console.

To run these test, one can load the unity project contained in  `3_integration_testing/NetworkTest` and run the code in the console.  The output of these test should appear in the console in Unity.

RPCTest.cs outputs the rotation matrices passed by the client.  This is used to test proper message passing and retrieval.

NetworkMenu.cs uses Unity’s legacy network build to create and establish and simple server client connection. On a successful connection, the connections count should increment by 1.

Acelerometer.cs reads accelerometer data from the phone and outputs the data on the console similar to RPCTest, however it does not use an RPC call but instead using Unity’s Unet networking system.  Testing both the legacy and Unet systems were necessary to determine the system with the better latency and overhead.

---

### Server

Currently, no unit tests have been written for the server. However, we have outlined several cases we want to cover under `3_unit_testing/Server/`.

---

### Window Capture

The window capture code contains a debugging functionality built in, to save each window capture as a jpg to the file system in real time. The test would simply by to visually inspect each captured image, and compare it to the user's currently open windows manually. 

---

### Gesture Tracking

---
