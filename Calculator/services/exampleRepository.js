const sql = require('mssql')
const config = require('../config')

const get = async (example, from, to) => {
    
    if(!example){
        return;
    }

    try {
        await sql.connect(config.sqlOptions);
    
        let sqlQuery = `SELECT Value FROM Examples WHERE Name = '${example}'`
        
        if(from){
            sqlQuery += ` and Timestamp >= ${from}`
        }

        if(to){
            sqlQuery += ` and Timestamp <= ${to}`
        }

        var records =  await sql.query(sqlQuery);
        return records.recordset;
   
    } catch (err) {
        console.log(err.message)
        throw(err)
    }
}

const unixTimeToDateTime = (timestamp) => {
    return new Date(timestamp).toLocaleString()
}

module.exports = { 
    get: get
}