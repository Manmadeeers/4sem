//basic checks
let form = document.forms.inf;
let surename = form.elements.surename;
let name = form.elements.name;
let mail = form.elements.mail;
let phone = form.elements.phone;
let city = form.elements.cities;
let selected = city.value;
let submit_button = document.getElementById('btn');

let isValid = false;
form.addEventListener('submit',(e)=>{


    e.preventDefault();

    let surename_input = surename.value.trim();
    if(!surename_input){
        showException(1,"This field should not be empty!");
    }
    let name_input = name.value.trim();
    if(!name_input){
        showException(2,"This field should not be empty!");
    }
    else if(name_input.length>20){
        showException(2,"This field can't take more then 20 characters");
    }











    
})

function showException(id,message){
    let err_div = document.getElementById(`${id}-er`);
    err_div.innerHTML = `<span>${message}</span>`
}