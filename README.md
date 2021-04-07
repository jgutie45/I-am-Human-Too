# I-am-Human-Too
CS 426 Video Game Group Project

## There are 3 type of Human AI:  
* Regular Human: average sight range, average chasing speed, average turnning speed
* Survivalist Human: largest sight range, slowest chasing speed, slowest turnning speed
* Strong Human: shortest sight range, fastest chasing speed, fastest turnning speed

## Detail Implementation:
* FSM for AI to do the following actions: Patrolling, Chasing, Attacking.
* AI navigation: By using NavMesh Surface script, set buildings and obstacle as obstacle layer. The script will mesh the obstacle layer objects as none walkable area, so the AI will walk around it instead of walk through it.
* Nav Mesh Agent script: this script is mainly control the AI speed and acceleration, by associating NavMesh Surface script that identify walkable region for AI.
* AI field of sight: FieldOfView script detect and filter the objects in certain range and angle. Users can set View Radius and View Angle for different type of AI

## Reference  
Third Person Movement and Camera: https://www.youtube.com/watch?v=4HpC--2iowE&t=1026s  
AI Navigation: https://www.youtube.com/watch?v=UjkSFoLxesw  
Field of Sight: https://www.youtube.com/watch?v=73Dc5JTCmKI