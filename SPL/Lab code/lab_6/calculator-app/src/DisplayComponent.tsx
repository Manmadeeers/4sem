interface IDisplay{
    content:string|number
}

function DisplayComponent(props:IDisplay){
    return(
        <div className="display">
            <span>{props.content}</span>
        </div>
    )
}

export default DisplayComponent;