@echo off
chcp 65001 >nul
title Neverlands Mobile — Сборка APK

echo.
echo ╔══════════════════════════════════════════════════════════╗
echo ║         Neverlands Mobile — Сборка Android APK          ║
echo ╚══════════════════════════════════════════════════════════╝
echo.

:: Переходим в папку репозитория (папка где лежит этот bat файл)
cd /d "%~dp0"

echo [1/3] Очистка предыдущей сборки...
echo ─────────────────────────────────────────────────
dotnet clean Neverlands.Mobile/Neverlands.Mobile.csproj
if %ERRORLEVEL% neq 0 (
    echo.
    echo [ОШИБКА] dotnet clean завершился с ошибкой!
    goto :error
)
echo [OK] Очистка завершена.
echo.

echo [2/3] Восстановление пакетов...
echo ─────────────────────────────────────────────────
dotnet restore Neverlands.Mobile/Neverlands.Mobile.csproj
if %ERRORLEVEL% neq 0 (
    echo.
    echo [ОШИБКА] dotnet restore завершился с ошибкой!
    goto :error
)
echo [OK] Пакеты восстановлены.
echo.

echo [3/3] Сборка и публикация APK (займёт 2-4 минуты)...
echo ─────────────────────────────────────────────────
dotnet publish Neverlands.Mobile/Neverlands.Mobile.csproj -f net9.0-android -c Release
if %ERRORLEVEL% neq 0 (
    echo.
    echo [ОШИБКА] Сборка завершилась с ошибками!
    goto :error
)

echo.
echo ╔══════════════════════════════════════════════════════════╗
echo ║                  СБОРКА УСПЕШНА!                        ║
echo ╚══════════════════════════════════════════════════════════╝
echo.
echo APK находится здесь:
echo.
echo   Neverlands.Mobile\bin\Release\net9.0-android\publish\
echo   com.neverlands.mobile-Signed.apk
echo.

:: Показываем размер файла
if exist "Neverlands.Mobile\bin\Release\net9.0-android\publish\com.neverlands.mobile-Signed.apk" (
    for %%F in ("Neverlands.Mobile\bin\Release\net9.0-android\publish\com.neverlands.mobile-Signed.apk") do (
        set /a size=%%~zF / 1048576
        echo   Размер файла: %%~zF байт
    )
    echo.
    echo Открыть папку с APK? Нажми любую клавишу...
    pause >nul
    explorer "Neverlands.Mobile\bin\Release\net9.0-android\publish"
) else (
    echo [!] APK файл не найден — проверь лог выше.
)

goto :end

:error
echo.
echo ╔══════════════════════════════════════════════════════════╗
echo ║                СБОРКА ЗАВЕРШИЛАСЬ С ОШИБКОЙ             ║
echo ╚══════════════════════════════════════════════════════════╝
echo.
echo Прокрути лог выше чтобы найти строки с [error].
echo.

:end
echo.
echo Нажми любую клавишу для выхода...
pause >nul