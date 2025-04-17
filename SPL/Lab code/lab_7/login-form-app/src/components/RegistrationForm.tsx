import React from "react";
import { useState } from "react";
import { Link } from "react-router-dom";
import { validateName,validateEmail,validatePassword } from "./validation";
// interface IRegistrationForm{
//     name:string;
//     email:string;
//     password:string;
//     confirmPasswod:string;
// }


const RegistrationForm = ()=>{
    const [formData,setFormData] = useState({
        name:'',
        email:'',
        password:'',
        confirmPassword:''
    });

    const [errors,setErrors] = useState({
        nameError:'',
        emailError:'',
        passwordError:'',
        confirmPasswordError:''
    });

    const [successMessage,setSuccessMessage] = useState('');

    const handleChange = (name:keyof typeof formData)=>(
        event:React.ChangeEvent<HTMLInputElement>
    )=>{
        const value = event.target.value;
        setFormData(prev=>({...prev,[name]:value}));

        switch(name){
            case "name":
                setErrors(prev=>({...prev,nameError:validateName(value)}));
            break;
            case "email":
                setErrors(prev=>({...prev,emailError:validateEmail(value)}));
            break;
            case "password":
                setErrors(prev=>({...prev,passwordError:validatePassword(value)}));
            break;
            case "confirmPassword":
                setErrors(prev=>({...prev,confirmPasswordError:validatePassword(value)}));
            break;
        }
    };
    let hasErrors = false;
    const handleSubmit = (e:any)=>{
        e.preventDefault();

        Object.keys(formData).forEach(key=>{
            const value = formData[key];
        })


    }


    return(
        <div className="formContainer">
            <h2>Registration</h2>
            {successMessage&&(
                <div className="success-message">{!hasErrors?'':`${successMessage}`}</div>
            )}

            <form onSubmit={handleSubmit}>  
                <div className="form-group">
                    <label htmlFor="name">Name:</label>
                    <input id="name"
                    type="text"
                    value={formData.name}
                    onChange={handleChange('name')}
                    className={`form-input ${errors.nameError ? 'error' : ''}`}
                    ></input>
                    {errors.nameError&&<span className="error-message">{errors.nameError}</span>}
                </div>
                <div className="form-group">
                    <label htmlFor="email">Email:</label>
                    <input
                        id="email"
                        type="email"
                        value={formData.email}
                        onChange={handleChange('email')}
                        className={`form-input ${errors.emailError ? 'error' : ''}`}
                    ></input>
                    {errors.emailError&&<span className="error-message">{errors.emailError}</span>}
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password:</label>
                    <input
                        id="password"
                        type="password"
                        value={formData.password}
                        onChange={handleChange('password')}
                        className={`form-input ${errors.passwordError ? 'error' : ''}`}>
                    </input>
                    {errors.passwordError&&<span className="error-message">{errors.passwordError}</span>}
                </div>
                <div className="form-group">
                    <label htmlFor="confirmPassword">Confirm password:</label>
                    <input
                        id="confirmPassword"
                        type="password"
                        value={formData.confirmPassword}
                        onChange={handleChange('confirmPassword')}
                        className={`form-input ${errors.confirmPasswordError ? 'error' : ''}`}
                    ></input>
                    {errors.confirmPasswordError&&<span className="error-message">{errors.confirmPasswordError}</span>}
                </div>
                <button type="submit" className="btn-submit">Sign up</button>
                <p className="switch-form">
                    Already have an account?<Link to="/sign-in">Sign in</Link>
                </p>
            </form>
        </div>
    )

}


export default RegistrationForm;