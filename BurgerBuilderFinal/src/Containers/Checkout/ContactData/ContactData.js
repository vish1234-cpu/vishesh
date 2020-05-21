import React,{useState} from 'react';
import classes from './ContactData.module.css';
import Button from '../../../components/UserInterface/Button/Button';
import axios from '../../../axios-orders';
import Spinner from '../../../components/UserInterface/Spinner/Spinner';
import Input from '../../../components/UserInterface/Input/Input';
import {connect} from 'react-redux';
import withErrorHandler from '../../../hoc/WithErrorHandler/WithErrorHandler';
import * as contactDataActions from '../../../Store/action/index';
import {updateObject,checkValidity} from '../../../shared/utility';


const contactData = (props) =>
{
   const [orderForm,setOrderForm] = useState({
        name:{
                    elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'Your Name'
                },
                value: '',
                validation: {
                    required: true
                },
                valid: false,
                touched: false
            },
            street: {
                elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'Street'
                },
                value: '',
                validation: {
                    required: true
                },
                valid: false,
                touched: false
            },
            zipCode: {
                elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'ZIP Code'
                },
                value: '',
                validation: {
                    required: true,
                    minLength: 5,
                    maxLength: 5,
                    isNumeric: true
                },
                valid: false,
                touched: false
            },
            country: {
                elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'Country'
                },
                value: '',
                validation: {
                    required: true
                },
                valid: false,
                touched: false
            },
            email: {
                elementType: 'input',
                elementConfig: {
                    type: 'email',
                    placeholder: 'Your E-Mail'
                },
                value: '',
                validation: {
                    required: true,
                    isEmail: true
                },
                valid: false,
                touched: false
            },
            deliveryMethod: {
                elementType: 'select',
                elementConfig: {
                    options: [
                        {value: 'fastest', displayValue: 'Fastest'},
                        {value: 'cheapest', displayValue: 'Cheapest'}
                    ]
                },
                value: '',
                validation: {},
                valid: true
            }
    });

   const [formIsValid,setFormIsValid] = useState(false);

	// constructor()
	// {
	// 	super();
	// 	this.state = {
	// 		orderForm : {

	// 			name:{
	// 				elementType: 'input',
 //                elementConfig: {
 //                    type: 'text',
 //                    placeholder: 'Your Name'
 //                },
 //                value: '',
 //                validation: {
 //                    required: true
 //                },
 //                valid: false,
 //                touched: false
 //            },
 //            street: {
 //                elementType: 'input',
 //                elementConfig: {
 //                    type: 'text',
 //                    placeholder: 'Street'
 //                },
 //                value: '',
 //                validation: {
 //                    required: true
 //                },
 //                valid: false,
 //                touched: false
 //            },
 //            zipCode: {
 //                elementType: 'input',
 //                elementConfig: {
 //                    type: 'text',
 //                    placeholder: 'ZIP Code'
 //                },
 //                value: '',
 //                validation: {
 //                    required: true,
 //                    minLength: 5,
 //                    maxLength: 5,
 //                    isNumeric: true
 //                },
 //                valid: false,
 //                touched: false
 //            },
 //            country: {
 //                elementType: 'input',
 //                elementConfig: {
 //                    type: 'text',
 //                    placeholder: 'Country'
 //                },
 //                value: '',
 //                validation: {
 //                    required: true
 //                },
 //                valid: false,
 //                touched: false
 //            },
 //            email: {
 //                elementType: 'input',
 //                elementConfig: {
 //                    type: 'email',
 //                    placeholder: 'Your E-Mail'
 //                },
 //                value: '',
 //                validation: {
 //                    required: true,
 //                    isEmail: true
 //                },
 //                valid: false,
 //                touched: false
 //            },
 //            deliveryMethod: {
 //                elementType: 'select',
 //                elementConfig: {
 //                    options: [
 //                        {value: 'fastest', displayValue: 'Fastest'},
 //                        {value: 'cheapest', displayValue: 'Cheapest'}
 //                    ]
 //                },
 //                value: '',
 //                validation: {},
 //                valid: true
 //            }
 //        },
 //        formIsValid: false,
 //        //loading: false
	// 		//loading:false
	// 	}
	// }

	const orderHandler = (event) =>
	{
		event.preventDefault();
		// this.setState({loading: true});
		const formData={};
		for(let formElementIdentifier in orderForm)
		{
			formData[formElementIdentifier] = orderForm[formElementIdentifier].value;
		}
		const order = {
			ingredients : props.ings,
			price : props.price,
			orderData :formData,
            userId: props.userId
			
		}

		props.onOrderBurger(order,props.token);
		//alert('You Continue!');
		// axios.post('/orders.json',order)
		// .then(response => {
		// 	this.setState({loading:false})
		// 	this.props.history.push('/');
		// })
		// .catch(error => {
		// 	this.setState({loading:false})
		// });
	}

	 // checkValidity(value, rules) {
  //       let isValid = true;
  //       if (!rules) {
  //           return true;
  //       }
        
  //       if (rules.required) {
  //           isValid = value.trim() !== '' && isValid;
  //       }

  //       if (rules.minLength) {
  //           isValid = value.length >= rules.minLength && isValid
  //       }

  //       if (rules.maxLength) {
  //           isValid = value.length <= rules.maxLength && isValid
  //       }

  //       if (rules.isEmail) {
  //           const pattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
  //           isValid = pattern.test(value) && isValid
  //       }

  //       if (rules.isNumeric) {
  //           const pattern = /^\d+$/;
  //           isValid = pattern.test(value) && isValid
  //       }

  //       return isValid;
  //   }

	 const inputChangedHandler = (event, inputIdentifier) => {
        
        const updatedFormElement = updateObject(orderForm[inputIdentifier],{
            value: event.target.value,
            valid: checkValidity(event.target.value,orderForm[inputIdentifier].validation),
            touched:  true
        });

        // { 

        //     ...updatedOrderForm[inputIdentifier]
        // };

        // updatedFormElement.value = event.target.value;
        // updatedFormElement.valid = this.checkValidity(updatedFormElement.value, updatedFormElement.validation);
        // updatedFormElement.touched = true;

        const updatedOrderForm = updateObject(orderForm,{
            [inputIdentifier] : updatedFormElement
        });

        //updatedOrderForm[inputIdentifier] = updatedFormElement;
        
        let formIsValid = true;
        for (let inputIdentifier in updatedOrderForm) {
            formIsValid = updatedOrderForm[inputIdentifier].valid && formIsValid;
        }
        //this.setState({orderForm: updatedOrderForm, formIsValid: formIsValid});

        setOrderForm(updatedOrderForm);
        setFormIsValid(formIsValid);
    }

	
		const formElementArray=[];
		for(let key in orderForm){
			formElementArray.push({
				id : key,
				config :orderForm[key]
			});

		}

		let form = (
			<form onSubmit={orderHandler}>

			{formElementArray.map(formElement=>(
				<Input
				key={formElement.id}
				elementType={formElement.config.elementType}
				elementConfig={formElement.config.elementConfig}
				value={formElement.config.value}
				invalid={ !formElement.config.valid}
				shouldValid={formElement.config.validation}
				touched={formElement.config.touched}
				changed={(event)=>inputChangedHandler(event,formElement.id)} />
				))}

			<Button btnType="Success" disabled={!formIsValid}>Order</Button>
			</form>
			);

		if(props.loading)
		{
			form = <Spinner />;
		}
        
		return(
			<div className={classes.ContactData}>
			<h4>Enter your Contact Data</h4>
			{form}
			</div>
			);
	
}

const mapStateToProps = state => {
	return{
		ings : state.burgerBuilder.ingredients,
		price:state.burgerBuilder.totalPrice,
		loading:state.order.loading,
        token: state.auth.token,
        userId: state.auth.userId
	};
}

const mapDispatchToProps = dispatch => {
	return {
		onOrderBurger : (orderData,token) => dispatch(contactDataActions.purchaseBurger(orderData,token))
	};
}


export default connect(mapStateToProps,mapDispatchToProps) (withErrorHandler(contactData,axios));