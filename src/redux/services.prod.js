import axios from "axios";
import { getClientUrl } from "../config";

const options = {
  headers: {
    Accept: "application/json",
    "OData-MaxVersion": "4.0",
    "OData-Version": "4.0",
    "If-None-Match": "null"
  },
  transformResponse: axios.defaults.transformResponse.concat(
    (data, headers) => {
      return data.value;
    }
  )
};

export const fetchPlz = () =>
  axios.get(
    getClientUrl() +
      "mat_plzs?$select=mat_plz_ortbez27,mat_plz_postleitzahl" +
      "&$orderby=mat_plz_ortbez27,mat_plz_postleitzahl",
    options
  );
export const fetchStr = plz =>
  axios.get(
    getClientUrl() +
      "mat_strs?$select=mat_str_strbez2l" +
      "&$orderby=mat_str_strbez2l" +
      "&$filter=_mat_plzid_value eq " +
      plz,
    options
  );
export const fetchGeb = str =>
  axios.get(
    getClientUrl() +
      "mat_gebs?$select=mat_geb_hnr,mat_geb_hnra" +
      "&$orderby=mat_geb_hnr" +
      "&$filter=_mat_strid_value eq " +
      str,
    options
  );
export const fetchConfig = () =>
  axios.get(getClientUrl() + "mat_configs", options);
