import React, { Component } from "react";
import { connect } from "react-redux";
import { setPlz } from "../redux/actions";
import { getPlzsByIds } from "../redux/selectors";
import _sortBy from "lodash/sortBy";

class PlzPickerSelect extends Component {
  render() {
    const { options, value, setPlz } = this.props;
    let optionsSorted = _sortBy(options, ["mat_plz_postleitzahl"]);

    return (
      <span>
        <h2>{value}</h2>
        <select
          onChange={e => {
            setPlz(e.target.value);
          }}
          value={value}
        >
          {optionsSorted.map(plz => (
            <option value={plz.mat_plzid} key={plz.mat_plzid}>
              {plz.mat_plz_postleitzahl}
            </option>
          ))}
        </select>
      </span>
    );
  }
}

const mapStateToProps = (state, { options }) => ({
  options: getPlzsByIds(state, options)
});

const actionCreators = { setPlz };

export default connect(
  mapStateToProps,
  actionCreators
)(PlzPickerSelect);
