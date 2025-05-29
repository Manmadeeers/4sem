import { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { loadPosts, addPost, editPost, removePost } from './postsSlice';
import PostForm from '../../components/PostForm';
import PostItem from '../../components/PostItem';
import { type RootState } from '../../app/store';

const Posts = () => {
  const dispatch = useDispatch<any>();
  const { posts, loading, error } = useSelector((state: RootState) => state.posts);

  useEffect(() => {
    dispatch(loadPosts());
  }, [dispatch]);

  const handleAddPost = (newPost: { title: string; body: string; }) => {
    dispatch(addPost(newPost));
  };

  const handleEditPost = (updatedPost: { id: number; title: string; body: string; }) => {
    dispatch(editPost(updatedPost));
  };

  const handleDeletePost = (id: number) => {
    dispatch(removePost(id)); // Check that this dispatches the correct ID
  };

  return (
    <div className="container mx-auto">
      <h1 className="text-2xl font-bold mt-6">Post Management</h1>
      <PostForm onAddPost={handleAddPost} />
      {loading && <p>Loading posts...</p>}
      {error && <p>Error: {error}</p>}
      <ul className="mt-4">
        {posts.map(post => (
          <PostItem 
            key={post.id} 
            post={post} 
            onEdit={handleEditPost} 
            onDelete={handleDeletePost} 
          />
        ))}
      </ul>
    </div>
  );
};

export default Posts;