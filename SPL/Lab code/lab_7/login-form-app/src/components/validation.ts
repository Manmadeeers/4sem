
// interface ILoginForm{
//     email:string;
//     password:string;
// }

// interface IResetPassword{
//     email:string;
// }


export const validateName = (value:string):string=>{
    if(!value.trim()){
        return "Name is required!";
    }
    if(!/^[а-яёА-ЯЁa-zA-Z\s]+$/.test(value)){
        return "Name must contain only latin or cyrilic letters!";
    }
    if(value.length<2||value.length>40){
        return "Name must contain 2-40 characters!";
    }
    return '';
}

export const validateEmail = (value:string):string=>{
    if(!value.trim()){
        return "Email is required!";
    }
    if(!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(value)){
        return "Incorrect email format!";
    }
    return '';
}

export const validatePassword = (value:string):string=>{
    if(!value.trim()){
        return "Password is required!";
    }
    if(value.length<8){
        return "Password must be at least 8 characters long!";
    }
    if(!/^[A-Z]/.test(value)){
        return "Password must contain an uppercase letter!";
    }
    if(!/^[a-z]/.test(value)){
        return "Password must contain a lowercase letter!";
    }
    if(!/^\d/.test(value)){
        return "Passwird must contain a number!";
    }
    if(/^\s/.test(value)){
        return "Password must not contain spaces!";
    }
    return '';
}

