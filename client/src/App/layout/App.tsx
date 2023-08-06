import { Typography } from '@mui/material';
import DepartureQuery from '../features/departureboard/DepartureQuery';
import Footer from '../features/departureboard/Footer';

function App() {
    return (
        <>
            <Typography variant='h1' sx={{ textAlign: "center" }}>Online Departureboard</Typography>
            <div style={{ margin: "60px" }}>
                <DepartureQuery />
            </div>
            <Footer />
        </>
    )
}

export default App;