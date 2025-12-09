DevOpsKurs – Projektöversikt

Det här projektet är min examinerande uppgift i DevOps-kursen.
Jag har byggt ett enkelt .NET 8 Web API i Visual Studio och kopplat det till en full CI/CD-pipeline i Azure DevOps.

Pipelinen gör allt automatiskt:

bygger projektet

kör tester

skapar en Docker-container

scannar efter sårbarheter

pushar containern till Azure Container Registry

deployar den till Azure Web App for Containers

Jag har även lagt till ett par enkla enhetstester (xUnit) och en Dockerfile som publicerar appen på port 8080, vilket används av Azure.

Målet med projektet var att visa att jag kan:

skapa och versionera kod

containerisera en applikation

sätta upp en fungerande CI/CD-kedja

automatisera deployment till Azure

Det här repo:t innehåller allt som behövs: API-koden, tester, Dockerfile och pipeline-definitionen.
