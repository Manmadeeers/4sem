import React from "react";
import { useTodos } from "../redux/context/context";
import TodoItem from "./ToDoItemComponent";

const TodoList: React.FC = () => {
  const { state } = useTodos();
  return (
    <ul style={{paddingLeft:0, listStyle:"none", margin:0}}>
      {state.length ? (
        state.map(todo=> <TodoItem key={todo.id} todo={todo} />)
      ) : (
        <li style={{
          textAlign:"center", color:"#bbb",padding:"30px 0",fontSize:16
        }}>No Tasks</li>
      )}
    </ul>
  );
};
export default TodoList;