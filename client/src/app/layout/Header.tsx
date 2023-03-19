import ShoppingBagTwoToneIcon from '@mui/icons-material/ShoppingBagTwoTone';
import { List, AppBar, ListItem, Switch, Toolbar, Typography, IconButton, Badge, Box } from "@mui/material";
import { NavLink } from "react-router-dom";

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
            color: 'primary.dark'
        },
        '&.active':{
            color: 'primary.light'
        }
}



interface Props {
    darkMode: boolean,
    handleThemeChange: () => void;
}

export default function Header({darkMode, handleThemeChange}: Props) {
    return(
        <AppBar position='static' sx={{mb: 4}}>
            <Toolbar sx={{display:'flex', justifyContent: 'space-between'}}>

                <Box display='flex' alignItems='center'>
                    <Typography variant='h5' component={NavLink} 
                        to='/'
                        sx={navStyles} > 
                        NIIR 
                    </Typography>
                    <Switch checked={darkMode} onChange={handleThemeChange}/> 
                </Box>

              
                {/* NAVIGACIONI LINKOVI PREKO NavLink */}
                <List sx={{display: 'flex'}} >
                    {midlinks.map(({title, path}) => (
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