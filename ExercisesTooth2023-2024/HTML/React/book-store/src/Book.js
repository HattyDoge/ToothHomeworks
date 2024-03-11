import React, {Component} from 'react';
class Book extends Component{
  //this.props.id -->> l'id del libro da mostrare
  //this.props.book_db -->> l'intero database dei libri
  render(){
    var libro = this.props.book_db.find((el) => el.id == this.props.id);
    return (
      <div className="card" style={{width: '18rem'}}>
          <img src={libro.immagine} className="card-img-top" alt="..." />
          <div className="card-body">
              <h5 className="card-title">{libro.titolo}</h5>
              <p className="card-text">{libro.descrizione}</p>
              <a href="#" className="btn btn-primary">Vedilo su IBS</a>
          </div>
      </div>
    );
  };
}

export default Book;
