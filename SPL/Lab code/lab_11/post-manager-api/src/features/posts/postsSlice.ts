import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import { fetchPosts, createPost, updatePost, deletePost, type Post, type NewPost } from './postsAPI';

// Load posts action configuration
export const loadPosts = createAsyncThunk<Post[]>('posts/load', fetchPosts);
// Add post action configuration
export const addPost = createAsyncThunk<Post, NewPost>('posts/add', createPost);
// Edit post action configuration
export const editPost = createAsyncThunk<Post, Post>('posts/edit', updatePost);
// Remove post action configuration
export const removePost = createAsyncThunk<void, number>('posts/remove', deletePost);

// Define the initial state
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

// Create the posts slice
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
      })
      .addCase(loadPosts.rejected, (state, action) => {
        state.loading = false;
        state.error = action.error.message || 'Something went wrong';
      })
      .addCase(addPost.fulfilled, (state, action) => {
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