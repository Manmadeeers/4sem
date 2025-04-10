import React from "react";
interface IInputField{
    type:string;
    placeHolder:string;
}

const InputComponent:React.FC<IInputField> = ({type,placeHolder})=>{

    return(
        <input type={type} placeholder={placeHolder} className="form-input"/>
    )
}

export default InputComponent;