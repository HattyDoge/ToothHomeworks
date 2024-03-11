import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';
import NavBar from './NavBar.js';
import Book from './Book.js';
import 'bootstrap/dist/css/bootstrap.css';

class App extends Component{
  state = {
    book_db:[ 
      {id: 0, immagine: "./images/libro-1.jpg", titolo: "Atalanta",  descrizione: "Un bellissimo libro di favole per bambini" },
      {id: 1, immagine: "./images/libro-2.jpg", titolo: "Il pozzo vale più del tempo", descrizione: "Un bellissimo libro di favole per bambini"} ]
  }
  render(){
    return (
      <div className="App">
        <NavBar />
        <div className='row'>
          <Book id = {0} book_db = {this.state.book_db}/>
          <Book id = {1} book_db = {this.state.book_db}/>
          <Book immagine = "images/libro-3.jpg" titolo = "Tutti su questo treno sono sospetti" descrizione = "Un bellissimo libro di favole per bambini"/> 
        </div>
      </div>
    );
  };
}

export default App;
