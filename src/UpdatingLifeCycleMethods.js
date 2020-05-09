import React from 'react';

class UpdateMethod extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			name:'Hello How are you'
		}

		console.log('*********************************************************');
		console.log('I am Constructor');
	}

	static getDerivedStateFromProps(props,state)
	{
		console.log(' I am getStateDerivedFromProps method ');
		return null;
	}

	componentDidUpdate()
	{
		console.log('I am componentDidUpdate method');
	}

	clickHandler = () =>
	{
		this.setState({
			name:'Ok Bye'
		})
	}

	render()
	{
		console.log('I am Render Method');
		return(
			<div>
			<h3>Update Lifecycle methods,Go to Console</h3>
			<h4>{this.state.name}</h4>
			<button onClick={this.clickHandler}>Update</button>
			</div>
			)
	}
}

export default UpdateMethod;