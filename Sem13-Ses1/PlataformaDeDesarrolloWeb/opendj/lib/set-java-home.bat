goto checkEnvJavaHome

:checkEnvJavaHome
if "%OPENDJ_JAVA_BIN%" == "" goto checkEnvJavaHomeLegacy
if not exist "%OPENDJ_JAVA_BIN%" goto checkEnvJavaHomeLegacy
goto checkEnvJavaArgs

:checkEnvJavaHomeLegacy
if "%OPENDS_JAVA_BIN%" == "" goto checkOpendjJavaHome
if not exist "%OPENDS_JAVA_BIN%" goto checkOpendjJavaHome
goto checkEnvJavaArgs

:checkOpendjJavaHome
if "%OPENDJ_JAVA_HOME%" == "" goto checkJavaHomeLegacy
set TEMP=%OPENDJ_JAVA_HOME%\bin\java.exe
if not exist "%TEMP%" goto checkJavaHomeLegacy
set OPENDJ_JAVA_BIN=%TEMP%
goto checkEnvJavaArgs

:checkJavaHomeLegacy
if "%OPENDS_JAVA_HOME%" == "" goto checkJavaHome
set TEMP=%OPENDS_JAVA_HOME%\bin\java.exe
if not exist "%TEMP%" goto checkJavaHome
set OPENDJ_JAVA_BIN=%TEMP%
goto checkEnvJavaArgs

:checkDefaultJavaHome
set TEMP=C:\Program Files (x86)\Java\jre7\bin\java.exe
if not exist "%TEMP%" goto checkEnvJavaArgs
set OPENDJ_JAVA_BIN=%TEMP%
goto checkEnvJavaArgs

:checkJavaHome
goto checkDefaultJavaHome

:checkEnvJavaArgs
if "%OPENDJ_JAVA_ARGS%" == "" goto checkJavaArgsLegacy
goto end

:checkJavaArgsLegacy
if "%OPENDS_JAVA_ARGS%" == "" goto checkJavaArgs
set OPENDJ_JAVA_ARGS=%OPENDS_JAVA_ARGS%
goto end

:checkJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldapcompare.java-args" goto checkldapcompareJavaArgs
if "%SCRIPT_NAME%.java-args" == "dsreplication.java-args" goto checkdsreplicationJavaArgs
if "%SCRIPT_NAME%.java-args" == "upgrade.java-args" goto checkupgradeJavaArgs
if "%SCRIPT_NAME%.java-args" == "base64.java-args" goto checkbase64JavaArgs
if "%SCRIPT_NAME%.java-args" == "start-ds.java-args" goto checkstart-dsJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldifmodify.java-args" goto checkldifmodifyJavaArgs
if "%SCRIPT_NAME%.java-args" == "dbtest.java-args" goto checkdbtestJavaArgs
if "%SCRIPT_NAME%.java-args" == "backup.offline.java-args" goto checkbackup.offlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "manage-account.java-args" goto checkmanage-accountJavaArgs
if "%SCRIPT_NAME%.java-args" == "backup.online.java-args" goto checkbackup.onlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldapsearch.java-args" goto checkldapsearchJavaArgs
if "%SCRIPT_NAME%.java-args" == "restore.online.java-args" goto checkrestore.onlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "export-ldif.offline.java-args" goto checkexport-ldif.offlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "setup.java-args" goto checksetupJavaArgs
if "%SCRIPT_NAME%.java-args" == "encode-password.java-args" goto checkencode-passwordJavaArgs
if "%SCRIPT_NAME%.java-args" == "make-ldif.java-args" goto checkmake-ldifJavaArgs
if "%SCRIPT_NAME%.java-args" == "control-panel.java-args" goto checkcontrol-panelJavaArgs
if "%SCRIPT_NAME%.java-args" == "manage-tasks.java-args" goto checkmanage-tasksJavaArgs
if "%SCRIPT_NAME%.java-args" == "stop-ds.java-args" goto checkstop-dsJavaArgs
if "%SCRIPT_NAME%.java-args" == "restore.offline.java-args" goto checkrestore.offlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldapmodify.java-args" goto checkldapmodifyJavaArgs
if "%SCRIPT_NAME%.java-args" == "uninstall.java-args" goto checkuninstallJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldif-diff.java-args" goto checkldif-diffJavaArgs
if "%SCRIPT_NAME%.java-args" == "import-ldif.offline.java-args" goto checkimport-ldif.offlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldapdelete.java-args" goto checkldapdeleteJavaArgs
if "%SCRIPT_NAME%.java-args" == "dsreplication.offline.java-args" goto checkdsreplication.offlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "create-rc-script.java-args" goto checkcreate-rc-scriptJavaArgs
if "%SCRIPT_NAME%.java-args" == "rebuild-index.java-args" goto checkrebuild-indexJavaArgs
if "%SCRIPT_NAME%.java-args" == "export-ldif.online.java-args" goto checkexport-ldif.onlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "import-ldif.online.java-args" goto checkimport-ldif.onlineJavaArgs
if "%SCRIPT_NAME%.java-args" == "dsframework.java-args" goto checkdsframeworkJavaArgs
if "%SCRIPT_NAME%.java-args" == "status.java-args" goto checkstatusJavaArgs
if "%SCRIPT_NAME%.java-args" == "dsconfig.java-args" goto checkdsconfigJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldappasswordmodify.java-args" goto checkldappasswordmodifyJavaArgs
if "%SCRIPT_NAME%.java-args" == "ldifsearch.java-args" goto checkldifsearchJavaArgs
if "%SCRIPT_NAME%.java-args" == "verify-index.java-args" goto checkverify-indexJavaArgs
if "%SCRIPT_NAME%.java-args" == "list-backends.java-args" goto checklist-backendsJavaArgs
goto end

:checkldapcompareJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkdsreplicationJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkupgradeJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkbase64JavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkstart-dsJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkldifmodifyJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkdbtestJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkbackup.offlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkmanage-accountJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkbackup.onlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkldapsearchJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkrestore.onlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkexport-ldif.offlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checksetupJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkencode-passwordJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkmake-ldifJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkcontrol-panelJavaArgs
set OPENDJ_JAVA_ARGS="-Xms64m" "-Xmx128m" "-client"
goto end

:checkmanage-tasksJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkstop-dsJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkrestore.offlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkldapmodifyJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkuninstallJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkldif-diffJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkimport-ldif.offlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkldapdeleteJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkdsreplication.offlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkcreate-rc-scriptJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkrebuild-indexJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkexport-ldif.onlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkimport-ldif.onlineJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkdsframeworkJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkstatusJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkdsconfigJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkldappasswordmodifyJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:checkldifsearchJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checkverify-indexJavaArgs
set OPENDJ_JAVA_ARGS="-Xms128m" "-Xmx256m"
goto end

:checklist-backendsJavaArgs
set OPENDJ_JAVA_ARGS="-Xms8m" "-client"
goto end

:end

