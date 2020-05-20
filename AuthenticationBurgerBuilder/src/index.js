import React from 'react';
import ReactDOM from 'react-dom';
import {BrowserRouter} from 'react-router-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import {createStore , applyMiddleware , compose , combineReducers} from 'redux';
import {Provider} from 'react-redux';
import burgerBuilderReducer from './Store/reducer/BurgerBuilder';
import thunk from 'redux-thunk'; // thunk is used for adding asyn code in the application 
import orderReducer from './Store/reducer/order';
import authReducer from './Store/reducer/auth';


const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose; // here we have used advance redux setup.

const rootReducer = combineReducers({
	burgerBuilder:burgerBuilderReducer,
	order:orderReducer,
	auth: authReducer
});

const store = createStore(rootReducer, composeEnhancers( // store is created using enhancers
	applyMiddleware(thunk)
	));

const app = (
	<Provider store={store}>
	<BrowserRouter>
	<App />
	</BrowserRouter>
	</Provider>
	);

ReactDOM.render(app, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: http://bit.ly/CRA-PWA
serviceWorker.unregister();
