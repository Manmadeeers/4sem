import React from "react";
import { useState } from "react";
import { useEffect } from "react";
import Display from "./Display";
import ButtonComponent from "./Buttons";

const buttons: string[] = [
    "C", "⌫", "/", "*",
    "7", "8", "9", "-",
    "4", "5", "6", "+",
    "1", "2", "3", "=",
    "0", ".",'(',')',
]


const Calulator: React.FC = () => {
    const [expression, setExpression] = useState<string>("");
    const [result, setResult] = useState<string>("");
    const [history, setHistory] = useState<string[]>([]);
    const [darkMode,setDarkMode] = useState<boolean>(()=>{
        const saved = localStorage.getItem("darkMode");
        return saved === "true";
    });
    
    
    const updateExpression = (value:string)=>{
        if(value==="."&&expression.endsWith(".")){
            return;
        }
        if(/^0[0-9]/.test(expression+value)){
            return;
        }
        setExpression(prev=>prev+value);
    }
    
    const backSpace = ()=>{
        setExpression(prev=>prev.slice(0,-1));
    }

    const clear = ()=>{
        setExpression("");
        setResult("");
    }

    const calculate = ()=>{
        try{
            const evalResult = eval(expression);
            if(!isFinite(evalResult)){
                setResult("Error");
            }
            else{
                setResult(evalResult.toString());
                setHistory(prev=>[...prev,`${expression} = ${evalResult}`]);
            }
        }
        catch{
            setResult("Error");
        }
    }

    const handleClick = (value:string)=>{
        switch(value){
            case "C":clear();break;
            case "⌫":backSpace();break;
            case "=":calculate();break;
            default:updateExpression(value);
        }
    }
    useEffect(()=>{
        const handleKey = (e:KeyboardEvent)=>{
            if(/[\d\.\+\-\*\/]/.test(e.key)){
                updateExpression(e.key);
            }
            else if(e.key==="Enter"){
                calculate();
            }
            else if(e.key==="Backspace"){
                backSpace();
            }
            else if(e.key==="Escape"){
                clear()
            }
        };
        window.addEventListener("keydown",handleKey);
        return ()=>window.removeEventListener("keydown",handleKey);
        
    },[expression]);
    useEffect(()=>{
        document.body.classList.toggle("dark",darkMode);
        localStorage.setItem("darkMode", darkMode.toString());
    },[darkMode]);

   
    return (
        <div className={`calculator ${darkMode?"dark":""}`}>
            <button  className="theme-toggle" type="button" onClick={()=>setDarkMode(!darkMode)}>
                {darkMode?"☀️" : "🌙"}
            </button>
            <Display expression={expression} result={result}/>
            <div className="buttons">
                {buttons.map((btn,index)=>(
                    <ButtonComponent key={index} value={btn} onClick={()=>(handleClick(btn))}/>
                ))}
            </div>
            <div className="history">
                <h3>History</h3>
                <ul>
                    {history.slice(-5).reverse().map((entry,idx)=>(
                        <li key={idx}>{entry}</li>
                    ))}
                </ul>
            </div>
        </div>
    );
}


export default Calulator;