import React from "react";
import ButtonComponent from "./Button";
import InputComponent from "./Fields";

const Form:React.FC = ()=>{
    const handleClick = ()=>{
        console.log("Clicked");
    }
    return(
        <form>
            <h3>Sign in</h3>
            <InputComponent type="text" placeHolder="Login"/>
            <InputComponent type="e-mail" placeHolder="e-mail"/>
            <InputComponent type="password" placeHolder="Password"/>

            <ButtonComponent value="Sign In" onClick={handleClick}/>
        </form>
    )
}

export default Form;