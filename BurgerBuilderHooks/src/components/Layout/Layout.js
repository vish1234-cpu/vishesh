import React,{useState} from 'react';
import Aus from '../../hoc/aus';
import classes from './Layout.module.css';
import ToolBar from '../Navigation/Toolbar/Toolbar';
import SideDrawer from '../Navigation/SideDrawer/SideDrawer';
import {connect} from 'react-redux';

const layout = (props) => 
{
	// constructor()
	// {
	// 	super();
	// 	this.state = {
	// 		showdrawer : false
	// 	}
	// }

	const [sideDrawerVisible,setSideDrawerVisible] = useState(false);

	const sidedrawerClosedHandler=()=>
	{
		// this.setState({showdrawer:false})

		setSideDrawerVisible(false);

	}

	const sidedrawerToggle = () =>
	{
		setSideDrawerVisible(!sideDrawerVisible);

	}


	return(
    <Aus>
	<ToolBar drawerToggler={sidedrawerToggle} isAuth={props.isAuthenticated} />
	<SideDrawer isAuth={props.isAuthenticated} closed={sidedrawerClosedHandler}
	open={sideDrawerVisible}/>
	<main className={classes.Content}>
	{props.children}
	</main>
	</Aus>
			)
	
	

}

const mapStateToProps=state=>{
    return{
        isAuthenticated:state.auth.token !==null
    }
}
	

export default connect(mapStateToProps)(layout) ;