import React from "react";
import { useSelector } from "react-redux";
import DataItem from "../components/product/ProductItem";


const Favorites = () => {
  const data = useSelector((state) => state.data.data).filter(
    (d) => d.isFavorite
  );

  return (
    <>
      {data && (
        <div className="card_grid">
          {data.map((d) => (
            <DataItem key={d.id} data={d} />
          ))}
        </div>
      )}
    </>
  );
};

export default Favorites;
