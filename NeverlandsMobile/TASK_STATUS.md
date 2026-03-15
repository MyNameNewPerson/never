## ⚠️ CURRENT STATE — READ THIS FIRST

The previous implementation by Jules does NOT work. The app crashes on launch.

Root cause: App.xaml.cs calls Shell.GoToAsync() inside an async void method
that runs immediately after the constructor, before Shell has finished
initializing its layout. This causes a null reference crash on startup.

Do NOT keep the current App.xaml.cs logic. Replace it completely using
the correct initialization pattern described in Section 2.2 of this document.

Additionally:
- AppShell.xaml likely has incorrect route definitions — verify and fix
- Some ViewModels may have BindingContext set after InitializeComponent — fix all
- The app must launch and show LoginPage before any other work is considered done

JULES — МАСТЕР-ЗАДАНИЕ

NeverlandsMobile: полный рабочий Android-клиент

Репозиторий: github.com/MyNameNewPerson/never  |  Ветка: main

0. КРИТИЧЕСКИЕ ПРАВИЛА — ЧИТАЙ ПЕРВЫМ
Нарушение любого из этих правил = задача провалена. Проверяй каждый пункт перед коммитом.

0.1 Правило верификации — ОБЯЗАТЕЛЬНО
После КАЖДОГО изменения кода выполняй команду сборки и убеждайся что она проходит без ошибок:
dotnet build Neverlands.Mobile/Neverlands.Mobile.csproj -f net9.0-android
Если сборка падает — исправь ошибки ПРЕЖДЕ чем двигаться к следующему шагу. Не коммить код который не компилируется.

0.2 Правило запуска — финальная проверка
После всех изменений собери APK и убедись что он устанавливается и запускается:
dotnet publish Neverlands.Mobile/Neverlands.Mobile.csproj -f net9.0-android -c Release
Финальный APK: Neverlands.Mobile/bin/Release/net9.0-android/publish/com.neverlands.mobile-Signed.apk

0.3 Известные ошибки — НЕ ПОВТОРЯЙ
Ошибка	Причина	Правильное решение
Shell.GoToAsync('//LoginPage') крашится при старте	Shell ещё не инициализирован когда вызывается навигация	Навигацию вызывать только после того как Shell стал MainPage и layout завершён — использовать Dispatcher.Dispatch или OnAppearing
AppInitializer не найден	Отсутствует using Neverlands.Infrastructure.Services	Добавить using в App.xaml.cs
CS0104 OperationCanceledException	Конфликт Android.OS и System namespace	Писать System.OperationCanceledException явно
Страница открывается но пустая	BindingContext не установлен или установлен после InitializeComponent	Устанавливать BindingContext через DI в конструкторе до InitializeComponent или сразу после
Shell маршруты не работают	Routing.RegisterRoute вызван после Shell.Current инициализации	Регистрировать маршруты в AppShell конструкторе до base вызова
ActivityIndicator зависает	InitializeApp async void не awaited, навигация происходит до завершения	Весь async поток должен быть последовательным без race condition

 
1. ТЕХНИЧЕСКАЯ СРЕДА
Параметр	Значение	Обязательно
.NET SDK	9.0.312	Да — не 8.x, не 10.x
TargetFramework	net9.0-android	Да
MAUI Workload	9.0.120	Да
Microsoft.Maui.Controls	9.0.120 (явный PackageReference)	Да
CommunityToolkit.Mvvm	8.2.2	Да
Microsoft.Extensions.Logging.Debug	8.0.0	Да
Android min API	21 (Android 5.0)	Да
Android Build Tools	34.0.0	Да

2. АРХИТЕКТУРА ПРИЛОЖЕНИЯ
2.1 Структура проектов (не менять)
Проект	Роль	Что трогать
Neverlands.Core	Domain модели, интерфейсы	Только добавлять модели если нужно
Neverlands.Infrastructure	Реализации сервисов (NetworkService, ProfileManager, AppInitializer и т.д.)	Только исправлять баги
Neverlands.Automation	AutomationEngine, CombatService, NavigationService и т.д.	Только исправлять баги
Neverlands.Mobile	MAUI UI — Views, ViewModels, App.xaml	Основная работа здесь

2.2 Правильная инициализация приложения
Текущая проблема: App.xaml.cs вызывает Shell.GoToAsync слишком рано. Правильная схема:
// App.xaml.cs — ПРАВИЛЬНАЯ реализация
public App(AppInitializer initializer)
{
    InitializeComponent();
    MainPage = new AppShell();  // сначала Shell
}

// AppShell.xaml.cs — навигация после загрузки
protected override async void OnAppearing()
{
    base.OnAppearing();
    var initializer = Handler.MauiContext.Services
        .GetService<AppInitializer>();
    await initializer.InitializeAsync();
    var route = initializer.HasAutoLoginProfile()
        ? "///main" : "//login";
    await Shell.Current.GoToAsync(route);
}

2.3 AppShell.xaml — правильная структура маршрутов
<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
       x:Class="Neverlands.Mobile.AppShell">
  <!-- Скрытые маршруты для навигации -->
  <Shell.Items>
    <ShellContent Route="login" ContentTemplate="{DataTemplate views:LoginPage}" Shell.NavBarIsVisible="False" />
    <ShellContent Route="main"  ContentTemplate="{DataTemplate views:MainPage}" Shell.NavBarIsVisible="False" />
    <ShellContent Route="map"   ContentTemplate="{DataTemplate views:MapPage}" />
    <ShellContent Route="profiles" ContentTemplate="{DataTemplate views:ProfilesPage}" />
    <ShellContent Route="character" ContentTemplate="{DataTemplate views:CharacterPage}" />
    <ShellContent Route="automation" ContentTemplate="{DataTemplate views:AutomationPage}" />
    <ShellContent Route="settings" ContentTemplate="{DataTemplate views:SettingsPage}" />
  </Shell.Items>
</Shell>

Все страницы регистрировать через ShellContent, НЕ через Routing.RegisterRoute для основных экранов. Routing.RegisterRoute использовать только для вложенной навигации.

 
3. ЧТО ТАКОЕ NEVERLANDS — КОНТЕКСТ ДЛЯ UI
3.1 Игра
Neverlands — браузерная MMORPG. Игрок управляет персонажем через HTTP API. Клиент отправляет команды — сервер возвращает состояние. Карта мира состоит из клеток (cells). Персонаж перемещается по клеткам, сражается с монстрами, собирает ресурсы.

3.2 Что делает IBC клиент (оригинальный десктопный exe)
Функция IBC	Аналог в мобильном
Форма входа: логин, пароль, сервер, галочки RememberPassword и AutoLogin	LoginPage — точное воспроизведение
Список аккаунтов (мультиаккаунт)	ProfilesPage — управление несколькими аккаунтами
Главный HUD: HP, MP, уровень, локация, кнопки движения	MainPage — игровой интерфейс
Карта мира с клетками из map.xml	MapPage — отображение и навигация
Окно персонажа: характеристики, экипировка	CharacterPage
Панель автоматизации: боты, скрипты, режимы	AutomationPage
Настройки: API ключи, задержки, параметры	SettingsPage

3.3 Ресурсы карты (уже в проекте)
•	Resources/Raw/map.xml — клетки карты (id, name, x, y, type)
•	Resources/Raw/abcells.xml — дополнительные данные клеток
•	Resources/Raw/abteleports.xml — телепорты между локациями
•	Resources/Raw/abthings.xml — объекты на карте
•	Resources/Raw/bossusers.xml — боссы
•	Resources/Raw/map_mines.xml — шахты

 
4. LOGINPAGE — РЕАЛИЗОВАТЬ ПОЛНОСТЬЮ
Это самый важный экран. Приложение должно открываться с него если нет AutoLogin профиля.

4.1 Полный список элементов UI
Элемент	Тип MAUI	Binding	Поведение
Заголовок 'Neverlands'	Label	—	Крупный, по центру, вверху
Список профилей	Picker	SelectedProfile	При выборе — заполняет Login и Password из профиля
Поле логина	Entry	Login	Placeholder 'Логин'
Поле пароля	Entry	Password	IsPassword=True, Placeholder 'Пароль'
Чекбокс 'Запомнить пароль'	CheckBox + Label	RememberPassword	При снятии — пароль не сохраняется
Чекбокс 'Автовход'	CheckBox + Label	AutoLogin	При включении — следующий запуск пропускает LoginPage
Кнопка 'Войти'	Button	LoginCommand	Показывает ActivityIndicator, блокируется во время входа
Кнопка 'Новый профиль'	Button	AddProfileCommand	Очищает поля для ввода нового аккаунта
Кнопка 'Удалить'	Button	DeleteProfileCommand	Удаляет выбранный профиль с подтверждением DisplayAlert
ActivityIndicator	ActivityIndicator	IsLoading	Видим только во время входа
Label ошибки	Label	ErrorMessage	Красный цвет, видим только при ошибке

4.2 LoginViewModel — полная реализация
Файл: ViewModels/LoginViewModel.cs
[ObservableProperty] private ObservableCollection<UserProfile> _profiles;
[ObservableProperty] private UserProfile _selectedProfile;
[ObservableProperty] private string _login = string.Empty;
[ObservableProperty] private string _password = string.Empty;
[ObservableProperty] private bool _rememberPassword = true;
[ObservableProperty] private bool _autoLogin;
[ObservableProperty] private bool _isLoading;
[ObservableProperty] private string _errorMessage = string.Empty;

Логика OnSelectedProfileChanged:
partial void OnSelectedProfileChanged(UserProfile value)
{
    if (value == null) return;
    Login = value.Login;
    Password = _secureStorage.GetPassword(value.Id);
    AutoLogin = value.AutoLogin;
    RememberPassword = value.RememberPassword;
}

Логика LoginCommand:
[RelayCommand]
private async Task Login()
{
    if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password)) return;
    IsLoading = true; ErrorMessage = string.Empty;
    try {
        // ЭТАП 1: сначала просто сохранить и перейти (заглушка сети)
        var profile = new UserProfile { Login = Login, AutoLogin = AutoLogin,
            RememberPassword = RememberPassword };
        if (RememberPassword) await _secureStorage.SavePassword(profile.Id, Password);
        await _profileManager.SaveProfileAsync(profile);
        await _profileManager.SetActiveProfileAsync(profile);
        await Shell.Current.GoToAsync("///main");
    }
    catch (Exception ex) { ErrorMessage = ex.Message; }
    finally { IsLoading = false; }
}

ВАЖНО: сетевой вход (HTTP запрос к серверу игры) реализовать только если INetworkService.AuthenticateAsync уже реализован в NetworkService. Если не реализован — сначала переход без проверки, сеть добавить потом.

 
5. MAINPAGE — ИГРОВОЙ HUD
5.1 Элементы UI
Элемент	Binding	Описание
Имя + уровень (Label)	CharacterName, Level	Шапка HUD
HP полоска (ProgressBar)	HpPercent	+ Label с числами '150 / 300'
MP полоска (ProgressBar)	MpPercent	+ Label с числами (если есть MP)
Локация (Label)	CurrentLocation	Название текущей клетки карты
Кнопки движения (4 Button)	MoveNorthCommand и т.д.	Стрелки ↑↓←→ в Grid 3x3
Лог событий (CollectionView/ScrollView)	EventLog	Последние 20 событий, автоскролл вниз
Статус автоматизации (Label)	AutomationStatus	'Автоматизация: ВКЛ / ВЫКЛ'
Кнопка Карта	—	Shell.GoToAsync('//map')
Кнопка Персонаж	—	Shell.GoToAsync('//character')
Кнопка Профили	—	Shell.GoToAsync('//profiles')
Кнопка Автоматизация	—	Shell.GoToAsync('//automation')
Кнопка Настройки	—	Shell.GoToAsync('//settings')

5.2 MainViewModel ключевые свойства
[ObservableProperty] string _characterName;
[ObservableProperty] int _level;
[ObservableProperty] int _currentHp; [ObservableProperty] int _maxHp;
[ObservableProperty] int _currentMp; [ObservableProperty] int _maxMp;
public double HpPercent => MaxHp > 0 ? (double)CurrentHp / MaxHp : 0;
[ObservableProperty] string _currentLocation;
[ObservableProperty] string _automationStatus = "Автоматизация: ВЫКЛ";
[ObservableProperty] ObservableCollection<string> _eventLog = new();
[RelayCommand] Task MoveNorth() => MoveAsync("north");
[RelayCommand] Task MoveSouth() => MoveAsync("south");
[RelayCommand] Task MoveWest()  => MoveAsync("west");
[RelayCommand] Task MoveEast()  => MoveAsync("east");
[RelayCommand] void ToggleAutomation();

 
6. PROFILESPAGE
6.1 Элементы UI
Элемент	Описание
CollectionView профилей	Список всех сохранённых аккаунтов
Карточка профиля	Имя/логин, метка 'Активный' для текущего, дата последнего входа
Кнопка 'Войти'	Войти с выбранным профилем → MainPage
Кнопка 'Сделать активным'	Переключить активный профиль
Кнопка 'Удалить'	Удалить с подтверждением DisplayAlert
Кнопка 'Добавить'	Переход на LoginPage для нового аккаунта

7. MAPPAGE
7.1 Чтение XML карты
// Читать map.xml при инициализации MapViewModel
using var stream = await FileSystem.OpenAppPackageFileAsync("map.xml");
var doc = XDocument.Load(stream);
// Парсить элементы, заполнять ObservableCollection<MapCellViewModel>

7.2 Элементы UI
Элемент	Описание
ScrollView с Grid	Сетка клеток карты, размер по данным из XML
Клетка карты (Button/Frame)	Цвет зависит от типа: лес, город, шахта, телепорт
Текущая позиция	Выделена другим цветом или рамкой
Телепорты	Отмечены иконкой или цветом
Label с названием клетки	Показывается при тапе
Кнопка 'Перейти'	Отправляет команду навигации к выбранной клетке

 
8. CHARACTERPAGE
Элемент	Binding
Имя персонажа (Label крупный)	Name
Уровень	Level
HP полоска + числа	CurrentHp / MaxHp
MP полоска + числа	CurrentMp / MaxMp
Полоска опыта	CurrentExp / MaxExp + процент до следующего уровня
Золото / валюта	Gold
Таблица характеристик	Атака, Защита, Скорость, Удача
Слоты снаряжения (Grid 3x3)	Equipment — Голова, Тело, Оружие, Щит, Перчатки, Ноги, Кольцо, Амулет
Кнопка Обновить	RefreshCommand — запрос актуальных данных

9. AUTOMATIONPAGE
Элемент	Binding
Switch 'Автоматизация'	IsAutomationRunning — запускает BackgroundAutomationManager
CollectionView скриптов	Scripts из IScriptManager
Кнопка 'Запустить скрипт'	RunScriptCommand
Кнопка 'Остановить'	StopScriptCommand
Switch 'Автосбор ресурсов'	IsResourceFarmingEnabled
Switch 'Автобой'	IsAutoCombatEnabled
Label текущей задачи	CurrentTaskDescription
Лог автоматизации (ScrollView)	AutomationLog — последние события

10. SETTINGSPAGE
Элемент	Описание
Entry: AntiCaptcha API ключ	Сохранять через ISecureStorageService
Entry: задержка между действиями (мс)	Сохранять в Preferences
Switch: включить лог	Сохранять в Preferences
Entry: User-Agent для HTTP запросов	Сохранять в Preferences
Кнопка 'Сохранить'	SaveCommand — сохраняет все настройки
Кнопка 'Сброс'	ResetCommand — сброс к defaults с подтверждением

 
11. ОБЯЗАТЕЛЬНЫЕ ТЕХНИЧЕСКИЕ ТРЕБОВАНИЯ
11.1 XAML — каждая страница обязана иметь
•	x:DataType="vm:НазваниеViewModel" — обязателен для compiled bindings, устраняет предупреждения XC0022
•	xmlns:vm="clr-namespace:Neverlands.Mobile.ViewModels" — namespace для DataType
•	BindingContext устанавливается через DI в code-behind конструкторе

Шаблон code-behind для каждой страницы:
public LoginPage(LoginViewModel viewModel)
{
    BindingContext = viewModel;  // ДО InitializeComponent
    InitializeComponent();
}

11.2 MauiProgram.cs — текущий (не менять без причины)
Все сервисы уже зарегистрированы корректно. Дополнительно нужно добавить только если создаются новые сервисы. Убедиться что все страницы и ViewModels зарегистрированы как Transient.

11.3 Порядок реализации — строго по шагам
Шаг	Задача	Проверка перед переходом
1	Исправить AppShell.xaml — правильные маршруты ShellContent	dotnet build проходит
2	Исправить App.xaml.cs — убрать async навигацию из конструктора, перенести в AppShell.OnAppearing	Приложение запускается без краша
3	LoginPage XAML — все элементы согласно разделу 4	Страница открывается, все поля видны
4	LoginViewModel — свойства, команды, OnSelectedProfileChanged	Ввод в поля работает, кнопка Войти переходит на MainPage
5	MainPage XAML — HUD согласно разделу 5	HUD отображается с заглушечными данными
6	MainViewModel — свойства и команды	HP полоска, кнопки навигации работают
7	ProfilesPage — список профилей	Профили отображаются
8	MapPage — загрузка из XML, отображение клеток	Карта отображается
9	CharacterPage	Характеристики отображаются
10	AutomationPage + SettingsPage	Переключатели работают, настройки сохраняются

11.4 Что НЕ делать
•	Не переписывать Neverlands.Core, Neverlands.Infrastructure, Neverlands.Automation без явной необходимости
•	Не добавлять сетевые запросы если NetworkService.AuthenticateAsync не реализован — использовать заглушку
•	Не ставить async void кроме event handlers и OnAppearing
•	Не делать Shell.GoToAsync до того как Shell стал MainPage
•	Не делать бизнес-логику в code-behind — только в ViewModel
•	Не коммитить если dotnet build выдаёт ошибки

 
12. ФИНАЛЬНЫЙ ЧЕКЛИСТ
Каждый пункт должен быть выполнен и проверен перед финальным коммитом.

Запуск приложения:
•	Приложение собирается без ошибок: dotnet build → 0 errors
•	APK создаётся: com.neverlands.mobile-Signed.apk существует
•	Приложение запускается на Android устройстве/эмуляторе без краша
•	При первом запуске (нет профилей) открывается LoginPage
•	При повторном запуске с AutoLogin=true открывается MainPage

LoginPage:
•	Picker с профилями (пустой при первом запуске — OK)
•	Entry поля логин и пароль работают
•	Оба CheckBox работают и сохраняют значение
•	Кнопка Войти переходит на MainPage
•	ActivityIndicator показывается во время входа
•	ErrorMessage показывается при ошибке

MainPage:
•	Открывается без краша
•	HP полоска отображается (хоть с нулями)
•	4 кнопки движения кликабельны
•	Кнопки навигации к другим экранам работают

Остальные экраны:
•	Все 7 экранов открываются без краша
•	Нет пустых белых экранов без контента
•	Навигация назад работает

Критерий успеха: пользователь вводит логин/пароль → нажимает Войти → попадает на MainPage с HUD → может перейти на любой экран. Всё без крашей.
