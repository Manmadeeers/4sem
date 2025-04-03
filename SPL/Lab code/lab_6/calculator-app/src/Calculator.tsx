import CalculatorButton from "./CalcButton";
import DisplayComponent from "./Display";

function Calculator() {
    const calculatorButtons = [
        ['C', '+', '-', '*'],
        ['7', '8', '9', '/'],
        ['4', '5', '6', '%'],
        ['1', '2', '3', '='],
        ['0']
    ];

    const handleClick = () => {
        console.log('Clicked');
    }

    return (
        <div className="Calculator">
            <DisplayComponent content='0' />
            <div className="buttons">
                {calculatorButtons.flat().map((btn, idx) => (
                    <CalculatorButton key={idx} name={btn} callback={handleClick} />
                ))}
            </div>


        </div>
    )
}

export default Calculator;