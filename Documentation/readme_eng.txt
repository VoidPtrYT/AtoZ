Short documentation about application AtoZ [ENG]
This application used for fast convertation text in another register or correct error of language keyboard(russian\english).

Modes of work:
- Change language
Changed phrase whitch printed on russian keyboard layout to english layout with correct register, and another way. Else, you can edit what char edit to another char. For this you need to edit data in file lang.dat, whitch contaits in folder with executable file, and has Unicode encoding, this means - you can put almost any of symbol from languages.

Structure of lang.dat:
This is only additional file(not considering icon and documentation), whitch has next structure: <Input symbol> <output symbol>.
Strings whith more or less than 1 space are will be ignored.
Read always first symbol of lexem, and if there was be word - application read always read first char.
Equals key symbols are was be ignored, and even value are differce.
As default works with symbols as equals key combination Shift + <number>, as such as: ", ;, #, &, etc.
For optimization dont write strins where key and value are equals.

If application dont found value at lang.dat - will be writed source symbol.


- Change char register
This function don't needs additional files and works with directly with .NET Framework, and this is supply register of difference laungauges. Register converts to another, and this very conveniently if you press Caps Lock.

Shortcut keys:
- For select convertation language - you can press in menu "Смена языка", or press shorcut combination Ctrl + Q.
- For select convertation register - you can press in menu "Смена регистра", or press shortcut combination Ctrl + E.
- Clear buffer - you can clear by default clear, and with another 2 ways: by pressingh button "Очистка", and shotcut combination Ctrl + Del.
- Exit application - by pressing close on window frame, by pressing buttn "Выход", and by shorcut combination Alt + F4.

For conveniently of use - you can select all printed text by double click. If you do this with output text - this text selected all, and copy to you buffer.

Errors:
If application don't starts, or when load - you see error message - this can means - you don't has .NET Framework. You can downcoad framework from official wed page Microsoft, by this link: https://www.microsoft.com/ru-RU/download/details.aspx?id=55167. For more supply platforms - this application use .NET Framework 2.0, and can works at more newwest versions.

If you file lang.dat not exists in directory with executable file - you can show presenting warning, and application works in change register mode.

Minimal system reqirements:
- .NET Framework 2.0
- Minimum 6.8 MB Ram for start application. With full buffer in 65535 symbols - 10.4 MB
- Windows XP x86
- 1 core processor 1 GHz