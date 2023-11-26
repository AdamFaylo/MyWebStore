import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import api from "../utils/api";

const userURL = "Login/GetToken";

export const loginUser = createAsyncThunk(
  "user/loginUser",
  async (userCredentials) => {
      const response = await api.post(userURL, userCredentials);
      console.log(response.data);
      return response.data;
  }
);

export const me = createAsyncThunk(
  "user/me",
  async () => {
    const user = await fetchUser()
    return user
  }
)

const userReducer = createSlice({
  name: "user",
  initialState: {
    loading: false,
    user: null,
    error: null,
  },

  reducers: {
    setUser: (state, action) => {
      console.log(state.user?.cart)
      state.user = action.payload;
    },
    logOut: (state, action) => {
      state.user = null;
      localStorage.removeItem("mywebsite_token");
    },
  },

  extraReducers: (builder) => {
    builder
      // loginUser
      .addCase(loginUser.pending, (state) => {
        state.loading = true;
        state.user = null;
        state.error = null;
      })
      .addCase(loginUser.fulfilled, (state, action) => {
        state.loading = false;
        state.user = action.payload;
        state.error = null;
      })
      .addCase(loginUser.rejected, (state, action) => {
        state.loading = false;
        state.user = null;
        state.error = action.error.message; // Set the error message
      })
      // me
      .addCase(me.pending, (state) => {
        state.loading = true;
        state.user = null;
        state.error = null;
      })
      .addCase(me.fulfilled, (state, action) => {
        state.loading = false;
        state.user = action.payload;
        state.error = null;
      })
      .addCase(me.rejected, (state, action) => {
        state.loading = false;
        state.user = null;
        localStorage.removeItem('mywebsite_token');
        state.error = action.error.message; // Set the error message
      });
      
  },
});

export default userReducer.reducer;
export const { setUser, logOut } = userReducer.actions;
