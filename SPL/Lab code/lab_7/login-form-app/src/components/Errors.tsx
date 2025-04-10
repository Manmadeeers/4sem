import React from "react";
interface IError{
    messages:string[];
}

const ErrorComponent:React.FC<IError> = ({messages})=>{
    return(
        <div className="errors">
           {messages}
        </div>
    )
}

export default ErrorComponent;