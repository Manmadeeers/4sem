import React from "react";
import { useState } from "react";

interface ILoginForm{
    email:string,
    password:string;
}

interface IValidationErrors {
    [key: string]: string | undefined;
}




const LoginForm = ()=>{
    const [formData,setFormData] = useState<ILoginForm>({
        email:'',
        password:''
    });
    const [hasError,setHasError] = useState<boolean>(true);
    const [errors,seterrors] = useState<IValidationErrors>({});

    const handleChange = ()=>{

    }
    const handleSubmit = ()=>{

    }
    return(
        <div className="formContainter">
            <form>

            </form>
        </div>
    )
}


export default LoginForm;