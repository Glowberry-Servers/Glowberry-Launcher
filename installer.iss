; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Glowberry Launcher"
#define MyAppVersion "1.5.0"
#define MyAppPublisher "Glowberry Servers"
#define MyAppURL "https://github.com/Glowberry-Servers/Glowberry-Launcher"
#define MyAppExeName "Glowberry Launcher.exe"
#define MyAppAssocName "Executable File"
#define MyAppAssocExt ".exe"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{190D724E-C363-4F0C-B5A2-5721D712477E}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\Glowberry/Glowberry Launcher
ChangesAssociations=yes
DisableProgramGroupPage=yes
LicenseFile=C:\dev\Glowberry\Glowberry-Launcher\LICENSE.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=commandline
OutputBaseFilename=GlowberryLauncher-1.5.0-Setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern
ChangesEnvironment = yes
SetupIconFile=logo.ico
UninstallDisplayIcon={app}\logo.ico

[Messages]
// define wizard title and tray status msg
// both are normally defined in innosetup's default.isl (install folder)
SetupAppTitle = Setup {#MyAppName}
SetupWindowTitle = Setup - {#MyAppName} v{#MyAppVersion}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\DotNetZip.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\DotNetZip.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\gbhelper.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Glowberry Launcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Glowberry Launcher.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Glowberry Launcher.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\glowberry.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\glowberry.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\GlowberryDLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\GlowberryDLL.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\HtmlAgilityPack.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\HtmlAgilityPack.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\LaminariaCore_General.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\LaminariaCore_Winforms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\logo.ico"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Microsoft.Win32.TaskScheduler.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Microsoft.WindowsAPICodePack.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Microsoft.WindowsAPICodePack.Shell.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\Open.Nat.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.CodeDom.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Text.Encodings.Web.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Text.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\System.ValueTuple.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\dev\Glowberry\Glowberry-Launcher\bin\Release\WindowsFirewallHelper.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Tasks]
Name: envPath; Description: "Add to glowberry to PATH variable" 

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon


[Code]
const EnvironmentKey = 'SYSTEM\CurrentControlSet\Control\Session Manager\Environment';

procedure EnvAddPath(Path: string);
var
    Paths: string;
begin
    { Retrieve current path (use empty string if entry not exists) }
    if not RegQueryStringValue(HKEY_LOCAL_MACHINE, EnvironmentKey, 'Path', Paths)
    then Paths := '';

    { Skip if string already found in path }
    if Pos(';' + Uppercase(Path) + ';', ';' + Uppercase(Paths) + ';') > 0 then exit;

    { App string to the end of the path variable }
    Paths := Paths + ';'+ Path +';'

    { Overwrite (or create if missing) path environment variable }
    if RegWriteStringValue(HKEY_LOCAL_MACHINE, EnvironmentKey, 'Path', Paths)
    then Log(Format('The [%s] added to PATH: [%s]', [Path, Paths]))
    else Log(Format('Error while adding the [%s] to PATH: [%s]', [Path, Paths]));
end;

procedure EnvRemovePath(Path: string);
var
    Paths: string;
    P: Integer;
begin
    { Skip if registry entry not exists }
    if not RegQueryStringValue(HKEY_LOCAL_MACHINE, EnvironmentKey, 'Path', Paths) then
        exit;

    { Skip if string not found in path }
    P := Pos(';' + Uppercase(Path) + ';', ';' + Uppercase(Paths) + ';');
    if P = 0 then exit;

    { Update path variable }
    Delete(Paths, P - 1, Length(Path) + 1);

    { Overwrite path environment variable }
    if RegWriteStringValue(HKEY_LOCAL_MACHINE, EnvironmentKey, 'Path', Paths)
    then Log(Format('The [%s] removed from PATH: [%s]', [Path, Paths]))
    else Log(Format('Error while removing the [%s] from PATH: [%s]', [Path, Paths]));
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
    if CurStep = ssPostInstall 
     then EnvAddPath(ExpandConstant('{app}'));
end;

procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
begin
    if CurUninstallStep = usPostUninstall
    then EnvRemovePath(ExpandConstant('{app}'));
end;