import React from 'react';
import ReactDOM from 'react-dom/client';
import './App/layout/styles.css';
//import App from './App/layout/App';
import reportWebVitals from './reportWebVitals';
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';
import { Typography } from '@mui/material';
import DepartureQuery from './App/features/departureboard/DepartureQuery';
import Footer from './App/features/departureboard/Footer';


const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <>
    <Typography variant='h1' sx={{ textAlign: "center" }}>Online Departureboard</Typography>
    <DepartureQuery />
    <Footer />
  </>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
