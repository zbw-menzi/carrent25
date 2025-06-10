# Welcome to CarRent

[TOC]

## Vision

Das CarRent-System ermöglicht es Kunden, Fahrzeuge verschiedener Klassen einfach online zu reservieren, zu mieten und zurückzugeben. Ziel ist es, den gesamten Mietprozess – von der Registrierung über die Reservierung, Fahrzeugabholung (inkl. automatischer Freischaltung) bis zur Rückgabe und Schadensabwicklung – digital, effizient und benutzerfreundlich abzubilden. Die Integration externer Systeme (z.B. ParkingUnlockProSystem, Versicherungs-Umsystem) sorgt für einen reibungslosen Ablauf und hohe Servicequalität.

**Kernfunktionen:**

- Kundenregistrierung mit automatischer Vergabe einer Kundennummer (KNR00000)
- Fahrzeugreservierung nach Klasse, Zeitraum und Kostenberechnung, mit Vergabe einer Reservationsnummer (RNR00000)
- Verwaltung von Fahrzeugen mit Klassenzuordnung und Tagesgebühr
- Umwandlung von Reservationen in Mietverträge bei Abholung (inkl. PUPS-Integration)
- Rückgabeprotokoll und Schadensabwicklung mit Weiterleitung an Versicherungssystem

## C4 Model Overview

Das CarRent-System wird nach dem C4-Modell dokumentiert. Die Details finden sich in den jeweiligen Kapiteln der Dokumentation.

### 1. Context (siehe [03_context_and_scope.md](03_context_and_scope.md))

- Zeigt das CarRent-System im Zusammenspiel mit Kunden, externen Systemen (PUPS, Versicherung) und weiteren Akteuren.

### 2. Container (siehe [05_building_block_view.md](05_building_block_view.md))

- Beschreibt die Haupt-Software-Container (z.B. Web-Frontend, Backend, Datenbank) und deren Interaktionen.

### 3. Component (siehe [05_building_block_view.md](05_building_block_view.md))

- Detailliert die wichtigsten Komponenten innerhalb der Container (z.B. User Management, Reservation Service, Vehicle Management).

### 4. Deployment (siehe [07_deployment_view.md](07_deployment_view.md))

- Zeigt, wie die Container auf die Infrastruktur verteilt werden (z.B. Cloud, On-Premises).