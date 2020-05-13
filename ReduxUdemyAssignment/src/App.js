import React, { Component } from 'react';

import Persons from './containers/Persons';

class App extends Component {
  render() {
    return (
      <div className="App">
        <h2 style={{color:'blue',textAlign:'center'}} > UDEMY ASSIGNMENT ON REDUX BASICS</h2>
        <h3 style={{color:'green',textAlign:'center'}}>click on below button to add a new Person data</h3>
      <Persons />
      </div>
    );
  }
}

export default App;
