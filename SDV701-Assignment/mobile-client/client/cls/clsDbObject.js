class clsDbObject {
    constructor(dataObject) {
        for (let property in dataObject) {
            let value = dataObject[property]
            this[property] = value;
        }
        console.log(this)
    }
    getFormattedDateString(dateString){
        let d = new Date(dateString)
        return `${d.getDate()}/${d.getMonth()}/${d.getFullYear()}`
    }
    generateQuickGuid() {
        //Code from https://stackoverflow.com/questions/105034/create-guid-uuid-in-javascript Jeff Ward
        return Math.random().toString(36).substring(2, 15) + Math.random().toString(36).substring(2, 15);
    }
}
