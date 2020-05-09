import React from 'react';

class Fragment extends React.Component
{
	render()
	{
		return(
			<React.Fragment>
			<div>
			<h3>Fragment Demo</h3>
			</div>
			<p>I am the adjacent Paragraph element</p>
			</React.Fragment>
			)
	}
}

export default Fragment;