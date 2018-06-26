class DatabaseConnector {
    constructor(pdatabaseURL) {
        this.databaseURL = pdatabaseURL || 'https://veggiestall-database-keristero.c9users.io'
    }
    request(requestType, path, data) {
        return new Promise((resolve, reject) => {
            let XHR = new XMLHttpRequest();
            let searchParams = new URLSearchParams();

            // Push our data into our FormData object
            for (let name in data) {
                console.log(name, data[name])
                searchParams.append(name, JSON.stringify(data[name]));
            }
            // Define what happens in case of error
            XHR.addEventListener('error', function(event) {
                alert('Oops! Something went wrong.');
                reject(event)
            });
            XHR.onreadystatechange = function() {
                if (XHR.readyState === 4) {
                    let parsedResponse = JSON.parse(XHR.response)
                    resolve(parsedResponse);
                }
            }
            // Set up our request
            XHR.open(requestType, this.databaseURL + path);

            // Send our FormData object; HTTP headers are set automatically
            XHR.send(searchParams);
        })
    }
    getData(path) {
        return new Promise((resolve, reject) => {
            this.request("GET", path).then((result) => {
                console.log(result)
                resolve(result);
            })
        })
    }
    putData(path, key, value) {
        return new Promise((resolve, reject) => {
            this.request("PUT", path, { key: key, value: value }).then((result) => {
                console.log(result)
                resolve(result);
            })
        })
    }
    postData(path, key, value) {
        return new Promise((resolve, reject) => {
            this.request("POST", path, { key: key, value: value }).then((result) => {
                console.log(result)
                resolve(result);
            })
        })
    }
    initializeObjectsIntoDictionary(pObjects, pClassname) {
        //accepts a generic js object in the shape of a dictionary, and the classnames to init
        //returns a initialized dictionary
        let newDictionary = {};
        for (let key in pObjects) {
            newDictionary[key] = new window[pClassname](pObjects[key])
        }
        return newDictionary;
    }

}
