import React from "react";
import { useState } from "react";
import { Link } from "react-router-dom";
import { validateName, validateEmail, validatePassword } from "./validation";
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

    const [formData, setFormData] = useState<IRegistrationForm>({
        name: '',
        email: '',
        password: '',
        confirmPassword: ''
    });

    const [errors, setErrors] = useState<IValidationErrors>({});

    const [successMessage, setSuccessMessage] = useState<string>('');

    const validateField = (name: keyof IRegistrationForm, value: string) => {
        switch (name) {
            case 'name':
                if (value.length < 2) {
                    setErrors(prev => ({ ...prev, name: 'Name must contain at least two characters!' }));
                }
                else if (!/^[a-zA-Zа-яА-ЯёЁ]/.test(value)) {
                    setErrors(prev => ({ ...prev, name: 'Name must contain letters from cyrilic or latin alphabet!' }))
                }
                else {
                    setErrors(prev => ({ ...prev, name: undefined }));
                }
                break;
            case 'email':
                const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
                if (value.length < 10) {
                    setErrors(prev => ({ ...prev, email: 'Too short email address!' }));
                }
                else if (!emailRegex.test(value)) {
                    setErrors(prev => ({ ...prev, email: 'Incorrect email format!' }));
                }
                else {
                    setErrors(prev => ({ ...prev, email: undefined }));
                }
                break;
            case 'password':
                if (value.length < 8) {
                    setErrors(prev => ({ ...prev, password: 'Password should be at least 8 characters long!' }));
                }
                else if (!/^[A-Z]+$/.test(value)) {
                    setErrors(prev => ({ ...prev, password: 'Password shold contain an uppercase letter!' }));
                }
                else if (!/^[a-z]+$/.test(value)) {
                    setErrors(prev => ({ ...prev, password: 'Password must contain a lowercase letter!' }));
                }
                else if (!/^[0-9]+$/.test(value)) {
                    setErrors(prev => ({ ...prev, password: 'Password should contain a number!' }));
                }
                else {
                    setErrors(prev => ({ ...prev, password: undefined }));
                }
                break;
            case 'confirmPassword':
                if (value !== formData.password) {
                    setErrors(prev => ({ ...prev, confirmPassword: 'Passwords should match!' }));
                }
                else {
                    setErrors(prev => ({ ...prev, confirmPassword: undefined }));
                }
                break;

        }
    }

    const handleSubmit = (ev: React.FormEvent): void => {
        ev.preventDefault();
        Object.entries(formData).forEach(([key, value]) => {
            validateField(key as keyof IRegistrationForm, value);
        })


        if (Object.values(errors).every(error => !error)) {
            setSuccessMessage("Sign up completed!");
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
            {successMessage && (<div className="succsess-message">{successMessage}</div>)}
            <form onSubmit={handleSubmit}>
                <div className="form-group">
                    <label htmlFor="name">Name:</label>
                    <input id="name"
                        type="text"
                        value={formData.name}
                        onChange={handleChange('name')}
                        className={errors.name ? 'border-red-500' : ''}
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
                        className={errors.email ? 'border-red-500' : ''}
                    ></input>
                    {errors.email && (<p className="error-message">{errors.email}</p>)}
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password</label>
                    <input id="password"
                        type="password"
                        value={formData.password}
                        onChange={handleChange('password')}
                        className={errors.password?'border-red-500':''}
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
                    className={errors.confirmPassword?'border-red-500':''}
                    ></input>
                    {errors.confirmPassword&&(<p className="error-message">{errors.confirmPassword}</p>)}
                </div>
                <button type="submit" className="btn-submit">Sign Up</button>
                <p className="switch-form">Already have an account?<Link to="/sign-in/">Sign In</Link></p>
            </form>
        </div>
    )

}


export default RegistrationForm;