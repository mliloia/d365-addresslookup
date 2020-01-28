import React, { Component } from "react";
import { connect } from "react-redux";
import {
  fetchPlzs,
  fetchStrs,
  fetchGebs,
  fetchConfigs,
  setObject
} from "../redux/actions";
import OrtPickerSelect from "./OrtPickerSelect";
import PlzPickerSelect from "./PlzPickerSelect";
import StrPickerSelect from "./StrPickerSelect";
import GebPickerSelect from "./GebPickerSelect";
import OkButton from "./OkButton";
import CancelButton from "./CancelButton";
import {
  selectPlzs,
  selectStrs,
  selectGebs,
  selectedPlz,
  selectedStr,
  selectedGeb
} from "../redux/selectors";
import { Stack } from "office-ui-fabric-react/lib/Stack";
import { Text } from "office-ui-fabric-react/lib/Text";
import { FontWeights } from "office-ui-fabric-react";
import { Spinner, SpinnerSize } from "office-ui-fabric-react/lib/Spinner";
import { Overlay } from "office-ui-fabric-react";

class MealsContainer extends Component {
  componentDidMount() {
    const { fetchPlzs, fetchConfigs, setObject } = this.props;
    fetchConfigs().then(() => fetchPlzs());

    const urlParams = new URLSearchParams(window.location.search);
    if (urlParams.has("Data")) {
      const dataParams = new URLSearchParams(urlParams.get("Data"));
      if (dataParams.has("object")) {
        const object = JSON.parse(dataParams.get("object"));
        setObject(object);
      }
    }
  }

  componentDidUpdate(prevProps) {
    if (prevProps.selectedPlz !== this.props.selectedPlz) {
      const { fetchStrs, selectedPlz } = this.props;
      fetchStrs(selectedPlz);
    }
    if (prevProps.selectedStr !== this.props.selectedStr) {
      const { fetchGebs, selectedStr } = this.props;
      fetchGebs(selectedStr);
    }
  }

  render() {
    const {
      plzs,
      strs,
      gebs,
      selectedPlz,
      selectedStr,
      selectedGeb
    } = this.props;

    const titleBoldStyle = { root: { fontWeight: FontWeights.semibold } };
    const buttonStackStyles = {
      root: {
        alignItems: "center",
        justifyContent: "center",
        display: "flex"
      }
    };

    const innerStackTokens = { childrenGap: 5, padding: 10 };
    const buttonStackTokens = { childrenGap: 100, padding: 20 };
    const overlayStackTokens = { padding: 180 };

    return (
      <Stack>
        <Stack tokens={innerStackTokens}>
          <Text variant="large" styles={titleBoldStyle}>
            Adresse auswählen
          </Text>
        </Stack>
        <Stack tokens={innerStackTokens}>
          <OrtPickerSelect options={plzs} value={selectedPlz} />
          <PlzPickerSelect options={plzs} value={selectedPlz} />
          <StrPickerSelect options={strs} value={selectedStr} />
          <GebPickerSelect options={gebs} value={selectedGeb} />
        </Stack>
        <Stack horizontal tokens={buttonStackTokens} styles={buttonStackStyles}>
          <OkButton
            plzId={selectedPlz}
            strId={selectedStr}
            gebId={selectedGeb}
          />
          <CancelButton
            plzId={selectedPlz}
            strId={selectedStr}
            gebId={selectedGeb}
          />
        </Stack>
        {(plzs.length === 0 || strs.length === 0 || gebs.length === 0) && (
          <Overlay>
            <Stack
              horizontal
              tokens={overlayStackTokens}
              styles={buttonStackStyles}
            >
              <Spinner size={SpinnerSize.large} />
            </Stack>
          </Overlay>
        )}
      </Stack>
    );
  }
}

const mapStateToProps = state => ({
  plzs: selectPlzs(state),
  strs: selectStrs(state),
  gebs: selectGebs(state),
  selectedPlz: selectedPlz(state),
  selectedStr: selectedStr(state),
  selectedGeb: selectedGeb(state)
});

const actionCreators = {
  fetchPlzs,
  fetchStrs,
  fetchGebs,
  fetchConfigs,
  setObject
};

export default connect(
  mapStateToProps,
  actionCreators
)(MealsContainer);
