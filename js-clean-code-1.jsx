// example class component in react
// how would you refactor this using hooks?

class App extends React.Component {
  state = {
    value: localStorage.getItem("info") || ""
  };
  componentDidUpdate() {
    localStorage.setItem("info", this.state.value);
  }
  onChange = event => {
    this.setState({ value: event.target.value });
  };
  render() {
    const { value } = this.state;
    return (
      <div>
        <input value={value} type="text" onChange={this.onChange} />
        <p>{value}</p>
      </div>
    );
  }
}
