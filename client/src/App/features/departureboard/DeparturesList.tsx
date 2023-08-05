import { Grid } from "@mui/material";
import { Departure } from "../../models/departure";
import DepartureCard from "./DepartureCard";

interface Props {
    departures: Departure [];
}

/*export default function DeparturesList({departures}: Props) {
    return (
        <>
            <List>
                {departures.map((departure: Departure, index: number) => (
                    <ListItem><DepartureCard key={index} departure={departure} /></ListItem>
                ))}
            </List>
        </>
    )
}*/

export default function DeparturesList({departures}: Props) {
    return (
        <>
            <Grid container spacing={2} sx={{ '& > *': { fontWeight: 'bold' } }}>
                <Grid item xs={1}>
                <p>Time</p>
                </Grid>
                <Grid item xs={6}>
                <p>Destination</p>
                </Grid>
                <Grid item xs={1}>
                <p>Plat.</p>
                </Grid>
                <Grid item xs={4}>
                <p>Expected</p>
                </Grid>
                <Grid item xs={12} >
                {departures.map((departure: Departure, index: number) => (
                    <DepartureCard key={index} departure={departure} />
                ))}
                </Grid>
            </Grid>
                
        </>
    )
}