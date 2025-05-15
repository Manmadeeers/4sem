import { Provider } from 'react-redux'
import store from './redux/store'
import type React from 'react'
import './App.css'
import ToDoList from './components/ToDoList'

const App:React.FC = ()=>{
  return(
    <Provider store = {store}>
      <ToDoList/>
    </Provider>
  )
}
export default App
