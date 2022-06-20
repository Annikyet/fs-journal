# MVC

node is a js interpreter
express is or server building
bodyparser - middleware
error handler - middleware

JWT (JSON Web Token)
shared key, base64 encoded?

mongoose is a thing

schemas are classes for storing in db

routes are the 'subdirectory' for a specific type of data in an api

extends BaseController backend controller
super('cats') // go to api/cats
this.router
  .get('', this.cats)

`controller`
```js
async getCats(req, res, next) {
  try {
    let cats = await catsService.getCats()
    return res.send(cats)
  } catch (error) {
    // oops
    next(error)
  }
}
```


auth0 - account is the user logged in
  - may have personal info
auth - profile is any user
  - public information

ORM - Object Relational Mapper - Mongoose

`Car.js`
```js
import mongoose from 'mongoose'
const Schema = mongoose.Schema

export const CarSchema = new Schema({
  make: { type: String, required: true },
  model: { type: String, required: true },
  year: { type: Number, required: true, min: 1897, max: Date().getFullYear() + 2 },
  price: { type: Number, required: true, min: 1 },
  description { type: String, default: "No description provided." },
  imgUrl: { type: String, default: "http://placekitten.com/200/300" }
}, {timestamps: true, toJSON: { virtuals: true}})
```

`DbContext.js`
```js
// add this to DbContext
Cars = mongoose.model('Car', CarSchema)
```

`controllers/CarsController.js`
```js
import BaseController from "../utils/BaseController.js"
// no {} because it exports default

export class CarsController extends BaseController {
  constructor() {
    super('api/cars')
    
  }

  async getAll(req, res, next) {
    try {
      const cars = await carsService.getAll()
      // .getAll(req.body) - information from request
      return res.send(cars)
    } catch (error) {
      next(error)
    }
  }
}
```

`services/CarsService.js`
```js
class CarsService {
  async getAll() {
    const cars = dbContext.Cars.find({})
    // .find({make: 'DMC'}) - 'query'
    // .create(body)
  }

  async getById(id) {
    const car = await dbContext.Cars.findById(Id)
    if (!car) {
      throw new BadRequest()
    }
  }
}

export const carsService = new CarsService()
```

lucid.app is a thing

`.populate('attribute')` explained - it populates the entire object from another table in this object, by referencing its id. The name of the populate must match the name of the id in the current table.

HOW THE HECK DOES MONGODB/MONGOOSE WORK DO I DON'T GET IT ARGGHHHHHH!!! RDBMS WYA???