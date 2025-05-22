import "../styles/ToDoStyle.css"
import React, { useState, useEffect, useRef } from "react";
import { type ToDo } from "../redux/toDoSlice";
import { useDispatch } from "react-redux";
import { toggleToDo, deleteToDo, editToDo } from "../redux/toDoSlice";

interface Props {
    todo: ToDo;
}

const TodoItemComponent: React.FC<Props> = ({ todo }) => {
    const dispatch = useDispatch();
    const [isEditing, setEditing] = useState(false);
    const [text, setText] = useState(todo.text);
    const editRef = useRef<HTMLInputElement>(null);

    useEffect(() => {
        if (isEditing && editRef.current) {
            editRef.current.focus();
        }
    }, [isEditing]);

    const handleEdit = (e: React.FormEvent) => {
        e.preventDefault();
        if (text.trim() && text !== todo.text) {
            dispatch(editToDo({ id: todo.id, text: text.trim() }));
        }
        setEditing(false);
    };

    return (
        <li className="item-component">
            <input
                type="checkbox"
                checked={todo.isComplete}
                onChange={() => dispatch(toggleToDo(todo.id))}
                aria-label="Change Status"
            />
            <div className="inner-content">
                {!isEditing ? (
                    <span
                        style={{
                            textDecoration: todo.isComplete ? "line-through" : "none",
                            cursor: "pointer"
                        }}
                        onClick={() => {
                            setEditing(true);
                            setText(todo.text);
                        }}
                    >
                        {todo.text}
                    </span>
                ) : (
                    <form  onSubmit={handleEdit}>
                        <input
                            ref={editRef}
                            value={text}
                            onChange={(e) => setText(e.target.value)}
                           
                        />
                        <button aria-label="Add Task" id="submit-btn" type="submit">✓</button>
                    </form>
                )}
            </div>
            <button id="discard-btn" onClick={() => dispatch(deleteToDo(todo.id))} aria-label="Delete task">x</button>
        </li>
    );
};

export default TodoItemComponent;