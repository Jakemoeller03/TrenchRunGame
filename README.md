# Trench Run Game 🚀

A Unity-based spaceship game where you pilot a spacecraft through a narrow trench while avoiding obstacles.

## Game Description

Navigate your spaceship through an endless trench in space, dodging obstacles that spawn in your path. The goal is to survive as long as possible without crashing!

## How to Play

- **Movement**: Use `A` and `D` keys to move your spaceship left and right
- **Objective**: Avoid hitting obstacles to keep flying
- **Game Over**: Collision with any obstacle resets the game

## Features

✅ **Custom Spaceship Model**: Created in Blender for authentic space combat feel  
✅ **Trench Environment**: Narrow corridor gameplay with boundary walls  
✅ **Responsive Controls**: Smooth left/right movement with wall collision detection  
✅ **Dual Obstacle Types**: Two different obstacle variants spawn randomly  
✅ **Collision System**: Automatic scene reload on impact  
✅ **Infinite Gameplay**: Continuous forward movement with spawning obstacles  

## Technical Implementation

- **Player Movement**: A/D key input with boundary checking
- **Obstacle Spawning**: Periodic generation of two obstacle types at random positions
- **Collision Detection**: Trigger-based collision system
- **Scene Management**: Automatic scene reload on game over
- **Camera System**: Fixed camera following spaceship movement

## Controls

| Key | Action |
|-----|--------|
| A | Move Left |
| D | Move Right |

## Development Notes

This project was built following the trench run concept - a classic science fiction motif where spaceships navigate narrow corridors while avoiding hazards. The implementation focuses on core gameplay mechanics rather than visual polish.

## Project Structure

The game uses Unity's built-in physics system for collision detection and scene management for game state handling. The spaceship remains relatively stationary while obstacles move toward the player, creating the illusion of forward movement through the trench.

---
*Developed in Unity as part of a game development course project.*
