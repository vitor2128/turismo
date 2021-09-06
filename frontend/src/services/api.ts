import axios from 'axios';

const hubUrl = process.env.REACT_APP_URL;

const api = axios.create({
  baseURL: `${hubUrl}`,
});

export default api