import Grid from "@mui/material/Grid";
import { Product } from "../../app/models/product";
import ProductCard from "./ProductCard";



interface Props {
    products: Product[];
}


export default function ProductList({products}: Props) {
    return (

        <Grid container spacing={4}>
        {/* ako se koristi u lambda izrazu {} znaci da ce se vratiti vise razlicitih stvari i treba return */}
        {/* ako se koristi samo () ocekuje se da ce vratiti samo jednu stvar i ne navodi se return */}
        {products.map(product => (
        
            <Grid item xs={4} key={product.id} >
                <ProductCard product={product} />
            </Grid>


        ))}
      </Grid>

    )
}