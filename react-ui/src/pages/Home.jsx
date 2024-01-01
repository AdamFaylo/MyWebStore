import { useNavigate } from "react-router-dom";
import ProductsList from "../components/product/ProductList ";
import { useSelector } from "react-redux";
import { Button } from "react-bootstrap";

const Home = () => {
  return (
    <div>
      <ProductsList />
    </div>
  );
};

export default Home;
