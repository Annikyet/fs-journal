[postman docs](https://learning.postman.com)

postman tests build off the mocha framework and chai library

**Pre-request scripts**

**Tests** tab

- javascript that runs once the main request has gone out

```js
const res = pm.response
const car = pm.response.json()
console.log('tests file is running', res)

pm.test("request was successful", () => {
  // this is chai
  pm.expect(res.code).to.be.oneOf([200, 201], 'the request was unsuccessful')
})

pm.test('car has proper make', () => {
  pm.expect(car.make).to.be.an('string', 'make is not a string')
  pm.expect(car.make).to.be.eql('test make', 'make was incorrect')
})

var schema = {
  "make": {
    "type": "string"
  },
  "model": {
    "type": "string"
  },
  "price": {
    "type": "number"
  }
}

pm.test('Schema is vald', function () {
  res.to.have.jsonSchema(schema)
})
```

`pm` - refers to postman

```
[PASS] request was successful [200]
[FAIL] car has proper make [ AssertionError: make was incorrect: expected null to deeply equal 'test make']
[PASS] Schema is vald
```