## Sketches

### Introduction

![Introduction](/documentation/backend-introduction.excalidraw.png)

### Client Server Architecture

![Client Server Architecture](/documentation/client-server-architecture.excalidraw.png)

### The pieces

![The pieces](/documentation/backend-the-pieces.excalidraw.png)

## Command shortlist (The most important)

- Get Help

  ```sh
  dotnet --help
  ```

- Get Version

  ```sh
  dotnet --version
  ```

- Generate new project

  ```sh
  dotnet new sln
  dotnet new web
  dotnet sln add <name-of-.csproj>
  ```

- Start the project

  ```sh
  dotnet run
  ```

- Stop the server (any console program really)

  ```sh
  Ctrl + C
  ```

- Generate local development certificates

  ```sh
  dotnet dev-certs https
  ```

## References

- [.NET SDK installation](https://dotnet.microsoft.com/en-us/download)
- [HTTP Request Methods List](https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Methods)
- [HTTP Response Codes](https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Status)

### HTTP Clients

There's many alternatives here, doesn't matter really what you pick.

- [Hoppscotch](https://hoppscotch.io/)

> [!NOTE]
> 
> You need to add the [Hoppscotch Extension](https://www.google.com/search?q=hoppscotch+extension) to your browser for it to be able to send message to your local server.

- [Client URL (curl)](https://curl.se/)
- [Postman](https://www.postman.com/)
