import React, { useEffect , Suspense} from 'react';
import Layout from './components/Layout/Layout';
import BurgerBuilder from './Containers/BurgerBuilder/BurgerBuilder';
import Checkout from './Containers/Checkout/Checkout';
import {Route,Switch} from 'react-router-dom';
import Orders from './Containers/Orders/Orders';
import './App.css';
import Auth from './Containers/Auth/Auth';
import { connect } from 'react-redux';
import * as actions from './Store/action/index';
import Logout from './Containers/Auth/Logout/Logout';
//import { Route, Switch  } from 'react-router-dom';
import {withRouter, Redirect} from 'react-router-dom';
//import asyncComponent from './hoc/asyncComponent/asyncComponent';

const checkout = React.lazy(() => {
  return import('./Containers/Checkout/Checkout');
});

const orders = React.lazy(() => {
  return import('./Containers/Orders/Orders');
});

const auth = React.lazy(() => {
  return import('./Containers/Auth/Auth');
});



const app = (props) => {
const {onTryAutoSignup} = props;  // object destructuring for better dependencies in use effect
  useEffect(()=>{
    onTryAutoSignup();
  },[onTryAutoSignup]);


   
    let routes = (
      <Switch>
        <Route path="/auth" render={(props)=><Auth {...props} />} />
        <Route path="/" exact component={BurgerBuilder} />
        <Redirect to="/" />
      </Switch>
    );

    if (props.isAuthenticated ) {
      routes = (
        <Switch>
          <Route path="/checkout" render = { (props) => <Checkout {...props} /> } />
          <Route path="/orders" render = { (props) => <Orders {...props} /> } />
          <Route path="/logout" component={Logout} />
          <Route path="/auth" render= {(props) => <Auth {...props} />} />
          <Route path="/" exact component={BurgerBuilder} />
          <Redirect to="/" />
        </Switch>
      );
    }

    return (
      <div>
        <Layout>
         <Suspense fallback={<p>Loading.....</p>}>{routes}</Suspense>
        </Layout>
      </div>
    );
  }


const mapStateToProps = state => {
  return {
    isAuthenticated: state.auth.token !== null
  };
};

const mapDispatchToProps = dispatch => {
  return {
    onTryAutoSignup: () => dispatch( actions.authCheckState() )
  };
};

export default withRouter( connect( mapStateToProps, mapDispatchToProps )( app ) );
