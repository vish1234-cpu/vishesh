import React from 'react';

class PureComponent extends React.PureComponent 
{
	render()
	{
		console.log('PureComponent render method');
		return(
			<div>
			{this.props.name}
			</div>
			)
	}

}

export default PureComponent;