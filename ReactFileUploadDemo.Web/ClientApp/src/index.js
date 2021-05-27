import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import Home from './Home';
import FileUpload from './FileUpload';
const rootElement = document.getElementById('root');

ReactDOM.render(<FileUpload />,  rootElement);