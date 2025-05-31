import React from 'react';
import './FighterCard.css'; // استایل‌ها جداگانه

const FighterCard = ({ fighter }) => {
  return (
    <div className="fighter-card">
      <h2>{fighter.name}</h2>
      {fighter.nickname && <p><strong>Nickname:</strong> {fighter.nickname}</p>}
      <p><strong>Age:</strong> {fighter.age}</p>
      <p><strong>Weight:</strong> {fighter.weight} lbs</p>
      <p><strong>Rank:</strong> #{fighter.rank}</p>
    </div>
  );
};

export default FighterCard;