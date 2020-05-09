import React from 'react';

const memoChild = (props) =>
{
	console.log('child memo')

	return(
		<div>
		<h3>React Memo</h3>
		<p>{props.name}</p>
		</div>
		)
}

export default React.memo(memoChild); 
