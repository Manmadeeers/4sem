  import logo from './logo.svg';
  import './App.css';
  import './Buttons'
import buttonComponent from './Buttons';


  function App() {
  
    return (
      <div className="App">
        {buttonComponent("Increase")}
        {buttonComponent("Decrease")}
      </div>
    );
  }   
  export default App;
