import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import axios from 'axios';

export const fetchLogo = createAsyncThunk('logo/fetchLogo', async () => {
  const response = await axios.get('https://localhost:7182/api/LogoImage');
  console.log(response.data);
  return response.data;
});

const logoSlice = createSlice({
  name: 'logo',
  initialState: {
    data: null,
    loading: false,
    error: null,
  },
  extraReducers: {
    [fetchLogo.pending]: (state) => {
      state.loading = true;
    },
    [fetchLogo.fulfilled]: (state, action) => {
      state.data = action.payload;
      state.loading = false;
    },
    [fetchLogo.rejected]: (state, action) => {
      state.loading = false;
      state.error = action.error.message;
    },
  },
});

export default logoSlice.reducer;
