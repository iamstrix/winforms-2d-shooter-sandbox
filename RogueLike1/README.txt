Untitled RogueLike game

To do/add/fix
    > Oct 5
        > Learn about vector normalization

    > October 3
        > Moving background
        > Bullet shoot cooldown
        > Bullet speed limit
            > X, Y velocities are adjustable by button
            > Is false at runtime
            > Has options
                > Is not capped
                    > Sets capping method to false
                > Is capped
                    > Sets capping method to true
                    > Every button click, pass cap value -> Player; private variable -> Bullet class trajectory
        > Bullet trajectory greatly varies depending on player position
            > The nearer the player is to the top of the panel, the higher the velocities are for every direction
                > The trajectory formula has playerY as the divisor, might be the culprit

    > October 2
        > Enemy spawns outside panel
        > Enemy pathing toward player
        > Different shooting types

    > September 30
        > Bullet pierce
        > Bullet spread
        > Bullet auto-fire

Changelog
    October 3
        > Thought of more stuff to add
        > Add to plot
            > Everytime you destroy a wave of asteroids, you upgrade your device to increase its gravitational force range, attracting more, BIGGER, asteroids.
                > Level/wave 1, and so on

    October 2
        > Thought of stuff to add during recollection

    September 30
        > Added mouse-click targeting
            > I'm so happy I figured it out myself. I don't have to add velocities manually anymore
                > distanceY (Absolute) divided by higher values lessens the range and highers the sensitivity
                    to which bullet trajectory is assigned
        > Plan to change original d-pad for other functions
            > Bullet pierce
            > Bullet spread + - 
            > Enable auto-fire
            > Enable ring of bullets around player
        > Added multiple labels for display
            > Removed bullet counter for now, to work on again later
        > Fixed spawn range of objects
            > Was using this.Width, this.height which was the form, instead of the panel
        > Asteroid Destroyer game idea
            > In the far future, Humanity faces a cosmological threat; the Asteroid Barrage. Clusters of exploding galaxies send rocks flying
            across millions of light years, and the time for our planet has come. The world's best engineers came up with a device capable
            of pulling asteroid-like bodies toward its selective gravitational force. The world has entrusted this device to you and your ship,
            hoping that you can fend off the barrage and save humanity from proper extinction.
        > Planning to add List limit, and removal of entries beyond limit

        > Added player relocation button

    September 29
        > Changed colours
        > Added bullet counter
        > Enemies move
            > Dispose when out of panel1 bounds
        > Add enemy remove
            > Removed only half
                > Foreach loop was out of sync
            > Used a for-loop
                > Worked perfectly, felt so good
        > Bullet bounce damp
            > Doesn't seem to work fully
        
    September 28
        > Working on Spawn checker
        > Working on bounce mechanic

    September 27
        > Figured out how to move each bullet individually
            > Used four buttons to input x, y velocities manually
        > Bullet spread
        > Figured out better collision detection for bounces on walls
        > Bounce limit adjuster

        > Working on
            > Trying to add spawn checker for Enemy class
            > Trying to correct bounce mechanic when it comes to colliding with enemies
                > This is driving me crazy
            > Trajectory Calculation sample I thought of (Have not tried as of yet)
                > Sample origin = 67, 400
                > Sample target = 1129, 1000
                > Distance X, Y = 1062, 600
                > Bullet trajectory = Round 1062/600 to nearest whole number = 2, 1
                > Every tick, bullet moves 2 in X direction, 1 in Y direction

                > Could also use this to draw a trajectory line
                > Limit of 100 pixels in an outward direction
                > Use Draw pixel?

    September 23
        > Added Player, Enemy, Bullet class
        > Still figuring out how to make the bullets move

Consists of enemy, player, bullets
    > Basic projectile workings
    > Player movement

Pseudocode
    > Player
        > Takes form coordinates for spawning
        > Has a set size
        > Can move WASD
        > Shoots projectiles with key
    > Enemy
    > Bullets
        > Takes player / enemy coordinates for spawning
        > Set size of 10, 10 for now
        > Ability to track player mouse, or position of latest click
        Bullet Logic
            > Takes the coordinates of the recent mouse click
            > Algorithm that checks how many x, y changes it takes to reach the mouse click
            Sample code
                Origin X, Y = 100, 200
                Target X, Y = 600, 400
                Distance X, Y = 500, 200
                Speed = 10
                Time to reach X, Y = 50, 50

Code Dump
    > First Bullet Logic
        > Moves every bullet in the panel instead of individual bullets
            > I have to implement this logic in the bullet class itself

            foreach (Bullet bullet in panel1.Controls.OfType<Bullet>())
            {
                if (bullet.thisX > this.Width || bullet.thisX < 0)
                {
                    panel1.Controls.Remove(bullet);
                    bullet.Dispose();
                }

                else if (bullet.Location.X < lastMouseX)
                {
                    bullet.thisX += bullet.speed;
                }

                else if (bullet.Location.X > lastMouseX)
                {
                    bullet.thisX -= bullet.speed;
                }
                
                if (bullet.Location.Y < 0 || bullet.Location.Y > panel1.Height)
                {
                    panel1.Controls.Remove(bullet);
                    bullet.Dispose();
                }

                else if (bullet.Location.Y < lastMouseY)
                {
                    bullet.thisY += bullet.speed;
                }
                else if (bullet.Location.Y > lastMouseY)
                {
                    bullet.thisY -= bullet.speed;
                }
                    bullet.Location = new Point(bullet.thisX, bullet.thisY);
            }