import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import {
  OverlayContainer,
  FormContainer,
  StyledForm,
  StyledInput,
  StyledButtonRegister,
  StyledButtonSignIn,
  ContainerBtn,
  ErrorMessage,
} from "./LoginFromStyle";
import * as yup from "yup";
import api from "../../utils/api";

const schema = yup.object({
  emailaddress: yup
    .string()
    .required("Email address is required")
    .email("Invalid email format"), // Check for valid email format
  password: yup
    .string()
    .required("Password is required")
    .min(8, "Password must be at least 8 characters"), // Set a minimum password length
});

function LoginDashboard() {
  const [emailaddress, setEmailAddress] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const nav = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await schema.validate({ emailaddress, password });

      // Additional password strength checks can be added here if needed

      const loginData = { emailaddress, password };

      api
        .post("login", loginData)
        .then((result) => {
          if (result.status === 200) {
            localStorage.setItem("mywebsite_token", result.data);
            nav("/login_transition");
          } else {
            throw new Error(`Could not login (${result.status})`);
          }
        })
        .catch((ex) => {
          localStorage.removeItem("mywebsite_token");
          setError(ex.message);
          console.error(ex);
        });
    } catch (validationError) {
      setError(validationError.message);
    }
  };

  return (
    <OverlayContainer inlist={true}>
      <FormContainer>
        <StyledForm onSubmit={handleSubmit}>
          <h2>Login</h2>
          <StyledInput
            type="email"
            placeholder="Email"
            onChange={(e) => setEmailAddress(e.target.value)}
            value={emailaddress}
          />
          <StyledInput
            type="password"
            placeholder="Password"
            onChange={(e) => setPassword(e.target.value)}
            value={password}
          />
          <ContainerBtn>
            <StyledButtonSignIn type="submit">SIGN IN</StyledButtonSignIn>
            <Link to="/registerFrom">
              <StyledButtonRegister type="submit">
                RERGISTER
              </StyledButtonRegister>
            </Link>
          </ContainerBtn>
        </StyledForm>
        {error && <ErrorMessage>{error}</ErrorMessage>}
      </FormContainer>
    </OverlayContainer>
  );
}

export default LoginDashboard;
