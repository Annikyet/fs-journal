Allows server to update information to clients in realtime (sorta? also bidirectionally)

`client/env.js`:
```js
export const useSockets = true
```

Sockets are like wizards with portals instead of boats i guess? in the castle metaphor

Server can send a message without a request first. - if a socket is setup first.

 watchEffect or onMounted (good place to put 'it')

 ```js
 socketService.joinRoom(route.params.id)
 ```

 `client/SocketService.js`:
 ```js
 joinRoom(room) {
  this.emit('join_room', {room})
 }
  ```

  `room` is what SocketIO calls a socket connectionything
  `.room` is the object socket is passing.

`Handler`s are like inbound controllers/services.

`server/TestHandler.js`:
```js
export class TestHandler extends SocketHandler {
  constructor(io, socket) {
    super(io, socket)
    this.on('join_room', this.joinRoom)
    this.on('joined_room', this.joinedRoom)
    this.on('new_vote', this.newVote)
  }

  joinRoom(payload) {
    if(!payload.room) {
      this.socket.emit('error', {message: 'no room'})
    }
    this.socket.join(payload.room)
    this.socket.emit('joined_room', payload)
  }

  joinedRoom(room) {
    logger.log(`joined room: ${room}`)
  }

  newVote(payload) {
    AppState.votes.push(payload)
  }
}
```

`client/VotesController.js`:
```js
async create(req, res, next) {
  try {
    socketProvider.messageRoom(req.body.pollId, 'new_vote', vote)
  } catch (error) {
    
  }
}