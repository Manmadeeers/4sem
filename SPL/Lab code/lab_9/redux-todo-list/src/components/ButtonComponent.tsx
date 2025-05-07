import React from "react";

interface IButtonComponent{
    content:string;
    callback:()=>void;
}



const ButtonComponent:React.FC<IButtonComponent> = ({content,callback})=>{
    return(
        <button className="btn" onClick={callback}>{content}</button>
    )
}


export default ButtonComponent;