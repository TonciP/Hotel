import * as React from 'react';
import Grid from '@mui/material/Grid';
import Typography from '@mui/material/Typography';
import TextField from '@mui/material/TextField';
import FormControlLabel from '@mui/material/FormControlLabel';
import Checkbox from '@mui/material/Checkbox';
import { Button } from '@mui/material';

export default class  AddressForm extends React.Component  {

  constructor(props){
    super(props);
    this.datosCliente = props.formCliente;
    this.state = {
      clienteId: "",
      nombres : "",
      apellidos : "",
      email : "",
      direccion : "",
      telefono : ""
    }
  }
   componentWillUnmount(){
    //alert("me voy" + this.state.nombres);
    this.datosCliente(this.state.clienteId, this.state.nombres,this.state.apellidos, this.state.email, this.state.direccion, this.state.telefono);
  } 
  
  
  render(){
    function registrarCliente() {
      alert("registrando cliente" + this.state.nombres);
      /* fetch("https://localhost:7285/api/cliente", {
      method: "POST",
      body: JSON.stringify({
        nombres: this.state.nombres,
        apellidos: this.state.apellidos,
        email: this.state.email,
        direccion: this.state.direccion,
        telefono: this.state.telefono
      })
    })
        .then((response) => response.json())
        .then((data) => {

        })
        .catch((error) => {
          console.error("Error:", error);
        }); */
    }
    return (
      <React.Fragment>
        <Typography variant="h6" gutterBottom>
          Datos Cliente
        </Typography>
        <Grid container spacing={3}>
          <Grid item xs={12} sm={6}>
            <TextField
              required
              id="nombres"
              name="nombres"
              label="Nombre Completo"
              fullWidth
              autoComplete="given-name"
              variant="standard"
              onChange = {(event) => this.setState({nombres: event.target.value})}
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <TextField
              required
              id="apellidos"
              name="apellidos"
              label="Apellido Completo"
              fullWidth
              autoComplete="family-name"
              variant="standard"
              onChange = {(event) => this.setState({apellidos: event.target.value})}
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              required
              id="email"
              name="email"
              label="Email"
              fullWidth
              autoComplete="shipping address-line1"
              variant="standard"
              onChange = {(event) => this.setState({email: event.target.value})}
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              id="direccion"
              name="direccion"
              label="Direccion"
              fullWidth
              autoComplete="shipping address-line2"
              variant="standard"
              onChange = {(event) => this.setState({direccion: event.target.value})}
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <TextField
              required
              id="telefono"
              name="telefono"
              label="Telefono"
              fullWidth
              autoComplete="shipping address-level2"
              variant="standard"
              onChange = {(event) => this.setState({telefono: event.target.value})}
            />
          </Grid>
          {/* <Grid item xs={12} sm={6}>
            <TextField
              id="state"
              name="state"
              label="State/Province/Region"
              fullWidth
              variant="standard"
            />
          </Grid> */}
          {/* <Grid item xs={12} sm={6}>
            <TextField
              required
              id="zip"
              name="zip"
              label="Zip / Postal code"
              fullWidth
              autoComplete="shipping postal-code"
              variant="standard"
            />
          </Grid> */}
          {/* <Grid item xs={12} sm={6}>
            <TextField
              required
              id="country"
              name="country"
              label="Country"
              fullWidth
              autoComplete="shipping country"
              variant="standard"
            />
          </Grid> */}
          {/* <Grid item xs={12}>
            <FormControlLabel
              control={<Checkbox color="secondary" name="saveAddress" value="yes" />}
              label="Use this address for payment details"
            />
          </Grid> */}
        </Grid>
        {/* <Button
                  variant="contained"
                  onClick={registrarCliente}
                  sx={{ mt: 3, ml: 1 }}
                >
                Registrar
                </Button> */}
      </React.Fragment>
    );
  }
}