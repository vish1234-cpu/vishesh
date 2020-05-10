import axios from 'axios';

const instance = axios.create({
	baseURL: 'https://burger-builder-project-b091c.firebaseio.com/'
});

export default instance;