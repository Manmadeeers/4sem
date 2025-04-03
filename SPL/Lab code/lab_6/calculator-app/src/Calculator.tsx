import { useState } from "react";
import CalculatorButton from "./CalcButton";
import DisplayComponent from "./Display";
import HistoryComponent from "./History";

interface KeyMap {
    [key: string]: string;
  }

function Calculator() {

    const[history,changeHistory] = useState<string[]>(['Empty']);
    const[result,setResult] = useState<string>('0');
    const[input,setInput] = useState('');


    const calculatorButtons = [
        ['C', '+', '-', '*'],
        ['7', '8', '9', '/'],
        ['4', '5', '6', '%'],
        ['1', '2', '3', '='],
        ['0', '.', '(', ')']
    ];
    const keyMap: KeyMap = {
        '0': '0',
        '1': '1',
        '2': '2',
        '3': '3',
        '4': '4',
        '5': '5',
        '6': '6',
        '7': '7',
        '8': '8',
        '9': '9',
        '.': '.',
        '+': '+',
        '-': '-',
        '*': '*',
        '/': '/',
        '=': '=',
        '(':'(',
        ')':')',
        'Enter': '=',
        'Backspace': 'C'
      };
    

    const handleClick = (item:string) => {
        if(item==='='){
            try{
                const evaluateResult = eval(input);
                if(evaluateResult==Infinity){
                    throw Error("Devision by zero")
                }
                setResult(evaluateResult);
                if(history[0]=='Empty'){
                    history.pop();
                }
                history.push(evaluateResult);

                setInput(evaluateResult);
            }
            catch(error)
            {
              setResult('Error');
              setInput('');
            }
        }
        else if(item=='C'){
            setInput('');
            setResult('');
        }
        else{
            setInput((prev)=>prev+item);
            setResult((prev)=>prev+item);
        }
    }
    const handleKeyPress = (event:KeyboardEvent)=>{
      

    }


    return (
        <>
            <h1>Calculator</h1>
            <div className="Calculator">

                <DisplayComponent content={result} />
                <div className="buttons">
                    {calculatorButtons.flat().map((btn, idx) => (
                        <CalculatorButton key={idx} name={btn} callback={()=>handleClick(btn)} />
                    ))}
                </div>
                <HistoryComponent name="History" history={history}/>
            </div>
        </>

    )
}

export default Calculator;  