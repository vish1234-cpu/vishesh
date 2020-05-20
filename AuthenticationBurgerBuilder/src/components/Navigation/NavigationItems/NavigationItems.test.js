import NavigationItems from './NavigationItems';
import NavigationItem from '../NavigationItem/NavigationItem';
import {configure,shallow} from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

describe('<NavigationItems />',()=>{
	beforeEach(() => {
		let wrapper ;
		wrapper = shallow(<NavigationItems />)
	})
	it('should render two <NavigationItems /> elements if not authenticated',() => {
		const wrapper = shallow(<NavigationItems />)
		expect(wrapper.find(NavigationItem)).toHaveLength(2);
	});

	it('should render three <NavigationItems /> elements if authenticated',() => {
	     wrapper.setProps({isAuthenticated:true}); 
		expect(wrapper.find(NavigationItem)).toHaveLength(3);
	});

		it('should and exact logout button',() => {
			wrapper.setProps({isAuthenticated:true}); 
		expect(wrapper.contains(<NavigationItem link="/logout">Logout</NavigationItem>)).toEqual(true);
	});
});