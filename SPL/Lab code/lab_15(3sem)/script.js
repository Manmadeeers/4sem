//basic checks
let form = document.forms.inf;
let surename = form.elements.surename;
let name = form.elements.name;
let mail = form.elements.mail;
let phone = form.elements.phone;
let city = form.elements.cities;
let selected = city.value;
let submit_button = document.getElementById('btn');
let about = document.getElementById('about');
let bstu = form.elements.check;
let first_year = form.elements.first;
let second_year = form.elements.second;
let third_year = form.elements.third;
let fourth_year = form.elements.fourth;


form.addEventListener('submit',(e)=>{

    let isValid = true;
    e.preventDefault();

    let surename_input = surename.value.trim();
    if(!surename_input){
        isValid=false;
        showException(1,"This field should not be empty!");
    }
    else if(surename_input.length>20){
        isValid=false;
        showException(1,"This field can't take more then 20 characters");
    }
    else if(!/^[a-zA-Zа-яА-Я]+$/i.test(surename_input)){
        isValid=false;
        showException(1,"This field can contain only English or Russian letters");
    }
    let name_input = name.value.trim();
    if(!name_input){
        isValid=false;
        showException(2,"This field should not be empty!");
    }
    else if(name_input.length>20){
        isValid=false;
        showException(2,"This field can't take more then 20 characters");
    }
    else if(!/^[a-zA-Zа-яА-Я]+$/i.test(name_input)){
        isValid=false;
        showException(2,"This field can contain only English or Russian letters");
    }

    let email_input = mail.value;
    const emailRegExp = /^[^\s@]+@[a-zA-Z]{2,5}\.[a-zA-Z]{2,3}$/;

    if(!email_input){
        isValid=false;
        showException(3,"This field should not be empty");
    }
    else if(!emailRegExp.test(email_input)){
        isValid=false;
        showException(3,"Incorrect format");
    }

    let phone_input = phone.value;
    const phoneRegExp = /^\(0\d{2}\)\d{3}-\d{2}-\d{2}$/;

    if(!phone_input){
        isValid=false;
        showException(4,"This field could not be empty");
    }
    else if(!phoneRegExp.test(phone_input)){
        isValid=false;
        showException(4,"Incorrect format");
    }

    let about_input = about.value;
    if(!about_input){
        isValid=false;
        showException(8,"This field could not be empty");
    }
    else if(about_input.length>250){
        isValid=false;
        showException(8,"This field can't take more then 250 characters");
    }

    if(!bstu.checked){
        isValid=false;
        showException(6,"This field is obligatory");
    }

   if(document.querySelector('input[name:course]:checked').value==null){
    showException(7,"This field is obligatory");
   }

    if(isValid==true){
        clearErrors();
        //form.submit();
        let selected_city = city.value;
        let course = document.querySelector('input[name=course]:checked')?.value;
        let bstu_checked = document.getElementById('bstu').checked;

        let opinion_changer = [];
        if(selected_city!=="Minsk"){
            opinion_changer.push("City should be Minsk. Change your opinion");
        }
        if(course!=3){
            opinion_changer.push("Course should be three. Change your opinion");
        }
        if(!bstu_checked){
            opinion_changer.push("You shold be a bstu student! Change your opinion!");
        }

        if(opinion_changer.length>0){
            alert(opinion_changer);
        }
    }
})

function showException(id,message){
    let err_div = document.getElementById(`${id}-er`);
    err_div.innerHTML = `<span>${message}</span>`
}

function clearErrors(){
    let errors = document.querySelectorAll('.error');
    errors.forEach(error=>{
        error.textContent ="<p></p>";
    })
}