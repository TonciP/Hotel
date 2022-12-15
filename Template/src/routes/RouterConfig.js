import React from 'react'
import { Route, Routes } from 'react-router-dom'
import Checkin from '../pages/checkout/Checkin'

import { Reserva } from '../pages/reservas/Reserva'


export const RouterConfig = () => {
  return (
    <Routes>
        <Route path='/' element={<Reserva></Reserva>}></Route>
        <Route path='/checkin/:idhabitacion' element={<Checkin></Checkin>}></Route>
        {/* <Route path='/checkout' element={<Checkout></Checkout>}></Route> */}
        <Route path='/checkin' element={<Checkin></Checkin>}></Route>

    </Routes>
  )
}
