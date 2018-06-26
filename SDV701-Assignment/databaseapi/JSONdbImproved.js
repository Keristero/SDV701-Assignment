const fs = require('fs');

module.exports = class JSONdb {
    constructor(pdbPath) {
        this.dbPath = pdbPath;
        this.data = {}
        this.loadFromFile()
    }
    loadFromFile() {
        return new Promise((resolve) => {
            fs.readFile(this.dbPath, (err, resultJson) => {
                this.data = JSON.parse(resultJson);
                console.log('Loaded DB', this.data)
                resolve();
            })
        })
    }
    writeToFile() {
        return new Promise((resolve) => {
            fs.writeFile(this.dbPath, JSON.stringify(this.data), (err, result) => {
                console.log('Saved DB', this.data);
                resolve();
            })
        })
    }
    getReference(pPath, key) {
        //Create an object to return as output
        let o = {
            path: "root",
            reference: this.data,
        }

        //Find the desired reference
        for (var nextPart of pPath) {
            if (o.reference[nextPart] !== undefined) {
                o.path += ` -> ${nextPart}`
                o.reference = o.reference[nextPart];
            }
            else {
                o.path += ` -> ${nextPart} (undefined)`
                o.reference = null;
                break;
            }
        }

        //Return the output object
        console.log(o.path)
        return o;
    }
    getData(arr_path) {
        let result = this.getReference(arr_path);
        let response = new Response(`got ${result.path}`)
        
        if(result.reference !== null) {
            response.setData(result.reference)
        }else{
            response.setFailMessage(`failed to get ${result.path}`,null)
        }
        
        return response.toJson();
    }
    deleteData(arr_path, key) {
        let result = this.getReference(arr_path);
        let response = new Response(`deleted ${result.path}:${key}`)
        console.log(response.message)
        try {
            delete result.reference[key]
            this.writeToFile();
        }
        catch (e) {
            response.setFailMessage(`failed to delete ${result.path}:${key}`,e.message)
        }
        
        return response.toJson();
    }
    pushData(arr_path, key, value) {
        let result = this.getReference(arr_path, key);
        let response = new Response(`pushed value to ${result.path}:${key}`)

        try {
            result.reference[key].push(value)
            this.writeToFile();
        }
        catch (e) {
            response.setFailMessage(`failed to push value to ${result.path}`,e.message)
        }

        return response.toJson();
    }
    setData(arr_path, key, value) {
        let result = this.getReference(arr_path, key);
        let response = new Response(`set value of ${result.path}:${key}`);

        try {
            result.reference[key] = value
            this.writeToFile();
        }
        catch (e) {
            response.setFailMessage(`failed to set value of ${result.path}:${key}`,e.message)
        }

        return response.toJson();
    }
}

class Response{
    constructor(pInitialMessage){
        this.success = true;
        this.message = pInitialMessage
        this.data = null;
        this.error = null;
    }
    setFailMessage(pFailMessage,pError){
        this.success = false;
        this.message = pFailMessage;
        this.error = pError;
    }
    setData(pData){
        this.data = pData;
    }
    toJson(){
        return JSON.stringify(this);
    }
}