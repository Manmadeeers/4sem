import React from "react";
import AddToDoComponent from "./components/AddToDoComponent";
import TodoListComponent from "./components/ListComponent";
import TodoStatsFooter from "./components/ToDoFooterComponent";
import { Provider } from "react-redux";
import store from "./redux/store";
import "./styles/ToDoStyle.css"

const App: React.FC = () => {
    return (
        <Provider store={store}>
            <div className="container">
                <h1>ToDo List</h1>
                <AddToDoComponent />
                <TodoListComponent />
                <TodoStatsFooter />
            </div>
        </Provider>
    );
};

export default App;