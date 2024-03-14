import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';
import NavBar from './NavBar.js';
import Book from './Book.js';
import 'bootstrap/dist/css/bootstrap.css';

class App extends Component {
  state = {
    book_db: [
      { id: 0, immagine: "./images/libro-1.jpg", titolo: "Atlanta", descrizione: "Un bellissimo libro di favole per bambini." },
      { id: 1, immagine: "./images/libro-2.jpg", titolo: "Il pozzo vale più del tempo", descrizione: "" },
      { id: 2, immagine: "./images/libro-3.jpg", titolo: "Tutti su questo treno sono sospetti", descrizione: "" },
      { id: 3, immagine: "./images/libro-4.jpg", titolo: "Libro 3", descrizione: "Descrizione del libro 3" },
      { id: 4, immagine: "./images/libro-5.jpg", titolo: "Libro 4", descrizione: "Descrizione del libro 4" },
      { id: 5, immagine: "./images/libro-6.jpg", titolo: "Libro 5", descrizione: "Descrizione del libro 5" },
      { id: 6, immagine: "./images/libro-7.jpg", titolo: "Libro 6", descrizione: "Descrizione del libro 6" },
    ]
  }

  render() {
    return (
      <div className="App">
        <NavBar />

        <div className="row">
          <Book id = {0} book_db = {this.state.book_db} />
          <Book id = {1} book_db = {this.state.book_db} />
          <Book id = {2} book_db = {this.state.book_db} />
        </div>
      </div>
    );
  }
}

export default App;
