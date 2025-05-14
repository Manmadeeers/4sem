import { createContext, useContext, useReducer, type Dispatch, type ReactNode } from "react";
import { todoReducer, initialTodos } from "../reducers/reducer";
import { type Todo, type TodoAction } from "../types/types";

interface ITodoCtx {
    state: Todo[];
    dispatch: Dispatch<TodoAction>;
}
const TodoContext = createContext<ITodoCtx | undefined>(undefined);

export const TodoProvider = ({ children }: { children: ReactNode }) => {
    const [state, dispatch] = useReducer(todoReducer, initialTodos);
    return (
        <TodoContext.Provider value={{ state, dispatch }}>
            {children}
        </TodoContext.Provider> 

    );
};

export function useTodos() {
    const ctx = useContext(TodoContext);
    if (!ctx) throw new Error("useTodos must be used within TodoProvider");
    return ctx;
}