Discontinued 2D shooter with sandbox tools to apply OOP concepts.

C#, WinForms, Visual Studio

Throughout development, I realized that WinForms only uses integers for component coordinates, leading to floor division when calculating bullet trajectory, which ultimately ruined the whole thing. Programming the bullet trajectory calculation by myself was the aspect I had the most fun with during this project. The caveat for the trajectory calculation, though is that bullet velocity scales depending on how far the target is from the player, as I could not perform vector normalization given the limitation of WinForms' strict integer data type usage. 

Player features: 
- Shoot bullets, click anywhere

Enemy features:
Three enemy types:  
- Normal
- Boss
- Superboss (has my face on it)

Sandbox tools:
- Player x, y relocation
- Adjust bullet speed - random x, y changes to initial velocity
- Adjust bullet spread variance - scale of x, y variance for each builet
- Adjust bullet shoot count - how many bullets are shot per click
- Spawn enemy button
- Remove all bullets on screen
- Remove all enemies on screen
