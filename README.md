# ESGI_C#

# Designs patterns

Ils répondent à des problèmes de conception POO , ils résulte de bonne pratique en POO.

## Pattern de conception

### Singleton 

Singleton est un patron de conception de création qui garantit que l’instance d’une classe n’existe qu’en un seul exemplaire, tout en fournissant un point d’accès global à cette instance.

Le pattern singleton permet est utilisé pour créer une instance unique de classe.

D'autre pattern comme le pattern Abstract Factory est suceptible d'utiliser ce type d'instance unique.

L'application va utiliser la classe liasse vierge qui ne possédera qu'une seule instance.

![](https://i.imgur.com/XOyH7yi.png)

![](https://i.imgur.com/yPcEoYz.png)

Chaque classe qui utilise la liasse vierge doit avoir accès à la même instance. On doit surtout s'arranger pour qu'on ne puisse pas en créer de nouvelles