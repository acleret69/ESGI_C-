# ESGI_C#

# Designs patterns

Ils répondent à des problèmes de conception POO , ils résulte de bonne pratique en POO.

## Pattern de comportement

### intro

Les patterns de comportement distribuent les algorithmes/traitements entre les objets .
Ils organisent les interactions en renseignant le flux de contrôle et de traitement au sein d'un système d'objets

La distribution se fait soit par l'héritage soit par "délégation"

### chain of responsability

Le but est de contruire une chaine d'objets de manière à ce que si un objet de la chaine ne peut répondre à une requête, il puisse la passer à in "successeur" et ainsi de suite jusqu'à ce que l'un des objets puissent y répondre.

![](https://i.imgur.com/iM1qpCG.png)

structure concrète du pattern :
![](https://i.imgur.com/Qiu0sUn.png)

structure générique du pattern :
![](https://i.imgur.com/o85fUHO.png)