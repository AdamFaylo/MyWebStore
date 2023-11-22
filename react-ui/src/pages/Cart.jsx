import React from "react";
import { useSelector, useDispatch } from "react-redux";
import { addItem, removeItem } from "../features/cartSlice";

const Cart = () => {
  const cartItems = useSelector((state) => state.cart.items); 
  const dispatch = useDispatch();

  const handleAddItem = (item) => {
    dispatch(addItem(item));
  };

  const handleRemoveItem = (itemId) => {
    dispatch(removeItem({ id: itemId }));
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
