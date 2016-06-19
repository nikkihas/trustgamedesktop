# To do list


##############################
# IN VOLGORDE VAN PRIORITEIT #
##############################


## Level 10
- Create an infinite loop for when players choose one of the paths in front of them. When to go back on the platform behind them it brings them to the 'secret' space above Charlie.

- Duidelijke versie: Charlie wordt voorgesteld aan 3 keuzes, links, midden of rechts. Wanneer Charlie op 1 van deze platformen staat blijft het platform waarop Charlie staat stil staan. De andere platformen zweven omhoog (tot uit het zicht). Hierna worden alle platformen opnieuw gespawmed boven Charlie en zweven deze naar beneden. De door Charlie gekozen platform (degene waarop Charlie staat) wordt vervolgens "Give Up 1" gameObject
	- Er staan screenshots ter verduidelijking in de "trustgamedesktop" map (waarin ook de ToDoList staat)
	- Indien een gebrek aan tijd zouden we boven alle 3 de platformen een resetLevel trigge kunnen maken. Dat zou het level alleen wel een beetje verpesten omdat je snel door je keuzes en ideeen heen bent en als snel voor "I Give Up" gaan.
	
## End
- Restart Game after 1m (Is het dan het handigst om de scene naar "Intro" te veranderen? Of misschien helemaal opnieuw builden?)

## Level 09
- On button down 85% "right" door opens a little, 15% "wrong" door resets and closes
- Button down doesn't change color, it only pushes the little hexagon within the big hexagon, when the player steps away the hexagon goes back up
- Instead of opening the doors with rotation, the doors now open with moving the x position
- Remove old platform (I kept it there in case you need to see how I made the previous version.

## Level 07:
- Je kunt weer double-jumpen
	- Indien het grounded script niet lukt zouden we misschien een triggerbox kunnen maken boven de platformen, hierin is de input "2" enabled, hierbuiten disabled.

## Level 08
- Change exit platform to make Player 2 press "X" at least 20 times, after that you win level when Player 2 quits pressing
	- Duidelijke versie: On Trigger Platform: If input "2" is pressed 20 times and Charlie leaves Trigger, next level. 
- Voice: Level8b is the opening text for trigger. I want Level8c to loop after Level8b has ended
	- Duidelijke versie: On Trigger Platform Enter: Play Level8b (no loop) after 6 seconds play Level8c (loop)

## Level04:
- If Charlie collides with "Goal" freeze position, fade to black, start
- If Charlie collides with "Goal" play sound that is on gameObject, not all sounds

## Level05:
- Bug: Charlie veranderd van grootte op de RotatingPlatform
- Speel niet "Instruction x" wanneer level wordt gereset door de triggers (dus waarbij het lijkt waarop P2 het level reset)
	- Duidelijke versie: Wanneer het level wordt gereset door de ResetPoint01 en Resetpoint02 (de triggers welke suggereert dat P2 het level reset), mogen de soundtracks "Instuctions 3x", "Instruction 4x" etc. niet worden afgespeeld, je valt namelijk niet naar beneden.

## General
- Play sound on function (Platform Rise / Lower, Jump / Press X for platfom level08
- Fix bug with audio sources playing through each other.
- Fade out music similar to screen fader, lower the volume over the same length as the screen fader for a smooth transition.
- Script: Go to "End" scene when TotalTime = 0
- TotalTime: Ticking down from 12 minutes, every time Charlie dies -10 seconds from TotalTime

## Level05:
- Reset timelimit if Position resets

## Level 06
- Set IndicatorLights to layers so the players see different light
- Bug: Als ik op de final platform loop draait de brug 180 graden en tript die hem (zou te maken kunnen hebben met de trigger die doorloopt waar de brug eindigt?


##################
# IN GESPREK MET #
##################


## Control Scheme
1 = Square
2 = Cross
3 = Circle
4 = Triangle

## Fixed on 18-06-2016 (26 hours total)
- Added screen fading test.
	- LOOKS AWESOME!!!!!!! (remove when read)

## For Nikki
v Rotate the Charlie to 0 in every level.
v Describe the functions in a better way, its totally unclear (level 05, 08 and 10).
- Keep everything nice and tidy! Errors will be the result of a messy workspace.

## Intro (remove when read)
- Added "StartSound" to start the music in the Intro
- Added "NextLevelIntro" to start Level01 after 50s

## General (remove when read)
- Changed "NextLevel" from "GameObject.Find ("_GM")" to "GameObject.Find ("GameManager")".
- Added "GameManager" and "ScreenFader" to each scene.
