import React, { Component } from 'react';
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



class App extends Component {

  componentDidMount () {
    this.props.onTryAutoSignup();
  }

   render () {
    let routes = (
      <Switch>
        <Route path="/auth" component={Auth} />
        <Route path="/" exact component={BurgerBuilder} />
        <Redirect to="/" />
      </Switch>
    );

    if ( this.props.isAuthenticated ) {
      routes = (
        <Switch>
          <Route path="/checkout" component={Checkout} />
          <Route path="/orders" component={Orders} />
          <Route path="/logout" component={Logout} />
          <Route path="/" exact component={BurgerBuilder} />
          <Redirect to="/" />
        </Switch>
      );
    }

    return (
      <div>
        <Layout>
          {routes}
        </Layout>
      </div>
    );
  }
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

export default withRouter( connect( mapStateToProps, mapDispatchToProps )( App ) );
