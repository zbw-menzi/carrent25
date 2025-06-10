# Context and Scope

## Business Context

Das CarRent-System interagiert mit verschiedenen Akteuren und externen Systemen. Die folgende Grafik zeigt die wichtigsten Beziehungen:

```mermaid
C4Context
    Person(customer, "Kunde", "Mietet Fahrzeuge über das System")
    System(system, "CarRent-System", "Online-Plattform für Fahrzeugmiete")
    System_Ext(pups, "ParkingUnlockProSystem (PUPS)", "Fahrzeugfreischaltung")
    System_Ext(insurance, "Versicherungs-Umsystem", "Schadensabwicklung")
    Person(admin, "Mitarbeiter", "Verwaltet Fahrzeuge und Verträge")
    
    Rel(customer, system, "Reserviert, mietet, gibt Fahrzeuge zurück")
    Rel(admin, system, "Verwaltet System und Fahrzeuge")
    Rel(system, pups, "Fahrzeugfreischaltung bei Abholung")
    Rel(system, insurance, "Schadensmeldungen bei Rückgabe")
```

Das CarRent-System steht im Zentrum und verbindet Kunden, Mitarbeitende und externe Systeme für einen reibungslosen Mietprozess.

## Technical Context

Das System wird als Webanwendung mit Backend und Datenbank betrieben. Externe Schnittstellen werden über APIs angebunden.
