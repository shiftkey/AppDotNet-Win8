App.NET client for Windows 8
==============

## Goals

 - authenticate and query [App.NET](https://alpha.app.net/) data for a user
 - simple, succinct code
 - introduce Reactive Extensions to the masses
 - target Portable Library Tools (in future, partial support possible in Rx V2)

## Features to support

 - Authentication (OAuth 2)
 - Interacting with ([see source](https://github.com/appdotnet/api-spec/tree/master/resources))
    - Users
    - Posts
    - Filters (spec under review)
    - Subscriptions (spec under review)
    - Streams (spec under review)

## Example usage

To authenticate the user

    var auth = new Authenticator();
    var url = auth.CreateUrl("my-client-id", "http://my-site.com/redirect/uri");
    var result = await auth.Authenticate(url);
    if (result.IsSuccess) {
        var accessToken = result.AccessToken;
    }

To query for data

    var client = new UserSession("access-token");
    // NOTE: observables now play nice with async/await!
    var user = await client.GetUser("shiftkey");
    var fullName = user.Name;


