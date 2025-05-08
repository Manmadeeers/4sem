import React from "react";
import { useState } from "react";
import { Link } from "react-router-dom";
import { ILoginForm,IValidationErrors} from "./leadingComponentsInterfaces";
import { dataStorage } from "./personal";

interface ILogin{
    data:dataStorage[]
}

const LoginForm:React.FC<ILogin> = ({data})=>{
    const [formData,setFormData] = useState<ILoginForm>({
        email:'',
        password:''
    });
    const [errorMessage,setErrorMessage] = useState<string>('');
    const [successMessage,setSuccessMessage] = useState<string>('');
    const [hasError,setHasError] = useState<boolean>(true);
    const [errors,setErrors] = useState<IValidationErrors>({});
   

    const handleChange = (e:keyof typeof formData)=>(event:React.ChangeEvent<HTMLInputElement>)=>{
        switch(e){
            case 'email':
                setFormData(prev=>({...prev,email:event.target.value}));
                validateField('email',event.target.value);
            break;
            case 'password':
                setFormData(prev=>({...prev,password:event.target.value}));
                validateField('password',event.target.value);
            break;
        }
    }
    const handleSubmit = (ev:React.FormEvent)=>{
        ev.preventDefault();
        setHasError(false);

        Object.entries(formData).forEach(([key, value]) => {
            validateField(key as keyof ILoginForm, value);
        })
        if(!hasError){
            setErrorMessage('');
            setSuccessMessage("Log In completed");
            setFormData({email:'',password:''})
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
                    setHasError(false);
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
                    setHasError(false);
                }
                break;
        }
        let valid:boolean = true;
        data.forEach(d=>{
            if(d.email!=formData.email&&d.password!=formData.password){
                valid = true;
                
            }
        })
        if(!valid){
            //setErrors(prev=>({...prev,email:"error.doesn't suit already existing"}));
            setHasError(true);
            alert("Invalid data");
            console.log(data);
        }
        else{
            setHasError(false);
            alert("Data match!");
        }


    }
    return(
        <div className="form-container">
            <h2>Log In</h2>
            {successMessage&&(<div className="success-message">{successMessage}</div>)}
            {errorMessage&&(<div className="error-message-text">{errorMessage}</div>)}
            <form onSubmit={handleSubmit}>
                <div className="form-group">
                    <label htmlFor="email">Email:</label>
                    <input
                    id="email"
                    type="email"
                    onChange={handleChange('email')}
                    value={formData.email}
                    className={`form-input ${errors.email?'error':''}`}
                    ></input>
                    {errors.email&&(<p className="error-message">{errors.email}</p>)}
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password:</label>
                    <input
                    id="password"
                    type="password"
                    onChange={handleChange('password')}
                    value={formData.password}
                    className={`form-input ${errors.password?'error':''}`}
                    ></input>
                    {errors.password&&(<p className="error-message">{errors.password}</p>)}
                </div>
                <p className="forgot-pass">Forgot password?<Link to="/reset-pass/">Reset</Link></p>
                <button type="submit" className="btn-submit">Log in</button>
                <p className="switch-form">Don't have an account?<Link to="/sign-up/">Sign Up</Link></p>
            </form>
        </div>
    )
}


export default LoginForm;