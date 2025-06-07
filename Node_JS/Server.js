var http = require ('http');

http.createServer(function(req,res){
    res.writeHead(200,{'content-type':'text/html'});
    res.end("Hello World");
}).listen(8000); 

/* 
Use localhost:8000
When We Enter This Address
It Show The Output On The Default Browser Screen
It Prints "Hello World" Message In Window
*/
