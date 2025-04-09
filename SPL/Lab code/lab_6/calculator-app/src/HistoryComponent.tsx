interface IHistory{
    history:string[]|number[]
}

function HistoryComponent(props:IHistory){
    return (
        <div className="history-container">
            <div className="history-storage">

            </div>
        </div>
    )
}

export default HistoryComponent;