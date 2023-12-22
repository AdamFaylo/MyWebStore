import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchLogo } from "../../features/logo-slice";

const LogoComponents = () => {
  const dispatch = useDispatch();
  const { data: logo, loading, error } = useSelector((state) => state.logo);

  useEffect(() => {
    dispatch(fetchLogo());
    // If fetchLogo is stable and doesn't change, you can omit it from dependencies
  }, [dispatch]);

  if (loading) return <p>Loading...</p>;
  if (error) return <p>Error: {error.toString()}</p>; // Make sure error is a string

  return (
    <div>
      {logo && logo.length > 0 ? (
        logo.map((l) => (
          <img
            key={l.id}
            id={l.id}
            src={l.logo}
            alt={l.alt}
            style={{ height: "4rem", width: "8rem" }}
          />
        ))
      ) : (
        <div>No Logo available</div>
      )}
    </div>
  );
};

export default LogoComponents;
