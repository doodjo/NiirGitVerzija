import { useEffect, useState } from "react";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";
import axios from "axios";


// moze da se vrsi destruktuiranje (da ne mora svaki put da se koristi ovo props:, nego samo
// navedemo sta ce da nam treba) u ovom slucaju products i addProduct
export default function Bebe() {
    const [products, setProducts]  =useState<Product[]>([]);
    const [start] = useState(159);
    const [end] = useState(187);


  

    useEffect(() => {
      const fetchData = async () => {
        const response = await axios.get('http://localhost:5000/api/products');
        const data = response.data.slice(start, end);
        setProducts(data);
      };
      fetchData();
    }, [start, end]);
  
  
  
    
    return (
      <>
          <ProductList products={products} />
      </>
    )
}
