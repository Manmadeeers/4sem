import { INCREMENT,DECREMENT,RESET } from "./types";


export const increment = ():{type:typeof INCREMENT}=>({
    type:INCREMENT
})

export const decrement = (): { type: typeof DECREMENT } => ({
    type: DECREMENT
  });
  
  export const reset = (): { type: typeof RESET } => ({
    type: RESET
  });