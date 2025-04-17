import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './styles/styles.css';
import "./App.css"
import RegistrationForm from './components/RegistrationForm';
import LoginForm from './components/LoginForm';
import ResetPassword from './components/ResetPassword';

function App() {
  

  return (
    <BrowserRouter>
      <Routes>
        <Route path='sign-up' element={<RegistrationForm/>}/>
        <Route path='/sign-in/' element={<LoginForm/>}/>
        <Route path='reset-password' element={<ResetPassword/>}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App
