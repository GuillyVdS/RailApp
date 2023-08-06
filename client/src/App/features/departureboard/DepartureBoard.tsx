import { Container, Grid, Typography } from "@mui/material";
import DeparturesList from "./DeparturesList";
import { Departures } from "../../models/departures";
import React, { useState, useEffect } from "react";

interface Props {
  departures: Departures | undefined;
}

export default function DepartureBoard({ departures }: Props) {
  const [currentTime, setCurrentTime] = useState(new Date());

  useEffect(() => {
    const interval = setInterval(() => {
      setCurrentTime(new Date());
    }, 1000); // Update time every second (1000 milliseconds)

    return () => {
      clearInterval(interval);
    };
  }, []);

  return (
    <>
      <Container>
        <Typography variant="h5" sx={{ fontWeight: "bold", textAlign: "center", margin: "15px" }}>
          {departures?.location} Station Departures
        </Typography>
        <Grid sx={{ bgcolor: "#6e6e6e", color: "#c7b73e" }} container spacing={2}>
          <Grid item xs={12}>
            <DeparturesList departures={departures?.departures || []} />
          </Grid>
          <Grid item xs={7}></Grid>
          <Grid item xs={1}>
            <Typography sx={{ fontWeight: "bold" }}>Time</Typography>
          </Grid>
          <Grid item xs={4}>
            <Typography sx={{ fontWeight: "bold" }}>{currentTime.toLocaleTimeString()}</Typography>
          </Grid>
        </Grid>
      </Container>
    </>
  );
}
//<Grid container spacing={2}></Grid>