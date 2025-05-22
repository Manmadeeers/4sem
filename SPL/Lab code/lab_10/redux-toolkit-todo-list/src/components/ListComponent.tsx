// src/components/TodoListComponent.tsx
import React from "react";
import { useSelector } from "react-redux";
import { type RootState } from "../redux/store";
import TodoItemComponent from "./ToDoItemComponent";

const TodoListComponent: React.FC = () => {
    const todos = useSelector((state: RootState) => state.todos.todos);

    return (
        <ul style={{ listStyle: "none", padding: 0 }}>
            {todos.length ? (
                todos.map((todo) => <TodoItemComponent key={todo.id} todo={todo} />)
            ) : (
                <li className="todo-containment">No Tasks</li>
            )}
        </ul>
    );
};

export default TodoListComponent;