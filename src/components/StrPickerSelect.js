import React, { Component } from "react";
import { connect } from "react-redux";
import { setStr } from "../redux/actions";
import { getStrsByIds } from "../redux/selectors";
import { VirtualizedComboBox } from "office-ui-fabric-react/lib/ComboBox";
import { Stack } from "office-ui-fabric-react/lib/Stack";

class StrPickerSelect extends Component {
  render() {
    const { options, value } = this.props;
    let optionsKeyValue = options.map(str => {
      return {
        key: str.mat_strid,
        text: str.mat_str_strbez2l
      };
    });

    return (
      <Stack gap={10}>
        <h2>{value}</h2>
        <VirtualizedComboBox
          selectedKey={value}
          label="Strasse"
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
    const { setStr } = this.props;
    if (option) {
      setStr(option.key);
    }
  }
}

const mapStateToProps = (state, { options }) => ({
  options: getStrsByIds(state, options)
});

const actionCreators = { setStr };

export default connect(
  mapStateToProps,
  actionCreators
)(StrPickerSelect);
