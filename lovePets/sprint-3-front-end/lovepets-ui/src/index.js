import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';

import { usuarioAutenticado, parseJwt } from './services/auth';

import './index.css';

import App from './pages/home/App';
import Atendimentos from './pages/atendimentos/atendimentos';
import Veterinario from './pages/veterinario/veterinario';
import Pet from './pages/pet/pet';
import Login from './pages/login/login';
import NotFound from './pages/notFound/notFound';

import reportWebVitals from './reportWebVitals';

      // Estrutura do IF Ternário
      // CONDIÇÃO ? FAÇO ALGO SE VERDADEIRO : FAÇO ALGO SE FALSO
      // Exemplo:
      // 2 > 3 ? Sim : Não
      // resposta : Não


     //constante de permissao para adms
const PermissaoAdm = ({ component : Component }) => (
  <Route 
    render = { props => 
      usuarioAutenticado() && parseJwt().role === "1" ?
      <Component {...props} /> : <Redirect to="/login" />
    }
  />
)

     //constante de permissao para veterinarios
const PermissaoVet = ({ component : Component}) => (
  <Route
  render = {props =>
  usuarioAutenticado() && parseJwt().role === "2" ?
  <Component { ...props}/> : <Redirect to ="/veterinario"/>
}
/>
)


     //constante de permissao para pets (donos)
const PermissaoPet = ({ component: Component})=> (
  <Route
  render = {props =>
    usuarioAutenticado() && parseJwt().role === "3" ?
    <Component {...props}/>: <Redirect to = "pet"/>
  }
/>
)

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App} />
        <PermissaoAdm path="/atendimentos" component={Atendimentos} />
        <PermissaoVet path ="veterinario" component={Veterinario}/>
        <PermissaoPet path = "pet" component ={Pet}/>
        <Route path="/login" component={Login} />
        <Route exact path="/notfound" component={NotFound} />
        <Redirect to="/notfound" />
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
