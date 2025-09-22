var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/", (string body) =>
{
  return "Was called with Method: POST; Path: /";
});

app.MapGet("/", () =>
{
  return "Was called with Method: GET; Path: /";
});

app.MapPut("/", () =>
{
  return "Was called with Method: PUT; Path: /";
});

app.MapDelete("/", () =>
{
  return "Was called with Method: DELETE; Path: /";
});

app.Run();
