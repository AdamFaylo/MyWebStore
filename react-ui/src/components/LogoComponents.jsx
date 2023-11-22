import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchLogo } from "../features/logo-slice";
import Image from 'react-bootstrap/Image';


const LogoComponents = () => {
  const dispatch = useDispatch();
  const logo = useSelector((state) => state.logo.data);
  console.log(logo);
  
  useEffect(() => {
    dispatch(fetchLogo());
  }, [dispatch]);
  return (
    <div className="imag_container">
      {logo ? (
         <Image src={logo.logo} rounded  alt={logo.alt}/>
      ) : (
        <div>No Logo available</div>
      )}
    </div>
  );
};

export default LogoComponents;
