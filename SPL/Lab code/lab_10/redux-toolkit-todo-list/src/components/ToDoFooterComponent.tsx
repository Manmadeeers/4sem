// src/components/TodoStatsFooter.tsx
import React from "react";
import { useSelector } from "react-redux";
import { type RootState } from "../redux/store";

const TodoStatsFooter: React.FC = () => {
    const todos = useSelector((state: RootState) => state.todos.todos);
    const completed = todos.filter((todo) => todo.isComplete).length;

    return (
        <footer style={{ display: "flex", justifyContent: "space-between", marginTop: 16 }}>
            <span>Total: {todos.length}</span>
            <span>Completed: {completed}</span>
            <span>Active: {todos.length - completed}</span>
        </footer>
    );
};

export default TodoStatsFooter;