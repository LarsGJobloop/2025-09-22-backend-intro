var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/greeting", (string name) =>
{
  return $"Greeting {name}";
});

app.MapPost("/posts/{postNumber}", (int postNumber) =>
{
  return $"Was called with Method: POST; Path: /; PostNumber: {postNumber}";
});

app.MapGet("/posts", () =>
{
  var randomNumber = new Random().Next();
  return $"Was called with Method: GET; Path: /; Random Number {randomNumber}";
});

app.MapPut("/posts", () =>
{
  return "Was called with Method: PUT; Path: /";
});

app.MapDelete("/posts", () =>
{
  return "Was called with Method: DELETE; Path: /";
});

app.Run();
