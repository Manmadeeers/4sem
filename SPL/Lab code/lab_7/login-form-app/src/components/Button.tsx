import React from "react";
interface IButtonComponent{
    value:string|number;
    onClick:()=>void;
}


const ButtonComponent:React.FC<IButtonComponent> = ({value,onClick})=>{
    return(
        <button onClick={onClick} className="button">{value}</button>
    )
}

export default ButtonComponent;