import React from 'react';
import MemoChild from './MemoChild';
class MemoParent extends React.Component
{
	constructor()
	{
		super();
		this.state = {
			name:'Memo Example' 
		}
	}

	componentDidMount()
	{
		setInterval(()=>{
			this.setState({
				name: 'Memo Example' 
			})
		},5000)
	}
	render()
	{
		console.log('MemoParent render');
		return(
			<div>
			<MemoChild name={this.state.name}/>
			</div>
			)
	}
}

export default MemoParent;