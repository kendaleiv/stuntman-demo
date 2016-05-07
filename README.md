# Stuntman Demo

A demo of [RimDev.Stuntman](http://rimdev.io/stuntman) usage.

## API Test

- Make request to **~/Home/ApiEndpoint**
  - Without proper `Authorization` header should return HTTP `302` with `Location` header to Stuntman login.
  - With proper `Authorization` header should return HTTP `200` with expected JSON.

## License

MIT
