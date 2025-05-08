import React from "react";
import { useState } from "react";
import { Link } from "react-router-dom";
import { IResetPasswordForm ,IValidationErrors} from "./leadingComponentsInterfaces";






const ResetPassword = ()=>{
    const [hasError,setHasError] = useState<boolean>(true);
    const [formData,setFormData] = useState<IResetPasswordForm>({
        email:''
    })

    const [errors,setErrors] = useState<IValidationErrors>({});

    const [successMessage,setSuccessMessage] = useState<string>('');
    const [errorMessage,setErrorMessage] = useState<string>('');

    

    const validateField = (name: keyof IResetPasswordForm, value: string) => {
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
            
        }

    }


    const handleSubmit = (ev:React.FormEvent):void=>{
        ev.preventDefault();
        setHasError(false);

        Object.entries(formData).forEach(([key, value]) => {
            validateField(key as keyof IResetPasswordForm, value);
        })
        if(!hasError){
            setErrorMessage('');
            setSuccessMessage("Reset letter sent to your email");
            setFormData({email:''});

        }
        else{
            setSuccessMessage('');
            setErrorMessage("Something went wrong");

        }
    }


    const handleChange = (e:keyof typeof formData)=>(event:React.ChangeEvent<HTMLInputElement>)=>{
        switch(e){
            case 'email':
                setFormData(prev=>({...prev,email:event.target.value}));
                validateField('email',event.target.value);
            break;
        }
    }

   
    return(
        <div className="form-container">
            <h2>Reset Password</h2>
            {successMessage&&(<div className="success-message">{successMessage}</div>)}
            {errorMessage&&(<div className="error-message-text">{errorMessage}</div>)}
            <form onSubmit={handleSubmit}>
                <div className="form-group">
                    <label htmlFor="email">Email:</label>
                    <input id="email"
                    type="email"
                    value={formData.email}
                    onChange={handleChange('email')}
                    className={`form-input ${errors.email?'error':''}`}
                    ></input>
                    {errors.email&&(<p className="error-message">{errors.email}</p>)}
                </div>

                <button type="submit" className="btn-submit">Send</button>
                <p className="switch-form">Changed your mind?<Link to="/sign-up/">Go to Sign Up page!</Link></p>
            </form>
        </div>
    )
}

export default ResetPassword;