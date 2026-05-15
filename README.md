
# GDIM33 Vertical Slice
## Milestone 1 Devlog
I’m using Visual Scripting to handle state transitions in my enemy’s State Machine. First, I created two GameObject variables player and enemy. I then retrieved the Transform components of these two GameObjects, read their position values, and used the Distance node to calculate the distance between them. I compared the calculated distance against a predefined variable, then passed the result into an If node. If the condition evaluates to true, the transition is triggered.

My State Machine controls three different enemy behaviors Wander, Follow, and Attack. The Wander state is set as the start state. When the distance between the player and the enemy is less than the value of the checkFollow variable, the state transitions to Follow. When the distance exceeds checkFollow, the enemy transitions back to Wander. When the distance is less than the value of the checkAttack variable, the enemy transitions to Attack. When the distance exceeds checkAttack, the enemy transitions back to Follow.

All three behaviors (Wander, Follow, and Attack) are implemented using C# methods. When entering each corresponding state, I connect the Update node to the respective method node. Additionally, when entering the Wander state, I connect the Start node to a SetArea method, which randomly sets the enemy’s wander range.

break down Chart
<img width="1527" height="1080" alt="devlog1" src="https://github.com/user-attachments/assets/6a2e55c2-d6ff-4f49-98e3-c85cbbf51b93" />


## Milestone 2 Devlog
### Question 1

I aim to create an upgradable shooting weapon for Milestone 2. As the weapon level increases, it will be able to fire multiple bullet trajectories.

1. Create the shooting effect

    Create bullets with a collider component and make them move forward continuously.

    Use Instantiate to spawn bullets at designated shoot points.

2. Develop an upgradable weapon with multiple shoot points

    Define a List to store all shoot point references.

    Create a level-up input key and a variable to store the current weapon level.

    Use a for loop combined with the level value to determine how many shoot points should be activated.

    Use a foreach loop to fire bullets from every shoot point simultaneously.

### Question 2

I believe breaking down the development into these task steps has been very helpful. Firstly, it reduces the chance of making mistakes. In most cases, I used to get errors halfway through coding, which would mess up my entire program logic. This task list greatly improves this problem. However, new ideas may come to me while I am coding, which can disrupt my original plan.

### Question 3

In Visual Scripting, I call C# methods to implement the enemy state machine. I set up distance detection between the player and the enemy within Visual Scripting. I also wrote custom C# methods to define enemy behaviours in different states, such as patrolling within a range, following the player, and attacking the player. I use Visual Scripting to detect the distance between the player and the enemy. When the distance reaches a specific threshold, the enemy’s state will switch. The enemy’s behaviours in each state are implemented by invoking corresponding C# methods.

<img width="554" height="381" alt="devlog2 1" src="https://github.com/user-attachments/assets/9bee43af-1f6c-407c-9e9f-6c7d0d9c39a3" />

<img width="554" height="231" alt="devlog2 2" src="https://github.com/user-attachments/assets/617752ea-93d0-4057-a079-7ef60b0b0d2d" />


### Question 4

I also used the Animation and Animator Unity system. First, I created animation clips for the enemy, then used the Animator controller to switch between different animation states. Meanwhile, I implemented an Animation Event script logic: the player will only receive damage when the enemy’s attack animation reaches a specific frame, and the enemy cannot switch back to the walk state until its attack animation fully finishes playing.

## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
