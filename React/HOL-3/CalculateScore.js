import React from "react";
import "../Stylesheets/mystyle.css";

function CalculateScore({ Name, School, Total, goal }) {
  const averageScore = (Total / goal) * 100;

  return (
    <div className="score-card">
      <h1>Student Score Calculator</h1>

      <p>
        <strong>Name:</strong> {Name}
      </p>

      <p>
        <strong>School:</strong> {School}
      </p>

      <p>
        <strong>Total Score:</strong> {Total}
      </p>

      <p>
        <strong>Goal:</strong> {goal}
      </p>

      <h2>Average Score: {averageScore.toFixed(2)}%</h2>
    </div>
  );
}

export default CalculateScore;