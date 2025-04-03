import { useState } from "react";
import ButtonComponent from "./Button";
import './App.css';

function Counter(){
    const[count,setCount] = useState<number>(0);
    const handleIncreaseClick=()=>{
        setCount(prev=>prev+1);
    }
    const handleResetClick = ()=>{
        setCount(0);
    }

    
    return(
        
        <div className="counterComponent">
            <h1 style={{color:count>5?'red': ''}}>{count}</h1>
            <div className="buttons">
                <ButtonComponent name="Increase" callback={handleIncreaseClick}/>
                <ButtonComponent name="Reset" callback={handleResetClick}/>
            </div>
        </div>
    )
}


export default Counter;