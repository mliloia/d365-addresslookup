import React, { Component } from "react";
import { connect } from "react-redux";
import { setGeb } from "../redux/actions";
import { getGebsByIds } from "../redux/selectors";
import { VirtualizedComboBox } from "office-ui-fabric-react/lib/ComboBox";
import { Stack } from "office-ui-fabric-react/lib/Stack";

class GebPickerSelect extends Component {
  render() {
    const { options, value } = this.props;
    let optionsKeyValue = options.map(geb => {
      let optionText = "";
      if (geb.mat_geb_hnra) {
        optionText = geb.mat_geb_hnr + geb.mat_geb_hnra;
      } else if (geb.mat_geb_hnr) {
        optionText = geb.mat_geb_hnr.toString();
      }
      return {
        key: geb.mat_gebid,
        text: optionText
      };
    });

    return (
      <Stack gap={10}>
        <h2>{value}</h2>
        <VirtualizedComboBox
          selectedKey={value}
          label="Nummer"
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
    const { setGeb } = this.props;
    if (option) {
      setGeb(option.key);
    }
  }
}

const mapStateToProps = (state, { options }) => ({
  options: getGebsByIds(state, options)
});

const actionCreators = { setGeb };

export default connect(
  mapStateToProps,
  actionCreators
)(GebPickerSelect);
