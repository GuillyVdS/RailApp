import { Typography } from "@mui/material";
import React from "react";

const Footer = () => {
  return (
    <footer
      style={{
        position: "fixed",
        bottom: 0,
        width: "100%",
        backgroundColor: "#f5f5f5",
        padding: "10px",
        textAlign: "center",
      }}
    >
      <Typography>Data provided by <a href='https://www.realtimetrains.co.uk/'>RealTimeTrains</a></Typography>
    </footer>
  );
};

export default Footer;