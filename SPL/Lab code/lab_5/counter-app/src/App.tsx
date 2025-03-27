
import ButtonComponent from "./Button";
import { useState } from "react";

function App(){

  const [count, setCount] = useState(0);
  
  function handleIncreaseClick(){
    setCount(count+1);
    console.log(count);
  }
  function handleResetClick(){
    setCount(0);
  }

    return <div id="root">
        <div id="buttons">
          <ButtonComponent message="Increase" onclick={handleIncreaseClick}/>
          <ButtonComponent message="Reset" onclick={handleResetClick}/>
          <span>{count}</span>
        </div>
    </div>
}

export default App; 