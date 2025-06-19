import Child from "./Child";
import React from 'react'

function Parent() {
  return (
    <div>
      < Child name="Sunny" age={27} address="America" />
    </div>
  )
}

export default Parent
