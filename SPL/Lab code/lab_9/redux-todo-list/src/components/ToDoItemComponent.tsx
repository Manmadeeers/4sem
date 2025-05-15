import React, { useState } from "react";
import { type Todo } from "../redux/types/types";
import { useTodos } from "../redux/context/context";
import { useRef } from "react";
import { useEffect } from "react";
import { editTodo, toggleTodo, deleteTodo } from "../redux/actions/actions";


type Props = { todo: Todo; };
const TodoItem: React.FC<Props> = ({ todo }) => {
  const { dispatch } = useTodos();
  const [isEditing, setEditing] = useState(false);
  const [text, setText] = useState(todo.text);
  const editRef = useRef<HTMLInputElement>(null);

  useEffect(() => { if (isEditing && editRef.current) editRef.current.focus(); }, [isEditing]);

  function handleEdit(e: React.FormEvent) {
    e.preventDefault();
    if (text.trim() && text.trim() !== todo.text) {
      dispatch(editTodo(todo.id, text.trim()));
    }
    setEditing(false);
  }
  return (
    <li style={{
      display: "flex", alignItems: "center", gap: 8, padding: "8px 0", borderBottom: "1px solid #ededed"
    }}>
      <input
        type="checkbox"
        checked={todo.completed}
        onChange={() => dispatch(toggleTodo(todo.id))}
        style={{ width: 18, height: 18, cursor: "pointer" }}
        aria-label="Change Status"
      />
      <div style={{ flex: 1 }}>
        {!isEditing ? (
          <span
            style={{
              wordBreak: "break-word",
              textDecoration: todo.completed ? "line-through" : "none",
              color: todo.completed ? "#999" : "#222",
              fontSize: 16,
              cursor: "pointer"
            }}
            tabIndex={0}
            title="Edit"
            role="button"
            aria-label="Edit Task"
            onClick={() => { setEditing(true); setText(todo.text); }}
            onKeyDown={e => {
              if (e.key === "Enter" || e.key === " ") { setEditing(true); setText(todo.text); }
            }}
          >{todo.text}</span>
        ) : (
          <form onSubmit={handleEdit} style={{ display: 'flex', alignItems: 'center', gap: 6 }}>
            <input
              ref={editRef}
              value={text}
              onChange={e => setText(e.target.value)}
              style={{
                flex: 1, fontSize: 16, padding: '2px 6px', border: "1px solid #bbb", borderRadius: 3
              }}
              aria-label="Edit Task Info"
              onBlur={() => setEditing(false)}
              onKeyDown={e => { if (e.key === "Escape") setEditing(false); }}
            />
            <button
              type="submit"
              style={{
                padding: "3px 12px", border: 0, background: "#3ad29c", color: "#222",
                borderRadius: 3, fontWeight: 600, cursor: "pointer"
              }}
              title="Save"
              aria-label="Save"
            >✔</button>
          </form>
        )}
      </div>
      <button
        style={{
          background: "none", border: 0, color: "#e33", fontSize: 18, cursor: "pointer",
          marginLeft: 2, padding: 2
        }}
        aria-label="Delete task"
        title="Delete"
        onClick={() => dispatch(deleteTodo(todo.id))}
      >×</button>
    </li>
  );
};
export default TodoItem;