# unity-junior-data-persistence-prototype-6

## Screenshots

https://github.com/user-attachments/assets/c7f56fe6-70be-436b-826d-769294d4f6aa

## Table of Contents
1. [Description](#description)
2. [Installation](#installation)
3. [Run](#run)
4. [Credits](#credits)
5. [Contributing](#contributing)
6. [License](#license)

## Description

This prototype is part of the Junior Programmer Pathway from Unity Learn. Its purpose is to teach the fundamentals of gameplay mechanics through scripting in C#.
Unlike earlier prototypes, this one begins with a non-functional game. We were provided with a partially implemented codebase along with a PDF guide that briefly explains the existing code and outlines the tasks we need to complete to get the game working.

If you encounter difficulties, a step-by-step tutorial is also available to walk you through the process.

### Purpose

The objective of this prototype is to follow the mission given on the PDF:

- Scene management
  - Create transitions between two scenes.
  - Configure buttons so the user can control those transitions.
  - Configure a button to exit the application (or exit Play mode, in Unity Editor).
- Data persistence
  - Configure buttons in one scene to apply a chosen color to objects in a second scene.
  - Save the last color chosen by the user and preselect it the next time the application is launched.
- Inheritance and polymorphism
  - Create a new type of object in the simulation, with a variation on behavior derived from a base class.
- Abstraction
  - Refactor to reduce duplicate code and improve reusability.
- Encapsulation
  - Use getters and setters to protect data from misuse.
- Optimizing code
  - Profile example code to identify basic optimization issues.

## Controls

- In main menu, you can select a color to apply to units.
- Click on a working unit to select it.
- Then, click on a location in the world to move the unit there.
- If you click on a resource pile, the selected unit will automatically begin working (e.g., collecting resources).

### Technologies used

- **Unity** – Version 6000.0.47f1
- **C#** – Used for gameplay scripting
  
### Challenges and Future Features

One of the biggest challenges in this project was understanding what I was supposed to do and how the provided codebase actually worked. It wasn’t immediately clear, so it took some time to explore and figure things out.

We were then asked to implement features that we had never encountered before. In previous prototypes, these kinds of tasks were presented as optional “bonus features,” but here they were part of the main objectives which made it more challenging but also more rewarding.

I also had to learn how to use Unity’s Animator, which was new territory for me. My experience with animation comes mostly from JavaScript and CSS, where I’m fairly confident. Trying to achieve similar effects in Unity was a bit of a struggle at first—but a valuable one!

At the end of the project, I compared my solution to the official tutorial version and was pleasantly surprised to see that our approaches were different—but both worked! This helped me learn multiple ways to solve the same problem and discover new Unity features and scripting techniques.

## Installation

You can download pre-built releases for your supported operating system from the GitHub Releases page. Available builds include:
- macOS
- Windows
- Linux

## Run

To run the program, simply double-click the executable file for your operating system.

### MacOS

Unzip and open the .app file.

### Windows

Unzip and double-click the .exe file.

### Linux

```bash
chmod +x Prototype_6_Linux.x86_64
./Prototype_6_Linux.x86_64
```

### Web

Play on [browser](https://vpekdas.github.io/unity-junior-data-persistence-prototype-6)

## Credits

This project is based on the Unity **Junior Programmer Pathway** by Unity Learn.
Many thanks to the instructors for their excellent step-by-step video tutorials and guidance.

## Contributing

To report issues, please create an issue here:  [issue tracker](https://github.com/Vpekdas/unity-junior-data-persistence-prototype-6/issues).

If you'd like to contribute, please follow the steps outlined in [CONTRIBUTING.md](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
