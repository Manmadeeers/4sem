export const ADD_TODO = 'ADD_TODO';
export const TOGGLE_TODO = 'TOGGLE_TODO';
export const EDIT_TODO = 'EDIT_TODO';
export const DELETE_TODO = 'DELETE_TODO';

export interface Todo {
  id: number;
  text: string;
  completed: boolean;
}

interface AddTodoAction {
  type: typeof ADD_TODO;
  payload: string;
}
interface ToggleTodoAction {
  type: typeof TOGGLE_TODO;
  payload: number;
}
interface EditTodoAction {
  type: typeof EDIT_TODO;
  payload: { id: number; text: string };
}
interface DeleteTodoAction {
  type: typeof DELETE_TODO;
  payload: number;
}

export type TodoAction =
  | AddTodoAction
  | ToggleTodoAction
  | EditTodoAction
  | DeleteTodoAction;
