import React from "react";
import { BsFacebook } from "react-icons/bs";
import { SiLinkedin } from "react-icons/si";
import { MdEmail } from "react-icons/md";
import { ImWhatsapp } from "react-icons/im";

import "./footer.css";
const FooterComponent = () => {
  return (
    <>
      <footer className="site-footer">
        <div className="container">
          <div className="row">
            <div className="col-sm-12 col-md-6">
              <h6>About</h6>
              <p className="text-justify">
                Lorem ipsum dolor sit amet consectetur adipisicing elit.
                Quisquam, voluptatum! Quibusdam, voluptate. Quos, voluptatibus.
                Quisquam, voluptatum! Quibusdam, voluptate. Quos, voluptatibus.
              </p>
            </div>

            <div className="col-xs-6 col-md-3" style={{ display: "flex", flexDirection: "column", alignItems: "center" }}>
                <h6>My Resume</h6>
              <ul className="footer-links">
                <li>
                  <a>
                    <img
                      src="https://i.imgur.com/IVNZASa.png"
                      style={{ height: "6rem" }}
                    />
                  </a>
                </li>
              </ul>
            </div>
            <div className="col-xs-6 col-md-3">
              <h6>Contact Me</h6>
              <ul className="footer-links">
                <li>
                  <a>+972-505949292</a>
                </li>
                <li>
                  <a>
                    <MdEmail /> ed.mil.86@gmail.com
                  </a>
                </li>

                <div
                  style={{
                    display: "flex",
                    justifyContent: "flex-start",
                    gap: "15px",
                    position: "relative",
                    top: "1rem",
                  }}
                >
                  <li>
                    <a href="https://www.facebook.com/casca.dura.7">
                      <BsFacebook />
                    </a>
                  </li>
                  <li>
                    <a href="https://www.linkedin.com/in/adamfaylo/">
                      <SiLinkedin />
                    </a>
                  </li>
                  <li>
                    <a href="https://api.whatsapp.com/send/?phone=972505949292&text&type=phone_number&app_absent=0">
                      <ImWhatsapp />
                    </a>
                  </li>
                </div>
              </ul>
            </div>
          </div>
          <hr />
        </div>
        <hr />
      </footer>
    </>
  );
};

export default FooterComponent;
