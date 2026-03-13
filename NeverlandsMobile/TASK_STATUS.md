# Neverlands Mobile Project Task Status

## Project Objective
The goal of this project is to implement a modern, mobile-friendly client for the Neverlands browser game using .NET MAUI. The application preserves the automation logic of the original Windows desktop client while improving the architecture and usability for smartphone users.

## Current Architecture
The project follows a **Clean Architecture** pattern, separated into the following modules:

### 1. Neverlands.Core
Contains the platform-agnostic data models and core interfaces.
- `Models/UserProfile.cs`: Character credentials, tokens, and automation settings.
- `Models/GameState.cs`: Current state of the character in the game.
- `Interfaces/`: Core abstractions for networking, combat, and navigation.

### 2. Neverlands.Infrastructure
Handles external communication and persistence.
- `Services/NetworkService.cs`: Modern `HttpClient` implementation with cookie support and Windows-1251 encoding.
- `Services/AntiCaptchaService.cs`: Integration with Anti-Captcha API v2.

### 3. Neverlands.Automation
The "brain" of the application, responsible for automated gameplay.
- `Services/CombatService.cs`: turn-based combat logic.
- `Services/NavigationService.cs`: Pathfinding and automated movement.

### 4. Neverlands.Mobile
The .NET MAUI application layer.
- `ViewModels/MainViewModel.cs`: Dashboard state management.
- `Views/MainPage.xaml`: Touch-friendly mobile dashboard.
- `Platforms/Android/AutomationForegroundService.cs`: Background execution logic.

## Realized Tasks
- [x] Initial codebase analysis and architecture extraction.
- [x] Defined core models and interfaces.
- [x] Implemented `NetworkService` with `HttpClient` and retry logic.
- [x] Ported `AntiCaptchaService` to the new architecture.
- [x] Ported Combat and Navigation services.
- [x] Set up the .NET MAUI project with dependency injection and MVVM.
- [x] Implemented Android Foreground Service for persistent automation.
- [x] Implemented unit tests for ported logic.
- [x] **XML Data Integration**: Fully integrated `abcells.xml` and `map.xml` into `NavigationService` with coordinate mapping and BFS pathfinding.
- [x] **Secure Storage**: Implemented `SecureStorageService` using MAUI Essentials for character credentials.
- [x] **UI Completion**: Implemented Map, Profiles, and Settings screens using MVVM and touch-optimized components.
- [x] **Feature Parity**: Ported resource gathering logic (woodcutting, fishing, mining) into the new `ResourceAutomationService`.

## Remaining Tasks


# Neverlands Mobile Client — Project Specification & Task Status

## Project Objective

The goal of this project is to build a **modern mobile client for the Neverlands browser game** using **.NET MAUI**, based on the functionality of the **original Windows desktop client**.

The desktop client was originally distributed as a compiled executable and later **decompiled into C# source code**, which is now available in this repository.

The mobile client must:

* preserve **all gameplay automation features**
* reuse logic from the original client
* implement a **Clean Architecture**
* run on **Android**
* support **background automation**
* improve maintainability and performance

The final system should be a **fully functional mobile automation client** for Neverlands.

---

# Repository Structure

The repository contains two main components.

## Desktop Client (Reference Implementation)

This part of the repository contains the **decompiled Windows client**.

It already implements:

* combat engine
* navigation
* resource automation
* scripting
* network communication
* captcha solving
* XML map processing
* automation scheduling
* profile management

This codebase is the **authoritative reference implementation**.

Important rule:

> Do NOT rewrite gameplay logic that already exists.
> Locate the implementation in the desktop client and migrate it.

---

## Mobile Client

The mobile implementation is located in:

```
NeverlandsMobile
```

Architecture:

```
Neverlands.Core
Neverlands.Infrastructure
Neverlands.Automation
Neverlands.Mobile
Neverlands.Tests
```

The project follows **Clean Architecture**.

### Core

Contains platform-independent models and interfaces.

Examples:

```
UserProfile
GameState
GameCell
```

---

### Infrastructure

Handles external communication.

Examples:

```
NetworkService
AntiCaptchaService
SecureStorageService
```

Responsibilities:

* HTTP communication
* cookies and sessions
* Windows-1251 encoding
* captcha integration
* persistent storage

---

### Automation

Contains the gameplay automation logic.

Examples:

```
CombatService
NavigationService
ResourceAutomationService
ScriptManager
BackgroundAutomationManager
```

Responsibilities:

* automated combat
* navigation
* resource gathering
* scripted automation
* scheduling

---

### Mobile

The .NET MAUI application.

Examples:

```
MainPage
MapPage
ProfilesPage
SettingsPage
```

Responsibilities:

* UI
* ViewModels
* dependency injection
* Android services

---

### Tests

Automated tests validating migrated systems.

Examples:

```
Navigation tests
Combat tests
Automation tests
```

---

# Critical Development Rules

The following rules must always be respected.

### Do

* reuse desktop client logic
* refactor existing algorithms
* maintain the Clean Architecture structure
* update this document after each task

### Do Not

* invent gameplay logic
* remove existing features
* move business logic into UI
* mark tasks complete without verification

---

# Functional Discovery Phase

Before implementing new features, perform a **full repository analysis**.

Scan the desktop client and detect all implemented systems.

Examples:

```
combat engine
map navigation
automation engine
resource gathering
scripts
captcha handling
HTTP communication
session management
background schedulers
profile management
```

For each detected system document:

```
Feature
Source Files
Main Classes
Dependencies
```

Add the results below.

---

# Desktop Client Functional Map

(To be filled automatically during repository analysis)

| Feature | Source Files | Main Classes | Dependencies |
| ------- | ------------ | ------------ | ------------ |
|         |              |              |              |

---

# Desktop vs Mobile Feature Comparison

Analyze the mobile implementation and compare it to the desktop client.

| Desktop Feature       | Mobile Status | Missing Components          |
| --------------------- | ------------- | --------------------------- |
| Combat automation     | implemented   | edge cases                  |
| Navigation            | implemented   | teleport logic              |
| Resource automation   | partial       | mining optimization         |
| Scripts               | missing       | ScriptManager               |
| Background scheduling | partial       | BackgroundAutomationManager |

This table must always remain **accurate**.

---

# Implemented Systems

Document all completed migrations.

Example:

### Networking

Implemented:

```
NetworkService
HttpClient integration
retry logic
cookie management
Windows-1251 encoding
```

---

### Map Navigation

Implemented:

```
NavigationService
XML map parsing
BFS/Dijkstra pathfinding
```

Files:

```
abcells.xml
map.xml
```

---

### Resource Automation

Implemented:

```
woodcutting
mining
fishing
```

Service:

```
ResourceAutomationService
```

---

### Secure Storage

Implemented using:

```
MAUI SecureStorage
```

---

### Mobile UI

Implemented screens:

```
Dashboard
Map
Profiles
Settings
```

---

### Background Automation

Implemented via:

```
Android Foreground Service
```

Class:

```
AutomationForegroundService
```

---

# Remaining Tasks

This section lists tasks that must still be completed.

Each item must be removed once completed.

---

## Desktop Feature Discovery

Scan the desktop client and document all gameplay systems.

Deliverable:

```
Desktop Client Functional Map
```

---

## Feature Parity

Ensure that the mobile client implements:

```
combat automation
navigation automation
resource automation
script engine
automation timers
profile management
```

---

## Script Engine Migration

If the desktop client contains a script engine, migrate it into:

```
ScriptManager
```

inside the Automation layer.

---

## Background Automation Manager

Create a central manager responsible for:

```
automation loops
timers
task scheduling
```

---

## Map System Completion

Ensure full support for:

```
abcells.xml
map.xml
map_mines.xml
abteleports.xml
```

Requirements:

* single load
* memory cache
* dictionary lookup

---

## Performance Optimization

Verify that the mobile client uses:

```
async networking
no Thread.Sleep
task-based concurrency
cached game state
efficient parsing
```

---

## Test Coverage

Add tests for:

```
combat logic
navigation
automation decisions
network parsing
```

---

# Build Instructions

The project must compile successfully.

```
dotnet build NeverlandsMobile.sln
```

---

# Pull Request Requirements

All development must be submitted through Pull Requests.

Each PR must include:

* description of implemented features
* architectural explanation
* confirmation that tests pass

---

# Merge Conflict Resolution

If the Pull Request has conflicts with `main`, perform the following:

1. synchronize with `origin/main`
2. rebase the branch
3. resolve conflicts
4. verify the build
5. push updated branch

The PR must be **fully mergeable**.

---

# Documentation Updates

After completing any task:

1. update this document
2. move completed tasks from **Remaining Tasks**
3. add them to **Implemented Systems**
4. describe the implementation

---

# Final Completion Criteria

The project is complete only when:

* all desktop client systems are migrated
* mobile client supports full automation
* background automation works
* the project builds successfully
* tests pass
* the Pull Request is mergeable
* this document accurately reflects the project state

Do **not mark the project complete until all conditions are satisfied**.

---

