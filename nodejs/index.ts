import * as express from 'express';

const app = express();
const host = 'localhost';
const port = 3000;

app.get('/', (req, res) => {
    res.send('use ' + host + ':' + port + '/test');
})

app.route('/test')
 .get((req, res) => {
    res.send('test');
});

app.listen(port, () => {
    console.log('App is running on port ', port);
})