import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  return (
    <div className="App">
      <nav class="navbar bg-body-tertiary">
        <div class="container-fluid">
          <a class="navbar-brand" href="#">
            <img src="logo192.png" alt="Logo" width="30" height="24" class="d-inline-block align-text-top"/>
            Bootstrap
          </a>
        </div>
      </nav>
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Qui metteremo il nostro catalogo di libri.
        </p>
        <a
          className="App-link"
          href="https://www.ispascalcomandini.it"
          target="_blank"
          rel="noopener noreferrer"
        >
          IS Pascal-Comandini
        </a>
      </header>
    </div>
  );
}

export default App;
