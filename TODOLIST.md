# To do list (36 hours total)

## Intro
- Next Level after 49 seconds

## Level 10
- Create an infinite loop for when players choose one of the paths in front of them. When to go back on the platform behind them it brings them to the 'secret' space above Charlie.

- Duidelijke versie: Charlie wordt voorgesteld aan 3 keuzes, links, midden of rechts. Wanneer Charlie op 1 van deze platformen staat blijft het platform waarop Charlie staat stil staan. De andere platformen zweven omhoog (tot uit het zicht). Hierna worden alle platformen opnieuw gespawmed boven Charlie en zweven deze naar beneden. De door Charlie gekozen platform (degene waarop Charlie staat) wordt vervolgens "Give Up 1" gameObject
	- Er staan screenshots ter verduidelijking in de "trustgamedesktop" map (waarin ook de ToDoList staat)
	- Indien een gebrek aan tijd zouden we boven alle 3 de platformen een resetLevel trigge kunnen maken. Dat zou het level alleen wel een beetje verpesten omdat je snel door je keuzes en ideeen heen bent en als snel voor "I Give Up" gaan.
	
## Level 09 (is not possible to build in the remaining time)
- On button down 85% "right" door opens a little, 15% "wrong" door resets and closes
- Button down doesn't change color, it only pushes the little hexagon within the big hexagon, when the player steps away the hexagon goes back up
- Instead of opening the doors with rotation, the doors now open with moving the x position
- Remove old platform (I kept it there in case you need to see how I made the previous version.

## General
- Mountain Moving script
- Play sound on function (Platform Rise / Lower, Jump / Press X for platfom level08
- Fix bug with audio sources playing through each other.
- Script: Go to "End" scene when TotalTime = 0
- TotalTime: Ticking down from 12 minutes, every time Charlie dies -10 seconds from TotalTime
- Fade out to black when dying, Fade in on Respawm

## Level 08
- Fade out takes way longer than normal

## Level05:
- Reset timelimit if Position resets

## Control Scheme
1 = Square
2 = Cross
3 = Circle
4 = Triangle

## To do Nikki
v Copy GameManager from Level01 and copy to all scenes.
v Delete Music object from all scenes.
v Replace audio source in all GameManager objects to the file for that scene and double check if the volume is set to 0 and loop to active.
	- Outro does not loop, is that ok?
	- Intro has volume = 1 because it doesn't play automatically, probably because of "StartGame.cs"
v Do not scale objects, give them a actual size. This prevents parenting issues. This still has to be corrected with the moving platform in Level05.
- Adjust the lights in Level06. See: http://docs.unity3d.com/Manual/class-Light.html