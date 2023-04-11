import { Divider, Grid, Table, TableBody, TableCell, TableContainer, TableRow, Typography } from "@mui/material";
import axios from "axios";
import { response } from "express";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Product } from "../../app/models/product";

export default function ProductDetails() {
    // ok ovo je kul, kako da definises default vrednost
    const {id} = useParams<{id: string}>();

    const [product, setProduct] = useState<Product | null>(null);
    const [loading, setLoading] = useState(true);


    // kada se definise zavisnost onda ce se useEffect pozivati samo onda kada
    // se bude pribavljao id(kada se vrednost id-ja menja)
    useEffect(() => {
        axios.get(`http://localhost:5000/api/Products/${id}`)
        .then(response => setProduct(response.data))
        .catch(error => console.log(error))
        .finally(() => setLoading(false));
    }, [id])

    if (loading) return <h3>Loading...</h3>
    if (!product) return <h3>Product not found...</h3>

    return (
        <Grid container spacing={6}>
            <Grid item xs={6}>
                <img src={product.pictureUrl} alt={product.name} style={{width:'100'}} />
            </Grid>
            <Grid item xs={6}>
                <Typography variant='h3'>{product.name}</Typography>
                <Divider sx={{mb:2}}/>
                <Typography variant='h4' color='secondary'>{(product.price).toFixed(0)},99 RSD</Typography>
                <TableContainer>
                    <Table>
                        <TableBody>
                            <TableRow>
                                <TableCell>Naziv</TableCell>
                                <TableCell>{product.name}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Opis proizvoda</TableCell>
                                <TableCell>{product.description}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Tip</TableCell>
                                <TableCell>{product.type}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Brend</TableCell>
                                <TableCell>{product.brand}</TableCell>
                            </TableRow>
                            <TableRow>
                                <TableCell>Količina u magacinu</TableCell>
                                <TableCell>{product.quantityInStock}</TableCell>
                            </TableRow>
                        </TableBody>
                    </Table>
                </TableContainer>
            </Grid>
        </Grid>
    )
}