// src/components/PostForm.tsx
import React, { useState, useEffect } from 'react';
import { type Post,type NewPost } from '../features/posts/types';
import { useDispatch } from 'react-redux';
import { createPostAsync,editPostAsync } from '../features/posts/postsSlice';

interface PostFormProps {
    currentPost?: Post | null;
    setCurrentPost: (post: Post | null) => void;
}

const PostForm: React.FC<PostFormProps> = ({ currentPost, setCurrentPost }) => {
    const [title, setTitle] = useState('');
    const [body, setBody] = useState('');
    const dispatch = useDispatch();

    useEffect(() => {
        if (currentPost) {
            setTitle(currentPost.title);
            setBody(currentPost.body);
        } else {
            setTitle('');
            setBody('');
        }
    }, [currentPost]);

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        if (currentPost) {
            dispatch(editPostAsync({ ...currentPost, title, body }));
        } else {
            dispatch(createPostAsync({ title, body } as NewPost));
        }
        setCurrentPost(null);
    };

    return (
        <form onSubmit={handleSubmit}>
            <input
                type="text"
                value={title}
                onChange={(e) => setTitle(e.target.value)}
                placeholder="Title"
                required
            />
            <textarea
                value={body}
                onChange={(e) => setBody(e.target.value)}
                placeholder="Body"
                required
            />
            <button type="submit">{currentPost ? 'Update Post' : 'Add Post'}</button>
        </form>
    );
};

export default PostForm;