import ShoppingBagTwoToneIcon from '@mui/icons-material/ShoppingBagTwoTone';
import { List, AppBar, ListItem, Switch, Toolbar, Typography, IconButton, Badge, Box, Menu, MenuItem } from "@mui/material";
import { NavLink } from "react-router-dom";
import logo from './Niir_logo.png';
import React, { useState } from 'react';
import { makeStyles, styled } from "@mui/material/styles";
import ChildCareOutlinedIcon from '@mui/icons-material/ChildCareOutlined';
import EggOutlinedIcon from '@mui/icons-material/EggOutlined';
import CookieOutlinedIcon from '@mui/icons-material/CookieOutlined';
import SettingsInputSvideoOutlinedIcon from '@mui/icons-material/SettingsInputSvideoOutlined';
import KebabDiningOutlinedIcon from '@mui/icons-material/KebabDiningOutlined';
import LiquorOutlinedIcon from '@mui/icons-material/LiquorOutlined';
import SanitizerOutlinedIcon from '@mui/icons-material/SanitizerOutlined';
import CleaningServicesOutlinedIcon from '@mui/icons-material/CleaningServicesOutlined';
import BreakfastDiningOutlinedIcon from '@mui/icons-material/BreakfastDiningOutlined';


const midlinks = [
    {title: 'catalog', path: '/catalog'},
    {title: 'about', path: '/about'},
    {title: 'contact', path: '/contact'},
]

const rightlinks = [
    {title: 'login', path: '/login'},
    {title: 'register', path: '/register'},
]

const navStyles = {
        color: 'inherit', 
        textDecoration: 'none',
        typography: 'h6',
        '&:hover': {
            cursor: 'pointer',
            color: 'primary.dark',
          },
        '&.active':{
            color: 'primary.light'
        }
}

const StyledLink = styled(NavLink)(({ theme }) => ({
    color: theme.palette.text.primary,
    textDecoration: "none",
  }));



interface Props {
    darkMode: boolean,
    handleThemeChange: () => void;
}

export default function Header({darkMode, handleThemeChange}: Props) {
    

    const [anchorEl, setAnchorEl] = useState(null)

    const handleClick = (e: React.MouseEvent<any>) => {
        setAnchorEl(e.currentTarget);
    }
    const openMenu = Boolean(anchorEl)
    const handleClose = () => {
        setAnchorEl(null);
    };

    return(
        <AppBar position='static' sx={{mb: 4}}>
            <Toolbar sx={{display:'flex', justifyContent: 'space-between'}}>

                <Box display='flex' alignItems='center'>
                    <Typography variant='h5' component={NavLink} 
                        to='/'
                        sx={navStyles} > 
                        <Box
                        component="img"
                        sx = {{ height: 55 }}
                        display = 'flex'
                        align-items = "center"
                        alt = "Niir"
                        src = { logo }
                        /> 
                    </Typography>
                    <Switch checked={darkMode} onChange={handleThemeChange}/> 
                </Box>

            

              
                {/* NAVIGACIONI LINKOVI PREKO NavLink */}
                <List sx={{display: 'flex'}} >
                    {midlinks.map(({title, path}) => (
                        <div key={path}>
                            {title.toLowerCase() === 'catalog' ? 
                            <div>
                                <ListItem 
                                sx={navStyles} 
                                aria-controls='basic-menu' 
                                aria-haspopup="true"
                                aria-expanded={openMenu ? 'true' : undefined} 
                                onClick={handleClick}
                                >
                                    {title.toUpperCase()}
                                </ListItem>
                                {/* dropdown */}
                                <Menu id='basic-menu'
                                anchorEl={anchorEl}
                                open={openMenu}
                                onClose={handleClose}
                                >
                                    <MenuItem onClick={() => setAnchorEl(null)}sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <BreakfastDiningOutlinedIcon />
                                    <StyledLink to="/Namirnice">
                                        Namirnice</StyledLink>
                                    </MenuItem>

                                    <MenuItem onClick={() => setAnchorEl(null)}sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <EggOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Mlečni Proizvodi</StyledLink>
                                    </MenuItem>
                                    
                                    <MenuItem onClick={() => setAnchorEl(null)}sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <SettingsInputSvideoOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Voće i Povrće</StyledLink>
                                    </MenuItem>
                                    
                                    <MenuItem onClick={() => setAnchorEl(null)}sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <KebabDiningOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Meso</StyledLink>
                                    </MenuItem>
                                    
                                    <MenuItem onClick={() => setAnchorEl(null)}sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <LiquorOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Pića</StyledLink>
                                    </MenuItem>
                                    
                                    <MenuItem onClick={() => setAnchorEl(null)}sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <CookieOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Slatkiši i grickalice</StyledLink>
                                    </MenuItem>

                                    <MenuItem onClick={() => setAnchorEl(null)} sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <SanitizerOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Lična higijena</StyledLink>
                                    </MenuItem>

                                    <MenuItem onClick={() => setAnchorEl(null)} sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <CleaningServicesOutlinedIcon />
                                    <StyledLink to="/catalog">
                                        Kućna hemija</StyledLink>
                                    </MenuItem>

                                    <MenuItem onClick={() => setAnchorEl(null)} sx={{display: 'flex', alignItems:'center', justifyContent:'space-evenly'}} >
                                    <ChildCareOutlinedIcon />
                                    <StyledLink to="/catalog"> 
                                        Bebe
                                    </StyledLink>
                                    </MenuItem>

                                </Menu>
                            </div>
                            :
                            <ListItem
                            component={NavLink}
                            to={path}
                            sx={navStyles}
                            >
                                {title.toUpperCase()}
                            </ListItem> 
                    }   
                        </div>
                    ))}
                </List>






                <Box display='flex' align-items='center'>
                        {/* IKONICA */}
                    <IconButton size='large' edge='start' color='inherit' sx={{mr: 2}}>
                            <Badge badgeContent='4'>
                                <ShoppingBagTwoToneIcon />
                            </Badge>
                    </IconButton>

                    {/* NAVIGACIONI LINKOVI PREKO NavLink */}
                    <List sx={{display: 'flex'}} >
                        {rightlinks.map(({title, path}) => (
                            <ListItem
                            component={NavLink}
                            to={path}
                            key={path}
                            sx={navStyles}
                            >
                                {title.toUpperCase()}
                            </ListItem>
                        ))}
                    </List>
                </Box>
               

            </Toolbar>
        </AppBar>
    )
}