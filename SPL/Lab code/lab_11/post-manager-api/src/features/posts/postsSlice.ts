import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import { fetchPosts, createPost, updatePost, deletePost, type Post, type NewPost } from './postsAPI';

export const loadPosts = createAsyncThunk<Post[]>('posts/load', fetchPosts);
export const addPost = createAsyncThunk<Post, NewPost>('posts/add', createPost);
export const editPost = createAsyncThunk<Post, Post>('posts/edit', updatePost);
export const removePost = createAsyncThunk<void, number>('posts/remove', deletePost);

interface PostsState {
  posts: Post[];
  loading: boolean;
  error: string | null;
}

const initialState: PostsState = {
  posts: [],
  loading: false,
  error: null,
};

let  id_storage = 0;

const postsSlice = createSlice({
  name: 'posts',
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(loadPosts.pending, (state) => {
        state.loading = true;
      })
      .addCase(loadPosts.fulfilled, (state, action) => {
        state.loading = false;
        state.posts = action.payload; 
        id_storage = state.posts.length;
       // console.log(id_storage);
      })
      .addCase(loadPosts.rejected, (state, action) => {
        state.loading = false;
        state.error = action.error.message || 'Something went wrong';
      })
      .addCase(addPost.fulfilled, (state, action) => {
        id_storage = id_storage+1;
        console.log(id_storage);
        action.payload.id = id_storage;
        state.posts.push(action.payload); 
      })
      .addCase(editPost.fulfilled, (state, action) => {
        const index = state.posts.findIndex(post => post.id === action.payload.id);
        if (index !== -1) {
          state.posts[index] = action.payload; 
        }
      })
      .addCase(removePost.fulfilled, (state, action) => {
        state.posts = state.posts.filter(post => post.id !== action.meta.arg); 
      });
  },
});

export default postsSlice.reducer;