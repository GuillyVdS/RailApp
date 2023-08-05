import { Grid, Typography } from "@mui/material";
import { Departure } from "../../models/departure";

interface Props {
    departure: Departure
}

export default function DepartureCard({departure}: Props) {
    return (
        <>
            <Grid container spacing={2} sx={{ '& > *': { fontWeight: 'bold' } }}>
                <Grid item xs={1}>
                <Typography>{departure.departureTime}</Typography>
                </Grid>
                <Grid item xs={6}>
                <Typography>{departure.destination}</Typography>
                </Grid>
                <Grid item xs={1}>
                <Typography>{departure.platform || 'TBC'}</Typography>
                </Grid>
                <Grid item xs={4}>
                <Typography>{departure.expectedTime || 'TBC'}</Typography>
                </Grid>
            </Grid>
            
        </>
    )
}