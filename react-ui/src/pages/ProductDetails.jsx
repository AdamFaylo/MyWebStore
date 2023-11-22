import React from "react";
import { useSelector } from "react-redux";
import { Navigate, useParams } from "react-router-dom";

const ProductDetails = () => {
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
      <div
        style={{
          display: "grid",
          justifyItems: "center",
        }}
      >
        <h3>Details product</h3>
        <div
          style={{
            position: "absolute",
            right: "842px",
            top: "116px",
          }}
        >
          <h3>{product.productName}</h3>
          <div>{product.price}</div>
        </div>
        <img
          style={{
            border: "solid red 1px",
            borderRadius: "15px",
            height: "40rem"
        
          }}
          src={product.galleryImage[0].imageURL}
        />
        {/* Render other product details here */}
      </div>
    </>
  );
};

export default ProductDetails;
