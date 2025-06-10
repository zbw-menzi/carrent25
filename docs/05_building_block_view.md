# Building Block View

## Whitebox Overall System

Das CarRent-System besteht aus mehreren Containern, die jeweils eine zentrale Aufgabe übernehmen. Die folgende Grafik zeigt die wichtigsten Container und deren Beziehungen:

```mermaid
C4Container
    System_Boundary(system, "CarRent-System") {
      Container(web, "Web-Frontend", "React/Vue/Angular", "Nutzeroberfläche für Kunden und Mitarbeitende")
      Container(api, "Backend/API", "Spring Boot/.NET/Node.js", "Geschäftslogik und Schnittstellen")
      ContainerDb(db, "Datenbank", "PostgreSQL/MySQL", "Persistenz von Nutzern, Fahrzeugen, Reservierungen")
      Container_Ext(pups, "PUPS API", "REST API", "Fahrzeugfreischaltung")
      Container_Ext(insurance, "Versicherungs-API", "REST API", "Schadensabwicklung")
    }
    Rel(web, api, "REST/HTTPS")
    Rel(api, db, "JDBC/ORM")
    Rel(api, pups, "REST/HTTPS")
    Rel(api, insurance, "REST/HTTPS")
```

Die Containerstruktur ermöglicht eine klare Trennung von Präsentation, Logik und Persistenz sowie die Anbindung externer Systeme.

## Level 2

### White Box *\<building block 1>*

*\<white box template>*

### White Box *\<building block 2>*

*\<white box template>*

…

### White Box *\<building block m>*

*\<white box template>*

## Level 3

### White Box \<\_building block x.1\_\>

*\<white box template>*

### White Box \<\_building block x.2\_\>

*\<white box template>*

### White Box \<\_building block y.1\_\>

*\<white box template>*
