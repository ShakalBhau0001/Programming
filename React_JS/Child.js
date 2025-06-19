// Note :- Must be "Parent.js" file created ...

import React from 'react'

function Child(props) {
  return (
    <div>
      <h1> {props.name} </h1>
      <h1> {props.age} </h1>
      <h1> {props.address} </h1>
    </div>
  )
}

export default Child
