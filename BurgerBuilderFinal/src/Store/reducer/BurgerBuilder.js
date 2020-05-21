import * as actionTypes from '../action/actionTypes';

const initialState = {
	ingredients : 0,
		totalPrice:50,
		loading: false,
		error:false
	};

	const ingredientPrice ={
	salad:10,
	bacon:40,
	cheese:30,
	meat:50
}

const reducer = (state = initialState , action) => {

	switch(action.type){
		case actionTypes.ADD_INGREDIENT:
		return {
			...state,
			ingredients: {
				...state.ingredients,
				[action.ingredientName]: state.ingredients[action.ingredientName] + 1
			},
			totalPrice :  state.totalPrice+ingredientPrice[action.ingredientName]

		};

		case actionTypes.REMOVE_INGREDIENT:
		return {
			...state,
			ingredients: {
				...state.ingredients,
				[action.ingredientName]: state.ingredients[action.ingredientName] - 1
			},
			totalPrice :  state.totalPrice-ingredientPrice[action.ingredientName]

		};

		case actionTypes.SET_INGREDIENT:
		return {
			...state,
			ingredients:{
				salad:action.ingredients.salad,
				cheese:action.ingredients.cheese,
				meat:action.ingredients.meat,
				bacon:action.ingredients.bacon
			},
			totalPrice:50,
			error: false
		};

		case actionTypes.FETCH_INGREDIENT_FAILED:
		return {
			...state,
			error:true
		};

		default:
		return state;
	}


};

export default reducer;