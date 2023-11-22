import ListGroup from "react-bootstrap/ListGroup";
import { Link } from "react-router-dom";

const SidePanel = () => {
  return (
    <ListGroup>
      <ListGroup.Item as={Link} to="User">
        User
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Product">
        Product
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="BoxSize">
        BoxSize
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Customer">
        Customer
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Category">
        Category
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Color">
        Color
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Department">
        Department
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="GalleryImage">
        GalleryImage
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Order">
        Order
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Orderitem">
        Orderitem
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Payment">
        Payment
      </ListGroup.Item>

      <ListGroup.Item as={Link} to="ShippingAddress">
        ShippingAddress
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="Size">
        Size
      </ListGroup.Item>
      <ListGroup.Item as={Link} to="SubCategory">
        SubCategory
      </ListGroup.Item>
    </ListGroup>
  );
};

export default SidePanel;
