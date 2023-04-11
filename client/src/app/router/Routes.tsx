import { createBrowserRouter } from "react-router-dom";
import AboutPage from "../../features/about/AboutPage";
import Catalog from "../../features/catalog/Catalog";
import ProductDetails from "../../features/catalog/ProductDetails";
import ContactPage from "../../features/contact/ContactPage";
import Namirnice from "../../features/catalog/Namirnice";
import HomePage from "../../features/home/HomePage";
import App from "../layout/App";
import MlecniProizvodi from "../../features/catalog/MlecniProizvodi";
import VocePovrce from "../../features/catalog/VocePovrce";
import Meso from "../../features/catalog/Meso";
import Pica from "../../features/catalog/Pica";
import Slatkisi from "../../features/catalog/Slatkisi";
import LicnaHigijena from "../../features/catalog/LicnaHigijena";
import KucnaHemija from "../../features/catalog/KucnaHemija";
import Bebe from "../../features/catalog/Bebe";

export const ruta = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            {path: '', element:<HomePage />},
            {path: 'namirnice', element:<Namirnice />},
            {path: 'mlečniProizvodi', element:<MlecniProizvodi />},
            {path: 'voćePovrće', element:<VocePovrce />},
            {path: 'meso', element:<Meso />},
            {path: 'pica', element:<Pica />},
            {path: 'slatkisi', element:<Slatkisi />},
            {path: 'ličnaHigijena', element:<LicnaHigijena />},
            {path: 'kućnaHemija', element:<KucnaHemija />},
            {path: 'bebe', element:<Bebe />},   
            {path: 'catalog/:id', element:<ProductDetails />},
            {path: 'about', element:<AboutPage />},
            {path: 'contact', element:<ContactPage />},
        ]
    }
])