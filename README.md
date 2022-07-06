# ESGI_C#

# Designs patterns

Ils répondent à des problèmes de conception POO , ils résulte de bonne pratique en POO.

## Pattern de structure ou de structuration

### intro

Les patterns de structuration permettent de faciliter l'indépendance de l'interface d'un objet et de son implémentation.

En fournissant les interfaces ce pattern permet d'encapsuler la composition des objets.

cela augmente le niveau d'abstraction d'un système donné un peu à la manière des patterns de créatoon qui encapsulent la création d'objects .

Ces pattern mettent en avant les interfaces.

### Bridge

Le pattern Bridge est utilisé pour séparer le comportement de l'implémentation de l'interface et de l'implémentation de l'object.

On s'intéresse au demande d'immatriculation des véhicules.

Le formulaire de demande d'immatriculation possède deux implémentation différentes .

Classe Abstraite : FormulaireImmat

Classe Fille :
* FormulaireImmatHTML
* FormulaireImmatAPP

Au départ le système a été conçu pour la France uniquement . Ensuite on a du créé une sous-classe FormulaireImmatCH. Elle aussi abstraite pour avoir également deux sous-classes concrètes (qui sont FormulaireImmaHTML et FormulaireImmatAPP dédiées à la Suisse)

Problème shématisé :
![](https://i.imgur.com/LUWZp7p.png)

Pattern Bridge schéma correctif:
![](https://i.imgur.com/DLbRckB.png)

Pattern Bridge schéma générale:
![](https://i.imgur.com/haodmSC.png)