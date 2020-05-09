import React,{useState,useEffect} from 'react';

const Effect = () =>
{
	const [square,update] = useState(2);
	useEffect(()=>{
		console.warn(square)
	},[square==16])

	return(

		<div>
		<h3>Use Effect hook {square}</h3>
		<button onClick={()=>{update(square*square)}}>Square</button>
		</div>
		)

}
export default Effect; 