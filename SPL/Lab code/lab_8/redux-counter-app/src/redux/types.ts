export const INCREMENT = 'INCREMENT';
export const DECREMENT = 'DECREMENT';
export const RESET = 'RESET';

export type CounterAction =
    |{ type: typeof INCREMENT }
    | { type: typeof DECREMENT }
    | { type: typeof RESET };

