:: Remove old file just in case
if exist cssrc.tmp~ del cssrc.tmp~

:: List .cs files presents in src
dir ..\src\*.cs /B/S > cssrc.tmp~

:: Creates DLL
csc /t:library /out:TLD_CustomChallengeDifficulties.dll /r:../../dllsFromTLD/Assembly-CSharp.dll,../../dllsFromTLD/Harmony.dll,../../dllsFromTLD/UnityEngine.CoreModule.dll @cssrc.tmp~

del cssrc.tmp~