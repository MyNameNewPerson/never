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

## Remaining Tasks
- [ ] **XML Data Integration**: Fully integrate `abcells.xml` and `map.xml` into the `NavigationService`.
- [ ] **UI Completion**: Implement Map, Profiles, and Settings screens.
- [ ] **Secure Storage**: Implement credential storage using MAUI Essentials.

## Compilation Instructions
```bash
dotnet build NeverlandsMobile.sln
```

PrompT:
You are a senior software architect, reverse engineering specialist, and cross-platform mobile developer.

You are working inside a GitHub repository containing the full source code of a Windows desktop client for the browser game Neverlands.

The original application was distributed as a compiled executable and later decompiled into C#.
The repository therefore contains reconstructed source code that already implements the full functionality of the client.

The repository includes systems such as:

automation engines
combat logic
map navigation
resource gathering automation
profile management
XML map parsing
captcha handling
network communication
session management
UI components
background timers and schedulers

A new mobile architecture has already been started inside a directory called:

NeverlandsMobile

Your task is to continue development of the mobile client until it fully supports the functionality of the original desktop client.

You must work directly inside the repository and extend the existing NeverlandsMobile project.

Do NOT create a separate project.

CRITICAL PRINCIPLE

Do not invent gameplay logic if it already exists in the repository.

The desktop client already contains working implementations of most gameplay systems.

Your responsibility is to:

locate those implementations
extract them
refactor them
integrate them into the mobile architecture

The goal is full functional parity between the original desktop client and the mobile client.

FUNCTIONAL DISCOVERY PHASE (MANDATORY)

Before implementing new code you must perform a full discovery analysis of the repository.

Automatically scan the entire codebase and detect all gameplay systems implemented in the original client.

Examples include:

automation systems
combat engine
navigation system
map interaction
resource gathering automation
script automation
character state management
profile system
XML map parsing
captcha integration
HTTP communication
session handling
background schedulers
timers
UI interaction logic

Detect classes responsible for these systems.

Typical examples might include classes similar to:

LezFight
MapBot
NavigationManager
ScriptManager
CombatManager
ResourceAutomation
BackgroundTasks

Create a full functional map of the client.

Produce a structured list:

Feature
Source Files
Main Classes
Dependencies

This discovery map should represent the complete functional architecture of the desktop client.

ARCHITECTURE RECONSTRUCTION

Because the project was originally decompiled, many class names may be unclear.

Reconstruct the logical architecture by grouping classes into subsystems such as:

Game communication
Combat system
Navigation system
Automation system
Map handling
Configuration
Profiles
Services
UI

Document the architecture before continuing.

DESKTOP VS MOBILE FEATURE COMPARISON

Analyze the existing NeverlandsMobile project.

Determine which features have already been implemented in the mobile version.

Create a comparison table:

Desktop Feature
Mobile Status
Missing Components

Use this comparison to guide the remaining implementation work.

MIGRATION STRATEGY

When migrating code from the desktop client:

extract reusable logic
remove Windows Forms dependencies
refactor the logic into services
integrate into the mobile architecture

Do not rewrite logic that already works.

Reuse existing algorithms and logic whenever possible.

CLEAN ARCHITECTURE STRUCTURE

The mobile application must follow a layered architecture.

Core Layer
Game state models and shared interfaces.

Infrastructure Layer
Networking, cookies, HTTP communication, persistence, configuration.

Automation Layer
Gameplay automation logic extracted from the original client.

Services Layer
Application orchestration services.

Mobile UI Layer
MAUI interface and platform-specific code.

Business logic must never be placed in the UI layer.

AUTOMATION ENGINE

The mobile application must implement all automation capabilities already present in the original client.

These include systems such as:

automated resource gathering
automated navigation across the map
combat automation
scripted gameplay actions
task scheduling
character state monitoring

Important gameplay features may include:

auto woodcutting
auto mining
auto combat
map navigation
scripted actions
automation timers

These systems must be implemented using modular services.

Example structure:

AutomationEngine
CombatService
NavigationService
ResourceService
ScriptManager
BackgroundAutomationManager

Each service must be independent and reusable.

BACKGROUND EXECUTION

Automation must continue running when:

the application is minimized
the phone screen is locked
the user switches applications

Use Android Foreground Services to maintain persistent background execution.

Implement a BackgroundAutomationManager responsible for managing automation loops and services.

PERFORMANCE ARCHITECTURE

The new mobile client must significantly outperform the original desktop client.

Implement performance improvements such as:

async networking using HttpClient
removal of blocking loops and Thread.Sleep
task-based concurrency using async/await
caching frequently accessed game state in memory
loading XML map data only once
dictionary-based map cell lookup
reducing unnecessary network requests
using efficient parsing instead of heavy regular expressions

The goal is approximately a 5–10x performance improvement compared to the original client.

NETWORK AND PROTOCOL HANDLING

Ensure compatibility with the original game server communication.

Maintain correct handling of:

cookies
sessions
HTTP headers
character encoding

Game responses must continue to be parsed using Windows-1251 encoding.

XML MAP DATA

The original client contains XML files such as:

abcells.xml
map.xml

These must be loaded once and stored in memory structures.

Navigation systems should use fast lookup structures such as dictionaries.

VALIDATION AND TESTING

Every migrated system must be validated.

Implement automated tests for:

combat logic
navigation algorithms
automation decisions
network response parsing

Behavior must match the logic of the desktop client.

Add detailed logging for automation execution and error diagnostics.

MOBILE UI DESIGN

Continue building the mobile interface using .NET MAUI.

The application should include screens such as:

Dashboard
Character status and automation state.

Automation Control
Enable or disable automation modules.

Map and Navigation
Display map information and movement.

Profiles
Manage multiple characters.

Settings
Application configuration.

Logs
Display automation activity and diagnostics.

The interface must be optimized for touch interaction and small screens.

DEVELOPMENT WORKFLOW

All development must follow a structured Git workflow.

For each feature:

create a new branch
implement functionality
add or update tests
verify that the project builds successfully
confirm that existing functionality still works
submit changes via Pull Request

Each Pull Request must include:

description of implemented features
architectural explanation
confirmation that tests pass

FINAL OBJECTIVE

The final system must be a modern mobile client that:

preserves all functionality of the original desktop client
reuses existing logic from the repository
runs on Android using .NET MAUI
supports persistent background automation
provides a modern mobile interface
offers significantly improved maintainability and performance

Development should continue until the mobile implementation reaches full functional parity with the desktop client.



