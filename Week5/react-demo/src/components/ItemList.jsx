import React, {useState} from 'react'
import Item from './Item'

function ItemList() {

    //State for managing a user-inputted value, that we will later pass to our Item component
    const [newItem, setNewItem] = useState('');

    //State for holding my list of items to display
    const [items, setItems] = useState(['This is my first/default item.', 'Pancake']);

    const addItem = () => {
        if(newItem.trim()) {
            //Add the new item to the list stored in state
            //Hint: this uses the spread operator in JS "..."
            setItems([...items, newItem.trim()]);

            //Just clearing our text field
            setNewItem('');
        }
    }

    const handleInputChange = (event) => {
        setNewItem(event.target.value);
    }

  return (
    <div>
        <input 
            type="text"
            value={newItem}
            onChange={handleInputChange}
            placeholder='Enter a new item'
        />
        <button onClick={addItem}>Add Item</button>
        
        {/* List that will be populated with Item components based on the values stored in items array */}
        <ol>
            {
                items.map((item, index) => (
                    //Rendering the item component
                    <Item key={index} itemContent={item} />
                ))
            }
        </ol>



    </div>
  )
}

export default ItemList