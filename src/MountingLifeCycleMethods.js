import React from 'react';

class MountingMethod extends React.Component
{
	constructor()
	{
		super();

		this.state = {
			name:'vishesh kapoor'
		}
		console.log('*********************************************************');
		console.log('I am a Constructor');
	}

	static getDerivedStateFromProps(props,state)
	{
		console.log(' I am getStateDerivedFromProps method ');
		return null;
	}

	componentDidMount()
	{
		console.log('I am  componentDidMount method ');
	}
	render()
	{
		console.log('I am a render method');
		return(
			<div>
			<h3>Mounting Lifecycle methods,Go to Console</h3>
			</div>
			)
	}
}

export default MountingMethod;