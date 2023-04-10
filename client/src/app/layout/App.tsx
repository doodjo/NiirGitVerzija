import { ThemeProvider } from "@emotion/react";
import { Container, createTheme, CssBaseline } from "@mui/material";
import { useState } from "react";
import Header from "./Header";
import { Outlet } from "react-router-dom";


function App() {


  const [darkMode, setDarkMode] = useState(false);
  const paletteType = darkMode ? 'dark' : 'light';
  const theme = createTheme({
    
    palette: {

      primary: {
        light: '#b71c1c',
        main: '#f44336',
        dark: '#971243',
        contrastText: '#fff',
      },
      secondary: {
        light: '#ff7961',
        main: '#f44336',
        dark: '#f44336',
        contrastText: '#000',
      },
      mode: paletteType,
      background: {
        default: paletteType=== 'light' ? '#eaeaea' : '#121212'
      }
    }
  })


function handleThemeChange(){
  setDarkMode(!darkMode);
}


return (
  <ThemeProvider theme={theme}>
    <CssBaseline />
    <Header darkMode={darkMode} handleThemeChange={handleThemeChange} />
      <Container>
        <Outlet />
      </Container>
  </ThemeProvider>
 );
}

export default App;
