# Discontinued 2D shooter with sandbox tools to apply OOP concepts.

C#, WinForms, Visual Studio

Throughout development, I realized that WinForms only uses integers for component coordinates, leading to floor division when calculating bullet trajectory, which ultimately ruined the whole thing. Programming the bullet trajectory calculation by myself was the aspect I had the most fun with during this project. The caveat for the trajectory calculation, though is that bullet velocity scales depending on how far the target is from the player, as I could not perform vector normalization given the limitation of WinForms' strict integer data type usage. 

<img width="1872" height="950" alt="Screenshot 2025-12-18 033639" src="https://github.com/user-attachments/assets/cf13696f-4fc4-405b-b87d-3886a274d4aa" />

<img width="1868" height="951" alt="Screenshot 2025-12-18 033900" src="https://github.com/user-attachments/assets/c7ecd3b6-a17a-49c0-b369-f288d49fcbff" />

Player features: 
- Shoot bullets, click anywhere

Enemy features:
- Three enemy types
- Normal
- Boss
- Superboss

Sandbox tools:
- Player x, y relocation
- Adjust bullet speed - random x, y changes to initial velocity
- Adjust bullet spread variance - scale of x, y variance for each builet
- Adjust bullet shoot count - how many bullets are shot per click
- Spawn enemy button
- Remove all bullets on screen
- Remove all enemies on screen

Statistics display (upper left and right-most side):
- Mouse coordinates
- Player coordinates
- Last-clicked coordinates
- Object count
- Velocity (old testing statistic, can't bother to fix/remove)
- Bullet bounce limit
- Enemy count
- Bullet count
- Player to current mouse distance for trajectory calculation
- Calculated trajectory (displays different x, y quotients as the formula for this label uses a different divisor value than the actual bullet trajectories displayed at the right-most portion of the program
- Bullet trajectory history at the right-most side - shows actual bullet trajectory values

Feature I did not bother fixing:

<img width="237" height="326" alt="image" src="https://github.com/user-attachments/assets/75074104-5e5b-4d83-9e15-39452e966a89" />

- Old manual bullet trajectory adjuster, before I programmed my own click-to-shoot trajectory calculation
