import { createSlice,type PayloadAction } from "@reduxjs/toolkit";


export interface ToDo{
    id:number;
    text:string;
    isComplete:boolean;
}

export interface ToDoState{
    todos:ToDo[];
}

const initialState:ToDoState = {
    todos:[]
}

const toDoSlice = createSlice({
    name:'todos',
    initialState,
    reducers:{
        addToDo:(state,action:PayloadAction<string>)=>{
            const newToDo:ToDo = {
                id:1,
                text:action.payload,
                isComplete:false    
            };
            state.todos.push(newToDo);
        },
        toggleToDo:(state,action:PayloadAction<number>)=>{
            const toDo = state.todos.find(t=>t.id===action.payload);
            if(toDo){
                toDo.isComplete = !toDo.isComplete;
            }
        },
        deleteToDo:(state,action:PayloadAction<number>)=>{
            state.todos = state.todos.filter(t=>t.id!==action.payload);
        },
        // editToDo:(state,action:PayloadAction<number,string>)=>{

        // }
    }
});


export const {addToDo,toggleToDo,deleteToDo} = toDoSlice.actions;
export default toDoSlice.reducer;

