
//This is the full list of zombotany zombie variants for all the various plants, yes, ALL the various plants. Any plants added to the "plant_list.cs" will be have a unique zombotany.

//template_zombotany
    string  phead       = "Grass";                                       //name of the plant head
    string  zbody       = "Browncoat Basic";                             //zombie to be used for body, generally speaking, this would be the Browncoat Basic, but it can be the Brownparka for cold plants or the ZCorp for futuristic/high techy plants for example
    string  description = "Grass, but dead";                             //basic description of the zombie and its abilities (if available, you can easily take it straight from its game of origin)
    double  hp          = 6;                                             //hit points (hp) is counted in peas and should be taken from the plant's list and not the zombie's
    double  armour      = 0;                                             //if relevant, add the hp of potential armour (i.e. Cone), if not "double armour = 0"
    int     cr          = 1;                                             //CR stands for Challenge Rating, being the amount of "points" needed to spawn (+CR = Spawns later/less often) and therefore should be base on how threatening the zombie is. A zombotany specific guide will be made in due time, but winging it usually works too.
    double  speed       = normal;                                        //speeds written after template
    double  dmg         = 1;                                             //damage (dmg) is counted in peas - yes, even the zombies'. This is related to the melee eating damage of the zombie
    double  aps         = 2;                                             //aps stands for attacks per second, aka how fast the zombie attacks. This is related to the melee eating damage of the zombie
    string  projectile  = "pea";                                         //from the projectiles_list. This refers to the zombie's plant attack
    int     ai          = 1;                                             //mesured in seconds - ai stands for attack interval, aka time between each attack, aka how fast the plant attacks. This refers to the zombie's plant attack
    double  range       = line;                                          //measured in tiles or 'line;' or 'garden', range of sight of the plant. This refers to the zombie's plant attack                                     
    string  special     = "Is very good at dying.";                      //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line. This is also where you include Magnet-shroom weakness. Note : by default, zombies can't spawn on water or on air at all, so add precisions such as "Can spawn" or "only spawns in water" for the pool and "Flies towards the roof" (Flying zombies fly at "roof height", so if a peashooter is placed on the roof it'll be able to shoot the flying zombies) when necessary.
    string  almanac     = "Let's double the plant's almanac entries !";
    string  origin      = "Rogue Garden";                                //game(s) or mod(s) of origin - Add the game of origin of the plant, taken from the list and the game of origin of the zombotany if taken from one.

double  slower   = 1;
double  slow     = 2;
double  normal   = 3;
double  fast     = 4;
double  faster   = 5;
    
//copy-paste
    string  phead       = "";                                
    string  zbody       = "";                                
    string  description = "";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = ;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = 1;                 
    double  range       = line;                                     
    string  special     = "";                      
    string  almanac     = "";
    string  origin      = "Rogue Garden";  

//sunflower_zombie
    string  phead       = "Sunflower";                                
    string  zbody       = "Flag Zombie";                                
    string  description = "She might look nice but remember: zombie sun-production just means more zombies.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    //int     cr        = n/a;                                               
    double  speed       = slow;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                     
    string  special     = "Heals zombies that pass by her by 2hp.";                      
    string  almanac     = "How does sun production translate to healing, you ask ? It doesn't : announcing Huge Waves does. The healing comes from the flag. It's a family heirloom.";
    string  origin      = "Rogue Garden"; 

//twin_sunflower_zombie
    string  phead       = "Twin Sunflower";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "Twin Sunflower has come to heal the Zombotany Army.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = 6;                                               
    double  speed       = slow;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                     
    string  special     = "Every few seconds, heals all zombies in an 'plus' formation centered on herself for 2hp.";                      
    string  almanac     = "Okay, now you must really be wondering what justifies the healing from sunflowers. Well, Garden Warfare does.";
    string  origin      = "Rogue Garden"; 

//metal_petal_zombie
    string  phead       = "Metal Petal";                                
    string  zbody       = "Browncoat Basic";                               
    string  description = "Though her healing might not be the best, be warry of her health.";                      
    double  hp          = 80;                                           
    double  armour      = 0;                                       
    int     cr          = 7;                                               
    double  speed       = slow;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                     
    string  special     = "Heals zombies that pass by her by 2hp.";                      
    string  almanac     = "Unlike Medic Zombie, Metal Petal actually has a medical degree.";
    string  origin      = "Rogue Garden";   

//peashooter_zombie                                                                             
    string  phead       = "Peashooter";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "A rare sort, Peashooter Zombie has a Peashooter for a head and fires peas. This is why our scientists have called him Peashooter Zombie. They're very clever people you know.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = 1;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = "pea"; 
    int     ai          = 1.5;                 
    double  range       = line;                                                         
    string  almanac     = "Now, you might enjoy peas with your dinner, but when you combine a pea and a zombie you're in for big trouble. Big green trouble. That fires peas. Dinner doesn't sound so appealing now, eh?!";
    string  origin      = "PvZ 1";     

//peapod_zombie                              
    string  phead       = "Peapod";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "Peapod Zombie grows in power as he advances.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = 4;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = "pea"; 
    int     ai          = burst(n, 1.5);                 
    double  range       = line;                                     
    string  special     = "After every 2 rows grows an extra head (n + 1) up to 5.";                      
    string  almanac     = "The Mad Chemist Zombie is at fault for the late arrival of most of Peapod Zombie's heads. 'Who would've known plant food wouldn't have worked on a zombie hybrid?', he said.";
    string  origin      = "Rogue Garden";

//skyshooter_zombie
    string  phead       = "Skyshooter";                                
    string  zbody       = "Balloon Basic";                                
    string  description = "What's scarier than a zombie with a peashooter head ? A flying zombie with a peashooter head.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = 1;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = "pea"; 
    int     ai          = 1.5;                 
    double  range       = line;                                     
    string  special     = "Flies towards your roof.";                      
    string  almanac     = "Though he still has a rotor leaf, Skyshooter Zombie still can't fly without his balloon, he tied the rope too hard and now he can't unknot it.";
    string  origin      = "Rogue Garden";  

//repeater_zombie
    string  phead       = "Repeater";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "Twice as fast as a Peashooter Zombie...";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = 3;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = "pea"; 
    int     ai          = burst(2, 1.5);                 
    double  range       = line;                                                          
    string  almanac     = "... and twice as angry.";
    string  origin      = "Rogue Garden"; 

//threepeater_zombie
    string  phead       = "Threepeater";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "He shoots three peas in three lanes.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                       
    int     cr          = 4;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = "pea"; 
    int     ai          = 1.5;                 
    double  range       = line;                                     
    string  special     = "Shoots 3 peas, one in its line; and one in each adjacent line";                      
    string  almanac     = "Threepeater Zombie's heads are much less in synch than their plant counterparts. No wonder they've never fully eaten brain.";
    string  origin      = "Rogue Garden"; 

//gatling_pea_zombie    
    string  phead       = "Galting Pea";                                
    string  zbody       = "Foot Soldier Zombie";                                
    string  description = "Be warry: he's a fast attacker with tough armor.";                      
    double  hp          = 6;                                           
    double  armour      = 6;                                       
    int     cr          = 5;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = "pea"; 
    int     ai          = burst(4, 1.5);                 
    double  range       = line;                                                           
    string  almanac     = "Even though he litteraly took it from a Gatling Pea, Galting Pea Zombie's helmet is actually useful.";
    string  origin      = "PvZ 1"; 

//wallnut_zombie
    string  phead       = "Wallnut";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "He's a tough fellow to crack! Get it? Wall-nut? Crack? Who says people who write zombie survival guides for the Government don't have a sense of humour!";                      
    double  hp          = 80;                                           
    double  armour      = 0;                                       
    int     cr          = 4;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                                           
    string  almanac     = "Being half nut, Wall-nut Zombie knows how to easily crack a tough shell and get to the nut inside. And by shell we mean your skull. And by nut! we mean your brains. Sorry about that.";
    string  origin      = "PvZ 1"; 

//tall-nut_zombie
    string  phead       = "Tall-nut";                                
    string  zbody       = "Browncoat Basic";                                
    string  description = "Tall-nut Zombie's height is his biggest strenght.";                      
    double  hp          = 160;                                           
    double  armour      = 0;                                       
    int     cr          = 10;                                               
    double  speed       = slow;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                                          
    string  almanac     = "Tall-nut Zombie really likes being tall. It insures he gets the best view at concerts and flesh buffets.";
    string  origin      = "PvZ 1"; 

//sweet_potato_zombie
    string  phead       = "Sweet Potato";                                
    string  zbody       = "Browncoat Zombie";                                
    string  description = "Sweet as a Sweet Potato, deadly as a zombie.";                      
    double  hp          = 80;                                           
    double  armour      = 0;                                       
    int     cr          = 7;                                               
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                     
    string  special     = "Moves zombies behind her from neighbouring lanes into her own.";                      
    string  almanac     = "Sweet Potato Zombie really looked up to Brain Vendor Zombie before the fusion, then he became his biggest competitor. But Sweet Potato Zombie never stopped looking up to it.";
    string  origin      = "Rogue Garden";                        