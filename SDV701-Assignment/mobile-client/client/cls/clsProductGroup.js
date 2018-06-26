/* globals clsDbObject products*/

window.clsProductGroup = class clsProductGroup extends clsDbObject{
    constructor(dataObject){
        super(dataObject)
    }
    get productReferences(){
        let productReferences = {};
        this.ProductUIDs.forEach((productUID)=>{
            if(products.hasOwnProperty(productUID)){
                //If a product with the given id exists (has not been deleted)
                productReferences[productUID] = products[productUID]
            }
        })
        //Return dictionary containing references to product objects indexed by ID
        return productReferences;
    }
    toHTML(renderedProductUIDs,searchBoxText){
        let str = ""
        //Return early if the product name is not in the searchbox
        if(!this.Name.toLowerCase().includes(searchBoxText.toLowerCase())){
            return str
        }
        str+= `<div class=${this.constructor.name} id=${this.UID}>`
        str+= `<h2>${this.Name}</h2>`
        let prodRefs = this.productReferences
        for(let prodID in prodRefs){
            str += prodRefs[prodID].toHTML(renderedProductUIDs,"")
        }
        str+= `</div>`
        return str
    }
}