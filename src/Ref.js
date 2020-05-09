import React from 'react';

class ParentRef extends React.Component
{
	constructor()
	{
		super();
		this.inputRef = React.createRef()
		this.state = {
			name:''
		}

	}

	componentDidMount()
	{
	    this.inputRef.current.focus() // this will give the focus on the input space when the page will render.
	}

	clickHandler=()=>
	{
		alert(` Hello !! ${this.state.name} Hope You are fine.`);
	}

	render()
	{
		return(
			<div>
			<h3>Enter your name below:</h3>
			<p style={{color:'red'}}>The focus on textbox is the use case of ref</p>
			<input type="text" ref={this.inputRef} onChange={(e)=>this.setState({name:e.target.value})}/>
			<button onClick = {this.clickHandler}>Click Me</button>
			</div>
			)
	}
}

export default ParentRef;