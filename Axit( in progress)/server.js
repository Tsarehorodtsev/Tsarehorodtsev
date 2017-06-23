var http = require('http');
var url = require('url');
var fs = require('fs');

http.createServer(function(req, res) {
	if (req.url === '/') {
		fs.readFile('index.html', function(err, info) {
			if (err) {
				console.log(err);
				res.end("На сервере произошла ошибка!");
				return;
			} else {
				res.end(info);
			}
		});
	} else if (req.url === '/post') {
		var postData;
		req.addListener("data", function(postDataChunk) {
		  postData = postDataChunk;
		  
		  if (body.length > 1e4) {
		  	res.statusCode = 413;
		  	res.end("Your message is too big!");
		  }
		});
		req.addListener("end", function() {
		  res.setHeader("Content-Type", "text/html");
		  res.write(postData);
		  res.end();
		});
	} else if (req.url === '/get') {
		console.log(req);
		  res.end('OK! We have got an information!');
	} else {
		res.writeHead(404, {"Content-Type": "text/html; charset=utf-8"});
		res.write('<h1>Нет такой страницы! Ошибка 404</h1>');
		res.end();
	} 
}).listen(8080);