const repository = require('./exampleRepository')

const calculate = async (example, from, to) => {
    let values = await repository.get(example, from, to);

    values = values.map(v => v.Value);

    if(values.length <= 0)
        return {}

    let response = {
        avg: average(values),
        sum: sum(values)
    }
    console.log(values, response)
    return response;
}


const average = (arr) => {
    let value = arr.reduce((a,b) => a + b, 0) / arr.length;
    return parseFloat(value.toFixed(2))
}

const sum = (arr) => {
    let value = arr.reduce((a,b) => a + b);
    return parseInt(value)
}

module.exports = {
    calculate: calculate
}