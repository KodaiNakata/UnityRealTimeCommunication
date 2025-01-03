const PORT = 33333

const dgram = require('dgram');
const server = dgram.createSocket('udp4');

server.on('error', (err) => {
    console.log('server error:\n${err.stack}');
    server.close();
});

server.bind(PORT);