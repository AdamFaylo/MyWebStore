import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import axios from "axios";
import Swal from "sweetalert2";

const productURL = "https://localhost:7182/api/product";

export const fetchData = createAsyncThunk(
  "data/fetchData",
  async (_, { rejectWithValue }) => {
    try {
      const response = await axios.get(productURL);
      console.log(response.data);
      return response.data;
    } catch (error) {
      return rejectWithValue(error.response.data);
    }
  }
);

export const postData = createAsyncThunk(
  "data/postData",
  async (newProduct, { rejectWithValue }) => {
    try {
      const response = await axios.post(productURL, newProduct);
      return response.data;
    } catch (error) {
      return rejectWithValue(error.response.data);
    }
  }
);

const dataSlice = createSlice({
  name: "data",
  initialState: {
    data: [],
    filtered: [],
    status: "idle",
    error: null,
    isFavorite: false,
  },
  reducers: {
    toggleFavorite: (state, { payload }) => {
      const index = state.data.findIndex((d) => d.id === payload);

      if (index !== -1) {
        state.data[index].isFavorite = !state.data[index].isFavorite;
      }
    },
    dataFilter: (state, action) => {
      if (!action.payload) {
        state.filtered = state.data;
        return;
      }
      state.filtered = [
        ...state.data.filter((item) =>
          item.productName.toLowerCase().includes(action.payload.toLowerCase())
        ),
      ];
    },
  },
  extraReducers: (builder) => {
    builder
      .addCase(fetchData.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchData.fulfilled, (state, action) => {
        state.status = "succeeded";
        state.data = action.payload;
        state.filtered = action.payload;
      })
      .addCase(fetchData.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.payload ?? "Something went wrong";
      })
      .addCase(postData.pending, (state) => {
        state.status = "loading";
      })
      .addCase(postData.fulfilled, (state, action) => {
        state.status = "succeeded";
        state.data.push(action.payload);
        Swal.fire({
          icon: "success",
          title: "Product loaded from API!",
          showConfirmButton: false,
          timer: 1500,
        });
      });
  },
});

export default dataSlice.reducer;
export const { toggleFavorite, dataFilter } = dataSlice.actions;
