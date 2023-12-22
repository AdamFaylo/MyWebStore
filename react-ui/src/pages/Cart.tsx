import React from "react";
import { useSelector, useDispatch } from "react-redux";
import { RootState } from "../store/store";
import { OrderItem, User, Product } from "../types";
import { updateCart } from "../features/user-slice";
import ProductItem from "../components/product/ProductItem";

// Instead of using 'any', create a proper type for the updateCart function if possible.
const updateCartWorkaround = (updateCart) as any;

interface CartItemProps {
  cartItem: OrderItem;
}

const CartItem: React.FC<CartItemProps> = ({ cartItem }) => {
  return (
    <div>
      <ProductItem data={cartItem.product} />
      <div>
        Quantity: {cartItem.quantity}
        <br />
        Total item Price: {cartItem.quantity * cartItem.product.price}
      </div>
    </div>
  );
};

const CartList: React.FC = () => {
  const cartItems = useSelector<RootState, OrderItem[]>((state) => (state.user.user as User | null)?.cart?.orderItems ?? []);
  const dispatch = useDispatch();

  // Uncomment and adjust the handler functions if necessary
  const handleAddItem = (item: OrderItem) => {
    dispatch(updateCartWorkaround({ itemId: item.product.id, add: true }));
  };

  const handleRemoveItem = (item: OrderItem) => {
    dispatch(updateCartWorkaround({ itemId: item.product.id, add: false }));
  };

  return (
    <div>
      <h2>Your Cart</h2>
      {cartItems && cartItems.length > 0 && (
        <ul>
          {cartItems.map((item, index) => (
            <CartItem key={`${item.id},${index}`} cartItem={item} />
          ))}
        </ul>
      )}
    </div>
  );
};

export default CartList;
