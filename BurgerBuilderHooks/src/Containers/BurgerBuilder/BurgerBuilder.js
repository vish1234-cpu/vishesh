import React,{useState,useEffect} from 'react';
import Burger from '../../components/Burger/Burger';
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UserInterface/Modal/Modal';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';
import Aus from '../../hoc/aus';
import axios from '../../axios-orders';
import Spinner from '../../components/UserInterface/Spinner/Spinner';
import WithErrorHandler from '../../hoc/WithErrorHandler/WithErrorHandler';
import {connect} from 'react-redux';
//import * as actionTypes from '../../Store/action/actionTypes';
import * as burgerBuilderActions from '../../Store/action/index';
//import axios from '../../axios-orders';



 const burgerBuilder = (props) => 
{
	// constructor()
	// {
	// 	super();
	// 	this.state = {
	// 		// ingredients : {
	// 		// 	salad:0,
	// 		// cheese:0,
	// 		// meat:0,
	// 		// bacon:0
	// 		// },
	// 	//totalPrice:50,
	//     //purchasable:false,
	// 	purchasing:false
	// 	// loading: false,
	// 	}

	// }

	const [purchasing,setPurchasing] = useState(false);

	const {onInitIngredient} = props;

	useEffect(() => {

	onInitIngredient();
	
	},[onInitIngredient]);



	// componentDidMount()
	// {
	// 	this.props.onInitIngredient();
	// }

	const updatePurchasable = (ingredients) =>
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

	const purchaseHandler = () =>
	{
		 if (props.isAuthenticated) {
           setPurchasing(true);
        } else {
            props.onSetAuthRedirectPath('/checkout');
            props.history.push('/auth');
        }
	}

	const purchaseCancelHandler = () =>
	{
		setPurchasing(!purchasing);
	}

	const purchaseContinueHandler = () => // continue is now replaced with a post request. 
	{

		// const queryParams = [];
		// for(let i in this.state.ingredients){
		// 	queryParams.push(encodeURIComponent(i) + '=' + encodeURIComponent(this.state.ingredients[i]));
		// }
		// queryParams.push('price=' + this.state.totalPrice);
		// const queryString = queryParams.join('&');
		props.onInitPurchase();
		props.history.push('/checkout');
		//{
		// 	pathname:'/checkout',
		// 	search: '?' + queryString
		// });
	    //}
}
		


	
		const disabledInfo = {
			// ...this.state.ingredients
			...props.ings
		};
		for(let key in disabledInfo)
		{
			disabledInfo[key]=disabledInfo[key]<=0;
		}

		 let orderSummary = null;
        let burger = props.error ? <p>Ingredients cant be loaded!</p> : <Spinner />;

          if ( props.ings ) {
            burger = (
                <Aus>
                    <Burger ingredients={props.ings} />
                    <BuildControls
                        ingredientAdded={props.onIngredientAdded}
                        ingredientRemoved={props.onIngredientRemoved}
                        disabled={disabledInfo}
                        purchasable={updatePurchasable(props.ings)}
                        ordered={purchaseHandler}
                        price={props.price} />
                </Aus>
            );
            orderSummary = <OrderSummary
                ingredients={props.ings}
                price={props.price}
                purchaseCancelled={purchaseCancelHandler}
                purchaseContinue={purchaseContinueHandler} />;
        }

//          if ( this.props.ings ) {
//             burger = (
//                 <Aux>
//                     <Burger ingredients={this.props.ings} />
//                     <BuildControls
//                         ingredientAdded={this.props.onIngredientAdded}
//                         ingredientRemoved={this.props.onIngredientRemoved}
//                         disabled={disabledInfo}
//                         purchasable={this.updatePurchaseState(this.props.ings)}
//                         ordered={this.purchaseHandler}
//                         price={this.props.price} />
//                 </Aux>


//     orderSummary = <OrderSummary ingredients={this.props.ings}
//     price={this.props.price}
//     purchaseCancelled={this.purchaseCancelHandler}
//     purchaseContinue={this.purchaseContinueHandler}/>;

// }

  //   if(this.props.loading)
  //   {

		// orderSummary= <Spinner/>;
  //   }

    return(

    <Aus>

    <Modal show={purchasing} modelClosed={purchaseCancelHandler}>
   {orderSummary}
    </Modal>
    {burger}
    </Aus>
    )

   
}

const mapDispatchToProps = dispatch => {
	return {
		onIngredientAdded : (ingName) => dispatch(burgerBuilderActions.addIngredient(ingName)),
		onIngredientRemoved : (ingName) => dispatch(burgerBuilderActions.removeIngredient(ingName)),
		onInitIngredient : () => dispatch(burgerBuilderActions.initIngredient()),
		onInitPurchase : () => dispatch(burgerBuilderActions.purchaseInit()),
		onSetAuthRedirectPath: (path) => dispatch(burgerBuilderActions.setAuthRedirectPath(path))	
	};

}

const mapStateToProps = state => {
return{
	ings: state.burgerBuilder.ingredients,
	price : state.burgerBuilder.totalPrice,
	error : state.burgerBuilder.error,
    isAuthenticated: state.auth.token !== null
};
}

export default connect(mapStateToProps,mapDispatchToProps) (WithErrorHandler(burgerBuilder,axios));