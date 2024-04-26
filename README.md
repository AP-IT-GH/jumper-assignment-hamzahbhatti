# How to train an ML Agent to jump over oncoming obstacles

*Youssef Kasmi*

*Hamzah Bhatti*

## Introduction

The goal of this project is to train an ML Agent to successfully jump over oncoming obstacles using Unity and MLAgents. This guide provides a step-by-step walkthrough to achieve this outcome.

## Requirements

Before starting, ensure you have the following:

- Unity Hub (version 3.7.0)
- Unity Editor (version 2022.3.19f)
- MLAgents package (Python)
- Anaconda environment with MLAgent setup

## Creating a Project

1. **Open Unity Hub**:
   - Launch Unity Hub.
   - Click on "New project."

2. **Project setup**:
   - Choose a project name and location.
   - Select Unity Editor version 2022.3.19f.

2. **Import MLAgents**:
   - In Unity, go to `Window > Package Manager`.
   - Select `Packages: Unity Registry` and find `ML Agents`. Click `Install` to add it to your project.

## Creating a Single-Player Game

1. **Create following objects**:
   - Ensure that every object has the right tags and naming.
   - You can use the pictures below to fill in the parameters.
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/0689f624-79a7-4d1e-89b6-48e8b05ee213)
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/ddbe49df-2a44-4312-8c62-b63a7fc0971b)
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/efe7dcd6-867d-422e-934f-f5f827d0f08f)
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/a9110fb6-66e8-49d0-837f-c9bf7c524dfc)
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/229f1056-bda7-4866-8a80-7a827cc5c407)
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/93433ae1-4118-4182-8868-0babdaaa7098)
![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/d0bad0bd-ea48-447c-a187-53d4b976f555)


2. **Create prefab**:
   - Convert the obstacle object into a prefab.

3. **Set up MLPlayer**:
   - Attach a `Rigidbody` component to the MLPLayer object.
   - Create a new script named `MLPlayer` and attach it to the player.
   - Use the code from file (link to MLPlayer.cs file).
   - Change the Behavior Name to `MLPlayer`.

4. **Obstacle behavior**:
   - Create an obstacle script for obstacle objects to define their movement and behavior.
   - Use the code from file (link to Obstacle.cs file).

5. **Spawner script**:
   - Create a Spawner script and attach it to the road object.
   - Use the code from file (link to Spawner.cs file). [a link](https://github.com/AP-IT-GH/jumper-assignment-hamzahbhatti/blob/main/Assets/Obstacle.cs)

6. **Setup spawning points and prefab**:
   - Define spawn points (`SpawnPt` and `WallEnd`) within the road object.
   - Drag the obstacle prefab into the prefab field in the spawner script.
   - Link spawnpt to the spawn point in the spawner script.
     ![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/7bba38e4-e9e8-4ffa-b703-feff3b00f91a)

7. **Add WallReward object to the obstacle prefab**:
    ![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/5f040ae9-5f25-415e-95bc-c5b583d45393)

8. **MLPlayer Configuration**:
    - Add a `Decision Requester` component to the MLPlayer object.
    - Adjust the `Decision Period` to control decision-making frequency.
    ![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/a59fbb28-7db0-44a3-accb-2c6998a3546b)

10. **Sensor setup**:
    - Configure a `Ray Perception Sensor 3D` on the MLPlayer.
    - Adjust settings (e.g., ray angles, distance) to enable obstacle detection.
    - Make sure to change the `Z Rotation` to 90.
    ![image](https://github.com/AP-IT-GH/jumper-assignment-yfish1/assets/73119869/1fbae6a2-c936-461c-ac92-d8117f43c6e1)


## Let's train the Agent

1. **Open your project in the mlagents environment terminal**:
   - Once open, use following comman
  ```bash
   mlagents-learn
```
2. **Once ready, the terminal will notify you when you can start your project in Unity**

## Conclusion

[TO BE DONE]
