import { useState } from "react";
import CalculatorButton from "./CalcButton";
import DisplayComponent from "./Display";
import HistoryComponent from "./History";

function Calculator() {
    const calculatorButtons = [
        ['C', '+', '-', '*'],
        ['7', '8', '9', '/'],
        ['4', '5', '6', '%'],
        ['1', '2', '3', '='],
        ['0', '.', '(', ')']
    ];

    const handleClick = () => {
        console.log('Clicked');
    }
    const[history,changeHistory] = useState([]);

    return (
        <>
            <h1>Calculator</h1>
            <div className="Calculator">

                <DisplayComponent content='0' />
                <div className="buttons">
                    {calculatorButtons.flat().map((btn, idx) => (
                        <CalculatorButton key={idx} name={btn} callback={handleClick} />
                    ))}
                </div>
                <HistoryComponent name="History" history={['Empty']}/>
            </div>
        </>

    )
}

export default Calculator;  