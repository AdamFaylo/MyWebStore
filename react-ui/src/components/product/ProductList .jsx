/** @jsxImportSource @emotion/react */
import { useSelector } from "react-redux";
import { containerStyles, cardGridStyles } from "./ProductListStyles";
import ProductItem from "./ProductItem";
import { useNavigate, useParams } from "react-router-dom";
import { useMemo } from "react";
import SortPriceComponent from "../sort/SortPriceComponent";
import { Button } from "react-bootstrap";

const ProductList = () => {
  const { gender, category, subcategory } = useParams();
  const data = useSelector((state) => state.data.searchResults);
  const status = useSelector((state) => state.data.status);
  const error = useSelector((state) => state.data.error);
  const departments = useSelector((state) => state.departments.data);

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

  const items = useMemo(() => {
    if (!departments || !gender || !category) return data;
    try {
      const itemsForGender = departments.find(
        (d) => d.name === gender
      )?.categories;
      const itemsForCategory = itemsForGender?.find(
        (cat) => cat.name === category
      )?.subcategories;
      const itemsInSubCategory = itemsForCategory?.find(
        (subCat) => subCat.name === subcategory
      )?.products;
      return itemsInSubCategory || [];
    } catch (e) {
      console.error(e);
      return [];
    }
  }, [departments, gender, category, subcategory, data]);

  if (status === "loading") {
    return <div>Loading...</div>;
  }

  if (status === "failed") {
    return <div>Error: {error}</div>;
  }

  return (
    <div css={containerStyles}>
      {user && user.type === 999 ? (
        <Button
          style={{ position: "relative", left: "10px", width: "12rem" }}
          onClick={handlePrivateArea}
        >
          Back Office
        </Button>
      ) : null}
      <SortPriceComponent />
      <div css={cardGridStyles}>
        {items &&
          items
            .map((item) => <ProductItem key={item.id} data={item} />)}
      </div>
      {/* Add the Pagination component here */}
   
    </div>
  );
};

export default ProductList;
