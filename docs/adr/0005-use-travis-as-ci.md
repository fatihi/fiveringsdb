# Use Travis CI as CI Server

* Status: accepted
* Deciders: fatihi, programming-wolf, Fuzzylog1cza
* Date: 2018-12-18

Technical Story: #11

## Context and Problem Statement

Every project needs continuous integration (and ideally deployment).
We want to automagically create new versions of our software
and deploy them on the production server.
Which service shall we use for this?

## Decision Drivers <!-- optional -->

* The chosen solution should be cheap or free, even.
* The chosen solution has to support .NET Core

## Considered Options

* Gitlab CI
* Travis CI
* Circle CI
* Microsoft Azure DevOps
* Jenkins

## Decision Outcome

Chosen option: "Travis CI", because it satisfies our requirements.  
We did not consider Azure DevOps because we already decided
to use Travis CI when we became aware of it.  
Gitlab CI would have required to use a gitlab repository.  
Whilst Circle CI offers a limited free plan, Travis CI is always free
for open source projects.  
We might have chosen Jenkins if no other option was available,
but it simply is not as convenient as any other service.

## Links

* [Travis CI](https://travis-ci.com)
