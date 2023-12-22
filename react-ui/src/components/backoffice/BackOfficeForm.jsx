import { useState } from "react";
import { Form, Button } from "react-bootstrap";
import api from "../../utils/api";

const BackOfficeForm = () => {
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");
  const [addOn, setAddOn] = useState("");
  const [galleryImage, setGalleryImage] = useState("");

  const [feedback, setFeedback] = useState(null);

  const [nameError, setNameError] = useState("");
  const [priceError, setPriceError] = useState("");
  const [addOnError, setAddOnError] = useState("");
  const [galleryImageError, setGalleryImageError] = useState("");


  const handleReset = (e) => {
    e.preventDefault();

    setName("");
    setPrice("");
    setAddOn("");
    setGalleryImage("");

    setFeedback(null);
    setNameError("");
    setPriceError("");
    setAddOnError("");
    setGalleryImageError("");

  };

  const handleSubmit = (e) => {
    e.preventDefault();

    let isValid = true;

    if (name.trim() === "") {
      setNameError("Name is required");
      isValid = false;
    } else {
      setNameError("");
    }

    if (price.trim() === "") {
      setPriceError("Price is required");
      isValid = false;
    } else {
      setPriceError("");
    }

    if (addOn.trim() === "") {
      setAddOnError("AD is required");
      isValid = false;
    } else {
      setAddOnError("");
    }

    if (galleryImage.trim() === "") {
      setGalleryImageError("GalleryImage is required");
      isValid = false;
    } else {
      setGalleryImageError("");
    }



    if (isValid) {
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
          res.data;
          console.log(res.data);
          setFeedback({
            type: "success",
            message: "Product added successfully!",
          });
          
          // Optionally reset the form here
        })
        .catch((ex) => {
          console.error(ex);
          setFeedback({ type: "danger", message: "An error occurred!" });
        });
    }
  };

  return (
    <>
      <h2>Product form add / edit</h2>
      <Form onSubmit={handleSubmit}>

      <Form.Group>
          <Form.Label>GalleryImage</Form.Label>
          <Form.Control
            type="url"
            value={galleryImage}
            required
            onChange={(e) => setGalleryImage(e.target.value)}
            isInvalid={galleryImageError !== ""}
          />
          <Form.Control.Feedback type="invalid">
            {galleryImageError}
          </Form.Control.Feedback>
        </Form.Group>

        <Form.Group>
          <Form.Label>Name</Form.Label>
          <Form.Control
            type="text"
            value={name}
            required
            onChange={(e) => setName(e.target.value)}
            isInvalid={nameError !== ""}
          />
          <Form.Control.Feedback type="invalid">
            {nameError}
          </Form.Control.Feedback>
        </Form.Group>

        <Form.Group>
          <Form.Label>Price</Form.Label>
          <Form.Control
            type="text"
            value={price}
            required
            onChange={(e) => setPrice(e.target.value)}
            isInvalid={priceError !== ""}
          />
          <Form.Control.Feedback type="invalid">
            {priceError}
          </Form.Control.Feedback>
        </Form.Group>

        <Form.Group>
          <Form.Label>AddOn</Form.Label>
          <Form.Control
            type="time"
            value={addOn}
            required
            onChange={(e) => setAddOn(e.target.value)}
            isInvalid={addOnError !== ""}
          />
          <Form.Control.Feedback type="invalid">
            {addOnError}
          </Form.Control.Feedback>
        </Form.Group>

        <Button variant="primary" type="submit" onClick={handleSubmit}>
          Save
        </Button>
        <Button variant="secondary" type="reset" onClick={handleReset}>
          Cancel
        </Button>
      </Form>
    </>
  );
};

export default BackOfficeForm;
