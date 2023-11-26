import { configureStore } from "@reduxjs/toolkit";
import dataReducer from "../features/product-slice";
import userReducer from "../features/user-slice";
import departmentReducer from "../features/departments-slice";
import orderReducer from "../features/order-slice";
import logoReducer from "../features/logo-slice";
import authSlice from "../features/logo-slice";
import themeReducer from "../features/theme-slice";

const store = configureStore({
  reducer: {
    data: dataReducer,
    user: userReducer,
    departments: departmentReducer,
    orders: orderReducer,
    logo: logoReducer,
    auth: authSlice,
    theme: themeReducer,
  },
});

export type RootState = ReturnType<typeof store.getState>
export default store;
