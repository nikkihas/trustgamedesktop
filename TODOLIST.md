# To do list

## General
- Teleport naar het begin (Hierbij reset de tijd per level niet). Wat ik zou willen is het level resetten incl. de tijd per level zonder dat de geluiden opnieuw beginnen maar doorgaan. (playSoundAfterDeath.cs)
- Play sound on function (Platform Rise / Lower, Jump / Press X for platfom level08
- Play sound after x times death + time (level07)
- Fade out when dying

## Level 04
- Play sound on Trigger then after 10s play sound 4D and after 7 seconds go to next level "NextLevelAfterChoice". This script is applied on all negative "goal" objects in "Why"

## Level 05
- "RestartLevelFake": Speel geluid af, restart and destroy gameObject zodat je er uiteindelijk langs kunt.

## Level 06
- Change script to Rotate Z axis 90 degrees instead of remove collider

## Level 08
- Change exit platform to make Player 2 press "X" at least 20 times, after that you win level when Player 2 quits pressing
- Voice: Level8b is the opening text for trigger. I want Level8c to loop after Level8b has ended

## Level 09
- On button down 85% "right" door opens a little, 15% "wrong" door resets and closes
- Button down doesn't change color, it only pushes the little hexagon within the big hexagon, when the player steps away the hexagon goes back up
- Instead of opening the doors with rotation, the doors now open with moving the x position
- Remove old platform (I kept it there in case you need to see how I made the previous version.

## Level 10
- Create an infinite loop for when players choose one of the paths in front of them. When to go back on the platform behind them it brings them to the 'secret' space above Charlie (name of character).

## Fixed on 13-06-2016 (15 hours total)
- Created new character controller based on old character controller.
- Added scripts to play audio after an amount of time or after a collision. Watch out that these don’t not overlap.
- Modified MoveObject script to allow it to be used for the background objects.
- Modified Rise and LowerPlatform script to use current position.
- Fixed error and modified with SpeedDown script.

## For Nikki
- Replace the character controller (yes, again).
- Do not play the voice-over on awake but use a delay of a couple of seconds.
- Clean-up the controls.