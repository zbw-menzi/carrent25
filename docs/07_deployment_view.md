# Deployment View

## Infrastructure Level 1

Das folgende Diagramm zeigt die beispielhafte Verteilung der System-Container auf die Infrastruktur:

```mermaid
C4Deployment
title Deployment Diagram for Car Rental System

Deployment_Node(browser, "Browser", "Kunde/Mitarbeiter") {
    Container(web_frontend, "Web-Frontend", "React/Vue/Angular", "Nutzeroberfläche für Kunden und Mitarbeitende")
}

Deployment_Node(webserver, "Webserver", "Hostet Web-Frontend") {
    Container(web_frontend, "Web-Frontend", "React/Vue/Angular", "Nutzeroberfläche für Kunden und Mitarbeitende")
}

Deployment_Node(appserver, "App-Server", "Hostet Backend/API") {
    Container(api, "Backend/API", "Spring Boot/.NET/Node.js", "Geschäftslogik und Schnittstellen")
}

Deployment_Node(dbserver, "DB-Server", "Hostet Datenbank") {
    ContainerDb(db, "Datenbank", "PostgreSQL/MySQL", "Persistenz von Nutzern, Fahrzeugen, Reservierungen")
}

Deployment_Node_Ext(pups, "PUPS-System")
Deployment_Node_Ext(insurance, "Versicherungs-System")

Rel(browser, web_frontend, "HTTPS")
Rel(web_frontend, api, "REST/HTTPS")
Rel(api, db, "JDBC/ORM")
Rel(api, pups, "REST/HTTPS")
Rel(api, insurance, "REST/HTTPS")
```

Die Container werden auf dedizierten Servern oder Cloud-Ressourcen betrieben. Externe Systeme werden über das Internet angebunden.

## Infrastructure Level 2

### *&lt;Infrastructure Element 1&gt;*

*&lt;diagram + explanation&gt;*

### *&lt;Infrastructure Element 2&gt;*

*&lt;diagram + explanation&gt;*

…

### *&lt;Infrastructure Element n&gt;*

*&lt;diagram + explanation&gt;*
