import React from 'react';

class RegularComponent extends React.Component
{
	render()
	{
		console.log('RegularComponent render method');
		return(
			<div>
			{this.props.name}
			</div>
			)
	}
}

export default RegularComponent;