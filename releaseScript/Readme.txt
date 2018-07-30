*************

Welcome to the TLD's CustomChallengeDifficulties mod !

*************
* Motivation
*************

Ever got annoyed how easy the Challenges where ? This mod is for you !
This mod allows you to alter the challenges pre-set difficulties to make a challenge of your own.
Interloper Nomad ? This is now possible !

This mod relies on several settings files, whose values you can edit. These values will be the one used in the challenges.
If you want to change your settings, you simply have to reload the game.


*************
* Structure
*************

This release contains two folders.

-> The first folder, "customChallengeDifficulties", is the so-to-speech mod.
	It contains a folder with settings files in it, and a .dll file. See "How-to-install" for more info.

-> The second folder, "stringParser" is a utility that allows you to create a difficulty settings file from TLD's custom difficulty hashed string.
	This eases the modification of the difficulty settings file so that it is less error-prone.
	It requires Java 8 or more to work.


*************
* How-to-install
*************

1/
	First, you need to patch your TLD game.
	This is done very easily using what is called "The Mod Loader".
	If you haven't patched your game. Go do it now !
	https://github.com/zeobviouslyfakeacc/ModLoaderInstaller

2/
	Your game is patched ? Good !
	Now, to get it working, you need to go to your "mods" folder (which is located at "<Steam>/SteamApps/common/TheLongDark/mods").
	In this, extract the file "TLD_CustomChallengeDifficulties.dll" and the folder "customChallengesSettings".
	
	Your "mods" folder should then look like this :
	
	mods/
		customChallengesSettings/
			challenge_hunted_settings.txt
			challenge_hunted2_settings.txt
			challenge_nomad_settings.txt
			challenge_rescue_settings.txt
			challenge_whiteout_settings.txt
			difficulty_settings.txt
		TLD_CustomChallengeDifficulties.dll
		
	Notes :
		You do not need the "stringParser" folder in your "mods" directory.
		Having it should be harmless though, but it is not required to run the mod.

3/
	At this point, the mod is installed.
	Launching the game and starting a challenge will now use the custom settings.
	However, you might want to tweak the values of the settings files (see next point).


*************
* How to tweak the settings
*************

In the "customChallengesSettings" folder, you have several files.

1/
	The "challenge_<name>_settings.txt" files are related to one challenge in particular.
	They contain values specific to each challenge, like eg. the number of days to spend in each location in Nomad.
	You can edit these values.

2/
	The "difficulty_settings.txt" file is common to all the challenges.
	It sets the difficulty for all the challenges.
	Its configuration is extracted from the Custom difficulty screen of the game, so if you have a doubt what a parameter does, you can check its description in game.
	While it can be edited manually, there is a convenience alternative (see 2bis/ below).

2bis/
	If, like me, you are lazy, you probably won't want to manually go trough the difficulty_settings.txt file.
	So, you can use the stringParser utility (provided with the mod) to ease the modifications.
	I won't explain here how to use it, please go to the stringParser folder and read the "how_to_use.txt" file.
	

*************
* How it works
*************

TLD is a Unity / C# game.
Using some C# wizardry, namely known as the Harmony library, we are able to overwrite some values in the game while it's running.
I use that here to overwrite the ExperienceMode values of the challenges, as well as other things, and do some Magic.


*************
* Compatibility
*************

The mod was designed with version 1.33 of TLD (Vigilant Flame).
Future updates may or may not break the mod.


*************
* Misc.
*************

I don't think that "starting a challenge with some settings, saving, changing the settings values and loading the save" is a viable scenario.
You should not load a challenge which was created with different settings.

Survival mode and story mode are unaffected.

If you want to go back to default challenges, you can rename your "TLD_CustomChallengeDifficulties.dll" file into "TLD_CustomChallengeDifficulties.dll.bak". (the important part here being that the .dll extension is no more), or move "TLD_CustomChallengeDifficulties.dll" out of the "mods" folder (I personally use a "old_mods" folder).


Problem ? Question ? Want to improve this ?
View more on Github !
https://github.com/Spriggans12/TLD_CustomChallengeDifficulties