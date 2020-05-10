import React from 'react';
import classes from './Modal.module.css'
import Aus from '../../../hoc/aus';
import BackDrop from '../BackDrop/BackDrop';


const modal = (props) =>
{
	return(
		<Aus>
		<BackDrop show={props.show} clicked={props.modelClosed}/>
		<div className={classes.Modal} 
		style={{transform: props.show ? 'translateY(0)' : 'translateY(-100vh)',
		 opacity : props.show ? '1' : '0'}}>
		{props.children}
		</div>
		</Aus>
		)
}

export default modal;