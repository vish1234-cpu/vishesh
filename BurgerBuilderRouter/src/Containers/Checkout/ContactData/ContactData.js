import React from 'react';
import classes from './ContactData.module.css';
import Button from '../../../components/UserInterface/Button/Button';
import axios from '../../../axios-orders';
import Spinner from '../../../components/UserInterface/Spinner/Spinner';
class ContactData extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			name: '',
			email:'',
			address: {
				street: '',
				postalCode:''
			},
			loading:false
		}
	}

	orderHandler = (event) =>
	{
		event.preventDefault();
		this.setState({loading: true});
		const order = {
			ingredients : this.props.ingredients,
			price : this.props.price,
			customer : {
				name:'Vidwan Kumar',
				address : {
					street:'delhi street',
					zipCode:201006,
					country:'India'
				},
				emailId : 'Vijay@test.com'
			},
			deliveryMethod:'fastest'
		}
		//alert('You Continue!');
		axios.post('/orders.json',order)
		.then(response => {
			this.setState({loading:false})
			this.props.history.push('/');
		})
		.catch(error => {
			this.setState({loading:false})
		});
	}

	render()
	{
		let form = (
			<form>
			<input className={classes.Input} type="text" name="name" placeholder="Enter your Name" />
			<input className={classes.Input} type="text" name="email" placeholder="Enter your email" />
			<input className={classes.Input} type="text" name="street" placeholder="Enter your street" />
			<input className={classes.Input} type="text" name="postalCode" placeholder="Enter your postal code"/>
			<Button clicked={this.orderHandler} btnType="Success">Order</Button>
			</form>
			);
		if(this.state.loading)
		{
			form = <Spinner />;
		}
		return(
			<div className={classes.ContactData}>
			<h4>Enter your Contact Data</h4>
			{form}
			</div>
			)
	}
}

export default ContactData;