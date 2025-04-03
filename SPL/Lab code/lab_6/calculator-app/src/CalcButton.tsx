interface IButton{
    name:string;
    callback:()=>void;
}

function CalculatorButton(props:IButton){
    return(
        <button onClick={props.callback}>{props.name}</button>
    )
}

export default CalculatorButton;