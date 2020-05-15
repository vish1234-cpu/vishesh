import React from 'react';
import classes from './Burger.module.css';
import BurgerIngredients from '../BurgerIngredients/BurgerIngredients';
const burger = (props) =>
{
	let transformIngredient = Object.keys(props.ingredients)
	.map(ingredientkey => {
		return [...Array(props.ingredients[ingredientkey] )].map(( _, i) => {
			return <BurgerIngredients key={ingredientkey+i} type={ingredientkey} />;
		});

	})
	.reduce((arr,el)=>{
		return arr.concat(el)
	},[]);
	if(transformIngredient.length===0)
	{
		transformIngredient = <p>Start Adding Some Ingredients!</p>
	}
	return(
		<div className={classes.Burger}>
		<BurgerIngredients type="bread-top"/>
		{transformIngredient}
		<BurgerIngredients type="bread-bottom"/>
		</div>
		);

};

export default burger; 