import { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import { OverlayContainer, FormContainer, StyledForm, StyledInput, StyledButton, ErrorMessage } from './LoginFromStyle';
import * as yup from 'yup';
import api from '../../utils/api';
import { Anchor } from '@mantine/core';
import { useSelector } from 'react-redux';

const schema = yup.object({
  emailaddress: yup.string().required('Email address is required'), 
  password: yup.string().required('Password is required'),
});

function LoginDashboard() {
  const [emailaddress, setEmailAddress] = useState(''); 
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  const nav = useNavigate();


  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await schema.validate({ emailaddress, password });
      
      const loginData = { emailaddress, password }; 
   
      api.post('login', loginData)
        .then((result) => {
          if (result.status === 200) {
            localStorage.setItem('mywebsite_token', result.data);
            nav('/login_transition');
          } else {
            throw new Error(`Could not login (${result.status})`);
          }
        })
        .catch((ex) => {
          localStorage.removeItem('mywebsite_token');
          setError(ex.message);
          console.error(ex);
        });
    } catch (validationError) {
      console.log(validationError);
      setError(validationError.message);
    }
  };

  return (
    <OverlayContainer>
      <FormContainer>
        <StyledForm onSubmit={handleSubmit}>
        <h2>Login</h2>
          <StyledInput
            type="email"
            placeholder="Email"
            onChange={(e) => setEmailAddress(e.target.value)} 
          />
          <StyledInput
            type="password"
            placeholder="Password"
            onChange={(e) => setPassword(e.target.value)}
          />
          <StyledButton type="submit">Submit</StyledButton>
          <Link to="/registerFrom">
            <Anchor component="button" size="sm">
              Create an account
            </Anchor>
          </Link>
        </StyledForm>
        {error && <ErrorMessage>{error}</ErrorMessage>}
      </FormContainer>
    </OverlayContainer>
  );
}

export default LoginDashboard; 
