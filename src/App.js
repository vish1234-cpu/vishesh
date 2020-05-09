import React, { Component } from 'react';
import Ref from './Ref';
import MemoParent from './MemoParent';
import ParentPureComponent from './ParentPureComponent';
import Fragment from'./Fragment';
import MountingMethod from './MountingLifeCycleMethods';
import UpdateMethod from './UpdatingLifeCycleMethods';
import Styling from './Styling';
import Effect from './UseEffect';
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
      <Ref/>
      <br></br>
      <Fragment/>
      <br></br>
      <MemoParent/>
      <br></br>
      <ParentPureComponent/>
      <br></br>
      <MountingMethod/>
      <br></br>
      <UpdateMethod/>
      <br></br>
      <Styling/>
      <br></br>
      <Effect/>
      </div>
    );
  }
}

export default App;
