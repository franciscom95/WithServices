import React, { Component } from 'react';

export class FetchArea extends Component {

    displayName = "Rows Areas"
    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

        fetch('api/Area/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ forecasts: data, loading: false });
                
            });

     
      
    }

    static renderForecastsTable(forecasts) {

         
        // alert(JSON.stringify(forecasts))


        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>NomArea</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                {forecasts.map(area =>
                        <tr>
                            <td >{area.idArea}</td>
                            <td >{area.nomArea}</td>
                            <td>
                                <a className="action" > Edit</a>|
                                <a className="action"  >Delete</a>
                            </td>  
                            
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
    render() {
        let contents = this.state.loading
            ? <p><em>Cargando Información...</em></p>
            : FetchArea.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1>Consulta de Areas</h1>                
                {contents}
            </div>
        );


        

    }
}