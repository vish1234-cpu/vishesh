import React,{useState,useEffect} from 'react';
import Modal from '../../components/UserInterface/Modal/Modal'
import Aus from '../aus.js';
import useHttpErrorHandler from '../../hooks/http-error-handler';

const withErrorhandler = (WrappedComponent,axios) =>
{
	return props =>
	{
	const [error,clearError] = useHttpErrorHandler(axios);

		// // constructor()
		// // {
		// // 	super();
		// // 	this.state = {
		// // 		error: null
		// // 	}
		// // }

		// const [error,setError] = useState(null);

		// useEffect(() => {
		// 	return () => {
		// 		 axios.interceptors.request.eject(requestInterceptor);
		// 		 axios.interceptors.response.eject(responseInterceptor);
		// 	};
		// },[requestInterceptor,responseInterceptor]);

		
		// 	const requestInterceptor = axios.interceptors.request.use(req => {
		// 		setError(null);
		// 		return req;
		// 	});

		// 	const responseInterceptor = axios.interceptors.response.use(res=>res,err => {
		// 		setError(err)
		// 	});

		

		// const errorConfirmedhandler = () =>
		// {
		// 	setError(null);
		// };

		
			return(
			<Aus>
			<Modal show={error} clicked={clearError}>
			{error ? error.message : null}
			</Modal>
		<WrappedComponent {...props}/>
		</Aus>
		)
		
	}

	
		

	
	
}

export default withErrorhandler;