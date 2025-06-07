var http = require ('http');
var dt = require ('./MyModule.js');

http.createServer(function(req,res){
    res.writeHead(200,{'content-type':'text/html'});
    res.write("The Current Date & Time :-> "+dt.MyDateTime());
    res.end();
}).listen(8000);
