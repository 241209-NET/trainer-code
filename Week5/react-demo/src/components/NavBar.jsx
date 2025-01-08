import React from 'react'
import { Link } from 'react-router-dom'

function NavBar() {
  return (
    <nav>
        <ul>
            {/* Link to my Counter component */}
            <li><Link to='/counter'>Counter</Link></li>
            {/* Link to my ItemList component */}
            <li><Link to='/itemlist'>ItemList</Link></li>
        </ul>
    </nav>
  )
}

export default NavBar