'use strict'

const config = require('./config');
let express = require('express');
let api = require('./services/router');

let logger = (req, res, next) => {
    let current_datetime = new Date();
    let formatted_date =
        current_datetime.getFullYear() +
        "-" +
        (current_datetime.getMonth() + 1) +
        "-" +
        current_datetime.getDate() +
        " " +
        current_datetime.getHours() +
        ":" +
        current_datetime.getMinutes() +
        ":" +
        current_datetime.getSeconds();
    let method = req.method;
    let url = req.url;
    let status = res.statusCode;
    let log = `[${formatted_date}] ${method}:${url} ${status}`;
    
    console.log(log);
    next();
};

express()
    .use(logger)
    .use("/api", api)
    .listen(config.port, () => console.log(`Listening on port http://localhost:${config.port}/`));