# Deployment View

## Infrastructure Level 1

Das folgende Diagramm zeigt die beispielhafte Verteilung der System-Container auf die Infrastruktur:

```mermaid
C4Deployment
    Node(browser, "Browser", "Kunde/Mitarbeiter")
    Node(webserver, "Webserver", "Hostet Web-Frontend")
    Node(appserver, "App-Server", "Hostet Backend/API")
    Node(dbserver, "DB-Server", "Hostet Datenbank")
    Node_Ext(pups, "PUPS-System")
    Node_Ext(insurance, "Versicherungs-System")
    
    Rel(browser, webserver, "HTTPS")
    Rel(webserver, appserver, "HTTPS")
    Rel(appserver, dbserver, "JDBC/ORM")
    Rel(appserver, pups, "REST/HTTPS")
    Rel(appserver, insurance, "REST/HTTPS")
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
