import axios from 'axios';

// Define types for Post and NewPost
export type Post = {
  id: number;
  title: string;
  body: string;
};

export type NewPost = {
  title: string;
  body: string;
};

// Base URL for the API
const BASE_URL = 'https://jsonplaceholder.typicode.com/posts';

// Fetch all posts
export const fetchPosts = async (): Promise<Post[]> => {
  const response = await axios.get<Post[]>(BASE_URL);
  return response.data;
};

// Create a new post
export const createPost = async (newPost: NewPost): Promise<Post> => {
  const response = await axios.post<Post>(BASE_URL, newPost);
  return response.data;
};

// Update an existing post
export const updatePost = async (post: Post): Promise<Post> => {
  const response = await axios.put<Post>(`${BASE_URL}/${post.id}`, post);
  return response.data;
};

// Delete a post by ID
export const deletePost = async (id: number): Promise<void> => {
  await axios.delete(`${BASE_URL}/${id}`);
};