taskkill /IM valheim.exe /F
cd C:\Users\%username%\AppData\LocalLow\IronGate\Valheim\worlds
git add .
git commit -m "autoCommit %date:~-4%%date:~3,2%%date:~0,2%.%time:~0,2%%time:~3,2%%time:~6,2%"
git push origin master
exit