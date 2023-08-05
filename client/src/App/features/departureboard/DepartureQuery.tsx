import { Container, Grid, Paper, Typography } from "@mui/material";
import React, { useState , useEffect} from "react";
import DepartureBoard from "./DepartureBoard";
import { Departures } from "../../models/departures";


export default function DepartureQuery() {
    //variables to keep track of state
    const [departures, setDeparture] = useState<Departures | undefined>(undefined);
    const [location, setLocation] = useState('');
    const [submitted, setSubmitted] = useState(false);

    //Station search form submission
    const handleSubmit = (e: React.ChangeEvent<any>) => {
      e.preventDefault();
      if (location.trim() !== '') {
        setSubmitted(true);
      }
    };

    useEffect(() => {
      let interval: NodeJS.Timeout | null = null;
  
      if (submitted) {
        // Fetch departures when submitted is true
        getDeparturesByCity(location);
  
        // Set interval for auto-refresh
        interval = setInterval(() => {
          getDeparturesByCity(location);
        }, 120000); // 120000 milliseconds = 2 minutes
      }
  
      // Cleanup function
      return () => {
        if (interval) {
          clearInterval(interval);
        }
        setSubmitted(false);
      };
    }, [submitted, location]);
  
    //Fetch departures by city
    function getDeparturesByCity(location: string) {
        fetch(`http://localhost:5000/api/DepartureBoard/${location}`)
          .then(response => response.json())
          .then(data => {
            if (data) {
              setDeparture(data);
            } else {
              setDeparture(undefined);
            }
          })
          .catch(error => {
            console.error('Error fetching departures:', error);
            setDeparture(undefined);
          });
    }

  return (
    <>
      <Container>
        <Paper sx={{ padding: "20px" }}>
          <Typography variant="h6" gutterBottom>
            Instructions
          </Typography>
          <Typography paragraph>
            Enter the location to search for departures. Station information can be retrieved by entering the stations code. I.e. Cambridge = CBG
          </Typography>
          <form onSubmit={handleSubmit}>
            <Grid container spacing={2}>
              <Grid item xs={12}>
                <div style={{ display: "flex", gap: "10px" }}>
                  <label>Location </label>
                  <input
                    type="text"
                    required
                    value={location}
                    onChange={(e) => setLocation(e.target.value)}
                  />
                  <button>Search Location</button>
                </div>
              </Grid>
            </Grid>
          </form>
        </Paper>
      </Container>
      <DepartureBoard departures={departures} />
    </>
  );
}