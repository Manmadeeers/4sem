import {counterReducer} from "./counterReducer";
import { createStore } from "redux";

export const counterStore = createStore(counterReducer);