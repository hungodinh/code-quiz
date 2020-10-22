// Sample react component implementation of a list view - listing the connections available

import React from 'react';
import PlatformEnvironmentLogin from './PlatformEnvironmentLogin';
import PlatformConnectionsList from './PlatformConnectionsList';

class ConnectionsPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      view: 'connections'
    }
  }

  render() {
    if (this.state.view === 'envLogin') {
      return (
        <PlatformEnvironmentLogin
          return={() => { this.setState({ view: 'connections' }); }} 
        />
      );
    } else if (this.state.view === 'connections') {
      return (
        <PlatformConnectionsList
          addConnection={() => { this.setState({ view: 'envLogin' })}}
        />
      )
    }
  }
}

export default ConnectionsPage;


