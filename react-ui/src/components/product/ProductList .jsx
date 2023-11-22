/** @jsxImportSource @emotion/react */
import { useSelector } from "react-redux";
import { containerStyles, cardGridStyles } from "./ProductListStyles";
import DataItem from "./ProductItem";
import { useParams } from "react-router-dom";
import { useMemo } from "react";

const ProductItem = () => {
 
  const {gender,category,subcategory} = useParams()
  const data = useSelector((state) => state.data.filtered);
  const status = useSelector((state) => state.data.status);
  console.log(data);
  const error = useSelector((state) => state.data.error);

  const departments = useSelector((state) => state.departments.data);
  const items = useMemo(() => {
    if(!departments || !gender || !category) return data
    try {
      const itemsForGender = departments.find(d => d.name === gender).categories
      console.log(itemsForGender)  
      const itemsForSubCategory = itemsForGender.find(categoryItems => categoryItems.name === category).subcategories
      const itemInSubCategory = itemsForSubCategory.find(subCategoryItems => subCategoryItems.name === subcategory).products
      return itemInSubCategory;
    }catch(e) {  console.log(e);  return []}


  },[departments,gender,category])


  if (status === "loading") {
    
    return <div>Loading...</div>;
  }

  if (status === "failed") {
    return <div>Error: {error}</div>;
  }
  return (
    <>
      <div css={containerStyles}>
        {items && (
          <div className="card_grid" css={cardGridStyles}>
            {items .map((d) => (
              <DataItem key={d.id} data={d} />
            ))}
          </div>
        )}
      </div>
    </>
  );
};

export default ProductItem;
