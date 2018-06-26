/* globals clsDbObject */

window.clsNotice = class clsNotice extends clsDbObject{
    constructor(dataObject){
        super(dataObject)
        
    }
    toHTML(){
        let str = ""
        str+= `<div class=${this.constructor.name} id=${this.UID}>`
        str+= `<h4>${this.getFormattedDateString(this.Date)}</h4>`
        str+= `<p>${this.Text}</p>`
        str+= `</div>`
        return str
    }
}