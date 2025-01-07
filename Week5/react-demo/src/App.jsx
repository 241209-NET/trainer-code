import React, { useState, createContext } from "react"
import Counter from "./components/Counter"
import ItemList from "./components/ItemList"
import './App.css'

// To use Context, we need to use createContext
// We will use this ThemeContext to share information about the user's preference of theme
// throughout the app
export const ThemeContext = createContext()


function App() {

  //Creating a state variable to hold the current theme selection
  const [theme, setTheme] = useState('dark'); //Theme state, can be (light/dark)

  const toggleTheme = () => {
    // Shorthand for an if statement. 
    // If currentTheme is dark, give it the value light.
    // Otherwise, if its not dark give it the value dark
    setTheme((currentTheme) => currentTheme === 'dark'? 'light' : 'dark');

  }

  return (
      
      <ThemeContext.Provider value={{ theme, toggleTheme}}>
        <div className={theme}>
          <h1>React Demo App!</h1>

          <Counter></Counter>
          <ItemList></ItemList>
          <button onClick={toggleTheme}>
            Switch to {theme === 'dark' ? 'Light' : 'Dark'} Theme
          </button>
        </div>
      </ThemeContext.Provider>

  )
}

export default App
