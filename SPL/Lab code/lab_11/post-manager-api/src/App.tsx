
import { Provider } from 'react-redux';
import store from './app/store';
import Posts from './features/posts/Posts';

const App = () => {
  return (
    <Provider store={store}>
      <Posts />
    </Provider>
  );
};

export default App;