# Designs patterns

Ils répondent à des problèmes de conception POO , ils résulte de bonne pratique en POO.

## Abstract Factory

Ce design pattern permet de séparer la création d'objets dérivant d'une classe mère. Cela permet de crée plusieurs objets issue d'une même classe mère.

### Scooter 

![](https://i.imgur.com/VHKNcU9.png)

Scooter est une classe abstraite , le catalogue contient des types scooter . Et les classe ScooterElectricté et Scooteressence hérite de Scooter.

![](https://i.imgur.com/DWLqZLU.png)

Ce schéma est une représentation générique du dessign pattern.

La classe abstraite ProduitAbstraitB équivaut à Scooter 
La classe abstraite ProduitAbstraitA équivaut à Automobile