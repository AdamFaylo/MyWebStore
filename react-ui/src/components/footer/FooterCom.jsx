import React from "react";
import "./FooterStyles";
import {
  Box,
  Container,
  Row,
  Column,
  FooterLink,
  Heading,
  
} from "./FooterStyles";
import { FaFacebook } from "react-icons/fa";
import { AiFillGithub, AiFillInstagram } from "react-icons/ai";
const Footer = () => {
  return (
    <Box>
      <Container>
        <Row>
          <Column>
            <Heading>
              <FooterLink href="https://linkedin.com/in/fayloadam/" target="_blank">
                <i>
                  <span>
                    <AiFillInstagram /> Instagram
                  </span>
                </i>
              </FooterLink>
            </Heading>
          </Column>
          <Column>
            <Heading>
              <FooterLink href="https://github.com/AdamFaylo" target="_blank">
                <i>
                  <span>
                    <AiFillGithub /> github
                  </span>
                </i>
              </FooterLink>
            </Heading>
          </Column>
          <Column>
            <Heading>
              {" "}
              <FooterLink href="https://www.https://www.facebook.com/casca.dura.7.com/" target="_blank">
                <i>
                  <span>
                    <FaFacebook /> Facebook
                  </span>
                </i>
              </FooterLink>
            </Heading>
          </Column>
          <Column>
            <Heading>
              <Heading>
                <FooterLink href="https://api.whatsapp.com/send/?phone=972505949292&text&type=phone_number&app_absent=0" target="_blank">
                  <i>
                    <span>
                      <FaFacebook /> WhatspApp
                    </span>
                  </i>
                </FooterLink>
              </Heading>
            </Heading>
            <FooterLink href="#" target="_blank"></FooterLink>
          </Column>
        </Row>
      </Container>
    </Box>
  );
};
export default Footer;
