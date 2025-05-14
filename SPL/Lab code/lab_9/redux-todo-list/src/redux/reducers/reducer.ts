
import { ADD_TODO, EDIT_TODO, DELETE_TODO, TOGGLE_TODO,type Todo,type TodoAction } from "../types/types";

export const initialTodos: Todo[] = [
  { id: 1, text: "Sdelat' kursach po OOP", completed: false },
  { id: 2, text: "Sdat' design poskoree", completed: true },
  { id: 3, text: "Don't go to Armiya", completed: false }
];
export function todoReducer(state: Todo[] = initialTodos, action: TodoAction): Todo[] {
  switch (action.type) {
    case ADD_TODO:
      return [
        ...state,
        {
          id: state.length ? Math.max(...state.map(t=>t.id)) + 1 : 1,
          text: action.payload,
          completed: false
        }
      ];
    case TOGGLE_TODO:
      return state.map(todo =>
        todo.id === action.payload
          ? { ...todo, completed: !todo.completed }
          : todo
      );
    case EDIT_TODO:
      return state.map(todo =>
        todo.id === action.payload.id
          ? { ...todo, text: action.payload.text }
          : todo
      );
    case DELETE_TODO:
      return state.filter(todo => todo.id !== action.payload);
    default:
      return state;
  }
}
