Messaging Project

Introduction

The Messaging Project is a simple yet flexible application designed to send messages through multiple channels, such as Email and SMS. The application leverages Dependency Injection (DI) to seamlessly switch between messaging methods without changing the core logic.

Purpose

This project demonstrates the use of:

Interfaces for defining contracts

Service classes for implementing messaging methods

Dependency Injection for flexible and maintainable code

Controllers as entry points to manage user requests

Features

Send messages via Email or SMS

Easily switch between messaging methods using DI

Clean and modular code structure

Simple to extend with new messaging services (e.g., WhatsApp)

Project Structure
MessagingSystem/
├── Interfaces/            # Contains interface definitions
├── Services/              # Contains implementation of interfaces
├── Controllers/           # Manages user requests
├── Program.cs             # Configures DI and runs the application
└── README.md              # Project documentation

Technologies Used

C#

.NET Core

Microsoft.Extensions.DependencyInjection

How It Works

Interfaces: Define methods without specifying how to implement them.

Classes: Implement the methods defined in interfaces.

Dependency Injection: Injects the chosen service at runtime.

Controller: Manages user requests and calls the appropriate service.

Flow

User sends a request via the Controller.

The Service processes the request using the injected implementation.

The message is sent using the specified method (Email/SMS).
