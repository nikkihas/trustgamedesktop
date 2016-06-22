# To do list (37 hours total)

## Level08
- Stop audio when you leave trigger (, tried to fix it but it didn’t work out).

## General
- Mountain Moving script
- Play sound on function (Platform Rise / Lower, Jump / Press X for platfom level08
- Fix bug with audio sources playing through each other.
- Script: Go to "End" scene when TotalTime = 0
- TimeLimit per level
- Fade out to black when dying, Fade in on Respawm

## Level05:
- Reset timelimit if Position resets

## To do Nikki
- Adjust the lights in Level06. See: http://docs.unity3d.com/Manual/class-Light.html
- I think it is good to put Level02 back, the game feels weird without it.
- Reset game function can be found in the GlobalVariables script (, press Cross, Square and Start at the same time).
- Adjusted time till hitbox destroys itself, to prevent Charlie from hitting it twice.
- GameTimer currently loads scene 7, change this value when you add or remove levels.
- The game timer is reset and started in the NextLevelTimer script.
- Intro appears to be cut short, couldn’t find NextLevelTime script in the scene, it should be placed on GameManager.
