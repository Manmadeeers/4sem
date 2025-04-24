import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { Provider } from 'react-redux'
import { counterStore } from './redux/counterStore.ts'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <Provider store={counterStore}>
      <App />
    </Provider>

  </StrictMode>,
)
