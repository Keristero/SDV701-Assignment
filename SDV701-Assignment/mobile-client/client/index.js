/* globals DatabaseConnector clsNotice */
let DB = new DatabaseConnector();

let notices;

//Button
document.getElementById("btn_newSale").onclick = ()=>{
    window.location = "/sale.html";
};

//Get notices
DB.getData("/notices").then((result)=>{
   let dataObjects = result.data;
   
   notices = DB.initializeObjectsIntoDictionary(dataObjects,"clsNotice")
   
   updateHTML()
})

//Display notices
function updateHTML(){
    let noticesHTML = ""
    
    //Generate notice HTML
    for(let property in notices){
       noticesHTML += notices[property].toHTML()
    }
    
    //Add generated HTML to the page
    document.getElementById("div_notices").innerHTML = noticesHTML;
}