import React from "react";

interface IDisplayProps{
    expression:string;
    result:string;
}

const Display:React.FC<IDisplayProps> = ({expression,result})=>{
    return(
        <div className="display">
            <div className="expression">{expression}</div>
            <div className="result">{result}</div>
        </div>
    );
}

export default Display;