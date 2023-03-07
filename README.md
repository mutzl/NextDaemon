# NextDaemon

Playground for creating Homeassistant Add-Ons based on NetDaemon.


## Steps
1. Created [project with CLI](https://netdaemon.xyz/docs/v3/started/development#2-get-the-project-template) and called it `NextDaemon`.
1. Added MVC and Blazor stuff following the [tutorial](https://netdaemon.xyz/docs/v3/tutorials/webhost).
1. Changed folder structure and moved project to `src` to align with [NetDaemon repository](https://github.com/net-daemon/netdaemon/tree/dev).
1. Added `Dockerfile`, `Dockerfile.AddOn` and sh6 scripts in `Docker`folder from [NetDaemon repository](https://github.com/net-daemon/netdaemon/tree/dev).

## Still ToDo
- add secrets
- Workflow / Action to deploy docker image
- `config.yaml` to create add-on
- clean `run` and `finish`scripts
- get the damn thing running!!!