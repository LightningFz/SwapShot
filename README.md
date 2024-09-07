# **SwapShot**

A technical showcase of a 2D puzzle-platformer developed using the Unity game engine and C# language. The game implements a unique pet-swapping mechanic and demonstrates various game development skills, including game logic design, player input handling, object collision detection, and file I/O for tracking player progress.

## **Table of Contents**
- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Game Mechanics](#game-mechanics)
- [Architecture](#architecture)
- [Installation](#installation)


## **Overview**
This project is a 2D platformer focused on puzzle-solving through a custom-designed pet-swapping mechanic. The game was built using Unity, with all core game logic written in C#. It features multiple levels and includes a system that tracks and stores the player's best times for each level.

The game was developed as a technical project and published on [Itch.io](#) for feedback and improvement. It is currently in a non-commercial, unpolished state, with the emphasis placed on functionality over visual design.

## **Technologies Used**
- **Unity**: Used for game engine functionalities, physics simulation, and level design.
- **C#**: Core language used to script game mechanics, player interactions, pet movement logic, and collision detection.
- **MonoBehaviour Framework**: Utilized to handle Unity’s component lifecycle, including the game loop (Update, FixedUpdate), collision events, and input handling.
- **File I/O**: Implemented in C# to read and write the player’s best run times in a persistent text file.
- **Physics Engine**: Unity's built-in 2D physics engine to handle player and pet interactions with the environment.

## **Game Mechanics**
- **Pet Swapping Mechanic**: 
  - Players are followed by a pet that they can shoot towards green boxes in the level.
  - Upon touching a green box, the pet and player swap positions, allowing for puzzle-solving.
  - This mechanic is implemented using collision detection (OnTriggerEnter2D) and positional transformations.
- **Player Movement**:
  - Movement is handled via Unity’s `Rigidbody2D` component to enable realistic physics-based movement (acceleration, deceleration, and friction).
  - The input system (Unity Input Manager) captures keyboard input for movement (`WASD` or arrow keys).
- **Shooting the Pet**:
  - Shooting the pet is done by calculating the direction from the player to the mouse position, with a force applied to the pet's Rigidbody2D to simulate projectile motion.

## **Architecture**
The game's code follows a modular design to separate gameplay mechanics, level management, and file I/O:
- **PlayerController.cs**: Manages player input, movement, and interactions.
- **PetController.cs**: Handles the pet’s behavior, such as following the player and swapping mechanics.
- **LevelManager.cs**: Manages level transitions and tracks player completion times.
- **RunTracker.cs**: Stores best run times and writes them to a text file using C#'s `StreamWriter` and `StreamReader`.

## **Installation**
1. Download the game from the [Itch.io page](https://lightningfz.itch.io/swapshot).
2. Extract the zip file to a local directory.
3. Run the executable file to launch the game.
