import React,{useState,useEffect} from 'react';


export default httpClient =>{

	const [error,setError] = useState(null);

		useEffect(() => {
			return () => {
				 httpClient.interceptors.request.eject(requestInterceptor);
				 httpClient.interceptors.response.eject(responseInterceptor);
			};
		},[requestInterceptor,responseInterceptor]);

		
			const requestInterceptor = httpClient.interceptors.request.use(req => {
				setError(null);
				return req;
			});

			const responseInterceptor = httpClient.interceptors.response.use(res=>res,err => {
				setError(err)
			});

		

		const errorConfirmedhandler = () =>
		{
			setError(null);
		};

		return[error,errorConfirmedhandler];
}		