import '../styles/styles.css'
import React, { useState } from "react";
import ButtonComponent from "./Button";
import { useDispatch, useSelector } from 'react-redux';



const Counter:React.FC = ()=>{
    const count = useSelector((state:number)=>state)
    return(
        <div className="containter">
            <div className="counter">
                <span>{count}</span>
                <ButtonComponent content="+" callback={()=}/>
                <ButtonComponent content="-" callback={handleClick}/>
                <ButtonComponent content="Reset" callback={handleClick}/>
            </div>
        </div>
    )
}

export default Counter;