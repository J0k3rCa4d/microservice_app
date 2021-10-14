
let express = require('express');
let router = express.Router();
const calculationService = require('./calculationService');

router.get('/', async (req, res) => {
  res.status(200).send();
});

router.get('/calculations/:example', async (req, res) => {

  try {
    let request = {
      example: req.params.example,
      from: req.query["from"],
      to: req.query["to"],
    }

    let result = await calculationService.calculate(request.example, request.from, request.to);
    
    res.send(result);

  } catch (error) {
    res.status(500).send(error.message)
  }
});

module.exports = router;
