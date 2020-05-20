import React from 'react';
import Aus from '../../hoc/aus';
import classes from './Layout.module.css';
import ToolBar from '../Navigation/Toolbar/Toolbar';
import SideDrawer from '../Navigation/SideDrawer/SideDrawer';
import {connect} from 'react-redux';

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
	<ToolBar drawerToggler={this.sidedrawerToggle} isAuth={this.props.isAuthenticated} />
	<SideDrawer isAuth={this.props.isAuthenticated} closed={this.sidedrawerClosedHandler}
	open={this.state.showdrawer}/>
	<main className={classes.Content}>
	{this.props.children}
	</main>
	</Aus>
			)
	
	}

}

const mapStateToProps=state=>{
    return{
        isAuthenticated:state.auth.token !==null
    }
}
	

export default connect(mapStateToProps)(Layout) ;