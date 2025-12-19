# MRCane 272

**MRCane** is a Unity-based iOS application that helps visually impaired users build mental maps of unfamiliar rooms by simulating walking through a virtual space using real-time step tracking and spatial audio.

---

## Project Goal

Visually impaired individuals need a safe way to explore new environments before entering them physically.
MRCane allows users to **march in place** while the app translates steps into first-person movement in a virtual room, providing spatial audio cues without real-world collision risks.

**Target Users:**
Visually impaired or blind individuals working with Orientation & Mobility (O&M) specialists.

---

## Features

* Real-time step tracking using iPhone pedometer
* First-person movement based on detected steps
* Manual step adjustment (Add / Subtract buttons)
* Accessible UI with audio feedback
* Multiple rooms and scene switching

---

## Tech Stack

* Unity
* C#
* Swift
* Xcode
* iOS

---

## Design & Implementation Overview

* **iOS / Swift Layer**
  Retrieves pedometer step data using native iOS APIs and sends it to Unity via a custom Unity iOS plugin.

* **Unity / C# Gameplay Layer**
  Converts step data into first-person movement and handles room navigation, scene changes, and player logic.

* **UI & Accessibility Layer**
  Implements accessible menus, audio feedback for UI elements, and manager scripts for button interactions (volume, room switching, step control). A virtual camera renders the 3D environment as a 2D texture for canvas display.
