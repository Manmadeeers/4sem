interface buttonProperty{
    name:string;
    callback:()=>void;
}

function ButtonComponent(props:buttonProperty){
    return(
        <button onClick={props.callback} id="but-comp">{props.name}</button>
    )
}

export default ButtonComponent;