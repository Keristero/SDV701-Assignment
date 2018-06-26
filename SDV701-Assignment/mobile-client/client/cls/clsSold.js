/* globals clsDbObject products*/

window.clsSold = class clsSold extends clsDbObject{
    constructor(pPriceObject,pProductUID,pQuantity){
        super({})
        this.UID = this.generateQuickGuid()
        this.Type = pPriceObject.priceType
        this.Price = pPriceObject.priceAmount
        this.Quantity = pQuantity
        this.ProductUID = pProductUID
    }
    toHTML(){
        let str = ""
        str+= `<div class=${this.constructor.name} id=${this.UID}>`
        str+= `<p><b>${products[this.ProductUID].Name}</b> Type<b> ${this.Type} </b>Price<b> $${this.Price}</b></p>`
        str+= `</div>`
        return str
    }
}