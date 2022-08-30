import React from 'react';
import ItemsList from './ItemsList'
//import { getAlluseers } from './../services/useerService'


export default class useerShowsContainer extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            shows: [],
            loading: false,
            error: ""
        };
    }

    //getAlluseers = () => {
    //    getAlluseers()
    //        .then((res) => res.json())
    //        .then((data) => this.setState({ loading: false, shows: data }))
    //        .catch((error) =>
    //            this.setState({ loading: false, error: error.message || error })
    //        );
    //}
    componentDidMount() {
        this.setState({ loading: true, error: "" });
       
        fetch('/api/useers')
            .then((res) => res.json())
            .then((data) => this.setState({ loading: false, shows: data }))       
            .catch((error) =>
                this.setState({ loading: false, error: error.message || error })
        );
        //console.log('componentDidMount() => ' + this.state.shows)
   }

   


    render() {
       // console.table('render() this.state => ', this.state.shows);


        const { loading, error, shows } = this.state;
        return (
            <div>
                <h3> shows </h3>
                {loading && <p>Loading...</p>}
                {!loading && shows && <ItemsList items={shows} />}
                {!loading && error && <p>{error}</p>}
            </div>
        );
    }
}