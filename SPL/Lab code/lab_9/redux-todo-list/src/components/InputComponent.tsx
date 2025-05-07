import React from "react";

interface IInputComponent{
    placeholder:string;
}


const InputComponent:React.FC<IInputComponent> = ({placeholder})=>{
    return(
        <input placeholder={placeholder} type="text" className="addition-input" id="addition"></input>
    )
}

export default InputComponent;