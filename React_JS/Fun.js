// OTP Generation

import React from 'react';

function Fun() {
  function xyz() {
    let otp = Math.floor(Math.random() * 9000 + 1000);
    alert(otp);
  }

  return (
    <div>
      <button onClick={xyz}>Click For OTP</button>
    </div>
  );
}

export default Fun;
