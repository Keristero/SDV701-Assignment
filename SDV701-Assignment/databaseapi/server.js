const express = require('express');
const app = express();
const JSONdb = require('./JSONdbImproved.js')
const bodyParser = require('body-parser');
app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: true }))

const server = app.listen(process.env.PORT || 3000, process.env.IP || "0.0.0.0", function(){
  var addr = server.address();
  console.log("Server listening at ", addr.address + ":" + addr.port);
});

const DB = new JSONdb("./database.json");


app.use(function (req, res, next) {
    //from https://stackoverflow.com/questions/18310394/no-access-control-allow-origin-node-apache-port-issue
    // Website you wish to allow to connect
    res.setHeader('Access-Control-Allow-Origin', 'https://veggiestall-mobile-client-keristero.c9users.io');
    // Request methods you wish to allow
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE');
    // Request headers you wish to allow
    res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
    // Set to true if you need the website to include cookies in the requests sent
    // to the API (e.g. in case you use sessions)
    res.setHeader('Access-Control-Allow-Credentials', true);
    // Pass to next layer of middleware
    next();
});

app.get('*', function (req, res) {
  let path = req.params[0]
  let arr_path = splitPath(path);
  let dbResponse = DB.getData(arr_path)
  console.log("GET response",dbResponse)
  res.send(dbResponse);
})

app.post('*', function (req, res) {
  let path = req.params[0]
  let arr_path = splitPath(path);
  let key = JSON.parse(req.body.key)
  let value = JSON.parse(req.body.value)
  let dbResponse = DB.pushData(arr_path,key,value)
  console.log("POST response",dbResponse)
  res.send(dbResponse);
})

app.put('*', function (req, res) {
  let path = req.params[0]
  let arr_path = splitPath(path);
  console.log("key",req.body.key)
  let key = JSON.parse(req.body.key)
  let value = JSON.parse(req.body.value)
  let dbResponse = DB.setData(arr_path,key,value)
  console.log("PUT response",dbResponse)
  res.send(dbResponse);
})

app.patch('*', function (req, res) {
  //I spent a hour or more trying to use the DELETE request to delete on the database, but apparently the DELETE request does not support body variables
  let path = req.params[0]
  let arr_path = splitPath(path);
  let key = JSON.parse(req.body.key)
  let dbResponse = DB.deleteData(arr_path,key)
  console.log("PATCH response",dbResponse)
  res.send(dbResponse);
})

function splitPath(pathString){
  let arr_split = pathString.split('/')
  let arr_path = arr_split.filter((str)=>{
    if(str.length > 0){return str}
  })
  return arr_path
}