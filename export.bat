cd .\src\Tgm.Roborally.Api\
del bin /F /S /Q
del obj /F /S /Q
dotnet build
dotnet pack
pause
wait