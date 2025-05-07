import React from "react";
import ButtonComponent from "./ButtonComponent";
import InputComponent from "./InputComponent";

interface IAddTaskComponent{
    callback:()=>void;
}

const AddTaskComponent:React.FC<IAddTaskComponent> = ({callback}) =>{
    return(
        <div className="addition-bar">
            <InputComponent placeholder="New task text here"/>
            <ButtonComponent content="Add" callback={callback}></ButtonComponent>
        </div>
    )
}

export default AddTaskComponent;

