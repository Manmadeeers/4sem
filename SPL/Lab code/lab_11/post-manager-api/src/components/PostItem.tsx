import React from 'react';

interface PostItemProps {
  post: { id: number; title: string; body: string; };
  onEdit: (post: { id: number; title: string; body: string; }) => void;
  onDelete: (id: number) => void;
}

const PostItem: React.FC<PostItemProps> = ({ post, onEdit, onDelete }) => {
  const handleEdit = () => {
    onEdit({...post});
  };

  return (
    <li>
      <h2>{post.title}</h2>
      <p>{post.body}</p>
      <button onClick={handleEdit}>Edit</button>
      <button onClick={() => onDelete(post.id)}>Delete</button>
    </li>
  );
};

export default PostItem;