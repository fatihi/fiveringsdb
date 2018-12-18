# Use Docker for Packaging and Deployment

* Status: accepted
* Deciders: fatihi, programming-wolf, Fuzzylog1cza
* Date: 2018-12-18

Technical Story: [#10](https://github.com/fatihi/fiveringsdb/issues/10)

## Context and Problem Statement

As this project is a web service, we need to deploy the bundle to a server.
Should we use a container system or just create WebDeploy packages?

## Considered Options

* Docker

## Decision Outcome

We chose "Docker" and did not consider any other option.
Using Docker makes everything super simple and the deployment
is a piece of cake.
