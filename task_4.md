Task #4 (ALL GROUPS) 

Use language and platform FOR YOU GROUP: 

JavaScript or TypeScript, React, Express, PostgreSQL or MySQL or any database (see below),
C#, .NET, some kind ASP.NET, SQL Server or PostgreSQL or MySQL or any database,

THE FIRST REQUIREMENT: YOU NEED TO CREATE A UNIQUE INDEX IN DATABASE.
- ПЕРВОЕ ТРЕБОВАНИЕ: ВАМ НЕОБХОДИМО СОЗДАТЬ УНИКАЛЬНЫЙ ИНДЕКС В БАЗЕ ДАННЫХ.

THE SECOND REQUIREMENT: YOUR TABLE SHOULD LOOK LIKE TABLE AND YOUR TOOLBAR SHOULD LOOK LIKE TOOLBAR.
- ВТОРОЕ ТРЕБОВАНИЕ: ВАША ТАБЛИЦА ДОЛЖНА ВЫГЛЯДЕТЬ КАК TABLE, А ВАША ПАНЕЛЬ ИНСТРУМЕНТОВ - КАК TOOLBAR.

THE THIRD REQUIREMENT: DATA IN THE TABLE SHOULD BE SORTED (E.G., BY THE LAST LOGIN TIME).
- ТРЕТЬЕ ТРЕБОВАНИЕ: ДАННЫЕ В ТАБЛИЦЕ ДОЛЖНЫ БЫТЬ ОТСОРТИРОВАНЫ (НАПРИМЕР, ПО ВРЕМЕНИ ПОСЛЕДНЕГО ВХОДА В СИСТЕМУ).

THE FOURTH REQUIREMENT: MULTIPLE SELECTION SHOULD BE IMPLEMENTED USING CHECKBOXES (SELECT ALL/DELECT ALL IS ALSO A CHECKBOX).
- ЧЕТВЕРТОЕ ТРЕБОВАНИЕ: МНОЖЕСТВЕННЫЙ ВЫБОР ДОЛЖЕН БЫТЬ РЕАЛИЗОВАН С ПОМОЩЬЮ ФЛАЖКОВ (ВЫБРАТЬ ВСЕ/УДАЛИТЬ ВСЕ - ЭТО ТОЖЕ ФЛАЖОК).

THE FIFTH REQUIREMENT: BEFORE EACH REQUEST EXCEPT FOR REGISTRATION OR LOGIN, SERVER SHOULD CHECK IF USER EXISTS AND ISN'T BLOCKED (if user account is blocked or deleted, any next user’s request should redirect to the login page).

- ПЯТОЕ ТРЕБОВАНИЕ: ПЕРЕД КАЖДЫМ ЗАПРОСОМ, ЗА ИСКЛЮЧЕНИЕМ РЕГИСТРАЦИИ ИЛИ ЛОГИНА, СЕРВЕР ДОЛЖЕН ПРОВЕРЯТЬ, СУЩЕСТВУЕТ ЛИ ПОЛЬЗОВАТЕЛЬ И НЕ ЗАБЛОКИРОВАН ЛИ ОН (если учетная запись пользователя заблокирована или удалена, любой следующий запрос пользователя должен перенаправляться на страницу входа в систему).

Create a working and deployed (remotely accessible) Web application with user registration and authentication.

Создайте работающее и развернутое (с удаленным доступом) веб-приложение с регистрацией и аутентификацией пользователя.

Non-authenticated users should not have access to the user management (admin panel). They have only access to login form or registration form.

Пользователи, не прошедшие проверку подлинности, не должны иметь доступа к управлению пользователями (административной панели). У них есть доступ только к форме входа в систему или регистрации.

Only authenticated non-blocked users should have access the user management table with at least the following fields: (selection checkbox), name, e-mail, last login time (or the last “activity” time or both), status (active/blocked). You also may add registration time, some sparkline for activity, etc. (optional).

Только прошедшие проверку подлинности неблокированные пользователи должны иметь доступ к таблице управления пользователями, содержащей, по крайней мере, следующие поля: (флажок для выбора), имя, адрес электронной почты, время последнего входа в систему (или время последней “активности”, или и то, и другое), статус (активен/заблокирован). Вы также можете добавить время регистрации, какой-нибудь спарклайн для активности и т.д. (опционально).

The leftmost column of the table should contains checkboxes without labels for multiple selection (table header contains only checkbox without label that selects or deselects all the records).

В крайнем левом столбце таблицы должны быть установлены флажки без меток для множественного выбора (заголовок таблицы содержит только флажок без меток, который выбирает или отменяет выбор всех записей).

There must be a toolbar over the table with the following actions: Block (button with text), Unblock (icon), Delete (icon). NO BUTTONS IN EACH ROW.

Над таблицей должна быть панель инструментов со следующими действиями: Заблокировать (кнопка с текстом), Разблокировать (значок), Удалить (значок). В КАЖДОЙ СТРОКЕ НЕТ КНОПОК.

You have to use any CSS framework (Bootstrap is recommended, but you can choose any CSS framework).
>All users should be able to block or delete themselves or any other user.

Вы должны использовать любой CSS-фреймворк (рекомендуется Bootstrap, но вы можете выбрать любой CSS-фреймворк).
>Все пользователи должны иметь возможность блокировать или удалять себя или любого другого пользователя.

User can use any non-empty password (even one character).

No e-mail confirmation should be required.

Blocked user should not be able to login, deleted user can re-register.

Пользователь может использовать любой непустой пароль (даже из одного символа).

Подтверждение по электронной почте не требуется.

Заблокированный пользователь не должен иметь возможности войти в систему, удаленный пользователь может повторно зарегистрироваться.

JUST IN CASE: YOU HAVE TO CREATE A UNIQUE INDEX IN THE DATABASE. NOT TO CHECK WITH YOU CODE FOR UNIQUENESS, BUT CREATE THE INDEX.

НА ВСЯКИЙ СЛУЧАЙ: ВАМ НУЖНО СОЗДАТЬ УНИКАЛЬНЫЙ ИНДЕКС В БАЗЕ ДАННЫХ. НЕ ДЛЯ ТОГО, ЧТОБЫ СВЕРЯТЬ С ВАШИМ КОДОМ УНИКАЛЬНОСТЬ, А ДЛЯ ТОГО, ЧТОБЫ СОЗДАТЬ ИНДЕКС.

YOU STORAGE SHOULD GUARANTEE E-MAIL UNIQUENESS INDEPENDENTLY OF HOW MANY SOURCES PUSH DATA INTO IT SIMULTANEOUSLY. 

ВАШЕ ХРАНИЛИЩЕ ДОЛЖНО ГАРАНТИРОВАТЬ УНИКАЛЬНОСТЬ ЭЛЕКТРОННОЙ ПОЧТЫ НЕЗАВИСИМО ОТ ТОГО, СКОЛЬКО ИСТОЧНИКОВ ОДНОВРЕМЕННО ЗАГРУЖАЮТ В НЕЕ ДАННЫЕ.

Note that a unique index is not the same as a primary key (which you should have too):
https://en.wikipedia.org/wiki/Database_index

Generally, you can use any "architecture". It's not important in this task. Generally, it's the most simple and straightforward to use a relational DB, e.g. PostgreSQL or MySQL. You can, if you wish, use anything else. E.g., MongoDB, but it really won't give you any advantage in this task (you just deprive yourself a very major skill). But you can. Or you can even try use some SaaS like Firebase. But be careful, you easily will get into some troubles. E.g.,  if you decide to use "out-of-the-box" users, it may be problematic to delete them. If you decide to use custom "users", you may have some problems with maintaining uniquieness of e-mails, etc. I have to remind, that you code can contain only error processing and management of uniqueness have to be performed on the storage level, but you code shouldn't contain checks whether the e-mail already exists. Arguably, the simplest solution is to use a classic boring "trivial" relational database. But even in Firebase you may try to create documents that uses e-mails as keys (again, it limits you ability to change e-mail by user request, etc.).
NO WALLPAPERS UNDER THE TABLE. NO ANIMATIONS. NO BROWSER ALERTS. NO BUTTONS IN THE DATA ROWS.

Как правило, вы можете использовать любую "архитектуру". В данной задаче это не важно. Как правило, наиболее простым и понятным является использование реляционной базы данных, например, PostgreSQL или MySQL. Вы можете, если хотите, использовать что-нибудь еще. Например, MongoDB, но это действительно не даст вам никаких преимуществ в этой задаче (вы просто лишите себя очень важного навыка). Но вы можете. Или вы даже можете попробовать использовать некоторые SAAS, такие как Firebase. Но будьте осторожны, вы легко можете столкнуться с некоторыми проблемами. Например, если вы решите использовать "готовых" пользователей, удалить их может быть проблематично. Если вы решите использовать пользовательских "пользователей", у вас могут возникнуть некоторые проблемы с сохранением уникальности электронных писем и т.д. Я должен напомнить, что ваш код может содержать только обработку ошибок, а управление уникальностью должно выполняться на уровне хранилища, но ваш код не должен содержать проверок того, существует ли уже электронное письмо. Возможно, самое простое решение - использовать классическую скучную "тривиальную" реляционную базу данных. Но даже в Firebase вы можете попытаться создать

Your application should work properly in different browsers and on different resolutions (desktop/mobile). And look like a business-oriented professional app (boring, but consistent and accurate). However, you have to get that automagically by properly using CSS framework like Bootstrap.

Ваше приложение должно корректно работать в разных браузерах и на разных разрешениях (настольных и мобильных). И выглядеть как профессиональное приложение, ориентированное на бизнес (скучное, но последовательное и точное). Однако вы должны добиться этого автоматически, правильно используя CSS-фреймворк, такой как Bootstrap.

DON'T INVENT ANYTHING, USE LIBRARIES FOR EVERYTHING.

НИЧЕГО НЕ ИЗОБРЕТАЙТЕ, ИСПОЛЬЗУЙТЕ БИБЛИОТЕКИ ДЛЯ ВСЕГО.

1) Implement:
2) adequate error messages;
3) tooltips;
4) status messages (informing user about succesful operation).

If you use N buttons (separate set of buttons for each row), the grade will be reduced by 20%. You need to implement selection and a toolbar. And align text properly in the cells (check the screenshot below).
This is table with toolbar (well, you are not required to show sparklines with previous user activity, it's definitely optional; also, this is only the table, you’ll need to implement the standard navigation header, logout, etc.) 

How to submit the solution
Send to p.lebedev@itransition.com:
- Full name.
- Link to source code in the public repository.
- Link to the deployed project (you can use any hosting you find suitable — azure, amazon, render, somee, vercel, netlify, anything).
- Recorded video: registration, login, non-current user selection, user blocking (the user status should be updated), user unblocking, all user selection (including current), all user blocking (with automatic redirection to the login page), demonstration of the index created in the database (if you use storage that doesn't support indices, demonstrate the solution using  documents with e-mail as keys or some kind of triggers – any solution that will guarantee consitency on the storage level).

PLEASE, MAKE SURE THAT YOUR VIDEO CONTAINS DEMONSTRATION OF THE INDEX IN THE DATABASE AS WELL AS PLACE IN THE CODE THAT CATCHES THE CORRESPONING ERROR AND SHOW AN APPROPRIATE MESSAGE. IF YOU USE SOME STORAGE NOT VERY SUITED FOR THIS TASKS THAT DOESN'T SUPPORT INDICES, DEMONSTRATE YOUR TRIGGERS OR DOCUMENTS THAT USES E-MAILS AS KEYS, ETC. If you ignore this requirement or implement it by checking if e-mail exists in the database by your code, the solution won't be accepted.

Deadlines for this task 01.08.25.

Why all users are admins, isn't that strange? Yes, kinda, in reality it won't be implemented this way. But here are two reasons:
1) To simplify testing (for you and for me).
2) To simplify your work, because you don't need to think about user roles (in this task).

However, the admin ability to delete themselves is very real and very ofter required — if you have no idea why, you may ask.

https://www.w3schools.com/sql/sql_ref_create_unique_index.asp

Users shouldn't be "kicked" right away. They should be "kicked" when they try to perform some action. For example, if I look at user list while somebody else blocks me (or I block itself from other browser), I can continue to stare at the users list as long as I want. But if I try to block or unblock somebody, I must be redirected to login page with the correspoding notification. You have to check before any server request that user exists and isn't blocked.

**About task #4**

Users shouldn't be "kicked" _right away_. They should be "kicked" when they try to perform some action. For example, if I look at user list while somebody else blocks me (or I block itself from other browser), I can continue to stare at the users list as long as I want. But if I try to block or unblock somebody, I must be redirected to login page with the correspoding notification. _You have to check before any server request that user exists and isn't blocked._

