@echo off
rem Пакетный файл для приложения SimpleCSharpApp.exe,
rem в котором захватывается возвращаемое им значение.
dotnet run
@if "%ERRORLEVEL%" == "0" goto success
:fail
rem Приложение потерпело неудачу,
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success
rem Приложение завершилось успешно,
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
rem Все готово,
echo All Done.