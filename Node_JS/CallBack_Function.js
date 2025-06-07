const x = require('http');
var f = require('fs');

x.createServer((req,res)=>{
    f.readFile("Demo.html",(err,result)=>{
        res.writeHead(200,{'content-type': 'text/html'});
        res.write(result);
        res.end();
    });
}).listen(8000,()=>{console.log("Server Is Started")});
