import * as React from 'react';
import Typography from '@mui/material/Typography';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import Grid from '@mui/material/Grid';
import { useParams } from 'react-router-dom';

const products = [
  {
    name: 'Product 1',
    desc: 'A nice thing',
    price: '$9.99',
  },
  {
    name: 'Product 2',
    desc: 'Another thing',
    price: '$3.45',
  },
  {
    name: 'Product 3',
    desc: 'Something else',
    price: '$6.51',
  },
  {
    name: 'Product 4',
    desc: 'Best thing of all',
    price: '$14.11',
  },
  { name: 'Shipping', desc: '', price: 'Free' },
];

const addresses = ['1 MUI Drive', 'Reactville', 'Anytown', '99999', 'USA'];
const payments = [
  { name: 'Card type', detail: 'Visa' },
  { name: 'Card holder', detail: 'Mr John Smith' },
  { name: 'Card number', detail: 'xxxx-xxxx-xxxx-1234' },
  { name: 'Expiry date', detail: '04/2024' },
];

export default function Review(props) {
  const { idhabitacion } = useParams('idhabitacion');
  const nombreCompleto = props.detalle.nombres + " " + props.detalle.apellidos;

  const [habitacionIdStep, setHabitacionId] = React.useState("");
  const [nombreHabitacionStep, setNombreHabitacion] = React.useState('');
  const [descripcionStep, setDescripcion] = React.useState('');
  const [cantidadDiponibleStep, setCantidadDisponible] = React.useState('');
  const [costoStep, setCosto] = React.useState('');

  React.useEffect(() => {
      getTipoHabitacionId();
  },[idhabitacion]);

  const getTipoHabitacionId = () => {
    fetch("https://localhost:7007/api/tipohabitacion/GetById", {
   /*  fetch("https://localhost:7285/api/tipohabitacion/GetById", { */
      tipoHabtiacionId: idhabitacion
    })
        .then((response) => response.json())
        .then((data) => {
          //return data;

          setHabitacionId(data.habitacionId);
          setNombreHabitacion(data.nombreHabitacion);
          setDescripcion(data.descripcion);
          setCantidadDisponible(data.cantidadDisponible);
          setCosto(data.costo);
        })
        .catch((error) => {
          console.error("Error:", error);
        });
  }
  return (
    <React.Fragment>
      <Typography variant="h6" gutterBottom>
        Datos Reserva
      </Typography>
      <List disablePadding>
        {/* {products.map((product) => ( */}
          <ListItem key="Cliente" sx={{ py: 1, px: 0 }}>
            <ListItemText primary="Cliente" />
            <Typography variant="body2">{nombreCompleto}</Typography>
          </ListItem>
          <ListItem key="Correo" sx={{ py: 1, px: 0 }}>
            <ListItemText primary="Correo" />
            <Typography variant="body2">{props.detalle.email}</Typography>
          </ListItem>
          <ListItem key="Telefono" sx={{ py: 1, px: 0 }}>
            <ListItemText primary="Telefono" />
            <Typography variant="body2">{props.detalle.telefono}</Typography>
          </ListItem>


        {/* ))} */}

        <ListItem sx={{ py: 1, px: 0 }}>
          <ListItemText primary="Total" />
          <Typography variant="subtitle1" sx={{ fontWeight: 700 }}>
            {costoStep}
          </Typography>
        </ListItem>
      </List>

      <Grid container direction="column" spacing={2}>
        <Grid item xs={12} sm={6}>
          <Typography variant="h6" gutterBottom sx={{ mt: 2 }}>
            TipoHabiticion
          </Typography>
          <Typography gutterBottom>{nombreHabitacionStep}</Typography>
          <Typography gutterBottom>{descripcionStep}</Typography>
          <Typography gutterBottom>{costoStep} Bs</Typography>
        </Grid>
        {/* <Grid item container direction="column" xs={12} sm={6}>
          <Typography variant="h6" gutterBottom sx={{ mt: 2 }}>
            Payment details
          </Typography>
          <Grid container>
            {payments.map((payment) => (
              <React.Fragment key={payment.name}>
                <Grid item xs={6}>
                  <Typography gutterBottom>{payment.name}</Typography>
                </Grid>
                <Grid item xs={6}>
                  <Typography gutterBottom>{payment.detail}</Typography>
                </Grid>
              </React.Fragment>
            ))}
          </Grid>
        </Grid> */}
      </Grid>
    </React.Fragment>
  );
}