
/*
6.1
Erkläre Single Responsibility Principle (SRP).

Das Single Responsibility Principle besagt, dass eine Klasse nur eine einzige Verantwortlichkeit haben sollte. Das bedeutet, 
dass eine Klasse nur für eine bestimmte Funktion oder Aufgabe zuständig sein sollte.
Dadurch wird der Code einfacher zu verstehen, zu warten und zu erweitern, da Änderungen an einer Verantwortlichkeit nicht
unbeabsichtigte Auswirkungen auf andere Verantwortlichkeiten haben. 

6.2

Erkläre Open Closed Principle (OCP).

Das Open Closed Principle besagt, dass Softwarekomponenten für Erweiterungen offen, aber für Änderungen geschlossen sein sollen.
Neue Funktionen sollten durch Erweiterung (z. B. neue Klassen oder Implementierungen) hinzugefügt werden, ohne bestehenden Code verändern zu müssen.


6.3

Erkläre Dependency Inversion Principle (DIP).

Das Dependency Inversion Principle besagt, dass hochwertige Module nicht direkt von konkreten Klassen abhängen sollen, sondern von Abstraktionen wie Interfaces.
Dadurch wird der Code flexibler, austauschbarer und leichter testbar.

6.4

Finde ein Beispiel aus deinem Code.

Ein Beispiel ist die Verwendung eines Interfaces wie `IRateable`.
Klassen wie `Dragon` oder `Spider` implementieren dieses Interface, sodass andere Teile des Programms nur mit der Abstraktion (`IRateable`) arbeiten müssen und nicht von einer konkreten Klasse abhängig sind.
*/