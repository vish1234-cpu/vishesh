import React from 'react';
//import axios from '../../axios-orders';
import Order from '../../components/Orders/Orders';
import * as orderActions from '../../Store/action/index';
import {connect} from 'react-redux';
import Spinner from '../../components/UserInterface/Spinner/Spinner';



class Orders extends React.Component
{
	// constructor()
	// {
	// 	super();
	// 	// this.state = {

	// 	// 	orders : [],
	// 	// 	loading :  true
	// 	// }
	// }

	componentDidMount()
	{
		this.props.onFetchOrders(this.props.token, this.props.userId);
	}
	// componentDidMount()
	// {
	// 	axios.get('/orders.json')
	// 	.then(response=>{
	// 		const fetchedOrders = [];
	// 		for(let key in response.data)
	// 		{
	// 			fetchedOrders.push({...response.data[key], id: key});
	// 		}
	// 		this.setState({loading:false,orders:fetchedOrders})
	// 	})
	// 	.catch(error=>{
	// 		this.setState({loading:false})
	// 	})
	// }
	 render () {
	 	let orders = <Spinner />;
        if ( !this.props.loading ) {

            orders = this.props.orders.map( order => (
                <Order
                    key={order.id}
                    ingredients={order.ingredients}
                    price={order.price} />
            ) )
        }
        return (
            <div>
                {orders}
            </div>
        );
    }
}

const mapStateToProps = state  => {
	return {
		orders : state.order.orders,
		loading : state.order.loading,
        token: state.auth.token,
        userId: state.auth.userId
	};
}

const matchDispatchToProps = dispatch => {
	return {
		onFetchOrders : (token, userId) => dispatch(orderActions.fetchOrder(token, userId))
	};
}

export default connect(mapStateToProps,matchDispatchToProps)(Orders) ;