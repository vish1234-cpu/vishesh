import React,{useState,useEffect} from 'react';
import Input from '../../components/UserInterface/Input/Input';
import Button from '../../components/UserInterface/Button/Button';
import classes from './Auth.module.css';
import * as actions from '../../Store/action/index';
import {connect} from 'react-redux';
import { Redirect } from 'react-router-dom';
import Spinner from '../../components/UserInterface/Spinner/Spinner';
import {updateObject,checkValidity} from '../../shared/utility';


const auth = (props) =>  {

const [controls,Setcontrols] = useState({

    email: {
                elementType: 'input',
                elementConfig: {
                    type: 'email',
                    placeholder: 'Mail Address'
                },
                value: '',
                validation: {
                    required: true,
                    isEmail: true
                },
                valid: false,
                touched: false
            },
            password: {
                elementType: 'input',
                elementConfig: {
                    type: 'password',
                    placeholder: 'Password'
                },
                value: '',
                validation: {
                    required: true,
                    minLength: 6
                },
                valid: false,
                touched: false
            }

});

const [isSignup,setIsSignup] = useState(true);

    // state = {
    //     controls: {
    //         ,
    //     isSignup: true
    // }

    const {buildingBurger,authRedirectPath,onSetAuthRedirectPath} = props;
    useEffect(() => {
        if (!buildingBurger && authRedirectPath !== '/') {
            onSetAuthRedirectPath();
        }
    },[buildingBurger,authRedirectPath,onSetAuthRedirectPath]);

    // componentDidMount() {
    //     if (!this.props.buildingBurger && this.props.authRedirectPath !== '/') {
    //         this.props.onSetAuthRedirectPath();
    //     }
    // }

   //  checkValidity  ( value, rules ) {
   //      let isValid = true;
   //      if ( !rules ) {
   //          return true;
   //      }

   //      if ( rules.required ) {
   //          isValid = value.trim() !== '' && isValid;
   //      }

   //      if ( rules.minLength ) {
   //          isValid = value.length >= rules.minLength && isValid
   //      }

   //      if ( rules.maxLength ) {
   //          isValid = value.length <= rules.maxLength && isValid
   //      }

   //      if ( rules.isEmail ) {
   //          const pattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
   //          isValid = pattern.test( value ) && isValid
   //      }

   //      if ( rules.isNumeric ) {
   //          const pattern = /^\d+$/;
   //          isValid = pattern.test( value ) && isValid
   //      }

   //      return isValid;
   //  }

    const inputChangedHandler = ( event, controlName ) => {
        const updatedControls = updateObject(controls,{
             [controlName]: updateObject(controls[controlName],{
                 value: event.target.value,
                valid: checkValidity( event.target.value, controls[controlName].validation ),
                touched: true
             })
        });

        //  {
        //     ...this.state.controls,
        
        // };

        // this.setState( { controls: updatedControls } );

        Setcontrols(updatedControls);
    }

    const submitHandler = ( event ) => {
        event.preventDefault();
        props.onAuth(controls.email.value, controls.password.value, isSignup );
    }

    const switchAuthModeHandler = () => {
        // this.setState(prevState => {
        //     return {isSignup: !prevState.isSignup};
        // });

        setIsSignup(!isSignup);
    }

    
        const formElementsArray = [];
        for ( let key in controls ) {
            formElementsArray.push( {
                id: key,
                config: controls[key]
            } );
        }

        let form = formElementsArray.map( formElement => (
            <Input
                key={formElement.id}
                elementType={formElement.config.elementType}
                elementConfig={formElement.config.elementConfig}
                value={formElement.config.value}
                invalid={!formElement.config.valid}
                shouldValidate={formElement.config.validation}
                touched={formElement.config.touched}
                changed={( event ) => inputChangedHandler( event, formElement.id )} />
        ) );

        if (props.loading) {
            form = <Spinner />
        }

        let errorMessage = null;

        if (props.error) {
            errorMessage = (
                <p>{props.error.message}</p>
            );
        }

        let authRedirect = null;
        if (props.isAuthenticated) {
            authRedirect = <Redirect to={props.authRedirectPath}/>
        }

        return (
            <div className={classes.Auth}>
                {authRedirect}
                {errorMessage}
                <form onSubmit={submitHandler}>
                    {form}
                    <Button btnType="Success">SUBMIT</Button>
                </form>
                <Button 
                    clicked={switchAuthModeHandler}
                    btnType="Danger">SWITCH TO {isSignup ? 'SIGNIN' : 'SIGNUP'}</Button>
            </div>
        );
    
}

const mapStateToProps = state => {
    return {
        loading: state.auth.loading,
        error: state.auth.error,
        isAuthenticated: state.auth.token !== null,
        buildingBurger: state.burgerBuilder.building,
        authRedirectPath: state.auth.authRedirectPath
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onAuth: ( email, password, isSignup ) => dispatch( actions.auth( email, password, isSignup ) ),
        onSetAuthRedirectPath: () => dispatch(actions.setAuthRedirectPath('/'))
    };
};

export default connect( mapStateToProps, mapDispatchToProps )( auth );