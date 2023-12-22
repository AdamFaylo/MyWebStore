import { useNavigate } from "react-router-dom";
import ProductsList from "../components/product/ProductList ";
import { useSelector } from "react-redux";
import { Button } from "react-bootstrap";

const Home = () => {
  const navigate = useNavigate();
  const { user } = useSelector((state) => state.user);

  const handlePrivateArea = () => {
    if (user) {
      if (user.type === 999) {
        navigate("/backoffice");
      } else {
        navigate("/cart");
      }
    } else {
      navigate("/login");
    }
  };

  return (
    <div>
      {user && user.type === 999 ? (
        <Button onClick={handlePrivateArea}>Back Office</Button>
      ) : null}
      <ProductsList />
    </div>
  );
};

export default Home;
