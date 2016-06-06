# To do list

—

## General

- Charlie kan amper omhoog lopen, slope angle, step angle

- Make character move faster
	- Don't make the character faster, it is adjusted to the speed of the PS3 Controller which is different from they keyboard.
- Decrease gravity
	- Project Settings -> Gravity

- Play sound after x times resetlevel. Nu zijn er twee manieren, 1. Level Restart (geluid restart hier ook wat ik niet wil), 2. Teleport naar het begin (Hierbij reset de tijd per level niet). Wat ik zou willen is het level resetten incl. de tijd per level zonder dat de geluiden opnieuw beginnen maar doorgaan.
	- Play sound after x times death + time (level07
- Mountains Breathing. Hexagons op de achtergrond bewegen onafhankelijk van elkaar naar boven en beneden, als een levend organisme
- Fade out when dying
- Play sound on function (Platform Rise / Lower, Jump / Press X for platfom level08
- Play only this sound and mute the rest (level02, "was that really so difficult" after completing the level, at that point you don't want to hear instructions anymore)

- Charlie plakt aan de muur wanneer je naar voren ingedrukt houdt


## Level 00 (Intro)
- Start Level01 after x seconds (done dealio!)
-
-

## Level 02
- Clean up hierarchy (done)
- Remove old scripts (done)
- Modify scripts to make move platforms up and down (done)
- Optimise scripts (done)

## Level 04
- Play sound that is not cut-off because of going to the next level

## Level 05
- Rotating Object make child
- Moving object make child
- "RestartLevelFake": Speel geluid af, restart and destroy gameObject zodat je er uiteindelijk langs kunt.

## Level 06
- Clean up hierarchy (done)
- Remove old scripts (done)
- Add time for the player to react to the red light (done)
- Add a child indicator light which is red when the parent is red (done)
- Make IndicatorLight01 only visible to player 1 and Indicatorlight02 only visible to player 2
- Change script to Rotate Z axis 90 degrees instead of remove collider

## Level 07
- Fix double jump
-
-

## Level 08
- Change exit platform to make Player 2 press "X" at least 20 times, after that you win level when Player 2 quits pressing
-
-

## Level 09
- On button down 85% "right" door opens a little, 15% "wrong" door resets and closes
- Button down doesn't change color, it only pushes the little hexagon within the big hexagon, when the player steps away the hexagon goes back up
- Instead of opening the doors with rotation, the doors now open with moving the x position
- Remove old platform (I kept it there in case you need to see how I made the previous version.

## Level 10
- Create an infinite loop for when players choose one of the paths in front of them. When to go back on the platform behind them it brings them to the 'secret' space above Charlie (name of character).
- Cannot slow down current RigidbodyFPSController.speed = 1f; see "speedDown1". "speedDown2" worked with previous controller. 


## Discuss
- Level02, use (currentPosition.y.currentPosition) instead of (0, y, 0)
- Level02, put Moving Platform in empty GameObject that contains the script to not move the Platform but the empty GameObject