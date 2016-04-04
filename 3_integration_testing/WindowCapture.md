# Expanse/Server | Group 13
## INTEGRATION TESTS

As of *04.01.2016* the window capture component of Expanse does not have any integration tests written. 
However, we have laid out several cases that we would like to specify when we do write tests.

#### Data Transfer Using Sockets

1. The window-capture socket should have a high enough throughput to support performant image passing without latency.
    
2. The window-capture socket should have a clearly defined data payload specification so as not to 'cross-contaminate' the image/metadata of one window with another's.
    
3. The window-capture socket should have a reasonable amount of allocated memory, and not leak memory.
  
