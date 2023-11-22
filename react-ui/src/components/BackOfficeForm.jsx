import { useState } from "react";
import { Form, Button } from "react-bootstrap";
import api from "../utils/api";

const BackOfficeForm = () => {
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");
  const [addOn, setAddOn] = useState("");
  const [galleryImage, setGalleryImage] = useState("");
  const [size, setSize] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();

    const newItem = {
      department: 1,
      departmentID: 1,
      orderID: 1,
      name,
      price,
      addOn,
    };

    console.log(newItem);

    api
      .post("product", newItem)
      .then((res) => {
        console.log(res.data);
      })
      .catch((ex) => console.error(ex));
  };

  return (
    <>
      <h2>Product form add / edit</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group>
          <Form.Label>Name</Form.Label>
          <Form.Control
            type="text"
            value={name}
            required
            onChange={(e) => setName(e.target.value)}
          />
        </Form.Group>

        <Form.Group>
          <Form.Label>Price</Form.Label>
          <Form.Control
            type="text"
            value={price}
            required
            onChange={(e) => setPrice(e.target.value)}
          />
        </Form.Group>

        <Form.Group>
          <Form.Label>AD</Form.Label>
          <Form.Control
            type="time"
            value={addOn}
            required
            onChange={(e) => setAddOn(e.target.value)}
          />
        </Form.Group>

        <Form.Group>
          <Form.Label>GalleryImage</Form.Label>
          <Form.Control
            type="url"
            value={galleryImage}
            required
            onChange={(e) => setGalleryImage(e.target.value)}
          />
        </Form.Group>

        <Form.Group>
          <Form.Label>Size</Form.Label>
          <Form.Control
            type="text"
            value={size}
            required
            onChange={(e) => setSize(e.target.value)}
          />
        </Form.Group>

        <Button variant="primary" type="submit">
          {" "}
          {/* Use type="submit" */}
          Save
        </Button>
        <Button variant="secondary" type="reset">
          {" "}
          {/* Use type="reset" */}
          Cancel
        </Button>
      </Form>
    </>
  );
};

export default BackOfficeForm;
