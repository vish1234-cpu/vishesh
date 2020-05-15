import React from 'react';
import Aus from '../../hoc/aus';
import classes from './Layout.module.css';
import ToolBar from '../Navigation/Toolbar/Toolbar';
import SideDrawer from '../Navigation/SideDrawer/SideDrawer';

class Layout extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			showdrawer : false
		}
	}
	sidedrawerClosedHandler=()=>
	{
		this.setState({showdrawer:false})

	}

	sidedrawerToggle = () =>
	{
		this.setState((prevState)=>{
            return {showdrawer:!prevState.showdrawer};
		});

	}

	render()
	{
	return(
    <Aus>
	<ToolBar drawerToggler={this.sidedrawerToggle}/>
	<SideDrawer closed={this.sidedrawerClosedHandler}
	open={this.state.showdrawer}/>
	<main className={classes.Content}>
	{this.props.children}
	</main>
	</Aus>
			)
	
	}

}
	

export default Layout;