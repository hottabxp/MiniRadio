[Files]
Source: ".\MiniRadio\bin\Release\bass.dll"; DestDir: "{pf32}\MiniRadio\"; Flags: ignoreversion createallsubdirs recursesubdirs
Source: ".\MiniRadio\bin\Release\Bass.Net.dll"; DestDir: "{pf32}\MiniRadio\"; Flags: ignoreversion createallsubdirs recursesubdirs
Source: ".\MiniRadio\bin\Release\MiniRadio.exe"; DestDir: "{pf32}\MiniRadio\"; Flags: ignoreversion createallsubdirs recursesubdirs
Source: ".\MiniRadio\bin\Release\MiniRadio.exe.config"; DestDir: "{pf32}\MiniRadio\"; Flags: ignoreversion createallsubdirs recursesubdirs
Source: ".\MiniRadio\data\playlist\club.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion
Source: ".\MiniRadio\data\playlist\list.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion
Source: ".\MiniRadio\data\playlist\misc.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion
Source: ".\MiniRadio\data\playlist\my.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion
Source: ".\MiniRadio\data\playlist\pop.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion
Source: ".\MiniRadio\data\playlist\retro.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion
Source: ".\MiniRadio\data\playlist\rock.txt"; DestDir: "{userdocs}\playlist\"; Flags: ignoreversion

[Setup]
AppName=MiniRadio
AppVersion=1.5
AppCopyright=Sergey Karbivnichiy
OutputDir=.
PrivilegesRequired=none
DefaultDirName={pf}\MiniRadio
