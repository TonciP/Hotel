import React from 'react'
import { Route, Switch } from 'react-router';

import AddressForm from '../pages/checkout/AddressForm';
import Checkout from '../pages/checkout/Checkout';
import PaymentForm from '../pages/checkout/PaymentForm';
import Review from '../pages/checkout/Review';

const RouterConfig = () => {
    return (
        <Switch>
            <Route path="/addressform" exact>
                <AddressForm/>
            </Route>

            <Route path="/checkout">
                <Checkout />
            </Route>

            <Route path="/payment-form" exact>
                <PaymentForm/>
            </Route>

            <Route path="/pedido/create">
                <FormPedido />
            </Route>

            <Route path="/review" exact>
                <Review/>
            </Route>

            <Route path="/">
                <Login />
            </Route>
        </Switch>
    );
}

export default RouterConfig;