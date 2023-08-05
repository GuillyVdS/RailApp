import { Departure } from "./departure";


export interface Departures {
    location: string;
    departures: Departure[];
}