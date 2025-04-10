import React from "react";
interface IButtonProps{
    value:string|number;
    onClick:()=>void;
}


const ButtonComponent:React.FC<IButtonProps> = ({value,onClick})=>{
    return(
        <button className="button-component" onClick={onClick}>
            {value}
        </button>
    );
}

export default ButtonComponent;