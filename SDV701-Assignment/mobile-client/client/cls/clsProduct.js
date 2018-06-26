/* globals clsDbObject currentSale renderedProductUIDs*/

window.clsProduct = class clsProduct extends clsDbObject{
    constructor(dataObject){
        super(dataObject)
        
    }
    toHTML(renderedProductUIDs,searchBoxText){
        let str = ""
        //Return early if the product HTML has already been generated
        if(renderedProductUIDs.hasOwnProperty(this.UID)){
            return str
        }
        //Return early if the product name is not in the searchbox
        if(!this.Name.toLowerCase().includes(searchBoxText.toLowerCase())){
            return str
        }
        
        str+= `<div class=${this.constructor.name} id=${this.UID}>`
        str+= `<h3>${this.Name}</h3>`
        //The section below generates a combo box with all the products price options
        str+= `<select id="sel_${this.UID}">`
        for(let priceID in this.Prices){
            str+= `<option value="${priceID}">${this.Prices[priceID].priceType}</option>`
        }
        str+= `</select>`
        //The section below generates a input box for the quantity
        str+= `<input id="txt_${this.UID}" type="number"></input>`
        str+= `<button id="btn_${this.UID}">Add to order</button>`
        str+= `<p>last updated: ${this.getFormattedDateString(this.LastModified)}</p>`
        str+= `</div>`
        
        renderedProductUIDs[this.UID] = true;
        
        return str
    }
    prepareButton(){
        document.getElementById(`btn_${this.UID}`).onclick = (()=>{
            this.addToOrder();
        })
    }
    addToOrder(sale){
        let priceTypeSelector = document.getElementById(`sel_${this.UID}`)
        let priceTypeID = priceTypeSelector.value
        let quantityInputBox = document.getElementById(`txt_${this.UID}`)
        let quantity = quantityInputBox.value
        currentSale.addProduct(this,priceTypeID,quantity)
    }
}