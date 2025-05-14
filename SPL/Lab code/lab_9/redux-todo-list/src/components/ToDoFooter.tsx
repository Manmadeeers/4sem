import React from "react";
import { useTodos } from "../redux/context/context";

const TodoStatsFooter: React.FC = () => {
  const { state } = useTodos();
  const completed = state.filter(t=>t.completed).length;
  const total = state.length;
  return (
    <footer style={{
      display:"flex", justifyContent:"space-between", fontSize:13, color:"#777", marginTop:16
    }}>
      <span>Total: <b>{total}</b></span>
      <span>Done: <b>{completed}</b></span>
      <span>Active: <b>{total-completed}</b></span>
    </footer>
  )
};
export default TodoStatsFooter;
