interface ICalcButton{
    name:string|number;
    callback:()=>void;
}

function CalculatorButton(props:ICalcButton){

    return(
    <button onClick={props.callback}>{props.name}</button>
    )
}


export default CalculatorButton;