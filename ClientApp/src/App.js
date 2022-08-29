import React, { Component } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './custom.css';
import { Header } from './components/Header'
import { Useers } from './components/Useers'
import CreateUseer from './components/CreateUseer'
import { DisplayBoard } from './components/DisplayBoard'
import UseerShowsContainer from './components/UseerShowsContainer'
import { getAllUseers, createUseer } from './services/UseerService'

class App extends Component {

    state = {
        useer: {},
        useers: [],
        numberOfUseers: 0
    }

    createUseer = (e) => {
        console.log('firstName=> ' + this.state.useer.firstName);
        console.log('lastName=> ' + this.state.useer.lastName);
        if (this.state.useer.firstName === undefined || this.state.useer.lastName === undefined || this.state.useer.firstName.length < 3 || this.state.useer.lastName.length < 3) {
            alert('lastName firstName  ==="undefined"');

        }
        else {
            createUseer(this.state.useer)
                .then(response => {
                    console.log(response);
                    this.setState({ numberOfuseers: this.state.numberOfuseers + 1, shows: response, loading: true, error: "" })
                });
        }

    }
    /*
     *
     * // add ProtoTypes Article

        Article.propTypes = {
            data: PropTypes.shape({
                author: PropTypes.string.isRequired,
                text: PropTypes.string.isRequired
            })
        }
     * 
     * */
    getAllUseers = () => {
        getAllUseers()
            .then(useers => {
               /* console.log(useers)*/
                this.setState({ useers: useers, numberOfuseers: useers.length, shows: useers, loading: true, error: ""  })
            });
    }

    onChangeForm = (e) => {
        let useer = this.state.useer
        if (e.target.name === 'firstname') {
            useer.firstName = e.target.value;
        } else if (e.target.name === 'lastname') {
            useer.lastName = e.target.value;
        }
        useer.email = 'krakoss@krakoss.ru';
        if (useer.firstName !== null && useer.lastName !== null) {
            this.setState({ useer })
        }
        else {
            alert('hi hi Krakoss');
        }

    }

    render() {

        return (
            <div className="App">
                <Header></Header>
                <div className="container mrgnbtm">
                    <div className="row">
                        <div className="col-md-8">
                            <CreateUseer
                                onChangeForm={this.onChangeForm}
                                createUseer={this.createUseer}
                            >
                            </CreateUseer>
                        </div>
                        <div className="col-md-4">
                            <DisplayBoard
                                numberOfuseers={this.state.numberOfuseers}
                                getAllUseers={this.getAllUseers}
                            >
                            </DisplayBoard>
                        </div>
                    </div>
                </div>
                <div className="row mrgnbtm">
                    <Useers useers={this.state.useers}></Useers>
                </div>
                <UseerShowsContainer></UseerShowsContainer>
            </div>
        );
    }
}

export default App;