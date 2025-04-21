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
    const [errorMessage,setErrorMessage] = useState<string>('');
    const [successMessage,setSuccessMessage] = useState<string>('');
    const [hasError,setHasError] = useState<boolean>(true);
    const [errors,setErrors] = useState<IValidationErrors>({});

    const handleChange = ()=>{

    }
    const handleSubmit = (ev:React.FormEvent)=>{
        ev.preventDefault();
        setHasError(false);

        Object.entries(formData).forEach(([key, value]) => {
            validateField(key as keyof ILoginForm, value);
        })
        if(!hasError){
            setErrorMessage('');
            setSuccessMessage("Sign up completed");

        }
        else{
            setSuccessMessage('');
            setErrorMessage("Something went wrong");

        }
        
    }

    const validateField = (name: keyof ILoginForm, value: string) => {
        switch (name) {
            case 'email':
                const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
                if (value.length < 10) {
                    setErrors(prev => ({ ...prev, email: 'Too short email address!' }));
                    setHasError(true);
                }
                else if (!emailRegex.test(value)) {
                    setErrors(prev => ({ ...prev, email: 'Incorrect email format!' }));
                    setHasError(true);
                }
                else {
                    setErrors(prev => ({ ...prev, email: undefined }));
                }
                break;
            case 'password':
                if (value.length < 8) {
                    setErrors(prev => ({ ...prev, password: 'Password should be at least 8 characters long!' }));
                    setHasError(true);
                }
                else if (!/[A-Z]/.test(value)) {
                    setErrors(prev => ({ ...prev, password: 'Password shold contain an uppercase letter!' }));
                    setHasError(true);
                }
                else if (!/[a-z]/.test(value)) {
                    setErrors(prev => ({ ...prev, password: 'Password must contain a lowercase letter!' }));
                    setHasError(false);
                }
                else if (!/[0-9]/.test(value)) {
                    setErrors(prev => ({ ...prev, password: 'Password should contain a number!' }));
                    setHasError(false);
                }
                else {
                    setErrors(prev => ({ ...prev, password: undefined }));
                }
                break;
        }

    }
    return(
        <div className="formContainter">
            <h2>Log In</h2>
            {successMessage&&(<div className="success-message">{successMessage}</div>)}
            {errorMessage&&(<div className="error-message">{errorMessage}</div>)}
            <form>
                <div className="form-group">
                    <label htmlFor="email">Email:</label>
                    <input
                    id="email"
                    type="email"
                    onChange={handleChange}
                    value={formData.email}
                    className={`from-input ${errors.email?'error':''}`}
                    ></input>
                    {errors.email&&(<p className="error-message">{errors.email}</p>)}
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password:</label>
                    <input
                    id="password"
                    type="password"
                    onChange={handleChange}
                    value={formData.password}
                    className={`form-input ${errors.password?'error':''}`}
                    ></input>
                </div>
            </form>
        </div>
    )
}


export default LoginForm;