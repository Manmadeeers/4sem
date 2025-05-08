import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './styles/styles.css';
import "./App.css"
import RegistrationForm from './components/RegistrationForm';
import LoginForm from './components/LoginForm';
import ResetPassword from './components/ResetPassword';
import { useState } from 'react';
import { dataStorage } from './components/personal';

function App() {
  const [personalData,setPersonalData] = useState<dataStorage[]>([]);
  const handleResigter = (user:dataStorage)=>{
    setPersonalData(prev=>([...prev,user]));
  }
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/sign-up/' element={<RegistrationForm callback={handleResigter} data={personalData}/>}/>
        <Route path='/sign-in/' element={<LoginForm data={personalData}/>}/>
        <Route path='/reset-pass/' element={<ResetPassword/>}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App
