import TodoInput from "./AddTodoComponent";
import TodoStatsFooter from "./ToDoFooter";
import TodoList from "./List";
import { TodoProvider } from "../redux/context/context";


const TodoApp: React.FC = () => (
  <TodoProvider>
    <div
      style={{
        minHeight:"100vh",
        background:"#f6f7fa",
        display:"flex", flexDirection:"column", alignItems:"center",
        fontFamily:"Arial, sans-serif", color:"#222"
      }}
    >
      <div style={{
        width:"100%",
        maxWidth:390,
        margin:"40px 0 16px",
        borderRadius:14,
        boxShadow:"0 3px 16px #0001",
        background:"#fff",
        padding:22,
        border:"1px solid #ececec"
      }}>
        <h1 style={{
          fontSize:23, fontWeight:700, margin:"0 0 14px", letterSpacing:"0.5px",color:'#6236ff'
        }}>ToDo List</h1>
        <TodoInput />
        <TodoList />
        <TodoStatsFooter />
      </div>
     
    </div>
  </TodoProvider>
);

export default TodoApp;
