import { useEffect } from "react";

const LogoComponents = () => {
  return (
    <div style={{ display: "flex", alignItems: "center" }}>
      <img
        style={{ height: "3rem" }}
        src={"https://i.imgur.com/yhlgVxL.png"}
        alt="logo site"
      />
      <h2>MyShop</h2>
    </div>
  );
};

export default LogoComponents;
