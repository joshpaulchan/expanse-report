Setting up gesture tracking (assuming you are using classic xbox360 kinect; procedure undefined for new kinect model)
Please make sure you find the following in the folder:

folder: code (the program code)
folder: drivers (drivers needed to create Kinect sensor connectivity)
txt: license
application: nite-bin-win...
application: OpenNI-Bin...
application: SensorKinect...

The three applications are open-source programs to help unlock and enhance the capabilities of the Kinect sensor.

Steps:
1. Uninstall any preexisting Kinect-related drivers, or SDK v1.8 or lower.
2. Install OpenNi, following on-screen instructions.
3. Install nite-bin-win..., using the license key provided in license.
4. Install SensorKinect..., following on-screen instructions.
5. Restart your computer, then open Device Manager.
6. In Device Manager, locate Prime... (this may read PrimeSense or PrimeSensor).
7. Right click on Kinect Motor, and click Update Driver Software.
8. Navigate to and select the "drivers" folder; Windows should handle the rest.
9. Open the Microsoft Visual Studio Solution kinect3 located in gesture_tracking->code.
10. Build the solution; it should place the resulting .exe in gesture_tracking->code->bin->Debug.
11. Run the .exe, and click connect on the appearing screen.
12. Ensure your Kinect is properly operational; the program may not run if the system has issues detecting or reading data from your Kinect.