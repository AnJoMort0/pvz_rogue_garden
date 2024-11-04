
//template_structure
    string  description = "A fallen log.";                                          //simple description of the structure and its abilities
    double  hp          = ;                                                         //hit points (hp) is counted in peas. These cannot be healed
    string  special     = "Launches rockets at ZCorp Consultants specifically.";    //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line.
    bool    gravebuster = false;                                                    //can it be destroyed by grave buster ?
    bool    hot_potato  = false;                                                    //can it be destroyed by hot potato ?

//copy-paste
    string  description = "";
    double  hp          = ;
    string  special     = "";
    bool    gravebuster = ;
    bool    hot_potato  = ; 

//gravestone
    string  description = "Gravestones are the classical PvZ structure.";
    double  hp          = ;
    bool    gravebuster = true;
    bool    hot_potato  = false; 

//engraved_gravestone
    string  description = "A gravestone engraved with great skill makes great zombies.";
    //double  hp        = n/a;
    string  special     = "Uneffected by plant attacks. Zombies that rise from them have 125% hp.";
    bool    gravebuster = true;
    bool    hot_potato  = false; 

//impstone
    string  description = "An undersized gravestone, perfect for throwing.";
    double  hp          = ;
    string  special     = "Spawns a CR 2 or less imp on every Huge and Final Wave.";
    bool    gravebuster = true;
    bool    hot_potato  = false;

//camping_tent
    string  description = "A tent filled with more zombies than it can fit.";
    double  hp          = ;
    string  special     = "Continuously spawns basics.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 

//frozen_plant
    string  description = "A frozen plant. It's in ice. Cause it's frozen.";
    double  hp          = ;
    string  special     = "Gets slowly melted when near fire plants.";
    bool    gravebuster = false;
    bool    hot_potato  = true; 

//sheep
    string  description = "Plants metamorphed into sheep by Wizard Zombie.";
    double  hp          = ;
    string  special     = "Uneffected by plant attacks. Disappears once the Wizard Zombie that spawned them dies.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 

//zombie_octopus
    string  description = "Zombie Octopus are lobbed by Octopus Zombie and entangle plants.";
    //double  hp        = n/a;
    bool    gravebuster = false;
    bool    hot_potato  = true; 

//zombie_statue
    string  description = "A surprisingly life-like statue of a zombie. Or I guess death-like.";
    double  hp          = ;
    string  special     = "If it reaches 0hp it'll turn into a Bust Head Zombie, unless killed by a gravebuster.";
    bool    gravebuster = true;
    bool    hot_potato  = false; 