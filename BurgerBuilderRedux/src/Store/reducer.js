import * as actionTypes from './action';

const initialState = {
	ingredients : {
				salad:0,
			cheese:0,
			meat:0,
			bacon:0
			},
		totalPrice:50,
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


		default:
		return state;
	}

	return state;

};

export default reducer;