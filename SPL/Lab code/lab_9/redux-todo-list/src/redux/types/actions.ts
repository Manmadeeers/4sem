import { ADD_TODO,DELETE_TODO,TOGGLE_TODO,EDIT_TODO } from "./types";

export const addTodo = (text:string) => ({
    type: ADD_TODO,
    payload: { id: Date.now(), text, completed: false }
});
  
export const toggleTodo = (id:number) => ({
    type: TOGGLE_TODO,
    payload: id
});
  
export const editTodo = (id:number, text:string) => ({
    type: EDIT_TODO,
    payload: { id, text }
});
  
export const deleteTodo = (id:number) => ({
    type: DELETE_TODO,
    payload: id
});
  