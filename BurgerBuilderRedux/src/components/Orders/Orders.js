import React from 'react';
import classes from './Orders.module.css';

const orders = (props) =>{

	const ingredients = [];
	for(let Ingredientsname in props.ingredients)
	{
		ingredients.push({
			name:Ingredientsname,amount: props.ingredients[Ingredientsname]
		});
	}

	const ingredientOutput = ingredients.map(ig=>{
		return <span style={{textTransform:'capitalize',display:'inline-block',margin:'0 8px',border:'1px solid #ccc',padding:'5px'}} key={ig.name}>{ig.name} ({ig.amount})</span>
	});
	return(
		<div className={classes.Orders}>
		<p>Ingredients: {ingredientOutput}</p>
		</div>
		)
}

export default orders;