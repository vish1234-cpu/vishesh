import React from 'react';
import classes from './BuildControls.module.css';
import BuildControl from './BuildControl/BuildControl';

const buildControls = (props) =>
{
	const controls = [
	{label:'Salad' , type:'salad'},
	{label:'Bacon',  type:'bacon'},
	{label:'Cheese' , type:'cheese'},
	{label:'Meat' , type:'meat'}];
	return(
		<div className={classes.BuildControls}>
		<p>Current Price: {props.price}</p>
		{controls.map(ctrl=>(
			<BuildControl key={ctrl.label}
			 label={ctrl.label}
			  added={()=>props.ingredientAdded(ctrl.type)}
			   removed={()=>props.ingredientRemoved(ctrl.type)} 
			   disabledButton={props.disabled[ctrl.type]}/>
			))}

			<button className={classes.OrderButton}
			disabled={!props.purchasable}
			onClick={props.purchasing}>ORDER NOW</button>


		</div>
		)
}

export default buildControls;