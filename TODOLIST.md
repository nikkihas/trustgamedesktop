# To do list

## General
- Play sound on function (Platform Rise / Lower, Jump / Press X for platfom level08
- Fix bug with audio sources playing through each other.

## Level05:
- Reset timelimit wanneer positie reset
- Speel niet "Instruction x" wanneer level wordt gereset door de triggers (dus waarbij het lijkt waarop P2 het level reset)

## Level 08
- Change exit platform to make Player 2 press "X" at least 20 times, after that you win level when Player 2 quits pressing
- Voice: Level8b is the opening text for trigger. I want Level8c to loop after Level8b has ended

## Level 09
- On button down 85% "right" door opens a little, 15% "wrong" door resets and closes
- Button down doesn't change color, it only pushes the little hexagon within the big hexagon, when the player steps away the hexagon goes back up
- Instead of opening the doors with rotation, the doors now open with moving the x position
- Remove old platform (I kept it there in case you need to see how I made the previous version.

## Level 10
- Create an infinite loop for when players choose one of the paths in front of them. When to go back on the platform behind them it brings them to the 'secret' space above Charlie.

## Control Scheme
- 1 = Square
- 2 = Cross
- 3 = Circle
- 4 = Triangle

## Fixed on 18-06-2016 (26 hours total)
- Modified PlaySoundCollision script (merge with PlaySoundRespawn script).
- Added PlaySoundCollisionTime script (merge with PlaySoundRespawnTime script).
- Modified NextLevel and NextLevel time script.
- Squashed some bugs.
- Added screen fading test.

## For Nikki
- Rotate the Charlie to 0 in every level.
- Describe the functions in a better way, its totally unclear (level 05, 08 and 10).
- Keep everything nice and tidy! Errors will be the result of a messy workspace.