# Brent's Magical Zoo
## overview
The goal was to build a zoo of animal to demonstrate the OOP principles of abstraction, inheritance, encapsulation, and polymorphism. This has no practical application.

## use
Currently, the application has no purpose or use case. If you wish to implement these classes in a zoological progect, you will need to grab all the classes to be certain you follow the complete inheritence tree.

## Architecture
The project is built to demonstrate the OOP priciples. The four principles are Abstraction, Encapsulation, Inheritance, and Polymorphism.

### Principles
#### Encapsulation
Encapsulation is the restriction of access/modification of properties and methods. Perhaps the cleanest example in this application is the Hydra and its heads. Anyone can look at a hydra and see how many heads it has, but to change the number of heads a hydra has you must invoke the `CutOffHead` method upon that hydra. That method requires in input parameter because the hydra's behavior is different depending upon how its head is cut off. By controlling access to the hydra's heads, I can force behavior to occur in the manner and under the conditions I desire.

#### Abstraction
Abstraction is, in brief, saying you want a thing to exist without caring about the details of what it is. For example, my Imaginary class says every imaginary item must have a Source(), but does not care what that source is. Further, Imaginary can have that abstraction because it is abstract itself - by the time we get to a class that can actually produce objects those abstractions have to be resolved.

#### Inheritance
The entire exercise is based upon inheritance. Specifically, all things in this "zoo" derive from the base class imaginary. To trace one specific lineage as an example, Dragon inherits from Lizard inherits from Animal inherits from Living inherits from Imaginary. This means Dragon has the behavior/requirements of being an Imaginary, Living, Lizard Animal AND any new code specific to being a dragon.

#### Polymorphism
Polymorphism, the final pillar of OOP. Polymorphism is the way one thing can have several different forms. As an example, my to move around and possess some form of Locomotion, but I don't care beyond that they must possess that method. The details are worked out later, further down the inheritance heirarchy. Indeed, I expect several animals to have completely different Locomotion() methods.
### Classes
#### Base abstract
Imaginary
This is the base class in the tree. It defines all derived classes as
- Having a property Exists = false;
- Having some form of a Sustanance() method // what does it eat? (1 abstract method)
- Having some form of a Size propterty //)
- Having some form of a Source() method // a mythological sources for the idea of the thing (2 abstract methods)

#### First derived abstract
Living
- Derives from Imaginary
- Adds a new Lifespan property (abstract)

Undead
- Derives from Imaginary
- Adds virtual Base property of "human"// Most undead are human, but an undead dragon (for example) is seen in lore.
- Overrides size with "Depends on the base"
- Adds virtual Basis() method // Most undead were once a single living creature, but some are otherwise.
- Adds abstract SlainBy[] property

#### Second derived abstract
Animal
- derives from living
- adds virtual property Legs as 4
- adds virual property Heads as 1
- adds absract method of Locomotion() (3rd abstract method)

Plant
- derives from living
- Overrides Sustanance() with a new method that returns "sunlight"
- Overrides lifespan with indefinite. The mythological plants in my zoo don't die from age.

Sentient_Undead
- derives from Undead
- adds abstract Name property
- adds abstract weaknesses[] property

#### Third derived abstract
Mammal
- derives from Animal
- Adds property blooded of "warm"

Lizard
- derives from Animal
- adds property LaysEggs of true
- adds property HasScales of true

#### Concrete classes
- DevilsSnare derives from Plant
- Ent derives from Plant
- Dragon derives from Lizard
- Hydra derives from Lizard
- Cerebus derives from Mammal
- Zombie derives from Undead
- Vampire derives from Sentient_Undead
- Lich derives from Sentient_Undead

## Sources
Wikipedia confirmed some information about the source material and especially the publication dates.