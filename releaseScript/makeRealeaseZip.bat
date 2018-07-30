:: Remove old release just in case
if exist release rmdir /S /Q release


:: C# part
cd ../csharp/make
call makeDLL.bat
cd ../../releaseScript

:: Java part
cd ../java/make
call makeJar.bat
cd ../../releaseScript


:: DLL copy
xcopy ..\csharp\make\TLD_CustomChallengeDifficulties.dll .\release\customChallengeDifficulties\

:: jar copy
xcopy ..\java\make\ParseSettings.jar .\release\stringParser\

:: Settings files copy
xcopy ..\customChallengesSettings .\release\customChallengeDifficulties\customChallengesSettings\

:: Java program doc copy
xcopy ..\java\how_to_use.txt .\release\stringParser\

:: Readme copy
xcopy .\Readme.txt .\release\


:: Zip it all !
"C:\Program Files (x86)\7-Zip\7z.exe" a -tzip TLD_CustomChallengeDifficulties.zip -r .\release\*


:: Lastly, remove release if the zipping worked
if exist TLD_CustomChallengeDifficulties.zip rmdir /S /Q release