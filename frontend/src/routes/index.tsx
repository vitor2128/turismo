import React from 'react';
import { BrowserRouter, Redirect, Route, Switch } from 'react-router-dom';

import PageMain from '../pages/Search';
import PageForm from '../pages/Form';

const Routes: React.FC = () => (
  <BrowserRouter>
    <Switch>
      <Route path="/create" exact component={PageForm} />
      <Route path="/" exact component={PageMain} />
      <Redirect path="*" to="/" />
    </Switch>
  </BrowserRouter>
);

export default Routes;
