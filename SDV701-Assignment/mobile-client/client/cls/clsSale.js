/* globals clsDbObject */

window.clsSale = class clsSale extends clsDbObject{
    constructor(){
        super({})
        this.UID = this.generateQuickGuid()
        this.Total = 0
        this.Date = new Date().toISOString();
        this.Sold = {}
    }
    addProduct(pProduct,priceUID,quantity){
        console.log(`Adding ${pProduct.Name} to sale`)
        let newSoldItem = new clsSold(pProduct.Prices[priceUID],pProduct.UID,quantity)
        console.log("new sold item",newSoldItem);
        this.Sold[newSoldItem.UID] = newSoldItem
        this.Total = this.calculateTotal();
        updateSaleHTML();
    }
    calculateTotal(){
        let newTotal = 0;
        for(let soldID in this.Sold){
            newTotal += this.Sold[soldID].Price*this.Sold[soldID].Quantity
        }
        return newTotal;
    }
    toHTML(){
        let str = ""
        str+= `<div class=${this.constructor.name} id=${this.UID}>`
        str+= `<h3>Order Total = $${this.Total}</h3>`
        for(let soldID in this.Sold){
            str += this.Sold[soldID].toHTML()
        }
        str+= `</div>`
        return str
    }
}