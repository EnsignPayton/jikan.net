 [![Discord Server](https://img.shields.io/discord/460491088004907029.svg?style=flat&logo=discord)](https://discord.gg/4tvCr36) ![build status](https://travis-ci.org/Ervie/jikan.net.svg?branch=master) ![build status](https://img.shields.io/nuget/v/JikanDotNet.svg) [![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT) [![GitHub issues open](https://img.shields.io/github/issues/Ervie/jikan.net.svg?maxAge=2592000)]() 

# jikan.net

Jikan.net is a .NET wrapper for [Jikan](https://jikan.moe) RESTful API for parsing data from [MyAnimeList](https://myanimelist.com). Main objective of the wrapper is to simplify utilization of Jikan API, as strongly typed languages are not-so-easy to use with elastic json (sure we can go use dynamics in .NET, but let's think about performance).

### Main attributes

* Written in to work with .Net Standard 2.0, compatible with .Net Framework (4.6.1 or newer), .Net Core (2.0 or newer) and .net (6.0 or newer).
* Fully asynchromous request fetching (can be forced to synchromous if needed).
* Light on dependencies 
    * No dependencies if you are using .Net Core 3.x or net 6.0.
    * Single dependancy for .Net Framework and .Net Core 2.x (System.Text.Json).
* Usable with Dependency Injection.

# List of features

- Anime
    - Basic information
    - Characters 
    - Staff
    - Episode
    - News
    - Videos/PV/Episodes
    - Pictures
    - Statistics
    - Forum Topics
    - More Info
    - Reviews
    - Recommendations
    - User Updates
    - Related entries
    - Themes
    - External links
    - Full information
- Manga
    - Basic information
    - Characters 
    - News
    - Pictures
    - Stats
    - Forum Topics
    - More Info
    - Reviews
    - Recommendations
    - User Updates
    - Related entries
    - External links
    - Full information
- People
    - Basic information
    - Related anime
    - Related manga
    - Voice acting roles
    - Pictures
    - Full information
- Characters
    - Basic information
    - Related anime
    - Related manga
    - Voice actors
    - Pictures
    - Full information
- Search 
    - Anime
    - Manga
    - People
    - Characters
    - Users
    - Clubs
- Seasonal Anime 
- Anime Scheduling (for current season)
- Top
    - Anime
    - Manga
    - People
    - Characters
    - Reviews
- Genre
    - Anime genres
    - Manga genres
- Producer
- Magazine
- User
    - Profile
    - Friends
    - History
    - Statistics
    - Favorites
    - About
    - Reviews
    - Recommendations
    - Clubs
    - Anime list (will become obsolete soon)
    - Manga list (will become obsolete soon)
- Clubs
    - Profile
    - Member list
    - Staff
    - Relations
# Installation

### Package manager

```
PM> Install-Package JikanDotNet
```

### .NET CLI

```
>dotnet add package JikanDotNet
```

Then restore dependencies:
```
>dotnet restore
```

# Changelog

## 24.06.2022 - Version 2.2.0

- Features
    * Add new endpoint for retrieving additional data in single call:
        * `GetAnimeFullDataAsync`
        * `GetMangaFullDataAsync`
        * `GetCharacterFullDataAsync`
        * `GetPersonFullDataAsync`
    * Add support for injecting own HTTP client with HttpClientFactory pattern
        * Passing custom endoint in configuration is still supported, but will be phased out


**[Read More](https://github.com/Ervie/jikan.net/blob/master/Changelog.md)**

# Documentation &  Usage example

See [project wiki](https://github.com/Ervie/jikan.net/wiki#usage-example).
