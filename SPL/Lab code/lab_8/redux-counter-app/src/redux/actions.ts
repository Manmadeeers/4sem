import { INCREMENRT,DECREMENT,RESET } from "./types";

export const increment = ()=>{
    return {type: INCREMENRT};
}

export const decrement = ()=>{
    return {type: DECREMENT};
}

export const reset = ()=>{
    return {type: RESET};
}