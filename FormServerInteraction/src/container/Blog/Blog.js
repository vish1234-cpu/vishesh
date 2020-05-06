import React, { Component } from 'react';
import axios from 'axios';
import Post from '../../components/Post/Post';
import FullPost from '../../components/FullPost/FullPost';
import NewPost from '../../components/NewPost/NewPost';
import classes from './Blog.module.css';

class Blog extends Component {

    constructor() // step2. then we create a state to store that data.
    {
        super();
        this.state = {
            posts : [] ,
            selectedPostId:null,
            error:false
        }
    }
    // componentDidMount() // get request are always taken place in component did mount 
    // {
    //     axios.get('https://jsonplaceholder.typicode.com/posts') //step1  get request to this link to get all the data. 
    //     .then(response=>{
    //         this.setState({posts:response.data}); // step3 then we setState the in the axios method because get request is asynchronous.
    //         console.log(response); // for getting the data at console.

    //         });
    // }

    articleClickedHandler = (id) =>
    {
        this.setState({selectedPostId:id})

    }

    componentDidMount() // transforming the data
    {
        axios.get('https://jsonplaceholder.typicode.com/posts')
        .then(response => {
            const posts = response.data.slice(0,10);
            const updatedPost = posts.map(postCopy => {
                return {
                    ...postCopy,
                    author:'Max'
                }
            });
        this.setState({posts:updatedPost});
        }).catch(error => {
            this.setState({error:true});
        });
    }
    render () { // step4 then map posts to get the data.

    let post = <p style={{textAlign:'center',color:'red'}}>something went wrong!!</p>

        if(!this.state.error)
        {
            post = this.state.posts.map(post=>{
            return <Post author={post.author}
             body={post.body}
              key={post.id}
               title={post.title}
                articleClicked={(id)=>this.articleClickedHandler(post.id)}/>
        });


        }
      
      
        return (
            <div>
                <section className={classes.Posts}>
                   {post}
                </section>
                <section>
                    <FullPost id={this.state.selectedPostId} />
                </section>
                <section>
                    <NewPost />
                </section>
            </div>
        );
}
}
export default Blog;