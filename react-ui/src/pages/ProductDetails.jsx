import React from "react";
import { useSelector } from "react-redux";
import { Navigate, useNavigate, useParams } from "react-router-dom";

const ProductDetails = () => {
  const styleDetailsImg = {
    borderRadius: "15px",
    height: "40rem",
  };
  const styleCardDetails = {
    display: "grid",
    justifyItems: "center",
  };

  const containerCardDetails = {
    display: "grid",
    justifyItems: "center",
    marginTop: "5rem",
  };

  const navigate = useNavigate();
  const handle = () => {
    navigate("/");
  };

  const { id } = useParams();
  const numberId = parseInt(id);
  //console.log("this is" + numberId);
  const { data, status } = useSelector((state) => state.data);
  const product = data.find((product) => product.id === numberId);

  if (status === "loading") {
    return <div>Loading...</div>;
  }

  if (!product) {
    return <Navigate to={"/errorPage"} />;
  }
  //console.log(product);
  return (
    <>
      <div style={containerCardDetails}>
        <h3>Details product</h3>
        <button className="btn btn-primary" onClick={handle}>
          Come back
        </button>
        <div style={styleCardDetails}>
          <img style={styleDetailsImg} src={product.galleryImage[0].imageURL} />
          <div
            style={{
              position: "relative",
              right: "207",
              top: "91px",
            }}
          >
            <h3>{product.productName}</h3>
            <div>{product.price}</div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ProductDetails;
