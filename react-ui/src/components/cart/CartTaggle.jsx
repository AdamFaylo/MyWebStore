import React from "react";
import { PiShoppingCartSimpleBold } from "react-icons/pi";

import { useState } from "react";
import styled from "@emotion/styled";
import { Link } from "react-router-dom";

const CartTaggle = () => {
  const [itemsInCart, setItemsinCart] = useState(3);

  const Rounded = styled.span`
  border-radius: 60%;
  width: 17px;
  height: 16px;
  display:grid;
  align-content: center;
  background: #bd3333;
  color: white;src/index.tsx
  place-items:center;
  position:absolute;
  left: 16px;
  top:-6px;
 `;
  return (
    <>
      <Link to="/cart">
        <button
          style={{
            border_radius: "50%",
            position: "relative",
            height:"34px",
            width: "34px",
            padding:"6px",
            marginLeft: "5px",
            marginRight: "5px",
            borderRadius:"5px",
            border: "1px solid #c3bebe",
          }}
        >
          <Rounded>{itemsInCart}</Rounded>
          <PiShoppingCartSimpleBold style={{ fontSize: "18px", display: "grid" }} />
        </button> 
      </Link>
    </>
  );
};
export default CartTaggle;
