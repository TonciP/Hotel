import React from "react";
import Cards from "../../components/Cards";
import { FilterProvider } from "../../components/FilterContext";
import Header from "../../components/Header";

export const Reserva = () => {
  return (
    <div>
      <FilterProvider>
        <Header />
        <Cards />
      </FilterProvider>
    </div>
  );
};
