import React from 'react';
import { ToastContainer } from "react-toastify";
import Routes from './routes';
import GlobalStyles from './styles/globalStyles';


const App: React.FC = () => {
  return (
    <>
      <GlobalStyles />
      <ToastContainer bodyStyle={{ fontSize: 16 }} />
      <Routes />
    </>
  )
}

export default App;
