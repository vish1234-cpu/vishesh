import React from 'react';
import Aus from '../../../hoc/aus';
import Button from '../../UserInterface/Button/Button';


const orderSummary=(props)=>
{
	const ingredientSummary = Object.keys(props.ingredients)
	.map(igkey => {
		return <li key={igkey}><span>{igkey}</span>: {props.ingredients[igkey]}</li>
	});
	

	return(
	<Aus>
	<h3>Your Order</h3>
	<p>Delicious burger with the following ingredients:</p>
	<ul>
	{ingredientSummary}
	</ul>
	<p><strong>Total Price:{props.price}</strong></p>
	<p>Continue to checkout?</p>
	<Button btnType="Danger" clicked={props.purchaseCancelled}>Cancel</Button>
	<Button btnType="Success" clicked={props.purchaseContinue}>Continue</Button>
	</Aus>
	)
}

export default orderSummary;