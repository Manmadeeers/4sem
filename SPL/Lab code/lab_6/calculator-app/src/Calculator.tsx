import CalculatorButton from "./CalculatorButton";
import DisplayComponent from "./DisplayComponent";
import HistoryComponent from "./HistoryComponent";
import './App.css'

enum Operation {
    ADDITION = '+',
    SUBTRACTION = '-',
    MULTIPLICATION = '*',
    DIVISION = '/',
    EQUAL = '=',
    CLEAR = 'C',
    BACKSPACE = '⌫'
}

const Buttons = [
    ['C','⌫','(',')'],
    ['7','8','9','*'],
    ['4','5','6',''],
    ['1','2','3','+'],
    ['0','000','.',Operation.EQUAL]
]

function handleClick(){
    console.log("Clicked");
}

function Calculator(){


    return(
        <div className="Calculator">
            <DisplayComponent content={0}/>
            <div className="buttonGrid">
                {Buttons.map((row,rowIndex)=>(
                    <CalculatorButton key={rowIndex} name={rowIndex} callback={handleClick}/>
                ))}
            </div>
        </div>
    )
}

export default Calculator;