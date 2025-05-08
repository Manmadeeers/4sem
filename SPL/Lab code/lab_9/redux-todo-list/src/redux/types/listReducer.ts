import { ADD_TODO,TOGGLE_TODO,EDIT_TODO,DELETE_TODO } from "./types";

const initialState = {
    todos: []
};

export const listReducer = (state = initialState,action:any)=>{
    switch(action.type){
        case ADD_TODO:
            return {...state,todo:[...state.todos,action.payload]};
        case DELETE_TODO:
            return {...state }
    }
}