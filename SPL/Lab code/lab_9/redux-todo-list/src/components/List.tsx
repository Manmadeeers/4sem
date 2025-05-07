import React from "react";
import ButtonComponent from "./ButtonComponent";
import InputComponent from "./InputComponent";


const ToDoList:React.FC = ()=>{

    const handleClick = ()=>{

    }

    return(
        <div className="todo-list">
            <div className="addition-bar">
                <InputComponent placeholder="New task text here"/>
                <ButtonComponent content="Add New" callback={handleClick}/>
            </div>
            <div className="container">
                
            </div>
        </div>
    )
}
export default ToDoList;