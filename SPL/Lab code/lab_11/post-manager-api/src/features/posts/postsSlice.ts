import { createSlice,createAsyncThunk } from "@reduxjs/toolkit";
import { type Post, type NewPost, createPost,deletePost,editPost,fetchPosts } from "./postsAPI";
import { stat } from "fs";
import axios from "axios";
import exp from "constants";

export interface PostsState{
    posts:Post[];
    loading:boolean;
    error:string|null;
}

const initialState:PostsState = {
    posts:[],
    loading:false,
    error:null
}

//actions

export const fetchPostsAsync = createAsyncThunk("posts/fetchPosts",async()=>{
    return await fetchPosts();
})

export const createPostAsync = createAsyncThunk("posts/createPost", async(newPost:NewPost)=>{
    return await createPost(newPost);
})


export const deletePostAsync = createAsyncThunk("posts/deletePost", async(id:number)=>{
    return await deletePost(id);
})

export const editPostAsync = createAsyncThunk("posts/editPost",async(updPost:Post)=>{
    return await editPost(updPost);
})

//slice

const postSlice = createSlice({
    name:"posts",
    initialState,
    reducers:{},
    extraReducers:(builder)=>{
        //fetch
        builder.addCase(fetchPostsAsync.pending,(state)=>{
            state.loading = true;
        });
        builder.addCase(fetchPostsAsync.fulfilled,(state,action)=>{
            state.loading = false;
            state.posts = action.payload;
        });
        builder.addCase(fetchPostsAsync.rejected,(state,action)=>{
            state.loading = false;
            state.error = action.error.message||"Failed to fecth";
        });
        //post
        builder.addCase(createPostAsync.fulfilled,(state,action)=>{
            state.posts.push(action.payload);
        });
        //put
        builder.addCase(editPostAsync.fulfilled,(state,action)=>{
            const index = state.posts.findIndex(p=>p.id===action.payload.id);
            if(index!==-1){
                state.posts[index] = action.payload;
            }
        });
        //delete
        builder.addCase(deletePostAsync.fulfilled,(state,action)=>{
            state.posts = state.posts.filter(p=>p.id !== action.payload)
        })
    }
});

export default postSlice.reducer;