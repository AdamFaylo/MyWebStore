// src/LoginFormStyles.js
import styled from '@emotion/styled';

export const Container = styled.div`
  display: grid;
  justify-items: center;
`;

export const OverlayContainer = styled.div`
  display: grid;
  align-content: center;
  height: 84vh;
  width: 30rem; 
  border-radios: solid 1px black;
`;

export const FormContainer = styled.div`
  background: white;
  padding: 48px;
  border-radius: 10px;
  border:solid black 0.5px;
  background-color: #f5f5f5;
`;

export const StyledForm = styled.form`
  display: flex;
  flex-direction: column;
`;

export const StyledInput = styled.input`
  padding: 10px;
  margin-bottom: 10px;
  border: 1px solid #ddd;
  border-radius: 4px;
`;

export const StyledButton = styled.button`
  padding: 10px;
  width: 100%;
  border: none;
  border-radius: 4px ;
  background-color: #007bff;
  color: white;
  cursor: pointer;
  &:hover {
    background-color: #0056b3;
  }
`;

export const ErrorMessage = styled.div`
  color: red;
  margin-top: 10px;
`;
