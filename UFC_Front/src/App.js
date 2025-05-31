import React, { useEffect, useState } from 'react';
import axios from 'axios';
import FighterCard from './Components/FighterCard';

function App() {
  const [fighters, setFighters] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/fighters') // آدرس API
      .then(res => setFighters(res.data))
      .catch(err => console.error(err));
  }, []);

  return (
    <div style={{ display: 'flex', flexWrap: 'wrap', padding: '2rem' }}>
      {fighters.map(f => (
        <FighterCard key={f.id} fighter={f} />
      ))}
    </div>
  );
}

export default App;
