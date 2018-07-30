:: Remove old file just in case
if exist javasrc.tmp~ del javasrc.tmp~

:: List .java files presents in src
dir ..\src\*.java /B/S > javasrc.tmp~

:: javac to create the .class files into bin
if exist ..\bin rmdir /S /Q ..\bin
mkdir ..\bin
@"%JAVA_HOME%\bin\javac.exe" -d ..\bin @javasrc.tmp~
del javasrc.tmp~

:: jar to create the .jar file
"%JAVA_HOME%\bin\jar.exe" -cvfm ParseSettings.jar manifest.txt ..\bin\*