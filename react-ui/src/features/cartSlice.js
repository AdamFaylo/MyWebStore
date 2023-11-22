
import { createSlice } from '@reduxjs/toolkit';
import { logOut } from './user-slice';


const initialState = {
  items: [], // cart items
};

export const cartSlice = createSlice({
  name: 'cart',
  initialState,
  reducers: {
    addItem: (state, action) => {
      state.items.push(action.payload);
    },
    removeItem: (state, action) => {
      state.items = state.items.filter(item => item.id !== action.payload.id);
    },
    clearCart: state => {
      state.items = [];
    },
  },
  extraReducers: (builder) => {
    builder.addCase(logOut, (state) => {
      // Clear the cart when user logs out
      state.items = [];
    });
  },
});

export const { addItem, removeItem, clearCart } = cartSlice.actions;

export default cartSlice.reducer;
