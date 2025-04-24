import { INCREMENRT,DECREMENT,RESET } from "./types";
export interface counterState{
    count:number;
}

const initialState :counterState = {count:0};


export const counterReducer = (state = initialState,action:any):counterState=>{
    switch(action.type){
        case INCREMENRT:
            return {...state,count:state.count+1};
        break;
        case DECREMENT:
            return {...state,count:state.count-1};
        break;
        case RESET:
            return initialState;
        break;
        default:
            return state;
        break;


    }
}

