import React from 'react';
import classes from './SideDrawer.module.css';
import Logo from '../../Logo/Logo';
import NavigationItems from '../NavigationItems/NavigationItems';
import BackDrop from '../../UserInterface/BackDrop/BackDrop';
import Aus from '../../../hoc/aus';

const sideDrawer = (props) =>
{
	let attachedClasses =[classes.SideDrawer,classes.Close];
	if(props.open)
	{
		attachedClasses=[classes.SideDrawer,classes.Open];
	}
	return(
		<Aus>
		<BackDrop show={props.open} clicked={props.closed}/>
		<div className={attachedClasses.join(' ')}>
		<div className={classes.Logo}>
		 <Logo/>
		</div>
		<nav className={classes.DesktopOnly}>
		<NavigationItems/>
		</nav>
		</div>
		</Aus>
		)
}

export default sideDrawer;