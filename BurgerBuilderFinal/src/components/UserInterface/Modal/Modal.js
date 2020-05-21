import React ,{useEffect} from 'react';
import classes from './Modal.module.css'
import Aus from '../../../hoc/aus';
import BackDrop from '../BackDrop/BackDrop';


const modal = (props) =>  {

    // useEffect(() => {


    // },[])

    // shouldComponentUpdate ( nextProps, nextState ) {
    //     return nextProps.show !== this.props.show || nextProps.children !== this.props.children;
    // }

    // componentWillUpdate () {
    //     console.log('[Modal] WillUpdate');
    // }

    
        return (
            <Aus>
                <BackDrop show={props.show} clicked={props.modalClosed} />
                <div
                    className={classes.Modal}
                    style={{
                        transform: props.show ? 'translateY(0)' : 'translateY(-100vh)',
                        opacity: props.show ? '1' : '0'
                    }}>
                    {props.children}
                </div>
            </Aus>
        )
    
}

export default React.memo(modal,(prevProps,nextProps) => nextProps.show === prevProps.show && nextProps.children === prevProps.children );