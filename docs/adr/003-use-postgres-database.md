# [Use PostgreSQL as Database]

* Status: accepted
* Deciders: fatihi, programming-wolf, Fuzzylog1cza
* Date: 2018-12-18

Technical Story: #8

## Context and Problem Statement

We need a database for our new application (which will be rewritten in C#,
see [ADR-0001](0001-use-dotnet-core-and-c-sharp.md)).
Will we use a new database or will we continue to use the existing database?

## Considered Options

* Keep the existing database and its data
* Use MS SQL with a new schema
* Use PostgreSQL with a new schema

## Decision Outcome

Chosen option: "PostgreSQL", because it comes out best
regarding the pros and cons below.

## Pros and Cons of the Options

### Keep existing database

* Good, because no changes are required
* Bad, because the current schema can be improved a lot
* Bad, because the entity structure of the DB and our new entities
might/will vary.
* Bad, because the database was designed with a different
language/structure in mind

### Use MS SQL

* Good, because it is from Microsoft and integration with
the Entity Framework is very good.
* Bad, because it is a proprietary and commercially licensed database.
* Bad, because only a few developers are familiar with it.
* Bad, because it is limited to linux and Windows

### Use PostgreSQL

* Good, because it is open source.
* Good, because it is known to most of our developers.
* Good, because it also works well with Entity Framework
* Good, because it supports pretty much every OS.
