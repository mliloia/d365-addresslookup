import axios from "axios";
import { BASE_URL } from "../config";

export const fetchBreakfast = () => axios.get(BASE_URL + "breakfast");
export const fetchLunch = () => axios.get(BASE_URL + "lunch");
export const fetchDinner = () => axios.get(BASE_URL + "dinner");
export const fetchPlz = () =>
  axios.get(BASE_URL + "mat_plzs?_sort=mat_plz_postleitzahl");
export const fetchStr = plz =>
  axios.get(BASE_URL + "mat_strs?_mat_plzid_value=" + plz);
