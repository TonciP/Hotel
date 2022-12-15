/* import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Button, Card, Image } from 'react-bootstrap';
import { Link } from 'react-router-dom';


const ListaHuespedes = () => {
    const token = localStorage.getItem('token')

    const [lista, setLista] = useState([]);
    const [cargando, setCargando] = useState(false);

    useEffect(() => {
        
        obtenerListaHuespedes();
    }, []);

    const obtenerListaHuespedes = () => {
        setCargando(true);
        axios.get('https://localhost:7098/api/Huesped/search', {
            headers: {
                "Authorization": "Bearer " + token
            }
        }).then(response => {
            console.log('response', response.data);
            console.log(localStorage.getItem('token'));
            
            setLista(response.data);
            setCargando(false);
        }).catch(error => {
            // console.log('error', error);
            if (error.response.status === 401) {
                //history.push('/login');
            }
        });
    }
    return <div>
        {cargando === true && <h1>Cargando...</h1>}
        {cargando === false &&
            <Card className="mt-3">

                <Card.Body>
                    <Card.Title>huespedes</Card.Title>

                    <table className="table">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Dni</th>

                            </tr>
                        </thead>
                        <tbody>
                            {lista.map(item =>
                                <tr key={"item-" + item.id}>
                                    <td>{item.huespedId}</td>
                                    <td>{item.dni}</td>
                                </tr>
                            )}

                        </tbody>
                    </table>
                </Card.Body>
            </Card>
        }
    </div >;
}

export default ListaHuespedes; */