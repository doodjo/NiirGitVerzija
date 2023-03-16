import { Button } from "@mui/material";
import { useEffect, useState } from "react";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";


// moze da se vrsi destruktuiranje (da ne mora svaki put da se koristi ovo props:, nego samo
// navedemo sta ce da nam treba) u ovom slucaju products i addProduct
export default function Catalog() {
    const [products, setProducts]  =useState<Product[]>([]);

    // SAMO DEMO KAKO RADI DUGME
        <>
    <ProductList products={products}></ProductList>
    <Button variant='contained' onClick={addProduct}>Add product</Button>
        </>
    // SAMO DEMO KAKO RADI DUGME



      
    useEffect(() => {
    fetch('http://localhost:5000/api/products')
    .then(response => response.json())
    .then(data => setProducts(data)) 
    }, [])
  
  
  
    // SAMO DEMO KAKO RADI DUGME
      // dodajemo products u novi array svakim klikom na dugme
      // ako dodamo prevState mozemo da vidimo i proizvode pre nego da doajemo
      // ova komponenta skladisti states unutar nje
      function addProduct() {
        setProducts(prevState => [...prevState,
        {
          id: prevState.length + 101,
          name: 'product' + (prevState.length + 1), 
          price: 300,
          brand: 'nesto',
          description: 'neki opis',
          pictureUrl: 'https://picsum.photos/200',
        }])
      }
    // SAMO DEMO KAKO RADI DUGME
    
    return (
      <>
          <ProductList products={products} />
      </>
    )
}