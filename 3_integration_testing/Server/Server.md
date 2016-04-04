# Expanse/Server | Group 13
## INTEGRATION TESTS

As of *04.01.2016* the server component of expanse does not have any integration tests written. However, we have laid out several cases that we would like to specify when we do write tests.

#### Data Transfer Using Sockets

1. The server program should be able to create read and writable sockets/data stream objects for inter-process communication between the server and the gesture tracking program, and the server and the window capture program.
    
2. The window-capture socket should have a high enough throughput to support performant image passing without latency.
    
3. The window-capture socket should have a clearly defined data payload specification so as not to 'cross-contaminate' the image/metadata of one window with another's.
    
4. The gesture-tracking socket should have a clearely defined data specification so to distinguish the key points of data - namely, the position of the recognized finger tips and relevant gesture information
