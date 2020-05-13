import React from 'react';
import Burger from '../../components/Burger/Burger';
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UserInterface/Modal/Modal';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';
import Aus from '../../hoc/aus';
import axios from '../../axios-orders';
import Spinner from '../../components/UserInterface/Spinner/Spinner';
import WithErrorHandler from '../../hoc/WithErrorHandler/WithErrorHandler';
import {connect} from 'react-redux';
import * as actionTypes from '../../Store/action';


class BurgerBuilder extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			// ingredients : {
			// 	salad:0,
			// cheese:0,
			// meat:0,
			// bacon:0
			// },
		//totalPrice:50,
	    //purchasable:false,
		purchasing:false,
		loading: false,
		}

	}

	updatePurchasable(ingredients)
	{
		const sum = Object.keys(ingredients)
		.map(igkey=>{
			return ingredients[igkey];
		}).reduce((sum,ele)=>{
			return sum+ele;
		},0);
		return sum>0;

	}

	// addIngredientHandler=(type)=>
	// {
	// 	const oldCount = this.state.ingredients[type];
	// 	const updateCount = oldCount+1;
	// 	const updateIngredients = {
	// 		...this.state.ingredients
	// 	};
	// 	updateIngredients[type]=updateCount;
	// 	const priceAddition = ingredientPrice[type];
	// 	const oldPrice = this.state.totalPrice;
	// 	const newPrice = oldPrice+priceAddition;
	// 	this.setState({totalPrice:newPrice,ingredients:updateIngredients})
	// 	this.updatePurchasable(updateIngredients);

	// }

	// removeIngredientHandler=(type)=>
	// {
	// 	const oldCount = this.state.ingredients[type];
	// 	if(oldCount<=0)
	// 	{
	// 		return;
	// 	}
	// 	const updateCount = oldCount-1;
	// 	const updateIngredients = {
	// 		...this.state.ingredients
	// 	};
	// 	updateIngredients[type]=updateCount;
	// 	const priceDeduction = ingredientPrice[type];
	// 	const oldPrice = this.state.totalPrice;
	// 	const newPrice = oldPrice-priceDeduction;
	// 	this.setState({totalPrice:newPrice,ingredients:updateIngredients})
	// 	this.updatePurchasable(updateIngredients);

	// }

	purchaseHandler = () =>
	{
		this.setState({purchasing:true})
	}

	purchaseCancelHandler = () =>
	{
		this.setState({purchasing:false})
	}

	purchaseContinueHandler = () => // continue is now replaced with a post request. 
	{

		// const queryParams = [];
		// for(let i in this.state.ingredients){
		// 	queryParams.push(encodeURIComponent(i) + '=' + encodeURIComponent(this.state.ingredients[i]));
		// }
		// queryParams.push('price=' + this.state.totalPrice);
		// const queryString = queryParams.join('&');

		this.props.history.push('/checkout')
		{
		// 	pathname:'/checkout',
		// 	search: '?' + queryString
		// });
	}
}
		


	render()
	{
		const disabledInfo = {
			// ...this.state.ingredients
			...this.props.ings
		};
		for(let key in disabledInfo)
		{
			disabledInfo[key]=disabledInfo[key]<=0;
		}

	let orderSummary = <OrderSummary ingredients={this.props.ings}
    price={this.props.price}
    purchaseCancelled={this.purchaseCancelHandler}
    purchaseContinue={this.purchaseContinueHandler}/>;

    if(this.state.loading)
    {

		orderSummary= <Spinner/>;
    }

    return(

    <Aus>

    <Modal show={this.state.purchasing} modelClosed={this.purchaseCancelHandler}>
   {orderSummary}
    </Modal>

    <Burger ingredients={this.props.ings} />

	<BuildControls ingredientAdded={this.props.onIngredientAdded} 
	ingredientRemoved={this.props.onIngredientRemoved}
    disabled={disabledInfo}
    purchasable={this.updatePurchasable(this.props.ings)}
    purchasing={this.purchaseHandler}
    price={this.props.price}/>

	</Aus>
			)
	}
}

const mapDispatchToProps = dispatch => {
	return {
		onIngredientAdded : (ingName) => dispatch({type:actionTypes.ADD_INGREDIENT,ingredientName:ingName}),
		onIngredientRemoved : (ingName) => dispatch({type:actionTypes.REMOVE_INGREDIENT,ingredientName:ingName})		
	};

}

const mapStateToProps = state => {
return{
	ings: state.ingredients,
	price : state.totalPrice
};
}

export default connect(mapStateToProps,mapDispatchToProps) (WithErrorHandler(BurgerBuilder,axios));