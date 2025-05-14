import React, { useState } from "react";
import { useTodos } from "../redux/context/context";
import { useRef } from "react";
import { addTodo } from "../redux/actions/actions";


const TodoInput: React.FC = () => {
  const { dispatch } = useTodos();
  const [text, setText] = useState("");
  const inputRef = useRef<HTMLInputElement>(null);

  function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    if (text.trim()) {
      dispatch(addTodo(text.trim()));
      setText("");
    }
  }
  return (
    <form
      onSubmit={handleSubmit}
      style={{display:"flex", gap:8, marginBottom:20}}
      aria-label="Add Task"
    >
      <input
        ref={inputRef}
        value={text}
        onChange={e => setText(e.target.value)}
        placeholder="New Task..."
        style={{
          flex:1,
          padding:"8px 12px",
          borderRadius: 4,
          border: "1px solid #bbb",
          fontSize: 15
        }}
        aria-label="New Task"
      />
      <button
        type="submit"
        disabled={!text.trim()}
        style={{
          padding:"8px 20px",
          background:"#6236ff",
          color:"#fff",
          border:0,
          borderRadius:4,
          fontWeight:600,
          fontSize:15,
          cursor: text.trim() ? "pointer" : "not-allowed",
          opacity: text.trim() ? 1 : .5
        }}
      >
        Add
      </button>
    </form>
  );
};
export default TodoInput;