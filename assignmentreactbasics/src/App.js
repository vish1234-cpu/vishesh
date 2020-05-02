import React, { Component } from 'react';
import AddFruitRow from './Fruits';
import './style.css';
import './App.css';

class App extends Component {
   constructor(props)
  {
    super(props);
    this.state={
      fruitsList:[],
      inputText:' ',
      newFruitDetails:{
        name:' ',
        quantity:' '
      }
    }
  }

  textboxHandler=(e)=>{

    let inputStr=e.target.value;
    let fruit=inputStr.split("-")[0];
    let quant=inputStr.split("-")[1];
    this.setState({
      inputText:inputStr,
      newFruitDetails:{
        name:fruit,
        quantity:quant
      }
    })
  }

  /*This is called when button is clicked,
  and new fruit is added in the table by adding the fruit in the fruitList array in the state*/

  newFruit=(e)=>{

    e.preventDefault();
    const newFruitDetails=this.state.newFruitDetails;
    if(newFruitDetails.name!== " " )
    {
      const items=[...this.state.fruitsList,newFruitDetails];
      this.setState({
        fruitsList:items,
        inputText:' ',
        newFruitDetails:{
         name:' ',
          quantity:' '
       }
      });
    }
  }

  /*This event is called when delete button is clicked and 
  it updates the fruitsList array in the state with the remaining fruits*/

  removeFruitRecord=(name)=>{
    const remainingFruits=this.state.fruitsList.filter(item=>
      item.name!==name);
      console.log(remainingFruits);
      this.setState({
        fruitsList:remainingFruits
      })
  }

  render(){

  return (
  <div>
    <header>
    <form onSubmit={this.newFruit} >
    <h1>ENTER A FRUIT WITH A QUANTITY:</h1>
    <br></br> 
      <input type="text" placeholder="Enter fruit and quantity"  value={this.state.inputText} onChange={this.textboxHandler}></input>
      <button type="submit">Add Fruit</button>
    </form>
    <p>{this.state.fruitsList.name}</p>
    <table className="table">
      <thead>
        <tr>
        <th>
          Fruit
        </th>
        <th>
          Quantity
        </th>
        <th></th>
        </tr>
      </thead>
      <tbody>
        <AddFruitRow fruitsList={this.state.fruitsList} removeFruitRecord={this.removeFruitRecord}></AddFruitRow>
      </tbody>
    </table>
    </header>
    </div>
  );
}}


export default App;
