import React from 'react';
import RegularComponent from './RegularComponent';
import PureComponent from './PureComponent';

class ParentPureComponent extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			name:'Pure Component Demo'
		}
	}

	componentDidMount()
	{
		setInterval(()=>{
			this.setState({
				name: 'Pure Component Demo'
			})
		},5000)
	}

	render()
	{
		console.log('ParentPureComponent render method');
		return(
			<div>
			<h3>Parent Component</h3>
			<RegularComponent name={this.state.name} />
			<PureComponent name={this.state.name} />
			</div>
			)
	}
}

export default ParentPureComponent;