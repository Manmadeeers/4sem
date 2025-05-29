import React, { useState } from 'react';
import "../styles/styles.css"

interface PostFormProps {
  onAddPost: (post: { title: string; body: string; }) => void;
}

const PostForm: React.FC<PostFormProps> = ({ onAddPost }) => {
  const [title, setTitle] = useState('');
  const [body, setBody] = useState('');

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onAddPost({ title, body });
    setTitle('');
    setBody('');
  };

  return (
    <form onSubmit={handleSubmit}>
      <input 
        type="text" 
        value={title} 
        onChange={e => setTitle(e.target.value)} 
        placeholder="Title"
        required 
      />
      <textarea 
        value={body} 
        onChange={e => setBody(e.target.value)} 
        placeholder="Body"
        required 
      />
      <button type="submit">Add Post</button>
    </form>
  );
};

export default PostForm;