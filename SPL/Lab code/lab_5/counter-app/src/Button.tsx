

function ButtonComponent(props:any){
    return(
        <button onClick={props.onClick}>{props.message}</button>
    )
}

export default ButtonComponent;