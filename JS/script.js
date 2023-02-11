const axios = require('axios');

axios.get('https://t42023-d2ff8-default-rtdb.firebaseio.com/dadostrabalho.json').then(response => {console.log(response.data)})