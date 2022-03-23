# Backend Engineer assignment
This assignment is not a fail/pass kind of assignment, it's merely a way for us to get insight into how you structure code etc.

We use it as a base for interview 2.

You should fork the repository and once you have completed the assignment you should send us the link to your version.

Create you code in the `src` folder.

If you have to use private repository for the assignment, then ask us for github usernames that you can invite.

## The assignment
### Gateway
Implement a `GatewayService` which handles incoming requests.

The gateway should handle calls to `/api/pokemons/` which targets the `First service`. `Second service` is not exposed through te gateway.

### First service
You should implement a service that handles requests to `/api/pokemons/`.
- `GET` requests should fetch from DB and return data to the client.
- `PUT`, `POST` and `DELETE` should make a request to `Second service` with the operation+data and return `200 OK`

Specs:
- Should be possible to get ALL pokemon, a range of pokemon and single pokemon
- `PUT`and `POST` should only be done for single entries
- `DELETE` should accept a range of IDs

### Second service
Lastly you need to implement the service handling the requests coming from `First service`
- `PUT` messages should add the pokemon to the database if it does NOT exist
- `POST` messages should update a specific pokemon in the database if it DOES exist
- `DELETE` should just delete the specified pokemon - we don't really care if it exist or not as long as it gets deleted if it does


Use docker containers for all your external dependencies (database etc.). You do not have to prepare the services for container usage.

You can use whatever database you like (we use PostgreSQL) - including a mocked database in code.

## Important notice
Use best practices for C#/.NET and make sure you think about testability (don't write tests, but write code that can be tested if need be).

## Example
You do **NOT** need to name your services like this. This is just an **EXAMPLE**. The example is for the base version of this assignment.

![backend-assignment drawio (2)](https://user-images.githubusercontent.com/1456819/155525766-ad827d19-6f74-4d11-89f5-bc5c17350d31.png)
