# GDIM33 Vertical Slice
## Milestone 1 Devlog
I’m using Visual Scripting to handle state transitions in my enemy’s State Machine. First, I created two GameObject variables player and enemy. I then retrieved the Transform components of these two GameObjects, read their position values, and used the Distance node to calculate the distance between them. I compared the calculated distance against a predefined variable, then passed the result into an If node. If the condition evaluates to true, the transition is triggered.

My State Machine controls three different enemy behaviors Wander, Follow, and Attack. The Wander state is set as the start state. When the distance between the player and the enemy is less than the value of the checkFollow variable, the state transitions to Follow. When the distance exceeds checkFollow, the enemy transitions back to Wander. When the distance is less than the value of the checkAttack variable, the enemy transitions to Attack. When the distance exceeds checkAttack, the enemy transitions back to Follow.

All three behaviors (Wander, Follow, and Attack) are implemented using C# methods. When entering each corresponding state, I connect the Update node to the respective method node. Additionally, when entering the Wander state, I connect the Start node to a SetArea method, which randomly sets the enemy’s wander range.

break down Chart


## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
