import { Navigate } from "react-router-dom";

const Protected = ({ children }) => {
  const isAutheticated = Boolean(localStorage.getItem("mywebsite_token"));

  if (isAutheticated) {
    console.log("isAutheticated");
    return children;
  }
  return <Navigate to="/loginDeshboard" />;
};

export default Protected;
