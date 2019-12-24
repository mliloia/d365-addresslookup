import React, { Component } from "react";
import { connect } from "react-redux";
import {
  fetchMeals,
  fetchPlzsIfNeeded,
  fetchStrsIfNeeded
} from "../redux/actions";
import MealShowcase from "./MealShowcase";
import PlzPickerSelect from "./PlzPickerSelect";
import {
  selectBreakfastMeals,
  selectDinnerMeals,
  selectLunchMeals,
  selectPlzs,
  selectStrs,
  selectGebs,
  selectedPlz,
  selectedStr,
  selectedGeb
} from "../redux/selectors";

class MealsContainer extends Component {
  constructor(props) {
    super(props);
  }

  componentDidMount() {
    const {
      fetchMeals,
      fetchPlzsIfNeeded,
      fetchStrsIfNeeded,
      selectedPlz
    } = this.props;

    fetchMeals()
      .then(() => {
        fetchPlzsIfNeeded();
      })
      .then(() => {
        fetchStrsIfNeeded(selectedPlz);
      });
  }

  componentDidUpdate(prevProps) {
    if (prevProps.selectedPlz !== this.props.selectedPlz) {
      const { fetchPlzsIfNeeded, fetchStrsIfNeeded, selectedPlz } = this.props;
      fetchPlzsIfNeeded().then(() => {
        fetchStrsIfNeeded(selectedPlz);
      });
    }
  }

  render() {
    const {
      breakfastMeals,
      lunchMeals,
      dinnerMeals,
      plzs,
      strs,
      gebs,
      selectedPlz,
      selectedStr,
      selectedGeb
    } = this.props;

    return (
      <div className="meals-container">
        <MealShowcase title="Breakfast" meals={breakfastMeals} />
        <MealShowcase title="Lunch" meals={lunchMeals} />
        <MealShowcase title="Dinner" meals={dinnerMeals} />
        <PlzPickerSelect options={plzs} value={selectedPlz} />
      </div>
    );
  }
}

const mapStateToProps = state => ({
  breakfastMeals: selectBreakfastMeals(state),
  lunchMeals: selectLunchMeals(state),
  dinnerMeals: selectDinnerMeals(state),
  plzs: selectPlzs(state),
  strs: selectStrs(state),
  gebs: selectGebs(state),
  selectedPlz: selectedPlz(state),
  selectedStr: selectedStr(state),
  selectedGeb: selectedGeb(state)
});

const actionCreators = { fetchMeals, fetchPlzsIfNeeded, fetchStrsIfNeeded };

export default connect(
  mapStateToProps,
  actionCreators
)(MealsContainer);
