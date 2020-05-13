import React from 'react';
import classes from './ContactData.module.css';
import Button from '../../../components/UserInterface/Button/Button';
import axios from '../../../axios-orders';
import Spinner from '../../../components/UserInterface/Spinner/Spinner';
import Input from '../../../components/UserInterface/Input/Input';
import {connect} from 'react-redux';

class ContactData extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			orderForm : {

				name:{
					elementType: 'input',
					elementConfig: {
						type:'text',
						placeholder: 'your name'
					},
					value:'',
					validation : {
						required:true
					},
					valid : false,
					touched : false
				},

				street:{
					elementType: 'input',
					elementConfig: {
						type:'text',
						placeholder: 'your street'
					},
					value:'',
					validation : {
						required:true
					},
					valid : false,
					touched : false
				},

				zipCode:{
					elementType: 'input',
					elementConfig: {
						type:'text',
						placeholder: 'ZIPCODE'
					},
					value:'',
					validation : {
						required:true,
						minLength:6,
						maxLength:6
					},
					valid : false,
					touched : false
				},

				country:{
					elementType: 'input',
					elementConfig: {
						type:'text',
						placeholder: 'COUNTRY'
					},
					value:'',
					validation : {
						required:true
					},
					valid : false,
					touched : false
				},

				emailId : {
					elementType: 'input',
					elementConfig: {
						type:'text',
						placeholder: 'EMAIL'
					},
					value:'',
					validation : {
						required:true
					},
					valid : false,
					touched : false
				},

				deliveryMethod:{
					elementType: 'select',
					elementConfig: {
						options:[
						{value:'fastest',displayValue:'Fastest'},
						{value:'cheapest',displayValue:'Cheapest'}
						]
					},
					value:'fastest',
					validation:{},
					valid : true
				}

			},
			formIsValid:false,
			loading:false
		}
	}

	orderHandler = (event) =>
	{
		event.preventDefault();
		this.setState({loading: true});
		const formData={};
		for(let formElementIdentifier in this.state.orderForm)
		{
			formData[formElementIdentifier] = this.state.orderForm[formElementIdentifier].value;
		}
		const order = {
			ingredients : this.props.ings,
			price : this.props.price,
			orderData :formData
			
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

	checkValidity(value,rules)
	{
		let isValid:true

		if(!rules)
		{
			return true; 
		}

		if(rules.required){
			isValid = value.trim() !== ' ' && isValid;
		}

		if(rules.minLength){
			isValid = value.length >= rules.minLength && isValid;
		}

		if(rules.maxLength){
			isValid = value.length <= rules.maxLength && isValid;
		}

		return isValid;
	}

	inputChangeHandler = (event,inputIdentifier) =>
	{
		const updatedOrderForm = {
			...this.state.orderForm
		}
		const updatedFormElement={
			...updatedOrderForm[inputIdentifier]
		};
		updatedFormElement.value=event.target.value;
		updatedFormElement.valid=this.checkValidity(updatedFormElement.value,updatedFormElement.validation)
		console.log(updatedFormElement);
		updatedFormElement.touched = true;
		updatedOrderForm[inputIdentifier] = updatedFormElement;

		let formIsValid = true;
		for(let inputIdentifier in updatedOrderForm)
		{
			formIsValid = updatedOrderForm[inputIdentifier].valid && formIsValid;
		}
		this.setState({orderForm:updatedOrderForm,formIsValid:formIsValid});
	}

	render()
	{
		const formElementArray=[];
		for(let key in this.state.orderForm){
			formElementArray.push({
				id : key,
				config : this.state.orderForm[key]
			});

		}

		let form = (
			<form onSubmit={this.orderHandler}>

			{formElementArray.map(formElement=>(
				<Input
				key={formElement.id}
				elementType={formElement.config.elementType}
				elementConfig={formElement.config.elementConfig}
				value={formElement.config.value}
				invalid={ !formElement.config.valid}
				shouldValid={formElement.config.validation}
				touched={formElement.config.touched}
				changed={(event)=>this.inputChangeHandler(event,formElement.id)} />
				))}

			<Button btnType="Success" disabled={this.state.formIsValid}>Order</Button>
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

const mapStateToProps = state => {
	return{
		ings : state.ingredients,
		price:state.totalPrice
	};
}


export default connect(mapStateToProps) (ContactData);