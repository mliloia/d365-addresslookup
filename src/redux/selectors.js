// General Selectors
export const selectBreakfastMeals = state => state.ui.breakfast;

export const selectLunchMeals = state => state.ui.lunch;

export const selectDinnerMeals = state => state.ui.dinner;

export const selectPlzs = state => state.ui.plzs;

export const selectStrs = state => state.ui.strs;

export const selectGebs = state => state.ui.gebs;

export const selectedPlz = state => state.ui.selectedPlz;

export const selectedStr = state => state.ui.selectedStr;

export const selectedGeb = state => state.ui.selectedGeb;

// By id selectors
export const getMealById = (state, id) => state.entities.meals[id];

export const getRatingById = (state, id) => state.entities.ratings[id];

export const getPlzById = (state, id) => state.entities.plzs[id];

export const getPlzsByIds = (state, ids) =>
  ids.map(id => state.entities.plzs[id]);
export const getStrsByIds = (state, ids) =>
  ids.map(id => state.entities.strs[id]);
export const getStrsByPlzId = (state, plzId) => {
  return Object.keys(state.entities.strs)
    .map(key => state.entities.strs[key])
    .filter(str => str._mat_plzid_value === plzId);
};
