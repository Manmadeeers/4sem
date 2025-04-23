import React from "react";
import { useState } from "react";
import { Link } from "react-router-dom";

interface IRegistrationForm {
    name: string;
    email: string;
    password: string;
    confirmPassword: string;
}

interface IValidationErrors {
    [key: string]: string | undefined;
}

//that's bullshit. don't do like this pls :))



const RegistrationForm = () => {

    const [hasError,setHasError] = useState<boolean>(true);

    const [formData, setFormData] = useState<IRegistrationForm>({
        name: '',
        email: '',
        password: '',
        confirmPassword: ''
    });

    const [errors, setErrors] = useState<IValidationErrors>({});

    const [successMessage, setSuccessMessage] = useState<string>('');
    const [errorMessage,setErrorMessage] = useState<string>('');


    const validateField = (name: keyof IRegistrationForm, value: string) => {
        switch (name) {
            case 'name':
                if (value.length < 2) {
                    setErrors(prev => ({ ...prev, name: 'Name must contain at least two characters!' }));
                    setHasError(true);
                }
                else if (!/^[a-zA-Zа-яА-ЯёЁ]/.test(value)) {
                    setErrors(prev => ({ ...prev, name: 'Name must contain letters from cyrilic or latin alphabet!' }))
                    setHasError(true);
                }
                else {
                    setErrors(prev => ({ ...prev, name: undefined }));
                    setHasError(false);
                }
                break;
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
            case 'confirmPassword':
                if (value !== formData.password) {
                    setErrors(prev => ({ ...prev, confirmPassword: 'Passwords should match!' }));
                    setHasError(true);
                }
                else if(value.length==0){
                    setErrors(prev=>({...prev,confirmPassword:'You should confirm your password!'}))
                }
                else {
                    setErrors(prev => ({ ...prev, confirmPassword: undefined }));
                    setHasError(false);
                }
                break;
        }

    }

   
    const handleSubmit = (ev: React.FormEvent): void => {
        
        ev.preventDefault();
        setHasError(false);

        Object.entries(formData).forEach(([key, value]) => {
            validateField(key as keyof IRegistrationForm, value);
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

  

    const handleChange = (e:keyof typeof formData) => (event:React.ChangeEvent<HTMLInputElement>)=>{
        switch(e){
            case 'name':
                setFormData(prev=>({...prev,name:event.target.value}));
                validateField('name',event.target.value);
            break;
            case 'email':
                setFormData(prev=>({...prev,email:event.target.value}));
                validateField('email',event.target.value);
            break;
            case 'password':
                setFormData(prev=>({...prev,password:event.target.value}));
                validateField('password',event.target.value);
            break;
            case 'confirmPassword':
                setFormData(prev=>({...prev,confirmPassword:event.target.value}));
                validateField('confirmPassword',event.target.value);
            break;
        }
    }

    return (
        <div className="form-container">
            <h2>Sign up</h2>
            {successMessage && (<div className={`success-message`}>{successMessage}</div>)}
            {errorMessage&&(<div className="error-message-text">{errorMessage}</div>)}
            <form onSubmit={handleSubmit} id="from">
                <div className="form-group">
                    <label htmlFor="name">Name:</label>
                    <input id="name"
                        type="text"
                        value={formData.name}
                        onChange={handleChange('name')}
                        className={`form-input ${errors.name?'error':''}`}
                    ></input>
                    {errors.name && (<p className="error-message">{errors.name}</p>)}
                </div>
                <div className="form-group">
                    <label htmlFor="email">Email:</label>
                    <input
                        id="email"
                        type="email"
                        value={formData.email}
                        onChange={handleChange('email')}
                        className={`form-input ${errors.email?'error':''}`}
                    ></input>
                    {errors.email && (<p className="error-message">{errors.email}</p>)}
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password</label>
                    <input id="password"
                        type="password"
                        value={formData.password}
                        onChange={handleChange('password')}
                        className={`form-input ${errors.password?'error':''}`}
                    >
                    </input>
                    {errors.password&&(<p className="error-message">{errors.password}</p>)}
                </div>
                <div className="form-group">
                    <label htmlFor="confirmPassword">Confirm Password:</label>
                    <input
                    id="confirmPassword"
                    type="password"
                    value={formData.confirmPassword}
                    onChange={handleChange('confirmPassword')}
                    className={`form-input ${errors.confirmPassword?'error':''}`}
                    ></input>
                    {errors.confirmPassword&&(<p className="error-message">{errors.confirmPassword}</p>)}
                </div>
               
                <button type="submit" className="btn-submit">Sign Up</button>
                <p className="switch-form">Already have an account? <Link to="/sign-in/">Sign In</Link></p>
            </form>
        </div>
    )

}


export default RegistrationForm;