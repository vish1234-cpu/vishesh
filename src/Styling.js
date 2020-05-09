import React from 'react';
import classes from './Styling.module.css';

class Styling extends React.Component
{
	

	render()
	{
		const cs = {
		color :'yellow',
		fontSize : '60px'
	}
		return(
			<div>
			<h2 style={{color:'green'}}>Inline Styles In React</h2>
			<h2 style={cs}>External Styles In React</h2>
			<h2 className={classes.headingTwo}>Css Modules In React</h2>
			</div>
			)
	}
}

export default Styling;