import "./App.css"

interface IHistory{
    name:string;
    history:string[];
}

function HistoryComponent(props:IHistory){
    return(
        <div className="History-container">
            <h3>{props.name}</h3>
            <div className="History">
                {props.history.map((item,idx)=>(
                    <span key={idx}>{item}</span>
                ))}
            </div>
        </div>
    )
}

export default HistoryComponent;