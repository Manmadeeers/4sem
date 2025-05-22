import "../styles/ToDoStyle.css"
import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { addToDo } from "../redux/toDoSlice";

const AddToDoComponent: React.FC = () => {
    const dispatch = useDispatch();
    const [text, setText] = useState("");

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        if (text.trim()) {
            dispatch(addToDo(text.trim()));
            setText("");
        }
    };

    return (
        <form onSubmit={handleSubmit} className="add-form">
            <input
                value={text}
                onChange={(e) => setText(e.target.value)}
                placeholder="New Task..."
                
            />
            <button type="submit" >
                Add
            </button>
        </form>
    );
};

export default AddToDoComponent;