# I-am-Human-Too
CS 426 Video Game Group Project

## There are 3 type of Human AI:  
* Regular Human: Blue signt sector, average sight range, average chasing speed, average turnning speed
* Survivalist Human: Green signt sector, largest sight range, slowest chasing speed, slowest turnning speed
* Strong Human: Red signt sector, shortest sight range, fastest chasing speed, fastest turnning speed

## Detail Implementation:
* FSM for AI to do the following actions: Patrolling, Chasing, Attacking.
* AI navigation: By using NavMesh Surface script, set buildings and obstacle as obstacle layer. The script will mesh the obstacle layer objects as none walkable area, so the AI will walk around it instead of walk through it.
* Nav Mesh Agent script: this script is mainly control the AI speed and acceleration, by associating NavMesh Surface script that identify walkable region for AI.
* AI field of sight: FieldOfView script detect and filter the objects in certain range and angle. Users can set View Radius and View Angle for different type of AI
* Added Background Music that will not stop playing due to added code to prevent it from stopping even if the scenes change to set the tone of the city
* Added sound effect to Zombie, so that user can hear the character.
* Added buildings and piles of rubble from the asset store to set the scene to be more Post Apocalyptic

## UI Design:
* Added start menu, Player can choose START to start the game, OPTIONS to set up the game, and QUIT to quit the game. 
* Created a health bar above the player, it visualize the attacking from AI.

## Reference  
Third Person Movement and Camera: https://www.youtube.com/watch?v=4HpC--2iowE&t=1026s  
AI Navigation: https://docs.unity3d.com/Manual/class-NavMeshSurface.html  
Field of Sight: https://www.youtube.com/watch?v=73Dc5JTCmKI
