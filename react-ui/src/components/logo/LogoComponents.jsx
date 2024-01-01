import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchLogo } from "../../features/logo-slice";

const LogoComponents = () => {
  const dispatch = useDispatch();
  const { data: logo, loading, error } = useSelector((state) => state.logo);

  useEffect(() => {
    dispatch(fetchLogo());
   
  }, [dispatch]);

  if (loading) return <h3>Loading...</h3>;
  if (error) return <h3>Error: {error.toString()}</h3>;

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
