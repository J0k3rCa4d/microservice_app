module.exports = {
    name: 'calculator',
    version: '0.0.1',
    env: process.env.NODE_ENV || 'development',
    port: process.env.PORT || 8889,
    sqlOptions: {
        user: 'SA',
        password: process.env.DB_PASS || '1244Pass_',
        server: process.env.DB_HOST || 'localhost', 
        database: 'Api',
        synchronize: true,
        trustServerCertificate: true,
    }
}