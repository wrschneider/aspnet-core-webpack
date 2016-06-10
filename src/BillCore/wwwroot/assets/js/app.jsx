import React from 'react';
import $ from 'jquery';

export default class App extends React.Component {
	state = {foo: '(loading)'};
	
	componentDidMount() {
		$.get('/Bill/api').then(data => this.setState({foo: data.foo}))
	}

   render() {
      return (
      	<div>
      		<h1>Hello, world</h1>
      		<div>state from API call: {this.state.foo}</div>
  		</div>
      )
    }
}
