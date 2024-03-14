import React, {Component} from 'react';
import logo from './logo.svg';

class NavBar extends Component {
  render() {
    return (
      <nav className="navbar bg-body-tertiary">
          <div className="container-fluid">
              <a className="navbar-brand" href="#">
              <img src="logo192.png" alt="Logo" width="30" height="24" className="d-inline-block align-text-top" />
              Bootstrap
              </a>
          </div>
      </nav>
    );
  }
}

export default NavBar;
