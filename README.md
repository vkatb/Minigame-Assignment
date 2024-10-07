# Minigame-Assignment
Capsule Shooter

Description
Capsue Shooter is a simple shooter game where you control the purple cube character. Try to shoot the red targets to destroy them. Avoid hitting the yellow targets; they will fall over pathetically (sad!).

Controls
Move - WASD
Rotate Camera - Move mouse left/right
Shoot - Space Bar

How to Play
Use the controls to move and shoot the targets. Hit red targets before they disappear and avoid shooting yellow targets. There's no penalty or score system unfortunately, but that's the rules.

Dev Log:
Most of the features I based off the Minigame 2 assignment, such as typical player movement, projectile movement and target spawning. I looked up how to rotate the character and found out how to use GetAxis("Mouse X") which is how the player rotates. I just attached the camera to the character so it would follow it. The PlayerTrigger and TargetTrigger objects are used so that touching the player/targets will delete the objects, their meshes are not rendered since they're basically used as a second boxcollider without making the actual objects fall through the ground by making them triggers. Tags are used to separate different trigger types and cause different effects. The walls also use triggers to set the player to a location in bounds. I just looked up on the internet how to make the targets despawn after a set time.

All assets used are default assets from Unity.
