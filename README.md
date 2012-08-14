App.NET client for Windows 8
==============

## Goals

 - authenticate and query [App.NET](https://alpha.app.net/) data for a user
 - simple, succinct code
 - introduce Reactive Extensions to the masses
 - target Portable Library Tools (in future, partial support possible in V2)

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

    var url = Authenticator.CreateUrl("appid", "appSecret");
    var result = await WebAuthenticationBroker.AuthenticateAsync(url);

To query for data

    var token = FetchCachedToken();
    var client = new AppNetClient(token);
    client.GetTimeline()
    	  .Subscribe(DisplayTimeline);
