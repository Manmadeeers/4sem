import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import { createPost, deletePost, editPost, fetchPosts } from "./postsAPI";
import { type Post, type NewPost } from "./types";



export interface PostsState {
    posts: Post[];
    loading: boolean;
    error: string | null;
}

const initialState: PostsState = {
    posts: [],
    loading: false,
    error: null
}

//actions

export const fetchPostsAsync = createAsyncThunk("posts/fetchPosts", async () => {
    return await fetchPosts();
})

export const createPostAsync = createAsyncThunk("posts/createPost", async (newPost: NewPost) => {
    return await createPost(newPost);
})


export const deletePostAsync = createAsyncThunk("posts/deletePost", async (id: number) => {
    return await deletePost(id);
})

export const editPostAsync = createAsyncThunk("posts/editPost", async (updPost: Post) => {
    return await editPost(updPost);
})

//slice

const postsSlice = createSlice({

    name: 'posts',

    initialState,

    reducers: {},

    extraReducers: (builder) => {

        builder

            .addCase(fetchPostsAsync.pending, (state) => {

                state.loading = true;

            })

            .addCase(fetchPostsAsync.fulfilled, (state, action) => {

                state.loading = false;

                state.posts = action.payload;

            })

            .addCase(createPostAsync.fulfilled, (state, action) => {

                state.posts.push(action.payload);

            })

            .addCase(editPostAsync.fulfilled, (state, action) => {

                const index = state.posts.findIndex(post => post.id === action.payload.id);

                if (index !== -1) {

                    state.posts[index] = action.payload;

                }

            })

            .addCase(deletePostAsync.fulfilled, (state, action) => {

                state.posts = state.posts.filter(post => post.id !== action.payload);

            });

    },

});

export default postsSlice.reducer;