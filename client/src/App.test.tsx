import React from 'react';
import { render, fireEvent, waitFor } from '@testing-library/react';
import App from './App/layout/App';
import DepartureQuery from './App/features/departureboard/DepartureQuery';

// Mock the DepartureQuery component since we are only testing App
jest.mock('./App/features/departureboard/DepartureQuery.tsx', () => () => <div data-testid="mocked-departure-query"></div>);

describe('App', () => {
  it('renders DepartureQuery component', () => {
    const { getByTestId } = render(<App />);
    const departureQueryElement = getByTestId('mocked-departure-query');
    expect(departureQueryElement).toBeInTheDocument();
  });
});

