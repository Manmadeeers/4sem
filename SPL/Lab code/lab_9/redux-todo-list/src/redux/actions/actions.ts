import { ADD_TODO,DELETE_TODO,TOGGLE_TODO,EDIT_TODO ,type TodoAction} from "../types/types";

export function addTodo(text: string): TodoAction {
  return { type: ADD_TODO, payload: text };
}
export function toggleTodo(id: number): TodoAction {
  return { type: TOGGLE_TODO, payload: id };
}
export function editTodo(id: number, text: string): TodoAction {
  return { type: EDIT_TODO, payload: { id, text } };
}
export function deleteTodo(id: number): TodoAction {
  return { type: DELETE_TODO, payload: id };
}