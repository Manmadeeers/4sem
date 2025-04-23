
import { CounterAction } from './types';

const initialState = 0;

export default function counterReducer(state = initialState, action: CounterAction) {
  switch (action.type) {
    case 'INCREMENT':
      return state + 1;
    case 'DECREMENT':
      return state - 1;
    case 'RESET':
      return 0;
    default:
      return state;
  }
}