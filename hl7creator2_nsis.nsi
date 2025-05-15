# define the name of the installer
Outfile "HL7Creator.exe"
Icon "HL7Creator\health.ico"

InstallDir $TEMP\HL7CreatorSetup

AutoCloseWindow true

# default section
Section

HideWindow

SetOutPath $INSTDIR

File /r HL7CreatorSetup\Release\*.*
ExecWait "$INSTDIR\Setup.exe"

RMDir /r "$INSTDIR"

SectionEnd
