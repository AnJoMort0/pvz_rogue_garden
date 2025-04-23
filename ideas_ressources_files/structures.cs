
//template_structure
    string  description = "A fallen log.";                                          //simple description of the structure and its abilities
    double  hp          = ;                                                         //hit points (hp) is counted in peas. These cannot be healed
    string  special     = "Launches rockets at ZCorp Consultants specifically.";    //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line.
    bool    gravebuster = false;                                                    //can it be destroyed by grave buster ?
    bool    hot_potato  = false;                                                    //can it be destroyed by hot potato ?
    bool    EMPeach     = false;                                                    //can EMPeach temporarily disable it ?
    string  origin      = "Rogue Garden";                                           //game(s) or mod(s) of origin.

//copy-paste
    string  description = "";
    double  hp          = ;
    string  special     = "";
    bool    gravebuster = ;
    bool    hot_potato  = ; 
    bool    EMPeach     = ;
    string  origin      = "";

//gravestone
    string  description = "Gravestones are the classical PvZ structure.";
    double  hp          = ;
    double  special     = "Can spawn zombies during Final Waves.";
    bool    gravebuster = true;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 1";

//engraved_gravestone
    string  description = "A gravestone engraved with great skill makes great zombies.";
    //double  hp        = n/a;
    string  special     = "Uneffected by plant attacks. Zombies that rise from them have 125% hp. Can spawn non-Imp and non-Gargantuar, except Cursed Gargolith, zombies during Final Waves.";
    bool    gravebuster = true;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "Rogue Garden";

//impstone
    string  description = "An undersized gravestone, perfect for throwing.";
    double  hp          = ;
    string  special     = "Spawns a CR 2 or less imp on every Huge and Final Wave.";
    bool    gravebuster = true;
    bool    hot_potato  = false;
    bool    EMPeach     = false;
    string  origin      = "Rogue Garden ; PvZ Heroes (Cursed Gargolith)";

//surfboard
    string  description = "Surfer Zombie's Surf Board";
    double  hp          = ;
    string  special     = "Weak to fire projectiles.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2";

//camping_tent
    string  description = "A tent filled with more zombies than it can fit.";
    double  hp          = ;
    string  special     = "Continuously spawns basics.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2";

//frozen_plant
    string  description = "A frozen plant. It's in ice. Cause it's frozen.";
    double  hp          = ;
    string  special     = "Gets slowly melted when near fire plants.";
    bool    gravebuster = false;
    bool    hot_potato  = true; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2";

//sheep
    string  description = "Plants metamorphed into sheep by Wizard Zombie.";
    //double  hp        = n/a;
    string  special     = "Uneffected by plant attacks. Disappears once the Wizard Zombie that spawned them dies.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2";

//zombie_octopus
    string  description = "Zombie Octopus are lobbed by Octopus Zombie and entangle plants.";
    double  hp          = ;
    string  special     = "When destroyed reveals the plant that it was entangling.";
    bool    gravebuster = false;
    bool    hot_potato  = true; 
    bool    EMPeach     = false;

//zombie_statue
    string  description = "A surprisingly life-like statue of a zombie. Or I guess death-like.";
    double  hp          = ;
    string  special     = "If it reaches 0hp it'll turn into a Bust Head Zombie, unless killed by a gravebuster.";
    bool    gravebuster = true;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2";

//construction_site
    string  description = "A tile undergoing construction.";
    //double  hp        = n/a;
    string  special     = "Disappears after 10 zombies pass on it. Construction zombies count double.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "Rogue Garden";

//mr_freezy
    string  description = "A Zombot-class robot, specializing in frost.";
    double  hp          = ;
    string  special     = "Creates artificial ice winds in a 4x3 area in front of itself.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = true;
    string  origin      = "PvZ Garden Warfare";

//dr_heals
    string  description = "A Zombot-class robot, specializing in healing.";
    double  hp          = ;
    string  special     = "Passively heals zombies in a plus shaped area.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = true;
    string  origin      = "PvZ Garden Warfare";

//loudmouth_bot
    string  description = "A Zombot-class robot, specializing in sound production.";
    double  hp          = ;
    string  special     = "Stuns plants in a 1x3 area in front of itself.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = true;
    string  origin      = "PvZ Garden Warfare";

//speaker
    string  description = "Zomboss' trusty music speakers.";
    double  hp          = ;
    string  special     = "Sends sound waves that passively damage plants up to 3 tiles in front of it, except ground plants and Phat Beets.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = true;
    string  origin      = "PvZ 2";

//supply_barrel
    string  description = "A supply barrel rolled by a Supply Barrel Roller Zombie.";
    double  hp          = ;
    string  special     = "Drops two Imps on the adjacent lanes after destruction.";
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2";

//gardener's_flower_pot
    string  description = "A Plant Pot that can't be shoveled or Planted On, is ignored by zombies and turns into a regular Plant Pot after three waves.";
    //double  hp          = n/a;
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "Rogue Garden";

//guard-gantuar_shield
    string  description = "The Guard-gantuar's honorary shield.";
    double  hp          = ;
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ 2 China";

//shylock's_dagger
    string  description = "The best tool to acquire your promised pound of flesh.";
    double  hp          = ;
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "Rogue Garden";

//shield_decoy
    string  description = "A paper cut-out of everyone's favourite All-Star.";
    double  hp          = ;
    bool    gravebuster = false;
    bool    hot_potato  = false; 
    bool    EMPeach     = false;
    string  origin      = "PvZ GW 2";