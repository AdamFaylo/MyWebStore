import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

const initialState = {
    data: null,
    status: "idle", // "idle", "loading", "succeeded", or "failed"
    error: null,
  };

const API_LOGO = "https://localhost:7182/api/LogoImage";

export const fetchLogo = createAsyncThunk("logo/fetchLogo", async () => {
  try {
    const response = await axios.get(API_LOGO);
    console.log(response.data);
    return response.data;
  } catch (error) {
    throw error;
  }
});

const logoSlice = createSlice({
    name: "logo",
    initialState,
    reducers: {},
    extraReducers: (builder) => {
      builder
        .addCase(fetchLogo.pending, (state) => {
          state.status = "loading";
        })
        .addCase(fetchLogo.fulfilled, (state, action) => {
          state.status = "succeeded";
          state.data = action.payload;
        })
        .addCase(fetchLogo.rejected, (state, action) => {
          state.status = "failed";
          state.error = action.error.message;
        });
    },
  });

export default logoSlice.reducer;
