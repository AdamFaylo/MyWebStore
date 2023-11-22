import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { registerUser } from "../../features/auth-slice"; // Import your registerUser action
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import { FormContainer, OverlayContainer } from "./LoginFromStyle";

function RegistrationForm() {
  const dispatch = useDispatch();
  const [formData, setFormData] = useState({
    firstname: "",
    lastname: "",
    username: "",
    emailaddress: "",
    password: "",
    // Add more fields as needed
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      // Dispatch the registerUser action with the form data
      await dispatch(registerUser(formData));
      // Registration was successful; you can handle this as needed.
      console.log("Registration successful!");
    } catch (error) {
      // Registration failed; you can handle this, e.g., show an error message.
      console.error("Registration error:", error.message);
    }
  };

  return (
    <OverlayContainer>
      <FormContainer>
        <h2>Register</h2>
        <Form onSubmit={handleSubmit}>
          <Form.Group controlId="formBasicEmail">
            <Form.Label>First name:</Form.Label>
            <Form.Control
              type="text"
              id="firstname"
              name="firstname"
              value={formData.firstname}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Last name:</Form.Label>
            <Form.Control
              type="text"
              id="lastname"
              name="lastname"
              value={formData.lastname}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>User name:</Form.Label>
            <Form.Control
              type="text"
              id="username"
              name="username"
              value={formData.username}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Email address:</Form.Label>
            <Form.Control
              type="email"
              id="emailaddress"
              name="emailaddress"
              value={formData.emailaddress}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Password:</Form.Label>
            <Form.Control
              type="password"
              id="password"
              name="password"
              value={formData.password}
              onChange={handleChange}
              autoComplete="current-password" // Add this line
              required
            />
          </Form.Group>
          {/* Add more form fields for user registration */}
          <Button variant="" type="submit">
            Register
          </Button>
        </Form>
      </FormContainer>
    </OverlayContainer>
  );
}

export default RegistrationForm;
