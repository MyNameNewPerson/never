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

You are working inside a GitHub repository that contains the full source code of a Windows desktop client for the browser game Neverlands.

The original client was distributed as a compiled executable and later decompiled into C#.
The repository now contains the recovered source code of the client including automation systems, navigation logic, combat logic, resource gathering automation, networking code, configuration management, UI code, and supporting infrastructure.

A new mobile architecture has already been started inside a directory called:

NeverlandsMobile

Your task is to continue development of the mobile client and ensure that the mobile implementation fully supports the functionality of the original desktop client.

You must work directly inside the existing repository and extend the existing NeverlandsMobile directory.

Do not create a new separate project.

CRITICAL PRINCIPLE

Do NOT invent gameplay logic if it already exists in the repository.

The original desktop client already implements most gameplay automation systems.
Your task is to locate this logic and reuse it.

Your work must focus on:

• extracting logic from the existing code
• refactoring it
• integrating it into the mobile architecture

The goal is full functional parity between the desktop client and the mobile client.

FULL FUNCTIONAL DISCOVERY (MANDATORY FIRST STEP)

Before implementing new code, perform a full discovery analysis of the repository.

The purpose of this step is to automatically detect all features implemented in the original client.

Scan the repository and identify all gameplay systems including:

automation modules
combat system
navigation system
map interaction
resource gathering automation
scripted actions
character state management
profile management
XML map handling
captcha integration
network communication
session handling
UI interaction
timers and schedulers

Detect classes and files responsible for these systems.

Examples may include classes similar to:

LezFight
MapBot
NavigationManager
ScriptManager
CombatManager
ResourceAutomation
BackgroundTasks

Create a functional map of the entire client.

Output a structured list showing:

Feature Name
Source Files
Primary Classes
Dependencies

This discovery phase must produce a complete list of functionality implemented in the original client.

DESKTOP VS MOBILE COMPARISON

Next, analyze the existing NeverlandsMobile implementation.

Determine which features from the desktop client have already been migrated.

Create a comparison table:

Desktop Feature
Mobile Implementation Status
Missing Components

Only after this comparison should implementation begin.

CODE MIGRATION STRATEGY

When porting functionality from the desktop client:

1. Extract reusable logic from the original code.
2. Remove Windows Forms dependencies.
3. Refactor the logic into reusable services.
4. Integrate the services into the mobile architecture.

The architecture must be organized into layers:

Core
Game models, shared interfaces, and state structures.

Infrastructure
Networking, HTTP communication, cookies, persistence, configuration.

Automation
All gameplay automation logic extracted from the original client.

Services
Application-level orchestration services.

Mobile UI
The MAUI interface and platform-specific code.

Business logic must never exist in the UI layer.

AUTOMATION ENGINE

The mobile application must support all automation capabilities already present in the original client.

These may include:

automated resource gathering
automated navigation
combat automation
script execution
task scheduling
character state monitoring

Implement these using modular services such as:

AutomationEngine
CombatService
NavigationService
ResourceService
ScriptManager
BackgroundAutomationManager

Each service must be independent and testable.

BACKGROUND EXECUTION

Automation must continue running when:

the application is minimized
the phone screen is locked
the user switches to another application

Use Android Foreground Services to maintain persistent background execution.

Implement a BackgroundAutomationManager that coordinates all automation tasks.

PERFORMANCE OPTIMIZATION

The mobile client should be significantly faster than the original desktop client.

Apply the following optimizations:

asynchronous networking using HttpClient
removal of Thread.Sleep loops
task-based concurrency using async/await
in-memory caching of game state
single-load parsing of XML map files
dictionary-based map lookup
reduced network requests
efficient parsing instead of heavy regular expressions

The target is approximately 5–10x performance improvement compared to the legacy client.

VALIDATION AND TESTING

Every migrated system must be verified.

Implement automated tests for:

combat logic
navigation algorithms
automation decision logic
network parsing

Validate behavior against the desktop client logic.

Add logging for automation actions and error diagnostics.

MOBILE UI DEVELOPMENT

Continue building the mobile UI using .NET MAUI.

The interface should include:

Dashboard
Displays character state and automation status.

Automation Control
Enables and configures automation modules.

Map and Navigation
Displays map information and movement.

Profiles
Manage multiple characters.

Settings
Application configuration.

Logs
Display automation activity and diagnostics.

The UI must be optimized for small screens and touch interaction.

WORKFLOW REQUIREMENTS

All development must follow a structured Git workflow.

For each feature:

1. Create a new branch.
2. Implement functionality.
3. Add or update tests.
4. Verify the project builds successfully.
5. Ensure existing features remain functional.
6. Submit the changes through a Pull Request.

Each Pull Request must include:

description of migrated functionality
architectural explanation
confirmation that tests pass

FINAL OBJECTIVE

The final result should be a complete modern mobile client that:

preserves all functionality of the original desktop client
reuses the logic already present in the repository
runs on Android using .NET MAUI
supports persistent background automation
provides a modern mobile interface
is significantly more maintainable and performant

Development should continue iteratively until the mobile client reaches full feature parity with the desktop client.


