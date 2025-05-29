import React, { useState } from 'react';
import '../styles/styles.css'; 

interface PostItemProps {
  post: { id: number; title: string; body: string; };
  onEdit: (post: { id: number; title: string; body: string; }) => void;
  onDelete: (id: number) => void;
}

const PostItem: React.FC<PostItemProps> = ({ post, onEdit, onDelete }) => {
  const [isEditing, setIsEditing] = useState(false);
  const [title, setTitle] = useState(post.title);
  const [body, setBody] = useState(post.body);

  const handleEditToggle = () => {
    setIsEditing(!isEditing);
    if (isEditing) {
      // If we are saving the edit, call onEdit with the updated values
      onEdit({ id: post.id, title, body });
    }
  };

  const handleCancelEdit = () => {
    // Resets the title and body to the original post details
    setTitle(post.title);
    setBody(post.body);
    setIsEditing(false);
  };

  return (
    <li>
      {isEditing ? (
        <>
          <input 
            type="text" 
            value={title} 
            onChange={(e) => setTitle(e.target.value)} 
          />
          <textarea 
            value={body} 
            onChange={(e) => setBody(e.target.value)} 
          />
          <button onClick={handleEditToggle}>Save</button>
          <button onClick={handleCancelEdit}>Cancel</button>
        </>
      ) : (
        <>
          <h2>{post.title}</h2>
          <p>{post.body}</p>
          <button onClick={handleEditToggle}>Edit</button>
          <button onClick={() => onDelete(post.id)}>Delete</button>
        </>
      )}
    </li>
  );
};

export default PostItem;