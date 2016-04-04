# Expanse | Group 13
## INTEGRATION TESTING

Expanse is comprised of four subsystems - **Virtualization**, **Window Capture**, **Server**, and **Gesture Capture**. These subsystems have been built in parallel and as of *04.01.2016* are not fully integrated.

---

### Virtualization

The folder NetworkTest contains the scripts and assets used to test the cross-system phone-desktop platform we are building on.  To run the tests requires a desktop with Windows Operating System and an Android Phone; no additional software is needed to run the test.

1. Get Android Phone and Desktop connected to the same network.

#### On Desktop:
1. Acquire the IPv4 address by running ipconfig
2. Under `NetworkTest/Build/Windows` run Sync.exe
3. In textfield with `localhost` replace with IPv4 address
4. Click on Lan Server Only(S) to start the server

#### On Phone:
1. Under `Network/Build/Android/` copy demo0.apk to phone
2. Run the application when the transfer is complete
3. Under the `localhost` textfield replace with the same IPv4 address found on the desktop
4. Click on Lan Client(c) to connect to the server

The virtual scene should appear and the phone tilt data should be able to control the camera in the scene.

---

### Server (GUI only)

Currently, no integration tests have been written for the server. However, we have outlined several cases we want to cover under `3_integration_testing/Server/`.

---

### Window Capture

Currently, no integration tests have been written for the window capture program. However, we have outlined several cases we want to cover under `3_integration_testing/WindowCapture/`.

---

### Gesture Tracking

Currently, no integration tests have been written for the gesture tracking program. However, we have outlined several cases we want to cover under `3_integration_testing/GestureTracking/`.
