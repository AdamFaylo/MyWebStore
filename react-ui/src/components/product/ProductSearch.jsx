import { useState } from "react";
import { useDispatch } from "react-redux";
import { dataFilter } from "../../features/product-slice";
import { Form } from "react-bootstrap";

const ProductSearch = () => {
  const dispatch = useDispatch();
  const [searchTerm, setSearchTern] = useState("");

  const handleSearch = (e) => {
    setSearchTern(e.target.value);
    dispatch(dataFilter(e.target.value));
    console.log(e.target.value);
  };
  return (
      <Form inline
      style={{
        padding: "3.5px",
        marginRight: "5px",
      }}
      >    
          <Form.Control
            type="search"
            placeholder="Search"
            className="me-2"
            aria-label="Search"
            value={searchTerm}
            onInput={handleSearch}
            style={{
              marginRight: "1px",
              height:"34px"
            }}
          />    
      </Form>
  );
};

export default ProductSearch;
