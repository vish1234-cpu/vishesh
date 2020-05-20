import React from 'react';
import classes from './Toolbar.module.css';
import Logo from '../../Logo/Logo';
import NavigationItems from '../NavigationItems/NavigationItems';
import Menu from '../SideDrawer/Menu/Menu';

const toolBar = (props) =>
{
	return(
	<header className={classes.ToolBar}>
	<Menu clicked={props.drawerToggler}/>
	<div className={classes.Logo}>
	 <Logo/>
	</div>
	<nav className={classes.DesktopOnly} >
	<NavigationItems isAuthenticated={props.isAuth} />
	</nav>
	</header>
	)

}

export default toolBar;