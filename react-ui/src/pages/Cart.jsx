import React from "react";
import { useSelector, useDispatch } from "react-redux";

const Cart = () => {
  const cartItems = useSelector((state) => state.cart.items); 
  const dispatch = useDispatch();

  const handleAddItem = (item) => {
    // should be dispatch(setUser(user here with new cart with new item after added with a server action AddItemToCart))
  //  dispatch(addItem(item));
  };

  const handleRemoveItem = (itemId) => {
    // should be dispatch(setUser(user here with new cart with  item quantity decreased/removed after added with a server action DecreaseItemQuantity))
   // dispatch(removeItem({ id: itemId }));
  };

  return (
    <div>
      <h2>Your Cart</h2>
      <ul>
        {cartItems.map((item, index) => (
          <li key={item.id || index}>{item.name}</li> 
        ))}
      </ul>
    </div>
  );
};

export default Cart;
