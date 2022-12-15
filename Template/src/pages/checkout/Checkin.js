import * as React from "react";
import CssBaseline from "@mui/material/CssBaseline";
import AppBar from "@mui/material/AppBar";
import Box from "@mui/material/Box";
import Container from "@mui/material/Container";
import Toolbar from "@mui/material/Toolbar";
import Paper from "@mui/material/Paper";
import Stepper from "@mui/material/Stepper";
import Step from "@mui/material/Step";
import StepLabel from "@mui/material/StepLabel";
import Button from "@mui/material/Button";
import Link from "@mui/material/Link";
import Typography from "@mui/material/Typography";
import { createTheme, ThemeProvider } from "@mui/material/styles";
import AddressForm from "./AddressForm";
import PaymentForm from "./PaymentForm";
import Review from "./Review";
import { json, useParams } from "react-router-dom";

function Copyright() {
  return (
    <Typography variant="body2" color="text.secondary" align="center">
      {"Copyright © "}
      <Link color="inherit" href="https://mui.com/">
        Your Website
      </Link>{" "}
      {new Date().getFullYear()}
      {"."}
    </Typography>
  );
}

const steps = ["Datos Cliente", "Detalles de reserva", ""];

/* function datosCliente(nombres,apellidos,email,direccion,telefono){
  setNombres(nombres);
  setApellidos(apellidos);
  setEmail(email);
  setDireccion(direccion);
  setTelefono(telefono);
} */

/* function getStepContent(step) {
  switch (step) {
    case 0:
      return <AddressForm 
      formCliente={(nombres,apellidos,email,direccion,telefono) => datosCliente(nombres,apellidos,email,direccion,telefono)}/>;
     case 1:
      return <PaymentForm />; 
    case 1:
      return <Review />;
    default:
      throw new Error('Unknown step');
  }
} */

const theme = createTheme();

export default function Checkin() {
  const [activeStep, setActiveStep] = React.useState(0);
  const { idhabitacion } = useParams("idhabitacion");

  const [clienteIdStep, setClienteId] = React.useState("");
  const [nombresStep, setNombres] = React.useState("");
  const [apellidosStep, setApellidos] = React.useState("");
  const [emailStep, setEmail] = React.useState("");
  const [direccionStep, setDireccion] = React.useState("");
  const [telefonoStep, setTelefono] = React.useState("");

  
  const [habitacionIdStep, setHabitacionId] = React.useState("");
  const [nombreHabitacionStep, setNombreHabitacion] = React.useState('');
  const [descripcionStep, setDescripcion] = React.useState('');
  const [cantidadDiponibleStep, setCantidadDisponible] = React.useState('');
  const [costoStep, setCosto] = React.useState('');

  React.useEffect(() => {
    getTipoHabitacionId();
  }, [idhabitacion]);

  const getTipoHabitacionId = () => {
    fetch("https://localhost:7007/api/tipohabitacion/GetById", {
    /* fetch("https://localhost:7285/api/tipohabitacion/GetById", { */
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


  const datosCliente = (
    clienteId,
    nombres,
    apellidos,
    email,
    direccion,
    telefono
  ) => {
    setClienteId(clienteId);
    setNombres(nombres);
    setApellidos(apellidos);
    setEmail(email);
    setDireccion(direccion);
    setTelefono(telefono);

    fetch("https://localhost:7007/api/cliente", {
    /* fetch("https://localhost:7285/api/cliente", { */
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        accept: "application/json",
        charset: "utf-8",
      },
      body: JSON.stringify({
        nombres: nombres,
        apellidos: apellidos,
        email: email,
        direccion: direccion,
        telefono: telefono,
      }),
    })
      .then((response) => response.json())
      .then((data) => {
        //return data;
        setClienteId(data);
      })
      .catch((error) => {
        console.error("Error:", error);
      });
  };

  const notificarCliente = () => {
    fetch("https://localhost:7007/api/notificacion", {
    /* fetch("https://localhost:7285/api/notificacion", { */
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        accept: "application/json",
        charset: "utf-8",
      },
      body: JSON.stringify({
        tipoHabitacion: {
          nombreHabitacion: nombreHabitacionStep,
          descripcion: descripcionStep,
          cantidadDisponible: cantidadDiponibleStep,
          costo: costoStep,
        },
        estadia: {
          fechaIngreso: "2022-12-25T05:09:17.372Z",
          fechaSalida: "2022-12-25T05:09:17.372Z",
        },
        tracking: {
          hash: "BF0E68B2-4DEF-4E2D-BBF1-FA24C33C6680",
          duracion: "2022-12-11T05:09:17.372Z",
        },
        cliente: {
          nombres: nombresStep,
          apellidos: apellidosStep,
          email: emailStep,
          direccion: direccionStep,
          telefono: telefonoStep,
        },
        qrpath: "no hay",
      }),
    });
  };
  const pedirReserva = () => {
    fetch("https://localhost:7007/api/reserva", {
    /* fetch("https://localhost:7285/api/reserva", { */
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        accept: "application/json",
        charset: "utf-8",
      },
      body: JSON.stringify({
        clienteId: clienteIdStep,
        trackingId: "BF0E68B2-4DEF-4E2D-BBF1-FA24C33C6680",
        tipoHabitacionId: idhabitacion,
        estadia: {
          fechaIngreso: {
            ingreso: "2022-12-25",
          },
          fechaSalida: {
            ingreso: "2022-12-25",
          },
        },
      }),
    })
      .then((response) => response.json())
      .then((data) => {
        //return data;
        /* alert("se ha realizado la reserva"); */
        notificarCliente();
      })
      .catch((error) => {
        console.error("Error:", error);
      });
  };
  const getStepContent = (step) => {
    switch (step) {
      case 0:
        return (
          <AddressForm
            formCliente={(
              clienteId,
              nombres,
              apellidos,
              email,
              direccion,
              telefono
            ) =>
              datosCliente(
                clienteId,
                nombres,
                apellidos,
                email,
                direccion,
                telefono
              )
            }
          />
        );
      /* case 1:
        return <PaymentForm />; */
      case 1:
        return (
          <Review
            detalle={{
              nombres: nombresStep,
              apellidos: apellidosStep,
              email: emailStep,
              direccion: direccionStep,
              telefono: telefonoStep,
            }}
          />
        );
      case 2:
        return pedirReserva();
      default:
        throw new Error("Unknown step");
    }
  };
  const handleNext = () => {
    setActiveStep(activeStep + 1);
  };

  const handleBack = () => {
    setActiveStep(activeStep - 1);
  };

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <AppBar
        position="absolute"
        color="default"
        elevation={0}
        sx={{
          position: "relative",
          borderBottom: (t) => `1px solid ${t.palette.divider}`,
        }}
      >
        <Toolbar>
          <Typography variant="h6" color="inherit" noWrap>
            Hotel Santa Cruz
          </Typography>
        </Toolbar>
      </AppBar>
      <Container component="main" maxWidth="sm" sx={{ mb: 4 }}>
        <Paper
          variant="outlined"
          sx={{ my: { xs: 3, md: 6 }, p: { xs: 2, md: 3 } }}
        >
          <Typography component="h1" variant="h4" align="center">
            Reservar
          </Typography>
          <Stepper activeStep={activeStep} sx={{ pt: 3, pb: 5 }}>
            {steps.map((label) => (
              <Step key={label}>
                <StepLabel>{label}</StepLabel>
              </Step>
            ))}
          </Stepper>
          {activeStep === steps.length - 1 ? (
            <React.Fragment>
              {getStepContent(activeStep)}
              <Typography variant="h5" gutterBottom>
                Thank you for your order.
              </Typography>
              <Typography variant="subtitle1">
                Your order number is #2001539. We have emailed your order
                confirmation, and will send you an update when your order has
                shipped.
              </Typography>
            </React.Fragment>
          ) : (
            <React.Fragment>
              {getStepContent(activeStep)}
              <Box sx={{ display: "flex", justifyContent: "flex-end" }}>
                {activeStep !== 0 && (
                  <Button onClick={handleBack} sx={{ mt: 3, ml: 1 }}>
                    Back
                  </Button>
                )}

                <Button
                  variant="contained"
                  onClick={handleNext}
                  sx={{ mt: 3, ml: 1 }}
                >
                  {activeStep === steps.length - 2 ? "Reservar" : "Next"}
                </Button>
              </Box>
            </React.Fragment>
          )}
        </Paper>
        <Copyright />
      </Container>
    </ThemeProvider>
  );
}
