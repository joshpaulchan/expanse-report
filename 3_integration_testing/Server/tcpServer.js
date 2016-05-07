
 // written by: Anthony Wong
  // tested by: Allen Tung, Joshua Chan, Anthony Wong
  // debugged by: Not applicable

//TCPserver.js is a basic test tcp server written in Node.js
//We used this to test and establish a proper connection between our subsystems.

var app = require('express')();
var http = require('http').Server();
var io = require('socket.io')(http);
var net = require('net');
var server = net.createServer();  
//var clientfeed = net.createServer();
var data = '';
var clientid = 0;
var delim = [255,217]; //Our Delmins?
var boundary = new Buffer(delim).toString('hex');

server.on('connection', handleConnection);

server.listen(8000, function() {  
  console.log('server listening to %j', server.address());
});

function handleConnection(conn) {  
  var remoteAddress = conn.remoteAddress + ':' + conn.remotePort;
  console.log('new client connection from %s', remoteAddress);
  

  //ALL data will be encoded as a base64 string
  conn.setEncoding('hex');

  
  conn.on('data', onConnData);
  //conn.on('end', onConnEnd);
  conn.once('close', onConnClose);
  conn.on('error', onConnError);

  function onConnData(d) {
         var index;
        //var remaining;
        

        data += d;
        //Indexof returns -1 if cannot find the substring
        index = data.indexOf(boundary);
        console.log(index); 
        if ( index != -1){
        var image = new Buffer(data.substring(0,index)).toString('base64');
        io.to(clientid).emit('image', { image: true, buffer: image });     
       // console.log(image);
        data = '';
        remaining = d.substring(index+2);
        data += remaining;
      }      
}


  


  function onConnClose() {
    console.log('connection from %s closed', remoteAddress);
  }

  function onConnError(err) {
    console.log('Connection %s error: %s', remoteAddress, err.message);
  }
}

io.on('connection', function(socket) {
  clientid = socket.id;
});

http.listen(3000, function(){
  console.log('listening on *:3000');
});

/*

  io.on('connection', function(socket) {
    console.log("A user connected");
    var end = buf[0];
    var imgStart = buf[end+1];
    socket.emit('title', {some: buf.toString('utf-8',1,end)})
    socket.emit('image', { image: true, buffer: buf.toString('base64',imgStart,buffer.length) });

    socket.on('disconnect', function() {
        console.log("A user disconnected");
    });
    
    var gesture = Math.random();
    
    });

http.listen(CLIENT_PORT, function () {
  console.log('Example app listening on port 3000!');
});
*/