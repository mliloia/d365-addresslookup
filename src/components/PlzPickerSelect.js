import React, { Component } from "react";
import { connect } from "react-redux";
import { setPlz } from "../redux/actions";
import { getPlzsByIds } from "../redux/selectors";
import _sortBy from "lodash/sortBy";
import { VirtualizedComboBox } from "office-ui-fabric-react/lib/ComboBox";
import { Stack } from "office-ui-fabric-react/lib/Stack";

class PlzPickerSelect extends Component {
  render() {
    const { options, value } = this.props;
    let optionsSorted = _sortBy(options, ["mat_plz_postleitzahl"]);
    let optionsKeyValue = optionsSorted.map(plz => {
      return {
        key: plz.mat_plzid,
        text: plz.mat_plz_postleitzahl
      };
    });
    const stackTokens = { childrenGap: 10 };
    return (
      <Stack stackTokens={stackTokens}>
        <VirtualizedComboBox
          selectedKey={value}
          label="PLZ"
          allowFreeform={true}
          autoComplete="on"
          options={optionsKeyValue}
          onChange={(event, option, index, value) =>
            this.onChange(event, option, index, value)
          }
          useComboBoxAsMenuWidth={true}
        />
      </Stack>
    );
  }

  onChange(event, option, index, value) {
    const { setPlz } = this.props;
    if (option) {
      setPlz(option.key);
    }
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
