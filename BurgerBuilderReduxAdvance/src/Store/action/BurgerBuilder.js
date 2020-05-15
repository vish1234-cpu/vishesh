import * as actionTypes from './actionTypes';
import axios from '../../axios-orders';


export const addIngredient = (name) => {

	return {
		type: actionTypes.ADD_INGREDIENT,
		ingredientName: name

	};

};

export const removeIngredient = (name) => {

	return {
		type: actionTypes.REMOVE_INGREDIENT,
		ingredientName: name

	};

};

export const fetchIngredientfailed = () => {

	return  {
		type: actionTypes.FETCH_INGREDIENT_FAILED
	};

};

export const setIngredient = (ingredients) => {

	return {
		type: actionTypes.SET_INGREDIENT,
		ingredients : ingredients
	};

};

export const initIngredient = () => {

	return dispatch => {
		axios.get('https://burger-builder-project-b091c.firebaseio.com/ingredients.json')
		.then(response => {
			dispatch(setIngredient(response.data))
		})
		.catch(error=>{
			dispatch(fetchIngredientfailed());
		});
		

	};

};