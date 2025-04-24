import '../styles/styles.css'
import { increment,decrement,reset } from '../redux/actions';
import { useDispatch, useSelector } from 'react-redux';
import { counterState } from '../redux/counterReducer';
import ButtonComponent from './Button';


const Counter:React.FC = ()=>{
    const count = useSelector((state:counterState)=>state.count);
    const dispatch = useDispatch();
    return(
        <div className="containter">
            <div className="counter">
                <span>{count}</span>
                <ButtonComponent content='+' callback={()=>dispatch(increment())}/>
                <ButtonComponent content='-' callback={()=>dispatch(decrement())}/>
                <ButtonComponent content='Reset' callback={()=>dispatch(reset())}/>
            </div>
        </div>
    )
}

export default Counter;