import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { registerUser } from "../../features/auth-slice"; // Import your registerUser action
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import { FormContainer, OverlayContainer } from "./LoginFromStyle";
import Swal from "sweetalert2";

function RegistrationForm() {
  const dispatch = useDispatch();
  const [formData, setFormData] = useState({
    firstname: "",
    lastname: "",
    username: "",
    emailaddress: "",
    password: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await dispatch(registerUser(formData));

      Swal.fire({
        title: "Registration successful!",
        icon: "success",
        confirmButtonText: "Cool",
      }).then((result) => {
        result.isConfirmed && window.location.reload();
      });
    } catch (error) {
      Swal.error({
        icon: "error",
        title: "Oops... There was an error!",
        text: "Something went wrong!",
      }).then((result) => {
        result.isConfirmed && window.location.reload();
      });
      console.error("Registration error:", error.message);
    }
  };

  return (
    <OverlayContainer>
      <FormContainer>
        <h2>Register</h2>
        <Form onSubmit={handleSubmit} style={{ width: " 27rem" }}>
          <Form.Group controlId="formBasicEmail">
            <Form.Label>First name:</Form.Label>
            <Form.Control
              type="text"
              name="firstname" // Removed id="firstname"
              value={formData.firstname}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Last name:</Form.Label>
            <Form.Control
              type="text"
              name="lastname" // Removed id="lastname"
              value={formData.lastname}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>User name:</Form.Label>
            <Form.Control
              type="text"
              name="username" // Removed id="username"
              value={formData.username}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Email address:</Form.Label>
            <Form.Control
              type="email"
              name="emailaddress" // Removed id="emailaddress"
              value={formData.emailaddress}
              onChange={handleChange}
              required
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Password:</Form.Label>
            <Form.Control
              type="password"
              name="password" // Removed id="password"
              value={formData.password}
              onChange={handleChange}
              autoComplete="current-password"
              required
            />
          </Form.Group>
          {/* Add more form fields for user registration */}
          <Button variant="danger" type="submit" style={{ width: "27rem" }}>
            Register
          </Button>
        </Form>
      </FormContainer>
    </OverlayContainer>
  );
}

export default RegistrationForm;
