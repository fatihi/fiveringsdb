# Use StyleCop as Style Checker

* Status: accepted
* Deciders: fatihi, programming-wolf, Fuzzylog1cza, MattD
* Date: 2018-12-18

Technical Story: [#13](https://github.com/fatihi/fiveringsdb/issues/13)

## Context and Problem Statement

We want to (and need to) have a specific level of code quality
and a unified code style. We do not want to have to review
stuff that can be checked with static code analysis.
There are many tools available on different platforms.
Which tool should we use?

## Decision Drivers

* It should work on every platform (linux, macOS, Windows)
* It should be available without any further costs
* It should be possible to use it on a CI server

## Considered Options

* EditorConfig
* Jetbrains' ReSharper
* StyleCop/StyleCop.Analyzers
* FxCop

## Decision Outcome

Chosen option: "StyleCop", because it meets all required criteria.
It is available on every platform because it is part of dotnet core
and the project structure. Thus, it can also be used on a CI server.
In addition, it is available for free.
_StyleCop.Analyzers_ is part of the new Roslyn compiler

### Positive Consequences 

* We can define a code style that will be valid for everyone automatically.
* We can use it as part of `msbuild` on our CI server. 
* No additional costs

### Negative consequences

* StyleCop  is not as powerful as ReSharper and does not allow for
as many checks. 

## Links <!-- optional -->

* [StyleCop website](https://github.com/StyleCop/StyleCop)
* [StyleCop.Analyzers website](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
