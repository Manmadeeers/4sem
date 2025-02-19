//basic checks
let form = document.forms.inf;
let surename = form.elements.surename;
let name = form.elements.name;
let mail = form.elements.mail;
let phone = form.elements.phone;
let city = form.elements.cities;
let selected = city.value;
let submit_button = document.getElementById('btn');
submit_button.addEventListener('click',()=>{
    if(surename.value = ''){
        let surename_message = document.getElementById('1er');
        surename_message.innerHTML = 'This field should not be empty';  
    }
    // alert(`${surename.value},${name.value},${selected}`);
    // city.value = '';
})
