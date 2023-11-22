import { Modal } from "antd";
import { useCallback } from "react";
import Container from "react-bootstrap/Container";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import { useDispatch, useSelector } from "react-redux";
import { Link, useNavigate } from "react-router-dom";
import { logOut } from "../../features/user-slice";
import DropDown from "./DropDown";
import Search from "../product/ProductSearch";
import CartTaggle from "../cart/CartTaggle";
import DarkModeButton from "../DarkModeButton";
import { FaPowerOff } from "react-icons/fa";
import { RiUserLine } from "react-icons/ri";
import "./navbar.css";

function NavScrollExample() {
  const isDark = useSelector((state) => state.theme.isDark);
  const { user } = useSelector((state) => state.user);
  const nav = useNavigate();
  const dispatch = useDispatch();
  const AuthButton = useCallback(() => {
    if (user) {
      return (
        <button
          style={{
            display: "grid",
            justifyContent: "center",
            height: "34px",
            width:"34px",
            borderRadius: "5px",
            border: "1px solid white",
            alignItems: "center",
            background: "red",
            haver:"blue",
          }}
          onClick={() => {
            Modal.confirm({
              content: "Would you like to log out ?",
              onOk: () => {
                dispatch(logOut());
                nav("/loginDeshboard");
              },
            });
          }}
        >
          <FaPowerOff
            style={{
              color: "white",
            }}
          />{" "}
        </button>
      );
    }
    return (
      <Link to="/login">
        <button
          style={{
            display: "grid",
            justifyContent: "center",
            height: "34px",
            width:"34px",
            borderRadius: "5px",
            border: "1px solid green",
            alignItems: "center",
          }}
        >
          <RiUserLine
            style={{
              color: "green",
            }}
          />
        </button>
      </Link>
    );
  }, [user]);
  return (

      <Navbar expand="lg" className={!isDark ? "light" : "dark"}>
        <Container fluid>
          <Navbar.Brand href="#">Navbar scroll</Navbar.Brand>
          <Navbar.Toggle aria-controls="navbarScroll" />
          <Navbar.Collapse id="navbarScroll">
            <Nav
              className="me-auto my-2 my-lg-0"
              style={{ maxHeight: "100px" }}
              navbarScroll
            >
              <Nav.Link href="/">Home</Nav.Link>
              <DropDown />
              <Nav.Link href="/about">About</Nav.Link>
            </Nav>
            <Search />
            <DarkModeButton />
            <CartTaggle />
            <AuthButton />
          </Navbar.Collapse>
        </Container>
      </Navbar>
  );
}

export default NavScrollExample;
