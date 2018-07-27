:: Remove old release just in case
rmdir /S /Q release

:: C# part (dll must have been compiled from VS !)
:: Settings files
xcopy ..\customChallengesSettings .\release\customChallengeDifficulties\customChallengesSettings\
:: dll
xcopy ..\bin\Debug\TLD_CustomChallengeDifficulties.dll .\release\customChallengeDifficulties\


:: Java part
cd ../java/make
call makeJar.bat
cd ../../releaseScript
:: jar
xcopy ..\java\make\ParseSettings.jar .\release\stringParser\
:: doc
xcopy ..\java\how_to_use.txt .\release\stringParser\

:: Readme
xcopy .\Readme.txt .\release\

:: Zip it all !
"C:\Program Files (x86)\7-Zip\7z.exe" a -tzip TLD_CustomChallengeDifficulties.zip -r .\release\*

:: Lastly, remove release
:: rmdir /S /Q release