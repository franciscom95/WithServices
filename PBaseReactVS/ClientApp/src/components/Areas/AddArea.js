import React, { Component } from 'react';


export class AddArea extends Component {

    displayName = "Rows Areas"
    constructor(props) {
        super(props);
        this.state = {value: ''};

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.onClick = this.handleClick.bind(this)
     
      
    }
    handleChange(event) {
        this.setState({value: event.target.value});
      }
      handleClick(event) {
        alert('sera : ' + this.state.value);

      }
      handleSubmit(event) {
        alert('El Nombre que insertastes va aquí : ' + this.state.value);
        event.preventDefault();
      }

 
      render() {
        return (

          <div className="container">
          <form className="container" onSubmit={this.handleSubmit}>
                    <h5>Alta Area</h5>

            <label>
              IdArea
              <input type="text" value={this.state.value} onChange={this.handleChange} />
             NomArea
              <input type="text" value={this.state.value} onChange={this.handleChange} />
            </label>
            <input type="submit" value="Submit" />

            <button
          className="btn btn-link float-left"
          onClick={this.handleClearForm}>Clear form</button>
          </form>

          </div>
        );


        

    }
}