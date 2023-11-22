import { Outlet } from "react-router-dom";
import { Container, Row, Col } from "react-bootstrap";
import SidePanel from "../components/SidePanel";


const BackOffice = () => {
  return (
    <div>
      <Container fluid>
        <Row>
          <Col md={3}><SidePanel/></Col>
          <Col md={9}>
            <h2>Welcome to the backOffice</h2>
            <Outlet />
          </Col>
        </Row>
      </Container>
    </div>
  );
};

export default BackOffice;
