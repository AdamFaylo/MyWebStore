import React from "react";
import { FaHeart, FaRegHeart } from "react-icons/fa";
import Card from "react-bootstrap/Card";
import Stack from "react-bootstrap/Stack";
import { useDispatch } from "react-redux";
import { toggleFavorite } from "../../features/product-slice";
import { toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Swal from "sweetalert2";
import { useNavigate } from "react-router-dom";

const ProductItem = ({ data }) => {
  const dispatch = useDispatch();
  const navigate = useNavigate();

  const iconStyles = { color: "#FF008A", fontSize: "20px" };

  const handleToggleFavorite = (e) => {
    e.stopPropagation();
    const message = data.isFavorite ? "Removed" : "Added";
    toast[data.isFavorite ? "error" : "success"](message, {
      position: "top-center",
      autoClose: 800,
    });
    dispatch(toggleFavorite(data.id));
  };

  const toastSuccessOptions = {
    position: "top-center",
    autoClose: 800,
  };

  const toastErrorOptions = {
    position: "top-center",
    autoClose: 800,
  };
 console.log(data.name)
  return (
    <>
      <div
        className="btn border-0"
        onClick={() => {
          Swal.fire("Clicked");
          navigate(`/products/${data.id}`);
        }}
      >
        <Stack direction="horizontal" gap={3}>
          <Card style={{ width: "19rem" }}>
            {data.galleryImage.map((image) => (
              <Card.Img
                key={image.id}
                variant="top"
                src={image.imageURL}
                alt={`${data.name} - ${image.alt}`}
              />
            ))}
            <Card.Body>
              <Card.Title>{data.name}</Card.Title>
              <p>{data.price}</p>
            </Card.Body>
            <button className="btn border-0" onClick={handleToggleFavorite}>
              {data.isFavorite ? (
                <FaHeart style={iconStyles} />
              ) : (
                <FaRegHeart style={iconStyles} />
              )}
            </button>
          </Card>
        </Stack>
      </div>
    </>
  );
};

export default ProductItem;
