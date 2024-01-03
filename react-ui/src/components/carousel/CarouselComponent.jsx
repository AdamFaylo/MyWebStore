import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchDepartments } from "../../features/departments-slice"; // Ensure correct path
import Carousel from "react-bootstrap/Carousel";

const CarouselComponent = () => {
  const dispatch = useDispatch();
  const departmentData = useSelector((state) => state.departments.data);
  const isLoading =
    useSelector((state) => state.departments.status) === "loading";
  const isError = useSelector((state) => state.departments.status) === "failed";

  useEffect(() => {
    dispatch(fetchDepartments());
  }, [dispatch]);

  if (isLoading) {
    return <div>Loading...</div>;
  }

  if (isError) {
    return <div>Error loading departments.</div>;
  }

  // Extract images for the carousel

  const images =
    departmentData.length > 0 &&
    departmentData[0].categories.length > 0 &&
    departmentData[0].categories[0].subcategories.length > 0 &&
    departmentData[0].categories[0].subcategories[0].products.length > 0
      ? departmentData[0].categories[0].subcategories[0].products[0]
          .galleryImage
      : [];

  return (
    <Carousel>
      {images.map((image, index) => (
        <Carousel.Item key={index}>
          <img src={image.imageURL} alt={`Slide ${index + 1}`} />
          <Carousel.Caption>
            <h3>{image.label}</h3>
            <p>{image.description}</p>
          </Carousel.Caption>
        </Carousel.Item>
      ))}
    </Carousel>
  );
};

export default CarouselComponent;
