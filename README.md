# EPE IDC Microservices 200 Session

**Introduction**
<p>This is the repo spin up to have our EPE IDC Micrservices Level-200 session related materials and code that can be shared to participants.<p>

**Description**
<p> Amchi Dukan can have many services but we have listed down few important ones below. It can vary case to case basis but for now we can define our domain within this. It will be difficult to create all these services in our hands-on session, so we have identified three basic ones which will suffice the initial lab session. </p>

**High level services**
<p align="center">
  <img src="services.png" height="400" width="850" title="hover text">
</p>

**Communication between these services**

<p align="center">
  <img src="arch.png" height="400" width="850" title="hover text">
</p>

**How to expose your API(s)?**

For exposing your API from local devices use **ngrok** tool, following is the documentation link https://ngrok.com/docs/getting-started

**'ngrok' command example**
```
Syntax :
ngrok http https://localhost:<port number> --host-header=localhost:<port number>

Example:
ngrok http https://localhost:44343 --host-header=localhost:44343
```
