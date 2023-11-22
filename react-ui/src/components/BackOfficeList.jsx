import { useState, useEffect } from "react";
import api from "../utils/api";
import { Button, Table } from "react-bootstrap";
import { Link } from "react-router-dom";

const BackOfficeList = () => {
  const [items, setItems] = useState([]);

  useEffect(() => {
    api
      .get("product")
      .then((result) => {

        setItems(result.data);
      })
      .catch((ex) => console.error(ex));
  }, []);
  return (
    <>
      <h3>ProductList</h3>
      <Button variant="primary" as={Link} to="new">
        Add New [+]
      </Button>
      <Table striped bordered>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
            <th>AddOn</th>
          </tr>
        </thead>
        <tbody>
          {items.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.price}</td>
              <td>{new Date(p.addedOn).toLocaleDateString() }</td>
              <td>
                <Button variant="info" as={Link} to={`edit/${p.id}`}>
                  Edit
                </Button>
                <Button variant="danger">Delete</Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </>
  );
};

export default BackOfficeList;
