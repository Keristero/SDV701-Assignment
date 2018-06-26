/* globals DatabaseConnector clsSale*/
let DB = new DatabaseConnector();

let products;
let productGroups;
let renderedProductUIDs = {};
let currentSale = new clsSale();

//Content divs
let div_productGroups = document.getElementById("div_productGroups");
let div_products = document.getElementById("div_products");
let div_sale = document.getElementById("div_sale");

//Search box
let txt_searchProducts = document.getElementById("txt_searchProducts");
let searchBoxText = "";
txt_searchProducts.onkeyup = ()=>{
    updateAllProductsHTML()
}
txt_searchProducts.onfocus = ()=>{
    txt_searchProducts.value = ""
}

//Buttons
document.getElementById("btn_submitSale").onclick = ()=>{
    submitSale();
};

document.getElementById("btn_cancelSale").onclick = ()=>{
    cancelSale();
};

//Get notices
DB.getData("/products").then((pResult)=>{
   let dataObjects = pResult.data;
   
   products = DB.initializeObjectsIntoDictionary(dataObjects,"clsProduct")
   
   //Get product gorups
    DB.getData("/productGroups").then((pResult)=>{
       let dataObjects = pResult.data;
       
       productGroups = DB.initializeObjectsIntoDictionary(dataObjects,"clsProductGroup")
       
       updateHTML()
    })
    
})

//Display notices
function updateHTML(){
    
    updateAllProductsHTML()
    
    updateSaleHTML()
    
}

function updateAllProductsHTML(){
    searchBoxText = txt_searchProducts.value
    updateProductGroupHTML()
    updateProductsHTML()
    
    //prepare generated buttons
    for(let property in renderedProductUIDs){
       products[property].prepareButton()
    }
}

function updateProductGroupHTML(){
    renderedProductUIDs = {};
    let productGroupsHTML = ""
    
    //Generate product html
    for(let property in productGroups){
       productGroupsHTML += productGroups[property].toHTML(renderedProductUIDs,searchBoxText)
    }
    
    div_productGroups.innerHTML = productGroupsHTML;
}

function updateProductsHTML(){
    let productsHTML = ""
    
    //Generate product html
    for(let property in products){
       productsHTML += products[property].toHTML(renderedProductUIDs,searchBoxText)
    }
    
    div_products.innerHTML = productsHTML;
}

function updateSaleHTML(){
    div_sale.innerHTML = currentSale.toHTML();
}

function cancelSale(){
    currentSale = new clsSale();
    updateSaleHTML()
}

function submitSale(){
    if(currentSale.Total > 0){
        console.log('Submitting sale')
        DB.putData("/sales",currentSale.UID,currentSale)
        //Clear the current sale
        currentSale = new clsSale();
        updateSaleHTML()
        alert("Sale submitted to database")
    }else{
        alert("Sale is empty, Add products to sale before submitting")
    }
}