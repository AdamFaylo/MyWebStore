import { Outlet, useNavigate } from "react-router-dom";
import { Container, Row, Col } from "react-bootstrap";
import SidePanel from "../components/backoffice/SidePanel";

const BackOffice = () => {
  const navigate = useNavigate();

  const handleEvent = () => {
    navigate("/");
  };

  return (
    <div>
      <Container fluid>
        <h2>Welcome to the Back Office</h2>
        <Row>
          <Col md={3}>
            <SidePanel />
          </Col>
          <Col md={9}>
            <Outlet />
          </Col>
        </Row>
        <button className="btn btn-danger" onClick={handleEvent}>
          Return Home Page
        </button>
      </Container>
    </div>
  );
};

export default BackOffice;
