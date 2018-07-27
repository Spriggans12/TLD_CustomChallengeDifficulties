:: Remove old release
rmdir /S /Q release

:: Create new release architecture
mkdir release
cd release
mkdir stringParser
mkdir mod

:: Goes back to releaseScript folder
cd ..


:: C# part
xcopy ..\customChallengesSettings .\release\mod\


:: Java part
cd ../java/make
call makeJar.bat
cd ../../releaseScript
xcopy ..\java\make\ParseSettings.jar .\release\stringParser\
xcopy ..\java\how_to_use.txt .\release\stringParser\

