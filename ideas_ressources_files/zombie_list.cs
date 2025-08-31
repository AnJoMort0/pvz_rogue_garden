
//This is the full list of zombies, which will have an almanac in the game. There will be adjustements with play-testing and many of these will take a long to time actually join the game. Any ideas are welcome as long as you follow the guidelines according to the comented template. You are welcome to propose changes and give feedback.

//template_category
    //template_zombie                               //think of including the words "Imp", "Zombie" or "Gargantuar" to the zombie's name if it doesn't already include a reference to its zombie status (i.e. Abracadaver, ZCorp). You can also include "variant_X:---" for special variants of zombies, and "elite_X:---" for elite versions of the zombies for ultra late-game.
        string  description = "blablabla";          //basic description of the zombie and its abilities (if available, you can easily take it straight from its game of origin)
        double  hp          = 10;                   //hit points (hp) is counted in peas
        double  armour      = 0;                    //if relevant, add the hp of potential armour (i.e. Cone), if not "double armour = 0"
        int     cr          = 1;                    //CR stands for Challenge Rating, being the amount of "points" needed to spawn (Higher CR means the zombie spawns later/less often) and therefore should be based on how threatening the zombie is. Check the CR Calculator to see a more in depth description of what CR is and get some help to decide it.
        double  speed       = normal;               //speeds written after template
        double  dmg         = 1;                    //damage (dmg) is counted in peas - yes, even the zombies'. Note: the average non-wall plant will have 6 HP.
        double  aps         = 2;                    //aps stands for attacks per second, aka how fast the zombie attacks
        string  special     = "";                   //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line. This is also where you include Magnet-shroom, Umbrella Leaf and other plant based weaknesses. Note: by default, zombies can't spawn on water or on air at all, so add precisions such as "Can spawn" or "only spawns in water" for the pool and "Flies towards the roof" (Flying zombies fly at "roof height", so if a peashooter is placed on the roof it'll be able to shoot the flying zombies) when necessary.
        string  almanac     = "ladders on sale";    //almanac entry, be it copied from one of the original games or entirely/partially new
        string  origin      = "Rogue Garden";       //game(s) or mod(s) of origin - add the original name of the zombie if the name changes for this (i.e. Monitor Head: string origin = "PvZ Battle for Neighbourville (TV Head)") as well as the origing of its gimmicks (i.e. Mad Chemist Zombie: string origin = "PvZ Heroes ; PvZ 2 (Dark Ages Potions)")

double  slower   = 1;
double  slow     = 2;
double  normal   = 3;
double  fast     = 4;
double  faster   = 5;

    //copy-paste
        string  description = "";
        double  hp          = 10;
        double  armor       = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "";
        string  origin      = "";

//special_lists
    //zombie_animals
string list     = "Zombie Chicken, Zombie Fire Rooster, Fraidy Cat, Zombie Monkey, Zombie Parrot, Zombie Pigeon, Hover-Goat 3000, Zombie Dove, Zombie Rabbit, Zombie Rat,  Zombie Walrus, Zombie Bull, Zombie Dog, Zom-Bats";
    
    //animal_herders
string list     = "Beast Zombie Handler, Chicken Wrangler Zombie, Fire Rooster Wrangler Zombie, Dog Walker Zombie, Loose Leash Zombie, Pack Leader Zombie, Cat Lady Zombie, Squirrel Herder Zombie, Turkey Rider Imp, Monkey Smuggler Zombie, Captain Deadbeard, Captain Flameface, Pigeon Feeder Zombie, Dolphin Rider Zombie, Seahorse Rider Zombie, Abracadaver, Pied Piper Zombie, Dodo Fossil Rider Imp, Smelly Zombie, Trapper Zombie, Octo Zombie, Bull Rider Imp, Walrus Rider Imp";

    //instrument_playing_zombies
string list     = "Tuba Zombie, Keytar Zombie, Undead Flamenco Dancers, Jack-in-the-box Zombie, Conga Drummer, Royal Horn Imp, Fanfare Trumpet Zombie, Fanfare Cymbals Zombie, Fanfare Snare Drum Zombie, Fanfare French Horn Zombie, Double Bass Zombie, Phantasmal Violinist";

    //zombies_with_mustache     list will expand as images are made
string list     = "Mixed-up Gravedigger Zombie, Backup Disco Zombie, Umbrella Zombie, Park Ranger Zombie, Bonus Track Buckethead";

    //robots_zcorp_maintenance_drone_can_attach_to
string list = "ZCorp Drone, ZCorp Swarm Drone, ZCorp EMP Drone, ZCorp Shield Generator, Neutron Imp, Cryoton Imp, Photon Imp, Proton Imp, Electron Imp, Hover-Goat 3000";

//Note: The game presents mutliple zombie body types. These are divided into three main categories; Imp, Zombie and Gargantuar that are tracked seperately for certain abilities. Zombies are also split into three body types, the only difference in these is appearance. These are; Regular - your typical browncoat body type, Bully - the pusher type zombies from PvZ 2, and Grunt - the fat worker type from PvZ1 (in Digger Zombie) or GW (in the Engineer)

//basics
        
    //browncoat_zombie
        string  description = "Regular Garden-variety Zombie.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "This zombie loves brains. Can't get enough. Brains, brains, brains day in and night out. Old and stinky brains? Rotten brains? Brains clearly past their prime? Doesn't matter: Browncoat Zombie wants'em.";
        string  origin      = "PvZ 1";

    //flag_zombie
        string  description = "Flag Zombie announces the arrival of many things, notably Huge Waves of zombies.";
        double  hp          = 10;
        double  armour      = 0;
        //int   cr          = n/a;
        double  speed       = fast;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "Make no mistake, Flag Zombie loves brains. In fact, he called himself Brain - unfortunately his spelling impairment led to his ID saying 'Brian' instead. However, somewhere down the line he also picked up a fascination with flags. Maybe it's because the flags always have brains on them. Hard to say.";
        string  origin      = "PvZ 1";
        //for every respective event variant, please reffer to "flagz_list.cs"

    //conehead_zombie
        string  description = "His traffic cone headpiece makes him twice as though as normal zombies.";
        double  hp          = 10;
        double  armour      = 18;
        int     cr          = 2;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "Conehead Zombie shuffled mindlessly forward like every other zombie. But something made him stop, made him pick up a traffic cone and put it on his head.";
        string  origin      = "PvZ 1";

    //screen_door_zombie
        string  description = "His screen door is an effective shield.";
        double  hp          = 10;
        double  armour      = 58;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Screendoor blocks incoming, non-piercing attacks from the front and can be removed by magnet-shroom.";
        string  almanac     = "He got his screen door from the last inexpertly defended home he visited, after he ate the homeowner's brains.";
        string  origin      = "PvZ 1";

    //buckethead_zombie
        string  description = "His bucket hat makes him extremely resistant to damage.";
        double  hp          = 10;
        double  armour      = 55;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Bucket can be removed by Magnetshroom";
        string  almanac     = "Buckethead Zombie always wore a bucket. Part of it was to assert uniqueness in an uncaring world. Mostly he just forgot it was there in the first place.";
        string  origin      = "PvZ 1";
    
    //brickhead_zombie
        string  description = "Brickhead Zombie's brick head provides thorough brickheaded brickheadness.";
        double  hp          = 10;
        double  armour      = 95;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "After consultation with various storybook wolves, it was determined that straw helmets and wood helmets were not up to snuff, and that brick helmets had to be seriously considered.";
        string  origin      = "PvZ 2";
    
            //variant_basic:ducky_tuber_zombie
                string  description = "The ducky tube allows this zombie to float on water.";
                //stats_of_relevent_basics
                string  special     = "Only spawns in the pool.";
                string  almanac     = "It takes a certain kind of zombie to be a Ducky Tuber. Not every zombie can handle it. Some crack. They can't take it. They walk away and give up on brains forever.";
                string  origin      = "PvZ 1";
                //for every respective basic variant, please reffer to "basics_list.cs"
                
            //variant_basic:balloon_zombie
                string description  = "A regular airborn zombie.";
                //stats_of_relevent_basics
                string special      = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing.";
                string almanac      = "The original Balloon Zombie was quite disappointed to see that the basics picked up on his technique.";
                string origin       = "PvZ 1";
                //for every respective basic variant, please reffer to "basics_list.cs"

            //variant_basic:brownparka_zombie
                string description  = "The zombie's brown parka protects him from the cold.";
                //stats_of_relevent_basics
                string special      = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling.";
                string almanac      = "Though many see the use of thicker clothing as a simple survival instinct, Brown Parka Zombie disapproves of this theory. For him, it's all about fashion.";
                string origin       = "PvZ 2 (Frostbite Caves basic)";
                //for every respective basic variant, please reffer to "basics_list.cs"

            //variant_basic:zcorp_zombie
                string description  = "A typical ZCorp Incorporated employee.";
                //stats_of_relevent_basics
                string special      = "Only spawns during the 'Rush Hour' ambush or when spawned by the ZCorp Customer Service and Conga Leader Zombie.";
                string almanac      = "He was issued the standard ZCorp coffee mug at orientation.";
                string origin       = "PvZ 2";
                //for every respective basic variant, please reffer to "basics_list.cs"

//default_zombies
    
    //imp
        string  description = "A small zombie that shuffles through your defenses. Often thrown into it.";
        double  hp          = 5;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = fast;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  almanac     = "What he lacks in reach he more than makes up for with his bad attitude, or Zombattitude as he likes to call it. Don't encourage him.";
        string  origin      = "PvZ 2";

            //variant_imp:fishy_imp
                string  description = "It's just an imp, but with a fin.";
                //stats_of_imp
                string  special     = "Only spawns in the pool.";
                string  almanac     = "Throws the *best* pool parties.";
                string  origin      = "PvZ Heroes";

            //variant_imp:paper_plane_imp
                string  description = "It's just an imp, but on a paper plane.";
                //stats_of_imp
                string  special     = "Flies towards your roof.";
                string  almanac     = "Paper Plane Imp realized the cons of the old balloon and made a new needle-proof mode of aerial movement.";
                string  origin      = "Rogue Garden";

            //variant_imp:brownparka_imp
                string  description = "It's just an imp, but with a winter jacket.";
                //stats_of_imp
                string  spceial     = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling.";
                string  almanac     = "Brownparka Imp recently took up knitting. He started with a scarf, moved to mittens and eventually knitted an entire parka out of cloth he ripped off of Brownparka Gargantuar's brownparka.";
                string  origin      = "PvZ 2 (Yeti Imp)";

            //variant_imp:head_office_imp
                string  description = "Even imps have to work in this economy.";
                //stats_of_imp
                string  special     = "Only spawns during the 'Rush Hour' ambush or when spawned by the ZCorp Customer Service.";
                string  almanac     = "Head Office Imp's door is always open. It is, however, highly inadvisable to take him up on that offer.";
                string  origin      = "PvZ 2 (Head Office Impgantuar)";

    //gargantuar
        string  description = "Gargantuar is a gigantic zombie. He lobs an Imp at your garden after taking some damage.";
        double  hp          = 190;
        double  armour      = 0;
        int     cr          = 20;
        double  speed       = fast;
        double  dmg         = 9999999999;
        double  aps         = 0.5;
        string  special     = "Throws an Imp upon reaching half hp.";
        string  almanac     = "When Gargantuar walks, the Earth trembles. When he moans, other zombies fall silent. He is the zombie other zombies dream they could be. But he still can't find a girlfriend.";
        string  origin      = "PvZ 2";

            //variant_gargantuar:deep_sea_gargantuar
                string  description = "From the deep sea, straight to your pool.";
                //stats_of_gargantuar
                string  special     = "Only spawns in the pool. Throws a Fishy Imp upon reaching half hp.";
                string  almanac     = "Has every single issue of Deep Sea Quarterly, but rarely has time to read them.";
                string  origin      = "PvZ 2 ; PvZ Heroes";
            
            //variant_gargantuar:brownparka_gargantuar
                string  description = "Other than a jacket, it also has three imps instead of one.";
                //stats_of_gargantuar
                string  spceial     = "Only spawns during winter. Immune to chilling and reduces the freezing effect of chilling. Throws 3 Brownparka Imps, at 75%, 50% and 25% hp.";
                string  almanac     = "He very much hates those Imps on his back. The darn things are itchy. They're always stealing parts of his parka. But at this point, he'd probably miss them if they ever cleared up.";
                string  origin      = "PvZ 2 (Sloth Gargantuar)";

            //variant_gargantuar:gargantuar_legal
                string  description = "Only the best and the beast in the business.";
                //stats_of_gargantuar
                string  special     = "Only spawns during the 'Rush Hour' ambush. Throws a Head Office Imp upon reachinh half hp.";
                string  almanac     = "Gargantuar Legal delivers cease-and-desists the old-fashioned way: with a baseball bat.";
                string  origin      = "PvZ 2 (Gargimp Legal)";

//miscellaneous_zombies
    
    //cosmic_browncoat_zombie
        string  special     = "Spawns a browncoat or browncoat variant on the neighbourghing lanes once he dies.";
        string  origin      = "Rogue Garden";
    
    //zombie_yeti
        string  special     = "Once it walkes past 4 columns or once 2 waves have passed (whichever one comes first) he walks backwards and out of the garden. If he gets killed, drops a Yeti Lunch Box."; //rewards from yeti lunch box to be defined
        string  origin      = "PvZ 1 ; PvZ 2";

    //comsic_yeti
        string  special     = "Once it walkes past 4 columns or once 2 waves have passed (whichever one comes first) he walks backwards and out of the garden. If he gets killed, spawns 2 Yeti zombies.";
        string  origin      = "PvZ Heroes";

    //newspaper_zombie
        string  description = "His newspaper provides limited defence, but great entertainment.";
        double  hp          = 12;
        double  armour      = 12;
        int     cr          = 3;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Becomes angry if the newspaper breaks, which increases his stats.";
        string  almanac     = "Newspaper Zombie was *this* close to finishing his sudoku puzzle. No wonder he's freaking out.";
        string  origin      = "PvZ 1";

            //newspaper_zombie_angry
                double  hp      = 12;
                double  armour  = 0;
                double  speed   = fast;
                double  dmg     = 1;
                double  aps     = 4;

        //elite_newspaper_zombie:sunday_edition_zombie
            string  origin      = "PvZ 2";

        //elite_newspaper_zombie:newspaper_plane_zombie
            string special = "Occasionally throws Paper Plane Imps.";
            string origin  = "PvZ Heroes (Newspaper Zombie)";

    //pogo_zombie
        string  description = "Pogo Zombie hops to bypass your defenses.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Pogo stick can be removed by magnet-shroom. Jumps at 'fast' speed. Jumps over all plants instead of eating them, except tall-nut which makes him loose his pogo stick if he jumps into it.";
        string  almanac     = "Sproing ! Sproing ! Sproing !That's the sound of a powerful and effective zombie doing what he does best.";
        string  origin      = "PvZ 1";

        //elite_pogo_zombie:shifting_zombie
            string  special     = "Shifting Pogo can be removed by magnet-shroom. Jumps at 'fast' speed. Jumps over all plants instead of eating them, except tall-nut which makes him loose his pogo stick if he jumps into it. Every 2-3 plants he teleports forwards one tile and up or down a lane, shifting positions and avoiding attacks.";
            string  origin      = "Rogue Garden";

        //variant_pogo_zombie:seahorse_rider_zombie
            string  description = "Rides a seahorse to jump over your defenses.";
            double  hp          = 20;
            double  armour      = 0;
            int     cr          = 6;
            double  speed       = normal;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Only spawns in the pool. Jumps over all plants instead of eating them, except tall-nut which makes him loose his seahorse and drown.";
            string  almanac     = "His small skirt risks making him exposed, which gives him headaches.";
            string  origin      = "PvZ Endless Edition";

            //elite_seahorse_rider_zombie:tidal_rider_zombie
                string  special     = "Only spawns in the pool. Jumps over every two plant instead of eating them, except tall-nut which makes him loose his seahorse and drown, and dives under every other plant avoiding attacks while underwater.";
                string  origin      = "Rogue Garden";

    //king_of_the_grill_gargantuar
        string  description = "There's never enough hot dogs for this King of the Grill.";
        double  hp          = 190;
        double  armour      = 0;
        int     cr          = 25;
        double  speed       = fast;
        double  dmg         = 9999999999;
        double  aps         = 0.5;
        string  spcial      = "Only spawns in the summer. A Hot Dog Imp spawns in his garden every time he kills a plant.";
        string  almanac     = "Chillin' beside the ol' backyard grill, cookin' up some brains, hangin' with his zombies... that's the good unlife.";
        string  origin      = "PvZ Heroes";

    //hot_dog_imp
        string  description = "Much like hot dogs, Hot Dog Imp will slide trough your defenses.";
        double  hp = 7;
        double  armour = 0;
        int     cr = 2;
        double  speed = fast;
        double  dmg = 0.5;
        double  aps = 3;
        string  special = "Only spawns during summer. When he eats, he dashes forward, skipping ahead one tile and damaging the plant in the process."; 
        string  almanac = "He was THIS close to wearing the chicken costume, but darn it, Team Mascot Imp called it first.";
        string  origin = "PvZ 2"; 

    //smashing_gargantuar
        string  description = "Attacks faster than a regular gargantuar but doesn't throw an Imp.";
        double  hp          = 190;
        double  armour      = 0;
        int     cr          = 24;
        double  speed       = fast;
        double  dmg         = 9999999999;
        double  aps         = 1;
        string  almanac     = "When he phones home, it means something completely different.";
        string  origin      = "PvZ Heroes";

        //elite_smashing_gargantuar:giga_gargantuar
            string  origin      = "PvZ 1";

    //hippity_hop_gargantuar
        string  description = "Throws mystery eggs instead of imps, so be careful.";
        double  hp          = 190;
        double  armour      = 0;
        int     cr          = 25;
        double  speed       = fast;
        double  dmg         = 9999999999;
        double  aps         = 0.5;
        string  special     = "Only spawns during spring. Throws a Mystery Egg upon reaching half hp.";
        string  almanac     = "Sometimes, what has been seen... can't be unseen. This is one of those times.";
        string  origin      = "PvZ Heroes";
        
            //mystery_egg
                string  description = "Turns into a zombie after landing.";
                //stats are irrelevent
                string  special     = "Doesn't spawn naturaly, only thrown by Hippity Hop Gargantuar. Turns into a random CR 3 or less zombie or imp when he lands.";
                string  almanac     = "'Mommy, where do little Zombies come from?' Asked and answered.";
                string  origin      = "PvZ Heroes";

    //surprise_gargantuar
        string  description = "You might be annoyed that he looks the same, but it wouldn't be a surprise that way.";
        double  hp          = 190;
        double  armour      = 0;
        int     cr          = 23;
        double  speed       = fast;
        double  dmg         = 9999999999;
        double  aps         = 0.5;
        string special      = "Moves to a random lane upon reaching half hp. Throws a random imp, except Gargantuar-throwing Imps, in the lane he leaves and another in the lane he lands on.";
        string  almanac     = "Surprise! It's a brains-eating monster at your party!";
        string  origin      = "PvZ Heroes";

    //cosmic_imp
        string  special     = "When killed, disapates into 5 random imps in a cross formation centered on himself. Can't create Gargantuar-throwing Imps.";
        string  origin      = "PvZ Heroes";

    //imp-throwing_imp
        string  special     = "Creates a random imp on another random lane when hit. Doesn't create Gargantuar-throwing Imps.";
        string  origin      = "PvZ Heroes";

    //gargantuar-throwing_imp
        string  special     = "Creates a random gargantuar on another random lane upon death. Doesn't create Gargantuar-throwing Gargantuars.";
        string  origin      = "PvZ Heroes";

    //gargantuar-throwing_gargantuar
        string  special     = "Creates a random gargantuar on another random lane upon reaching half hp and upon death. Doesn't create Gargantuar-throwing Gargantuars.";
        string  origin      = "PvZ Heroes";

    //snowball_thrower_imp
        string  description = "An imp that can throw snow balls at range to cool down plants until they freeze into blocks.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = fast;
        double  dmg         = 0;
        double  aps         = 1;
        string  special     = "Only spawns during winter. Attacks from 4 tiles away. Projectiles hits plants until freezing instead of damaging.";
        string  almanac     = "Snow is wonderful, it can create snow statues, bobsled trails, and even fast velosity snow balls. Take that Snow Pea.";
        string  origin      = "PvZ 2 (Hunter Zombie)";

    //ice_pirate_zombie
        string  descritpion = "Freezes the front-most plant on her lane.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 2;
        double  aps         = 2;
        string  special     = "When she spawns, she adds two levels of freeze to the first plant in her lane. If spawing on an ice trail created by a Zomboni, freezes the first the plant in her lane and adds two levels of freeze to the first plant on the neighbouring lanes as well.";
        string  almanac     = "You wouldn't believe how many brains a chunk of space ice goes for on a black market. Let's just say, she's rolling in gray matter.";
        string  origin      = "PvZ Heroes";

    //chicken_wrangler_zombie
        string  special     = "Upon reaching a plant, being hit for a certain amount of damage or dieing, releases up to three Zombie Chickens on his lane and on each neighbourghing lane.";
        string  origin      = "PvZ 2";

            //zombie_chicken
                string  origin      = "PvZ 2";

        //elite_chicken_wrangler_zombie:fire_rooster_wrangler_zombie
            string  special     = "Upon reaching a plant, being hit for a certain amount of damage or dieing, releases a Zombie Fire Rooster on his lane and on each neighbourghing lane.";
            string  origin      = "PvZ Heroes (Fire Rooster) ; PvZ 2 (Chicken Wrangler)";

    //zombie_fire_rooster
        string  special     = "When a plant is placed on this lane, moves to a neighboring lane then shoots a fireball before continuing forwards.";
        string  origin      = "PvZ Heroes";

    //mixed-up_gravedigger_zombie
        string  description = "The Mixed-Up Gravedigger creates Gravestones all over the map.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Creates Gravestones on random tiles of the lawn. If the tile is occupied, no Gravestone is created. Shovel can be removed by magnet-shroom.";
        string  almanac     = "Digging graves is hard work, but seeing customers rise out of them makes it all worth it.";
        string  origin      = "PvZ Heroes ; PvZ 2 (Tomb Raiser Zombie)";

    //grave_robber_zombie
        string  description = "Robs Gravestones to become stronger.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Stops at every Gravestone he passes by and gets +3 hp and +1 dmg but damages them stlightly. Buffs are doubled on Engraved Gravestones and they take double damage.";
        string  almanac     = "Why not rob graves? They're not going to miss it. It's not like the dead are rising up or anything.";
        string  origin      = "PvZ Heroes";

    //parasol_zombie
        string  descritpion = "Her parasol provides protection from lobbed projectiles.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 5;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns during spring and summer daytime. Blocks the effects and damage of attacks from above on the tile(s) she's on but not the tiles around";
        string  almanac     = "Wealthy beyond reason, the Parasol Zombie lived a life of luxury - when what she craved was a life of adventure, never forgetting to bring her trusty parasol. 'In case it rains,' she explained - but it only came out sounding like 'Brains'.";
        string  origin      = "PvZ 2";

    //umbrella_zombie
        string  description = "His umbrella provides protection from lobbed projectiles.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 5;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns during fall and winter. More likely to spawn during Rain Storm events. Spawns with the umbrela closed, then opens it to jump over the first plant he encounters and keeps it open. While open, blocks attacks from above, removes splash damage and stops A.K.E.E's bouncing but doens't block status effects.";
        string  almanac     = "Life comes and goes, but proper manners are forever.";
        string  origin      = "PvZ 2 (Parasol Zombie) ; PvZ Heroes and PvZ China (Gentleman Zombie)";

    //campimp_porter
        string  description = "Drops a tent on death.";
        double  hp          = 14;
        double  armour      = 0;
        int     cr          = 9;
        double  speed       = slower;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Doesn't spawn during winter. On death, spawns a tent on the tile behind him.";
        string  almanac     = "Campimp Porter is stronger than he looks. He's also more charming, smarter and has a better education.";
        string  origin      = "PvZ 2 (Imp Porter)";

    //dog_walker_zombie
        string description = "His dog can smell newly placed plants, and chases after them.";
        double  hp              = 20;
        double  armour          = 0;
        int     cr              = 4;
        double  speed           = normal;
        double  dmg             = 1;
        double  aps             = 2;
        string  special         = "Dog walks and eats one tile ahead of the zombie. When a plant is placed on a neighbouring lane, moves to it.";
        string  almanac         = "Is the zombie walking the dog, or is the dog walking the zombie? Hard to say.";
        string  origin          = "PvZ Heroes";

        //variant_dog_walker_zombie:loose_leash_zombie
            string description = "His dog can smell newly placed plants, and *really* chases after them.";
            double  hp              = 20;
            double  armour          = 0;
            int     cr              = 4;
            double  speed           = normal;
            double  dmg             = 1;
            double  aps             = 2;
            string  special         = "Dog walks and eats one tile ahead of the zombie. When a plant is placed on a neighbouring lane, moves to it. Has a 1/4 chance to release the Zombie Dog after switching lanes.";
            string  almanac         = "Let's just say Loose Leash Zombie isn't very good at tying knots.";
            string  origin          = "PvZ Heroes (Dog Walker)";

    //elite_dog_walker_zombie:pack_leader_zombie
            string description      = "Be careful, he's got a wolf and many, many dogs.";
            double  hp              = 40;
            double  armour          = 0;
            int     cr              = 9;
            double  speed           = normal;
            double  dmg             = 1.5;
            double  aps             = 2;
            string  special         = "Wolf walks and eats one tile ahead of the zombie. When a plant is placed on a neighbouring lane, moves to it. Spawns a Zombie Dog behind him when he switches lanes.";
            string  almanac         = "He still hasn't answered on who his dog supplier is.";
            string  origin          = "PvZ Heroes (Dog Walker)";

            //zombie_dog
                string  origin      = "PvZ Heroes (Dog Walker)";

    //cat_lady_zombie
        string despcription = "Releases hers cats when she dies.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 0;
        double  aps         = 0;
        string  special     = "Releases a fraidy cat on her lane and on the two neighbouring lanes upon death.";
        string almanac      = "One of her cats is a Z-Tube celebrity.";
        string  origin      = "PvZ Heroes";
        
            //fraidy_cat_zombie
                string  description = "He really doesn't like instant plants.";
                double  hp          = 15;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = slow;
                double  dmg         = 2;
                double  aps         = 1;
                string  special     = "Gains a movement speed and aps buff, and moves to a random lane when an instant plant is used in its lane or neighbouring lanes.";
                string  almanac     = "What's a black cat's favorite color? Purrrrr-ple.";
                string  origin      = "PvZ Heroes";

    //overstuffed_zombie
        string  description = "He's so fat that eating heals him.";
        double  hp          = 40;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 3;
        double  aps         = 1;
        string  special     = "Upon eating a plant, he restores his health (up to full if over half and up to half if under half -> dropped arm)";
        string  almanac     = "His cholesterol level is off the charts, and yet he seems to be in remarkably good health.";
        string  origin      = "PvZ Heroes";

    //energy_drink_zombie
        string  description = "He moves around your lawn and drinks as he advances.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 5;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Moves to a neighbouring lane and gains a movement speed and aps buff every 3 columns.";
        string  almanac     = "He can quit any time he wants.";
        string  origin      = "PvZ Heroes";

    //sneezing_zombie
        string  description = "Prevents plant healing.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Whilst alive, plants in her garden cannot heal.";
        string  almanac     = "Flowers give her awful allergies and sickening sneezes. Is that why she wears one on her head?";
        string  origin      = "PvZ Heroes";

    //chimney_sweep_zombie
        string  description = "The Chimney Sweep Zombie aims for your chimney instead of your doors.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Spawns on the side of the house with a ladder. Climbs up and moves to either side of the roof by hanging onto the roof's edge. Then acts like normal until he reaches the chimney (making you lose).";
        string  almanac     = "Who needs backdoors when you have chimneys? It's a growth industry.";
        string  origin      = "PvZ Heroes";

    //unlife_of_the_party
        string  description = "The Unlife Of The Party is more robust the more zombies there are.";
        double  hp          = 10;
        double  armour      = 19;
        int     cr          = 5;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Gets +1 hp for every other zombie on his and neighboughring lanes.";
        string  almanac     = "His archenemy is the Wall-Flower. Oh yeah, he likes to party.";
        string  origin      = "PvZ Heroes";

    //paparazzi_zombie
        string  description = "The Paparazzi Zombie becomes stronger during events";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Camera can be removed by Magnetshroom. More likely to appear during concert and boss events. During events : hp = 30, speed = fast, dmg = 2, aps = 2 and gains a 1 tile ranged attack with the camera flash.";
        string  almanac     = "Why is everyone always screaming and running away in his photos?";
        string  origin      = "PvZ Heroes";

    //flag_con_zombie
        string  description = "The Flag Con Zombie brings dangers forth, but he never knows what it is.";
        string  special     = "Summons an ambush when killed.";
        string  almanac     = "Flag Con Zombie just loves flag zombies. Though he struggles to find a job fitting for a flag zombie, his dedication to flagmanship grants him a warm welcome to every annual Flag Convention.";
        string  origin      = "Rogue Garden";

    //trick-or-treater-zombie
        string  description = "The Trick-or-treater Zombie buffs the health or damage of nearby zombies after eating a plant.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 3;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns during fall. Gives +2 hp OR +1 dmg to a nearby zombie after eating a plant.";
        string  almanac     = "Trick or treat? He is haunted by that question - and by an answer that continues to elude him.";
        string  origin      = "PvZ Heroes";

    //exploding_imp
        string  description = "Sacrifices himself to break your walls.";
        double  hp          = 5;
        double  armour      = 0;
        int     cr          = 3;
        double  speed       = fast;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  special     = "Once he reaches a plant, he deals heavy damage to it and dies. Chilling and freezing disable the bomb.";
        string  almanac     = "You could say he's an IMPlosives expert.";
        string  origin      = "PvZ Heroes and GW";

    //squirrel_herder_zombie
        string  description = "Destroys a nut or a berry when she spawns.";
        double  hp          = 15;
        double  armour      = 0;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special = "Destroys the first nut or berry in her lane when she spawns";
        string  almanac = "The only thing more difficult than herding cats.";
        string  origin = "PvZ Heroes";

    //hamsterball_imp
        string  description = "A very fast imp hidden under an extra layer of protection.";
        double  hp          = 5;
        double  armour      = 40;
        int     cr          = 6;
        double  speed       = faster;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  special     = "Releases the 'faster' moving imp inside it when it's destroyed.";
        string  almanac     = "He likes felines a lot more than rodents, but the hamster ball was more useful than a litter box.";
        string  origin      = "PvZ 2 (Zombie Hamsterball)";

    //trash_can_zombie
        string  description = "A zombie holding a trash can, that then jumps into said trash can.";
        double  hp          = 10;
        double  armour      = 58;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Holds his trash can in front of him to block incoming projectiles. Once he or the trash can reaches half hp/armor, he jumps into the trash can. This stops him in place and protects him from all directions. After the trash can is destroyed he keeps walking at half hp.";
        string  almanac     = "Sadly the Trash Can Zombie isn't here to pick up litter, or offer helpful tips on how to recycle your vegetable peelings or glass. If you've been closely studying this book, you will have realized by now that this zombie wants to eat your brains. He just uses the trash can to protect himself, not tidy up. What a shame. That said Trash Can Zombie is all about recycling waste. In this case he's eager for you to recycle the 'waste' brains sloshing about in your skull into something better: his dinner.";
        string  origin      = "PvZ 1 Console Edition ; PvZ Heroes";

            //elite:trash_can_zombie:theatre_zombie
                string  special     = "Holds holds a skull in front of him to block incoming projectiles. Once he reaches 0 hp, the skull floats for a few seconds, to perform a shakespearian monolgue, blocking projectiles from all directions and forcing pults in that lane to target it.";
                string  origin      = "PvZ 3 (Actor Zombie)";

    //turkey_rider_imp
        string  description = "Gives all zombies strenghtening leftovers when he dies.";
        double  hp          = 17;
        double  armour      = 0;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  special     = "Gives all zombies on his garden +1 hp when he dies.";
        string  almanac     = "He insists that, as far as modes of transportation go, turkeys outperform dolphins, walruses, and fossils any day.";
        string  origin      = "PvZ Heroes";

    //coffee_zombie
        string  description = "Caffeinates his fellow zombies.";
        double  hp          = 25;
        double  armour      = 0;
        int     cr          = 12;
        double  speed       = fast;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "While alive, every zombie in his garden has double aps.";
        string  almanac     = "He's been trying to cut back.";
        string  origin      = "PvZ Heroes";

    //headstone_carver_zombie
        string  description = "Engraves Gravestones he passes by.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Stops by Gravestones he passes and turns them into Engraved Gravestones.";
        string  almanac     = "His epitaphs have been published on headstones around the world.";
        string  origin      = "PvZ Heroes ; PvZ 1 (Gravestones)";

    //ninjimp
        string description  = "A small zombie that sneaks past your defences.";
        double  hp          = 5;
        double  armour      = 0;
        int     cr          = 3;
        double  speed       = fast;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  special     = "After taking damage for the first time, he turns invisible for 4 tiles before reapearing.";
        string  almanac     = "His motto: Walk softly and carry a big nunchuck.";
        string  origin      = "PvZ Heroes (Mini-Ninja) ; PvZ 2 China (Bandit Zombie)";

    //stealth_imp
        string  description = "A small zombie that wanders through your defences, untraceable.";
        double  hp          = 5;
        double  armour      = 0;
        int     cr          = 3;
        double  speed       = fast;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  special     = "Only spawns at night. Remains invisible and sneaks past plants for as long as he has his night-vision goggles on. He takes out his night-vision goggles when in range of light producers and fire plants and they can be removed by magnet-shroom.";
        string  almanac     = "Gadget Scientist Zombie is behind the mysterious technology that allows these night-vision goggles to make Stealth Imp invisible.";
        string  origin      = "PvZ 3";

    //monkey_smuggler_zombie
        string  description = "The monkey smuggler sends out his monkey behind the floral wall.";
        double  hp          = 22;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Once he reaches a wall plant, he spawns a zombie monkey behind it.";
        string  almanac     = "Piracy is serious monkey business.";
        string  origin      = "PvZ Heroes";

            //zombie_monkey
                string  description = "The Zombie Money is released by the Monkey Smuggler Zombie to attack your offence.";
                double  hp          = 15;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = fast;
                double  dmg         = 1;
                double  aps         = 3;
                string  almanac     = "It has a strange fascination with lifting eyepatches.";
                string  origin      = "PvZ 2 ; PvZ Heroes (Monkey Smuggler)";
    
    //smelly_zombie
        string  description = "His nasty odor deals extra damage to non-defensive plants.";
        double  hp          = 25;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Deals passive damage to non-wall plants in a cross shaped area centered on him.";
        string  almanac     = "Casual acquaintances don't understand where his pets are. They don't realize that stinkflies can be such tender little friends.";
        string  origin      = "PvZ Heroes";
    
    //trapper_zombie
        string  description = "He lays a trap, what else would a trapper do ?";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 5;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Creates a single-use trap on the tile he dies on. Any plant planted on that tile is stunned.";
        string  almanac     = "Purveyor of only the finest banana peel coats.";
        string  origin      = "PvZ Heroes";

    //cryo-yeti
        string  special     = "If chilled, becomes 'faster' and gets double aps. Immune to freezing and chilling.";
        string  origin      = "PvZ Heroes";

    //firefighter_zombie
        string  description = "Firefighter Zombie fights fire for the zombie army.";
        double  hp          = 10;
        double  armor       = 25;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Blocks incoming fire projectiles in a 3x3 area centered on him.";
        string  almanac     = "He's a little too eager to rescue kittens from trees.";
        string  origin      = "PvZ Heroes";

    //perfume_zombie
        string  description = "Throws a poisonous perfume bottle at the plants so they can't attack and are hurt.";
        double  hp          = 30;
        double  armor       = 0;
        int     cr          = 11;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 0.5;
        string  special     = "Throws perfume bottles at plants that release poisonous perfume that stuns and damages them. Perfume can be removed by Aloe.";
        string  almanac     = "Perfume Zombie's perfume is popular among the aristocrats. Smells, hmm... tasty!";
        string  origin      = "PvZ 2 China";

    //ballerina_zombie
        string  description = "A group of four agile dancing zombies.";
        string  hp          = 20;
        string  armor       = 0;
        int     cr          = 8;
        double  speed       = fast;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "More likely to spawn during Aerobics Class concert event. Always spawns in 'back-up dancer formation' and can randomly switch lanes.";
        string  almanac     = "'Spin, jump, close my eyes'. Ballerina Zombie likes this song the most.";
        string  origin      = "PvZ 2 China";

    //target_zombie
        string  special     = "Summons a Bungee Zombie on his lane on death.";
        string  origin      = "PvZ Versus Mode"; 

    //mailman_zombie
        string  speed       = faster;
        string  special     = "Walks past plants instead of eating them.";
        string  origin      = "PvZ Brutal Mode EX Plus (Letterhead Zombie)";

    //rocket_zombie
        string  description = "He rockets his way past your defences.";
        double  hp = 35;
        double  armor = 0;
        int     cr = 10;
        double  speed = slow;
        double  dmg = 1;
        double  aps = 2;
        string  special = "While with its rocket, he becomes 'faster' and ignores all plants. Rocket can be disabled with chilling or freezing.";
        string  almanac = "Rocket Zombie ain't got time for this. He ain't got time for that. He does, however, have time for differential calculus.";
        string  origin = "PvZ Adventure";

    //ice_block_zombie
        string  description = "He's pretty cold right now, and he'll make your plants cold too.";
        double  hp          = 10;
        double  armor       = 25;
        int     cr          = 6;
        double  speed       = nomral;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Once the ice block is broken, all plants in a 3x3 radius are frozen. Flaming projectiles instantly destroy the ice block. Immune to chilling and freezing.";
        string  almanac     = "The story of how he was frozen along with a fish is completely bogus. Lies from beginning to end.";
        string  origin      = "PvZ Adventure";

    //barrel_of_deadbeard
        string  description = "A barrel that explodes into a powerful pirate captain.";
        double  hp          = 20;
        double  armor       = 0;
        int     cr          = 15;
        double  speed       = slow;
        double  dmg         = 0;
        double  aps         = 0;
        string  special     = "On destruction, damages all plants in a 3x3 radius and spawns a Captain Deadbeard in its place.";
        string  almanac     = "No monkeys, just Zombies.";
        string  origin      = "PvZ Garden Warfare";

            //captain_deadbeard
                string  description = "Sends out his trusty parrot while he attacks with his laser gun.";
                double  hp          = 32;
                double  armor       = 0;
                //int   cr          = n/a;
                double  speed       = normal;
                double  dmg         = 2;
                double  aps         = 2;
                string  special     = "Shoots from a 2 tiles away. Sends out a Zombie Parrot.";
                string  almanac     = "Yo ho ho! It's a pirate's unlife for him!";
                string  origin      = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";

                    //zombie_parrot
                        string  description = "Attempts to fly away with your plants.";
                        double  hp          = 12;
                        double  armor       = 0;
                        //int   cr          = n/a;
                        double  speed       = fast;
                        double  dmg         = 0;
                        double  aps         = 0;
                        string  special     = "Flies towards the front-most plant of a random lane. Once it reaches it, it grabs onto it and stands for a few seconds before flying off with it. Once it flies off or is blown away by a plant, it reappears on the back of its Cpatain Deadbeard's lane and goes back into the hat. It is instantly killed by butter and if it tries to grab onto a Spring Bean, it will activate and headbutt the Zombie Parrot, killing it.";
                        string  almanac     = "He's a third generation aviation revolutionary. He wants to serve his pirate brethren like his father and his grandmother, Salty Anne, before him.";
                        string  origing     = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";

        //elite_barrel_of_deadbeard:barrel_of_flameface
            string  description = "A barrel that explodes into a fiery pirate captain.";
            double  hp          = 25;
            double  armor       = 0;
            int     cr          = 19;
            double  speed       = slow;
            double  dmg         = 0;
            double  aps         = 0;
            string  special     = "On destruction, damages all plants in a 3x3 radius and spawns a Captain Flameface in its place.";
            string  almanac     = "No flames, just Flameface.";
            string  origin      = "PvZ Garden Warfare ; PvZ Heroes";
                
                //elite_captain_deadbeard:captain_flameface
                    string  description = "Sends out his firey companion while he attacks with his fire gun.";
                    double  hp          = 45;
                    double  armor       = 0;
                    //int   cr          = n/a;
                    double  speed       = normal;
                    double  dmg         = 2;
                    double  aps         = 2;
                    string  special     = "Shoots from a 1 tiles away, attack pierces through the first plant and also damages the next one. Spawns a Fire Rooster Zombie, and respawns at the back of his lane when it dies.";
                    string  almanac     = "He also comes from a barrel, just a differen... barell.";
                    string  origin      = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";
        
    //pigeon_feeder_zombie
        string  special     = "While alive, spawns and respawns Zombie Pigeons on a 3x3 area around him similiarily to the disco zombie.";
        string  origin      = "PvZ 3";

            //zombie_pigeon
                string  special     = "Flies at roof height, clogging up your skies but land to eat.";
                string  origin      = "PvZ 3";

    //disco_zombie
        string  special     = "Unlike Dancer Zombie, he can spawn anywhen. While alive, creates Disco Backup Dancers in the tiles above, below and besides him.";
        string  origin      = "PvZ 1";

            //backup_disco_zombie
                string  origin      = "PvZ 1";

        //elite_disco_zombie:cosmic_dancing_zombie
            string  special     = "While alive, creates random instrument playing zombies above, below and besides him.";
            string  origin      = "PvZ Heroes";

    //line_dancer_zombie
        string  description = "Line Dancer Zombie sings down your lanes to damage all plants.";
        string  special     = "Moves between lanes. Occasionally sings, damaging every plant in her lane.";
        string  almanac     = "In her opinion, there's no better song to line dance to than the 'Zombie Shuffle.'";
        string  origin      = "PvZ Heroes";

    //medic_zombie
        string  special     = "Every few seconds, heals all zombies in an 'plus' formation centered on himself for 2hp. Heals Riot Police Zombies and Foot Soldier Zombies for double hp.";
        string  origin      = "PvZ Heroes ; PvZ 2 (Healer Zombie)";

    //foot_soldier_zombie
        string  special     = "Upon reaching the 4th column, he lauches himself upwards to the second to last lane of the roof, dealing heavy damage to the plant he lands on in the process.";
        string origin       = "PvZ Garden Warfare";

        //variant_foot_soldier_zombie:scuba_soldier_zombie
            string  special     = "Only appears in the pool. Dives into the water and stays there until the 4th column. Upon reaching it, he lauches himself upwards to the second to last lane of the roof, knocking over any plant on a lily on that tile and dealing heavy damage to the plant he lands on in the process.";
            string origin       = "PvZ Garden Warfare";

        //elite_foot_soldier_zombie:arctic_trooper_zombie
            string  special     = "Only spawns during winter. Resistant to chilling, freezing and cold projectiles. Upon reaching the 4th column, he lauches himself upwards to the second to last lane of the roof, freezing plants in a cross formation from where he jumps and dealing heavy damage to the plant he lands on in the process.";
            string origin       = "PvZ Garden Warfare";

        //elite_foot_solider_zombie:centurion_zombie
            string  special     = "Only spawns during summer. Appers in a gust of sand wind. Takes half damage from fire attacks. Upon reaching it, he lauches himself upwards to the second to last lane of the roof, bruing the plant he lands on and leaving a crater behind on the tile he launched himself from.";
            string origin       = "PvZ Garden Warfare";

        //elite_foot_solider_zombie:camo_ranger_zombie
            string  special     = "Only spawns during fall. Upon taking damage for the first time, he camouflages, going invisible, unless lit up, until he reaches the 4th column. Upon doing so,  he lauches himself upwards to the second to last lane of the roof, dealing heavy damage to the plant he lands on in the process.";
            string  origin      = "PvZ Garden Warfare";

        //elite_foot_solider_zombie:park_ranger_zombie
            string  special     = "Only spawns during spring. Using his propeller springs, he jumps over all plants instead of eating them, except tall-nut, which causes him to walk normally. Upon reaching the 4th column, he lauches himself upwards to the second to last lane of the roof, reactivating his springs and allowing him to keep jumping over plants and releasing a toxic fume where he jumps from, dealing passive damage to plants there for a few waves.";
            string  origin      = "PvZ Garden Warfare";

    //riot_police_bomber_zombie
        string  special     = "Throws smoke bombs forwards, shortly stunning the plant it lands on and causing smoke to appear on a cross area around it. Hits plants with his stick instead of eating.";
        string  origin      = "PvZ 2 China (Riot Police Zombie)";

    //riot_police_squadron
        string  special     = "Spawns in formation from 3 to 5 zombies. The zombies on the front and back hold their shields in front and behind them respectively. The zombies in the middle hold it above their heads. This protects the formation from attacks from all directions except down. They attack with their bastons instead of eating.";
        string  origin      = "PvZ 2 (Camel Zombies) | PvZ 2 China (Riot Police Zombie)";

    //riot_police_detonator_zombie
        string  origin      = "PvZ 2 (Prospector Zombie)";

    //gilet_jaune_zombie
        string  description = "The Gilet Jaune Zombie joins the undead protest with a megaphone in hand. His passionate shouts can rally other zombies to his cause.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 5;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "The Gilet Jaune Zombie occasionally stops and shouts slogans. This shout stuns plants in a 3x3 area and turns  basics into 'Rallied Protestor Zombies.'";
        string  almanac     = "To defend against the Gilet Jaune Zombie consider using plants with resistance to public dissatisfaction.";
        string  origin      = "Rogue Garden";

            //rallied_protestor_zombie
                string  description = "The Rallied Protestor Zombie is an incendiary addition to the undead protest, carrying a torch to burn the rival flora.";
                double  hp          = 10;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = fast;
                double  dmg         = 1;
                double  aps         = 2;
                string  special     = "Burns any plant he in front of he. Fire is extinguished with the Chill or Freeze effects and becomes a regular zombie. Fire projectiles can reignite the torch.";
                string  almanac     = "Ah, the Rallied Protestor Zombie, a true connoisseur of chaos. Mon dieu, the theatrics of the rebellion! Prepare for a fiery soirée.";
                string  origin      = "PvZ 2 (Explorer Zombie)";

    //tuba_zombie
        string  special     = "Plays an instrument. Once it reaches the middle of a tile, it stops then blows to push all zombies on that tile forwards 1-2 tile.";
        string  origin      = "Rogue Garden";

    //keytar_zombie
        string  special     = "Plays an instrument. Every few seconds, makes all basics and imps switch lanes.";
        string  origin      = "PvZ 3 ; PvZ Heroes (Disco-naut)";

    //undead_flamenco_dancers
        string  special     = "Plays an instrument. Two zombies, share HP but eat separately. Plays castanets to turn basics in a 3x3 area into Flamenco Backup Dancers that walk along the Undead Flamenco Dancers. Throws hat that deals damage equal to amount of Flamenco Backup Dancers in 3x3 area.";
        string  origin      = "PvZ Heroes (Flamenco Zombie); Rogue Garden";
        
        //flamenco_backup_dancers
            string  origin      = "Rogue Garden";

    //drum_major_zombie
        double  hp      = 10;
        double  armour  = 55;
        double  speed   = normal;
        double  dmg     = 1;
        double  aps     = 2;
        string  special = "Helmet can be removed by Magnet-Shroom. Summons three Fanfare Zombies on the tiles behind him (1x3). When a Zombie Boss is summoned and or if it spawns during a Boss Event, causes his Fanfare Zombies to play an arrival tune that will give a weak armor to the Boss.";
        string almanac  = "Recently promoted from Drum Minor";
        string origin   = "PvZ Heroes";

        //fanfare_trumpet_zombie
            string  special     = "Plays an instrument. Attacks from one tile away.";
            string  origin      = "Rogue Garden";
        
        //fanfare_cymbals_zombie
            string  special     = "Plays an instrument. Stuns plants in the diagonals.";
            string  origin      = "Rogue Garden";
        
        //fanfare_snare_drum_zombie
            string  special     = "Plays an instrument. Increases aps of Fanfare Zombies.";
            string  origin      = "Rogue Garden";
        
        //fanfare_french_horn_zombie
            string  special     = "Plays an instrument. Passively heals Fanfare Zombies.";
            string  origin      = "Rogue Garden";

    //double_bass_zombie
        double  speed       = slower;
        string  special     = "Plays an instrument. Bass protects zombie from attacks from the front. Occasionally flings projectiles back at plants by plucking bass.";
        string  origin      = "Rogue Garden";

    //phantasmal_violinist
        string  special     = "Plays an instrument. Occasionally stops a plays a tune that summons Haunting Ghosts in his garden.";
        string  origin      = "Rogue Garden";

    //lullaby_zombie
        string  special     = "Plays an instrument. Occasionally stops a plays his music box to cause plants in a 3x3 area to fall asleep.";
        string  origin      = "Rogue Garden";

    //sleepwalking_zombie
        string  special     = "Ignores sleeping plant. Has a chance to put the plant he is eating to sleep.";
        string  origin      = "Rogue Garden";

    //zomboni
        string  special     = "Affected by EMPeach. Creates an ice trail behind him that plants, except plant pots, cannot be planted on and Bobsleds can spawn on. Overrides Paint Bucket Zombie's Paint Trail.";
        string  origin      = "PvZ 1";

    //space_cowimp
        string  special     = "Affected by EMPeach. Flies towards your roof. Moves to a neighbouring lane when he eats a plant.";
        string  origin      = "PvZ Heroes (Space Cowboy)";

    //hover-goat_3000
        string  special     = "Affected by EMPeach. Flies towards your roof. Gives zombies directly under itself +1 dmg and heals them over time.";
        string  origin      = "PvZ Heroes ; PvZ GW";

    //interdimensional_zombie
        string  description = "The Interdimensional Zombie occasionally avoids attacks by glitching forward.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Affected by EMPeach. Every third attack that hits him doesn't inflict damage and causes him to glitch forwards one tile.";
        string  almanac     = "In a parallel dimension, this Zombie is a Space Pirate. In another, he's a Trash Can Zombie. Turns out, little choices in life can make a big difference.";
        string  origin      = "PvZ Heroes ; PvZ It's Versus Time (Glitched Zombie)";

    //cyborg_zombie
        string  description = "The Cyborg Zombie summons a stronger version of himself upon death.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 7;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Affected by EMPeach. Once dead, a Vengeful Cyborg Zombie spawns in his lane.";
        string  almanac     = "He'll be back.";
        string  origin      = "PvZ Heroes";

            //vengeful_cyborg_zombie
                string  description = "He is stronger than his summoner in every way.";
                double  hp          = 60;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = faster;
                double  dmg         = 2;
                double  aps         = 4;
                string  special     = "Affected by EMPeach. ";
                string  almanac     = "He's back";
                string  origin      = "PvZ Heroes";

    //bull_rider_imp
        string  special     = "Takes a couple of seconds to charge up before dashing forwards, propelling the imp forward on the first plant it hits and leaving behind the Zombie Bull.";
        string  origin      = "PvZ 2";

        //zombie_bull
            //Note that, for the purposes of counting the Bull Rider Imp in the Animal Herders and the Zombie Bull as an animal, it is no longer a robot in Rogue Garden
            string  origin      = "PvZ 2";

        //variant_bull_rider_imp:walrus_rider_imp
            string  special     = "Only spawns in the pool, during winter. Slides over the water, propelling the imp forward on the first plant it hits and leaving behind the Zombie Walrus.";
            string  origin      = "PvZ Heroes";

            //zombie_walrus
                string  origin      = "PvZ Heroes (Walrus Rider)";

            //elite_walrus_rider_imp:frost-walrus_rider_imp
                string  special     = "Only spawns in the pool, during winter. Slides over the water, freezing it behind himself (turning it into frozen shallow water for the next 3 waves) and propelling the imp forward on the first plant it hits and leaving behind the Zombie Frost-Walrus.";
                string  origin      = "Rogue Garden ; PvZ Heroes (Walrus Rider)";

                //zombie_frost-walrus
                    string  special     = "Frezes water where it slides, turning it into frozen shallow water for the next 3 waves.";
                    string  origin      = "Rogue Garden";

    //arcade_zombie
        string  special     = "Affected by EMPeach. Pushes an arcade machine that slows itself down but takes hits from the front and spawns 8-Bit Zombies. Can't push the arcade machine past Gravestones.";
        string  origin      = "PvZ 2";

            //variant_basic:8-bit_zombie
                //animated in less fps
                string  origin      = "PvZ 2";

    //bug_bot_imp
        string  origin      = "PvZ 2";

    //robo-cone_zombie
        string  origin      = "PvZ 2";

    //gargantuar_prime
        string  special     = "Affected by EMPeach. Shoots his laser at plants in the back of the garden. Attacks twice per attack. Throws Bug Bot Imp upon reaching half hp.";
        string  origin      = "PvZ 2";

    //airborn_zombies

        //bungee_zombie
            string  special     = "Before appearing, a target is placed on the tile it will land on. After a wave, he jumps down, waits for a few seconds during which it can be hit then steals the plant on that tile. If there is a pumpkin-like plant on that tile, it will prioritize the plant inside. It is blocked by Umbrella Leaf.";
            string  origin      = "PvZ 1";

        //bungee_plumber_zombie
            string  special     = "Before appearing, a copper pipe falls on the tile it will land on, dealing one damage to the plant on that tile and activating instants like potato mines. If there is a pumpkin-like plant on that tile, it will prioritize the plant inside. It is blocked by Umbrella Leaf. After a wave, the he jumps down to pick up the pipe, damaging the plant he lands on for 5 damage. If there is a pumpkin-like plant on that tile, it will prioritize the plant inside. It is blocked by Umbrella Leaf, but deals 2 damage to it.";
            string  origin      = "PvZ Heroes (Bungee Plumber Jumper)";

        //parachutist_zombie
            string  special     = "Falls down and gets stuck midair for 1 to 2 waves before falling onto the garden and acting like a normal zombie. It is blocked by Umbrella Leaf once it falls.";
            string  origin      = "PvZ 2 (Lost Pilot Zombie)";

        //roof_climber_zombie
            string  special     = "Throws his hook at the roof's gutter then swings into the garden. It is blocked by Umbrella Leaf.";
            string  origin      = "PvZ Heroes (Mountain Climber) ; PvZ 2 (Swashbuckler / Relic Hunter)";

        //copter_commandimp
            string  special     = "Flies towards your roof. Attacks from 2 tiles away.";
            string  orgin       = "PvZ Heroes (Copter Commando)";

        //kite_flyer_zombie
            string  description = "Kite Flyer Zombie flies a kyte above him. He shoots any damage inflicted to the kite right back at the plants.";
            double  hp          = 30;
            double  armour      = 0;
            int     cr          = 5;
            double  speed       = normal;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "More likely to appear during Fall. The kite flies on roof height above the Kite Flyer Zombie. Whatever damage the kite takes is shot back at the plants on the ground.";
            string  almanac     = "The naysayers were right. Flying a kite in a lightning storm WAS a real bright idea.";
            string  origin      = "PvZ Heroes";

                //kite
                    string  description = "The Kite Flyer Zombie's kite";
                    double  hp          = 15;
                    double  armour      = 0;
                    //int     cr        = n/a
                    double  speed       = normal;
                    double  dmg         = 0;
                    double  aps         = 0;
                    string  almanac     = "Yes it's the Balloon Zombie's design. No, Kite Flyer Zombie will not apologize.";
                    string  origin      = "PvZ Heroes (Kity Flyer)";

        //stupid_cupid_imp
            string  description = "Flies and attacks to plants under him, which stuns them for a few seconds.";
            double  hp          = 14;
            double  armour      = 0;
            int     cr          = 5;
            double  speed       = fast;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Flies towards your roof. Deals damage to plants beneath him, which stuns them for a few seconds.";
            string  almanac     = "What's love got to do with it? Honestly, he has no idea.";
            string  origin      = "PvZ Heroes";

        //sandman_zombie
            string  special     = "Flies towards your roof. Increases odds for plants in his lane falling asleep.";

    //aquatic_zombies
        
        //snorkel_zombie
            string  special     = "Only spawns in the pool. Dives underwater and only comes out to eat. He can be targeted and hit by lobbers while underwater.";

                //elite_snorkel_zombie:zombie_deep_diver
                    string  special     = "Only spawns in the pool. Dives underwater and only comes out to eat. Skips the first 1 to 3 plants he encounters and instead swims under them. He can't be targeted and hit by lobbers while underwater.";

        //surfer_zombie
            string  special     = "Only spawns during summer and spring. May spawn in the pool. If on land, carries a surfboard over his head that he smashes into the first plant he encounters and drops upon death. If in the pool, surfs rapidly, ignoring your plants except for tall-nut. Behaves like it would do in the pool when on shallow water lanes.";

        //fisherzombie
            string  special     = "Doesn't spawn during winter. Only spawns in the pool. Stays in the last column of the pool and hooks the front-most plant in his lane and pulls it forwards one tile. Doesn't affect Infi-nut.";
            string  origin      = "PvZ 2 (Fisherman Zombie)";

                //elite_fisherzombie:fisher_bucket_zombie
                    string  special     = "Can spawn in the pool, except during winter. If in the pool, stays in the last column and hooks the front-most plant in his lane and pulls it forwards one tile. Doesn't affect Infi-nut. If on land, once it reaches the garden, if it still has his bucket, lobs it forwads dealing 6 damage where he lands and an extra 1 damage to all plants in a 1x3 area behind it with the splattering fish. If it flies over an unoccupied Magnetshroom, gets pulled in and doesn't attack. Bucket can be removed by Magnetshroom.";
                    string  origin      = "PvZ 2 (Fisherman Zombie) ; PvZ Heroes (Buckethead Zombie)";

        //octo_zombie
            string  special     = "Throws Zombie Octopus at plants in the garden, prioritizing his lane.";
            string  origin      = "PvZ 2";

        //synchronized_swimmer_zombie
            string  special     = "Only spawns in the pool. More likely to spawn during Aerobics Class concert event. Always spawns in groups of three, covering all three pool lanes.";
            string  origin      = "PvZ Heroes";

        //imp_commander
            string  special     = "Only spawns in the pool. While alive, every zombie in his lane gets +0.5 aps.";
            string  origin      = "PvZ Heroes";

        //zombie_high_diver
            string  special     = "Spawns in the roof like the chimney swipper. Dives into one of the pool lanes, stays submerged for 1 to 3 tiles and advances away from the house.";
            string  origin      = "PvZ Heroes";

//carnival_zombies

    //nutcracker_zombie
        string special      = "Deals gargantuar damage to nuts.";
        string  origin      = "PvZ 2";

    //bonus_track_buckethead
        string  description = "Prevents your fastest plant from attacking";
        double  hp          = 10;
        double  armour      = 55;
        int     cr          = 11;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "While alive, stuns the highest aps plant in his lane.";
        string  almanac     = "He made a second volume of all his favourite songs for his brand new Mp3 player.";
        string  origin      = "PvZ Heroes";

    //beast_handler
        string  special     = "When an Animal Herder type zombie spawns, that zombie gets +1 dmg and +0,25 aps.";
        string  origin      = "PvZ Heroes (Zookeeper)";

    //elite_bull_rider_imp:rodeo_stunt_imp
            string  special     = "Rodeo Bull is affected by EMPeach. Takes a couple of seconds to charge up before dashing forwards, propelling the imp forward on the first plant it hits, damaging the hit plant and leaving behind the Rodeo-Bot. Once the imp lands, the Rodeo-Bot explodes.";
            string  origin      = "Rogue Garden ; PvZ 2 (Rodeo Legend Zombie)";

            //rodeo-bot
                string  special     = "Affected by EMPeach. Upon lauching the Rodeo Stunt Imp, starts a timer that explodes itself as the Imp lands. The explosion is disabled by using EMPeach while the timer is active or by killing the Rodeo-Bot. If the Rodeo Stunt Imp doesn't land, the timer still goes and the Rodeo-Bot still explodes.";
                string origin       = "Rogue Garden ; PvZ 2 (Rodeo Legend Zombie)";

    //ringmaster_zombie
        string  special     = "Every few seconds, summons one of four zombies in random lanes of the garden. He may summon an Abracadaver, Firebreather Zombie, Acrobat Imps or Zombie Juggler.";
        string  origin      = "Rogue Garden";

    //abracadaver
        string  special     = "Lifts his hat to reveal a Zombie Dove who'll try to fly off with your plants. If the dove dies, the hat falls off, which releases a Zombie Rabbit.";
        string  origin      = "PvZ Heroes ; PvZ 2 (Magician Zombie)";

        //zombie_dove
            string special = "Flies towards the front-most plant of a random lane. Once it reaches it, it grabs onto it and stands for a few seconds before flying off with it. Once it flies off or is blown away by a plant, it reappears on the back of its Abracadaver's lane and goes back into the hat. It is instantly killed by butter and if it tries to grab onto a Spring Bean, it will activate and headbutt the Zombie Dove, killing it.";
            string origin = "PvZ 2";

        //zombie_rabbit
            string  origin = "PvZ Heroes (Abracadaver); PvZ 2 (Weasel)";
    
    //firebreather_zombie
        string  description = "Firebreather Zombie... wait for it... breathes fire. And plenty of it!";
        string  special     = "Breathes fire onto plants from two tiles away dealing heavy damage over time. Fire is extinguished with the Chill or Freeze effects and becomes a regular zombie. Fire projectiles can reignite the beard.";
        string  origin      = "PvZ 2";

    //acrobat_imps
        string  special     = "Always spawns in a group of three on neighbourghing lanes. May spawn on pool lane and drown on landing. Will swing into the garden.";
        string  origin      = "PvZ 2 Reflourished (Trapeze Zombie)";

    //zombie_juggler
        string  special     = "Catches projectiles thrown at him and juggles them, not taking damage. Once he catches 5, he lobs them towards the roof. After that he stops doing it.";
        string  origin      = "Rogue Garden";

    //pied_piper_zombie
        string  description = "The Pied Piper sends out rats to block the front-most plant in his lane.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 3;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Plays an instrument. Sends Zombie Rats down his lane.";
        string  almanac     = "He was told that playing the pipe would summon raccoons. But whatevs.";
        string  origin      = "PvZ Heroes";

            //zombie_rat
                string  special     = "Cannot be hit by plants. Stuns the first plant they encounter until it dies, then goes on to the next plant. Dies if their Pied Piper dies.";
                string  origin      = "PvZ Heroes (Pied Piper)";

    //stiltwalker_zombie
        string  special     = "Walks over plants on his wooden stilts. The zombie itself walks between roof and garden height and the stilts are weak to fire attacks.";
        string  origin      = "PvZ 2";

    //drinking_zombie
        string  special     = "Drinks from his bottle upon reaching half hp. This buffs his speed, dmg and aps.";
        string  origin      = "PvZ 2 China";
    
    //elite_hamsterball_imp:ferris_wheel_zombie
        string  description = "A rather speedy zombie that certainly loves fun.";
        double  hp          = 10;
        double  armour      = 40;
        int     cr          = 8;
        double  speed       = faster;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Releases the Drinking Zombie inside it when it's destroyed.";
        string  almanac     = "It feels like the world is spinnig around Ferris Wheel zombie, but he's actually the one that's spinning this time.";
        string  origin      = "Rogue Garden";

    //firework_zombie
        string  description = "Launches fireworks at your plants.";
        double  hp          = 35;
        double  armor       = 0;
        int     cr          = 12;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Launches fireworks at random tiles that burn the plant there and create fire trails on them.";
        string  almanac     = "Want to clear some mushrooms? Fire works.";
        string  origin      = "PvZ 2 China ; design PvZ Heroes";

    //carnie_cannon
        string  special     = "Stays at the back of the garden and occasionnaly shoots out Carnie Imps. If not defeated after a certain time, explodes, shooting 4 to 6 Carnie Imps much further into the garden than it normally would.";
        string  origin      = "PvZ 2";

        //carnie_imp
            string  description = "Often launched from carnie cannons.";
            double  hp          = 5;
            double  armour      = 10;
            //int   cr          = n/a;
            double  speed       = fast;
            double  dmg         = 0.5;
            double  aps         = 3;
            string  special     = "Helmet can be removed by Magnetshroom.";
            string  almanac     = "At the same time, though, you wouldn't want to bet your life on these guys only coming out of cannons.";
            string  origin      = "PvZ 2";

    //imposter
        string  special     = "Splits into two imps on adjacent lanes on death, one of which is a Moustache Imp and the other is a random CR 3 or less Imp. While wearing the coat, it deals more damage when eating plants.";
        string  origin      = "PvZ Heroes and PvZ Adventure ; PvZ 2 (Carnie Imp Twins)";

        //moustache_imp
            string  special     = "After passing 4 columns turns into a random CR 4 or less zombie with a moustache.";
            string  origin      = "Rogue Garden";

    //outhouse_zombie
        string  special     = "Reveals a Basic (or variant), Newspaper Zombie (or elite), or Imposter upon breaking.";
        string  origin      = "PvZ GW";

    //balloon_vendor_zombie
        string  speed       = slower;
        string  special     = "Turns Basics that pass by him into their Balloon variant, fully healing them in the process.";
        string  origin      = "Rogue Garden";

//sportive_zombies
    
    //cosmic_sports_star
        string  special     = "Once he reaches the garden, summons a random non-garg and non-mechanic zombie from the Sportive category in his lane and the neighbourghing lanes.";
        string  origin      = "PvZ Heroes";
    
    //pole_vaulting_zombie
        string  origin      = "PvZ 1";

        //variant_pole_vaulting_zombie:dolphin_rider_zombie
            string  special     = "Only spawns in the pool. Swims on 'faster' speed while riding his dolphin. Jumps over the first plant he encounters and loses his dolphin. Can't jump over a tall-nut.";
            string  origin      = "PvZ 1";

        //elite_pole_vaulting_zombie:hog_rider_zombie
            string  special     = "Can jump over Tall-nut";
            string  origin      = "Clash of Clans";

    //catapult_zombie
        string  special     = "Affected by E.M.Peach.";
        string  origin      = "PvZ 1";

        //elite_catapult_zombie:football_catapult_zombie
            string  special     = "Affected by E.M.Peach.";
            string  origin      = "PvZ 1 (Catapult Zombie)";

    //football_zombie
        string  origin      = "PvZ 1";

        //elite_football_zombie:giga_football_zombie
            string  origin      = "PvZ 1 (Cut Content)";

    //quarterback_zombie
        string  special     = "Helmet does not provide extra HP but instead reduces damage taken by all attacks by 1 and can be removed by Magnetshroom. Upon spawning, throws a football that bounces twice before disappearing then rushes at 'faster' speed until he reaches a plant.";
        string  origin      = "PvZ Heroes (All-Star Zombie)";
    
        //elite_quarterback_zombie:all-star_zombie
            string  special     = "Helmet does not provide extra HP but instead reduces damage taken by all attacks by 2 and can be removed by Magnetshroom. Upon spawning, summons an All-star Super Fan Imp on his lane. Once it reaches the garden, rushes forwards at 'faster' speed, throws it forwards and deals gargantuar damage to the first plant it encounters.";
            string  origin      = "PvZ 2";

            //all-star_super_fan_imp
                string  origin      = "PvZ 2";

    //tennis_champ_zombie
        string  special     = "Attacks by hitting with her racket instead of biting. Has 5 dmg until eating her first plant.";
        string  origin      = "PvZ Heroes";

    //arm_wrestler_zombie
        string  special     = "Gains +2 hp and +1 dmg when a plant is planted on his lane.";
        string  origin      = "PvZ Heroes";

    //planetary_gladiator_zombie
        string  special     = "Absorbs damage for zombies in front of him in his lane.";
        string  origin      = "PvZ Heroes";

    //brain_vendor_zombie
        string  special     = "Moves zombies behind him from neighbouring lanes into his own.";
        string  origin      = "PvZ Heroes";

    //team_mascot_imp
        string  spceial     = "Gives all zombies in his lane +1 dmg for every plant that dies in his lane whilst he's alive.";
        string  origin      = "PvZ Heroes";

    //zombie_coach
        string  special     = "Gives all zombies in his lane +2 hp for every plant that dies in his lane whilst he's alive.";
        string  origin      = "PvZ Heroes";

    //bobsled_team
        string  special     = "Only spawns during winter or in Zomboni ice trail.";
        string  origin      = "PvZ 1";

    //mecha-football_zombie
        string  special     = "Affected by E.M.Peach. Pushes plants back for as long as there is space behind it.";
        string  origin      = "PvZ 2";

    //defensive_end_gargantuar
        string  special     = "While alive, all seeds recharge time is increased. Throws an All-Star Super Fan Imp upon reaching half hp.";
        string  origin      = "PvZ Heroes";

    //rodeo_gargantuar
        string  special     = "Switches plant with a plant behind it before smashing it. Throws a Zombie Chicken upon reaching half hp.";
        string  origin      = "PvZ Heroes";

//construction_zombies
    
    //construction_cone_zombie
        string  special     = "Once it reaches an empty tile, if it still has its cone, places it down turning the tile into a Construction Site";
        string  origin      = "PvZ 1 (Conehead Beta Design)";

    //pylon_imp
        string  special     = "On death, spawns a Loudmouth Bot.";
        string  origin      = "PvZ GW";

    //paint_bucket_zombie
        string  special     = "Doesn't spawn during winter. Once he reaches the garden, drops his bucket and drags it creating a trail of red paint the boosts the speed of zombies on it. It overrides Zomboni Ice Trails.";
        string origin       = "PvZ 1 (Buckethead Beta Design)";

    //ladder_zombie
        string  origin      = "PvZ 1";

    //supply_barrel_roller_zombie
        string  origin      = "PvZ 2 (Barrel Roller Zombie)";
    
    //digger_zombie
        string  special     = "Pickaxe can be stolen by Magnetshroom. He digs into the garden instead of walking, remaining underground as long as he has the pickaxe. While underground he ignores all plants except all the underground potatoes which he will eat and/or trigger. Once reaching the end of the garden or forced out of the ground by Magnetshroom, he will walk backwards. If he digs into an Archeology Guide Zombie's tunnel, he will come out the other end and walk forwards like any zombie.";
        string  origin      = "PvZ 1";

    //excavator_zombie
        string  origin      = "PvZ 2";
    
    //electrician_zombie
        string  special     = "Zombies behind him on his lane are faster.";
        string  origin      = "PvZ Heroes";

    //ac_perry
        string  special     = "Attacks at a two tile range, shooting ice balls to slowly freeze plants. If it passes by a Construction Site, it replaces it with a Mr. Freezy bot.";
        string  origin      = "PvZ GW";

    //kitchen_sink_zombie
        string  description = "This zombie has essentially got the power of a gargantuar, though he prefers eating over smashing.";
        string  special     = "Throws a pipe forwards before every attack.";
        string  origin      = "PvZ Heroes";

    //landscaper_zombie
        string  special     = "While alive, stuns the highest damage plant in his lane.";
        string  origin      = "PvZ Heroes ; PvZ GW";
            
    //gardener_zombie
        string  special     = "Once it reaches the garden, 'shovels' the front-most attacking plant in his lane (doesn't count as destroying it*) and replaces it with a Plant Pot that cannot be shoveled or be planted on for 3 waves.";  //*relevent for plants like Explodo-nut and Puni-Shroom
        string  description = "PvZ Heroes (Biodome Botanist Zombie)";

    //waste_barrel_imp
        string  special     = "Can spawn in the pool. Crushes plants he walks into. Destroyed by spike weed and tangled kelp.";
        string  origin      = "PvZ Heroes";
    
//museum_zombies
    
    //awakened_ra_zombie
        string  origin      = "PvZ 2 (Ra Zombie)";

    //awakened_cleopatra_zombie
        string  origin      = "PvZ 2 All-Star (Hero Cleopatra Zombie)";

    //elite_mixed-up_gravedigger:awakened_tomb_raiser_zombie
        string  special     = "Creates Engraved Gravestones on random tiles of the lawn. If the tile is occupied, no Gravestone is created.";
        string  origin      = "PvZ 2 (Tomb Raiser Zombie)";

    //awakened_undying_pharaoh
        string  special     = "While inside the sarcophagus takes -1 damage from all sources and prevents zombies behind him from going below 1 HP. After leaving the sarcophagus, becomes 'faster' speed, gains +2 aps and a 1 tile ranged attack with his staff. Upon death, drops his staff on the ground.";
        string  origin      = "PvZ 2 (Pharaoh Zombie) ; PvZ Heroes (Undying Pharaoh)";

        //variant_conehead:conehead_mummy
            string  origin      = "PvZ 2";

    //dodo_fossil_rider_imp
        string  origin      = "PvZ 2 (Dodo Rider)";

    //turquoise_skull_thief_zombie
        string  almanac     = "Every one of them brags about having stolen the real skull, but none realize they took it from the Neighbourghville Museum's gift shop.";
        string  origin      = "PvZ 2";

    //zombie_medusa
        string  special     = "Turns basics in front of it into zombie statues that she then pushes, crushing plants as she does so but being heavily slowed down. Can only have one zombie statue per tile.";
        string  origin      = "PvZ 2";

        //variant_kinght:bust_head_zombie
            string  description = "A bust head means this sculpted zombie can take a serious beating.";
            double  hp          = 10;
            double  armour      = 75;
            //int   cr          = n/a;
            double  speed       = normal;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Imune to Zombie Medusa's effect even after loosing all armor.";
            string  almanac     = "Bust Head Zombie belongs in the Neighbourghville Museum with a big sign that says, 'WARNING: THIS IS A ZOMBIE!'";
            string  origin      = "PvZ 2";

    //primeval_yeti
        string  special     = "Gives all zombies in his lane +2 hp and +1 dmg when he dies.";
        string  origin      = "PvZ Heroes";

    //cursed_gargolith
        string  special     = "Only spawns from Engraved Gravestones, but has high chances to spawn. Throws an Impstone upon reaching half hp.";
        string  origin      = "PvZ Heroes";

    //archeology_guide_zombie
        string  special     = "After a few seconds on the garden, opens a whole on the garden, digs forwards 3 tiles, then comes back up, creating a 5 tile long tunnel for non-gargantuar zombies to evade attacks and pass into your defenses. Diggers that dig into it come out the end of the tunnel. Each tile of the tunnel only lasts 10 seconds before disapearing. If he creates the tunnel through or on a shallow water tile, the tunnel collapses and the zombies inside die.";
        string  origin      = "PvZ 2 China (Lost Guide Zombie)";

//scientific_zombies
    
    //cosmic_scientist
        string  special     = "Once it reaches the garden, throws a potion on the lanes above and below him that each spawn a  zombie from the Scientific category.";
        string  origin      = "PvZ Heroes";

    //cardboard_robot_zombie
        string  description = "Just a zombie with fancy cardboard gadgets.";
        double  hp          = 14;
        double  armour      = 0;
        int     cr          = 2;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Attacks from 1 tiles away.";
        string  almanac     = "He's Rustbolt's biggest fan.";
        string  origin      = "PvZ Heroes";

    //elite_medic_zombie:necrologist
        string  special     = "Spawns a Dr. Heals after passing 3 columns.";
        string  almanac     = "He was a biologist in life.";
        string  origin      = "Rogue Garden";

    //nurse_gargantuar
        string  special     = "Heals himself 10 hp when he smashes a plant. Throws an Imp upon reaching half hp. If a boss event is ongoing, heals the boss instead.";
        string  origin      = "PvZ Heroes";

    //disinfection_zombie
        string  special     = "Only spawns in the pool. Releases toxic chemicals that slowly move along his lane, lightly damaging all plants.";
        string  origin      = "PvZ 2 China";
    
    //zombie_drop-off_rocket
        string  special     = "Flies towards your roof. Drops a Bug Bot Imp upon reaching 75%, 50% and 25% hp. If it reaches the roof, it stops and drops off a Moonwalker.";
        string  origin      = "PvZ 2 China (Transport Boat ambush) ; PvZ 2 (Bot Swarm ambush)";

            //moonwalker
                string  special     = "Dropped off by a Zombie Drop-off Rocket on the roof. Places down a flag at the edge of the roof that lasts 2 to 3 waves and makes all new zombies in that lane spawn with an additional 3 HP.";
                string  origin      = "PvZ Heroes";
    
    //gargologist_zombie
        string  special     = "While alive, all gargantuars in her lane get +0.5 aps.";
        string  origin      = "PvZ Heroes";

    //gadget_scientist_zombie
        string  description = "The Gadget Scientist Zombie summons Space Cadet Zombies onto the garden.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 8;
        double  speed       = fast;
        double  dmg         = 2;
        double  aps         = 1;
        string  special     = "Gun can be removed by Magnetshroom. Creates 4 Space Cadet Zombies across the 7 lanes, on the columns 4 to 6, once he reaches the garden. Attacks from 2 tiles away.";
        string  almanac     = "He wishes the Mad Chemist would stop copying his hairstyle.";
        string  origin      = "PvZ Heroes";

            //space_cadet_zombie
                string  description = "Is summoned by the Gadget Scientist Zombie.";
                double  hp          = 10;
                double  armour      = 5;
                //int   cr          = n/a;
                double  speed       = normal;
                double  dmg         = 1;
                double  aps         = 2;
                string  almanac     = "His body is in space but his head is in the clouds.";
                string  origin      = "PvZ Heroes";

    //mad_chemist_zombie
        string  description = "The Mad Chemist Zombie places potions on the ground around him to buff other zombies.";
        double  hp          = 40;
        double  armour      = 0;
        int     cr          = 8;
        double  speed       = fast;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Places potions on his lane and neighbouring lanes every three tiles. There are three different potions: Purple gives the zombies +10 armour (visually indicated by a purple cloud), orange makes them faster (not stackable) and blue makes them invisible and untouchable for three tiles. These effects do not stack with each other. Isn't affected by potions.";
        string  almanac     = "He's not so much 'mad' as he is 'mildly annoyed.'";
        string  origin      = "PvZ Heroes ; PvZ 2 and Pv2 China (Dark Ages potions)";

    //teleportation_zombie
        string  description = "The Teleportation Zombie teleports all zombies in his column one tile forwards upon death.";
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 9;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Teleports all zombies in his column one tile forwards upon death.";
        string  almanac     = "The phone cord stretches to another dimension.";
        string  origin      = "PvZ Heroes";

    //portal_technician_zombie
        string  description = "The Portal Technician Zombie turns into a random zombie after dying.";
        double  hp          = 20;
        double  armour      = 10;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "After dying, creates a random zombie in his place.";
        string  almanac     = "Soon everyone will own their own portal. But for now, he enjoys being an early adopter.";
        string  origin      = "PvZ Heroes";

    //space_ninja_zombie
        string  description = "He attacks all plants in a 3x3 area for 0.5 damage everytime he attacks.";
        string  origin      = "PvZ Heroes";

    //zom-blob
        string  special     = "More likely to spawn during Radiation Wave event. Ignores plants and leaves a blob trail behind him that deals damage over time and disappears after a few seconds.";
        string  origin      = "PvZ Heroes";

    //genetic_experiement
        string  special     = "More likely to spawn during the Radiation Wave event. Upon reaching the garden, incapsulates himself. He does not leave until the capsule is destroyed. Whilst in the capsule, gains +2 hp and +0.25 dmg for every four zombies that pass him.";
        string  origin      = "PvZ Heroes";

//zcorp_zombies
    
    //zcorp_monitor_head
        string  description = "ZCorp Monitor Heads are zombies with Cone-grade protection that can attack your plants from a distance.";
        double  hp          = 29;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 1;
        string  special     = "Can shoot plants in his lane from 4 tiles away.";
        string  almanac     = "ZCorp Monitor Head is hard-working. So much so that he purposefully fused his head with his monitor to achieve never-before-seen work efficiency.";
        string  origin      = "PvZ Battle for Neighborville (TV Head)";
    
    //zcorp_consultant
        string  description = "ZCorp Consultant disrupts your paradigm and table flips your bluesky/redocean.";
        double  hp          = 24;
        double  armour      = 0;
        int     cr          = 3;
        double  speed       = fast;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Hops between adjacent lanes, shoving other zombies in the process.";
        string  almanac     = "She works for ZCorp AND consults for them. Great gig if you can get it!";
        string  origin      = "PvZ 2";

    //zcorp_chair_racer
        string  origin      = "PvZ 2";

    //zcorp_customer_service
        string  description = "Once he reaches the garden, ZCorp Customer Service creates one ZCorp basic on every lane.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Creates one random ZCorp variant basic (except Brickhead) or imp in every lane.";
        string  almanac     = "Hang on - he's got to take this.";
        string  origin      = "PvZ Heroes (Cell Phone Zombie)";

    //zcorp_drone_engineer
        string  description = "The ZCorp Drone Enginner's flying drone attacks plants from a distance for him while he avoids being hit.";
        double  hp          = 10;
        double  armour      = 10;
        int     cr          = 6;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Remote can be removed by Magnetshroom. Controls a ZCorp Drone from 2 tiles distance. He only moves if he must do so for the drone to be able to attack. Behaves like a normal zombie if the drone dies.";
        string  almanac     = "He's not entirely sure how to fly this thing.";
        string  origin      = "PvZ Heroes (Zombot Drone Engineer)";

            //zcorp_drone
                string  description = "It is piloted by the ZCorp Drone Enginner and attacks from a distance.";
                double  hp          = 7;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = fast;
                double  dmg         = 1;
                double  aps         = 1;
                string  special     = "Affected by EMPeach. Flies between roof and garden height. Attacks from a 3-lane distance. If the ZCorp Drone Engineer dies or looses his remote, the drone joins another ZCorp Engineer. If there are none on the field, it dies.";
                string  almanac     = "The pencil on his helmet is completely useless, but the ZCorp engineer liked the aesthetics of it.";
                string  origin      = "PvZ Heroes (Zombot Drone Engineer)";

        //variant_zcorp_drone_engineer:zcorp_swarm_engineer
            string  description = "The ZCorp Swarm Enginner pilotes a couple of small drones from afar.";
            double  hp          = 10;
            double  armour      = 10;
            int     cr          = 7;
            double  speed       = slow;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Remote can be removed by Magnetshroom. Controls two ZCorp Swarm Drone on neighbourghing lanes from one tile back. He only moves if he must do so for the drone to be able to attack. Behaves like a normal zombie if the drone dies.";
            string  almanac     = "You know what's harder than flying one drone? Flying two drones.";
            string  origin      = "PvZ Heroes (Zombot Drone Engineer)";

                //zcorp_swarm_drone
                    string  description = "It is piloted by the ZCorp Swarm Enginner and attacks from a distance.";
                    double  hp          = 3;
                    double  armour      = 0;
                    //int   cr          = n/a;
                    double  speed       = faster;
                    double  dmg         = 1;
                    double  aps         = 0.5;
                    string  special     = "Affected by EMPeach. Flies between roof and garden height. Attacks from a 1-lane distance. If the ZCorp Swarm Engineer dies or looses his remote, the drone joins another ZCorp Engineer. If there are none on the field, it dies.";
                    string  almanac     = "These guys have pens on their helmets because it's classier.";
                    string  origin      = "PvZ Heroes (Zombot Drone Engineer)";

        //elite_zcorp_drone_engineer:zcorp_empd_engineer
            string  description = "The ZCorp EMPD Enginner controls a powerful, electric drone.";
            double  hp          = 12;
            double  armour      = 15;
            int     cr          = 10;
            double  speed       = slow;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Controls a ZCorp EMP Drone from 2 tiles away. He only moves if he must do so for the drone to be able to attack. Behaves like a normal zombie if the drone dies.";
            string  almanac     = "He's not sure he even brought the right remote.";
            string  origin      = "PvZ Heroes (Zombot Drone Engineer)";

                //zcorp_emp_drone
                    string  description = "It is piloted by the ZCorp EMPD Enginner and attacks from a distance.";
                    double  hp          = 8;
                    double  armour      = 5;
                    //int   cr          = n/a;
                    double  speed       = fast;
                    double  dmg         = 2;
                    double  aps         = 0.5;
                    string  special     = "Flies between roof and garden height. Attacks from a 3-lane distance. If the ZCorp EMPD Engineer dies, the drone keeps going on that lane. Attacks occasionaly cause an EMP stun wave in a 3x3 area around target plant.";
                    string  almanac     = "According to the ZCorp EMPD Engineer, EMPD stands fro 'Eat Your Brains Drone'. Yeah, he's never won a spelling bee.";
                    string  origin      = "PvZ Heroes (Zombot Drone Engineer)";

    //zcorp_drone_maintenance
        string  description = "The ZCorp Drone Maintenance can repair other ZCorp Drones from afar.";
        double  hp          = 10;
        double  armour      = 10;
        int     cr          = 6;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Summons a ZCorp Maintenace Drone, then advances as a regular zombie.";
        string  almanac     = "The ZCorp Drone Maintenance pilots the ZCorp Maintenace Drone. Not at all confusing.";
        string  origin      = "Rogue Garden";

            //zcorp_maintenance_drone
                string  description = "It is deployed by the ZCorp Drone Maintenace attaches onto other drones.";
                double  hp          = 5;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = fast;
                double  dmg         = 0;
                double  aps         = 0;
                string  special     = "Affected by EMPeach. Flies between roof and garden height. It attaches onto certain robots (list above), prioritizing ZCorp Drones when possible. While attached to one, it cannot be targeted directly and slowly heals the receptor robot. Once the receptor dies, it either flies to another robot if the ZCorp Drone Maintenance is still alive or dies if he isn't.";
                string  almanac     = "It was carefully coded to self destruct if the deployer dies, even though it doesn't really need him.";
                string  origin      = "Rogue Garden";

    //zcorp_robo-shield
        string  origin      = "PvZ 2 (Shield Zombie)";

    //zcorp_middle_manager
        string  description = "Gets faster and more resilient with the death of ZCorp zombies.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 8;
        double  speed       = slow;
        double  dmg         = 0.5;
        double  aps         = 1;
        string  special     = "Gains +1 hp and +0.5 aps for every ZCorp basic that dies in his lane.";
        string  almanac     = "Leike most managers, bringing pain to his employees gives him strngth.";
        string  origin      = "PvZ Heroes (Zombie Middle Manager)";
    
    //zcorp_custodian
        string  special     = "Affected by EMPeach. Flies towards the roof. Hits plants with his broom instead of eating them, dealing extra damage to plant with 0 aps. Occasionnaly drops sanitizer onto the garden, leaving a small puddle that damages plants on that tile and goes away after a few waves.";
        string  origin      = "PvZ Heroes (Celestial Custodian)";
    
//fantasy_roleplaying_club
    
    //cosmic_roleplayer_zombie
        string  special     = "Once it reaches the garden, turns into a random zombie from the Fantasy Roleplaying Club category.";
        string  origin      = "Rogue Garden ; PvZ 2 (Zombie Knight)";
    
    //imp_dragon
        string  special     = "Immune to fire damage.";
        string  origin      = "PvZ 2";

    //jester_zombie
        double  speed       = normal;
        string  special     = "Reflects projectiles forwards in front of itself. While spinning, moves at 'fast' speed.";
        string  origin      = "PvZ 2";

    //wizard_zombie
        string  special     = "Turns plants into Sheep that zombies can pass through. Plants stay in that form until the Zombie Wizard that turned them dies.";
        string  origin      = "PvZ 2";

    //wizard_gargantuar
        string  special     = "Turns plants he smashes into Zombie Goats. Throws an Imp Dragon upon reaching half hp.";
        string  origin      = "PvZ Heroes";

            //zombie_goat
                string  special     = "When another Zombie Goat or Hover-Goat 3000 within a 3x1 tile area reaches half-hp, gains +1 dmg and +2 hp.";
                string  origin      = "PvZ Heroes";

    //royal_horn_imp
        string  special     = "Plays an instrument. Once it reaches the garden, stops and blows his horn, summoning a Zombie King on his tile but being crushed in the process.";
        string  origin      = "PvZ 2 (Zombie King)";
    
            //zombie_king
                string  special     = "Turns basics into Zombie Knights";
                string  origin      = "PvZ 2";

                    //zombie_knight
                        string  description = "His king appointed helm proves amazing protection from damage.";
                        double  hp          = 10;
                        double  armour      = 75;
                        //int   cr          = n/a;
                        double  speed       = normal;
                        double  dmg         = 1;
                        double  aps         = 2;
                        string  special     = "Helmet can be removed by Magnet-Shroom.";
                        string  almanac     = "Knight Zombie was just as surprised as anyone when Zombie King promoted him. He'd never say this out loud, but he's not sure he deserves the position. He's not sure he has what it takes to wear the armor. But like they say, 'Fake it 'til you make it.'";
                        string  origin      = "PvZ 2";

    //elite_zombie_knight:knight_of_the_living_dead
        string  description = "The Knight of the Living Dead is more living than dead due to his armor.";
        double  hp          = 10;
        double  armour      = 75;
        int     cr          = 10;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Shield blocks straight shooting attacks from the front. As long as he has his helmet, takes 2 less damage from non-fire damage but takes double fire damage. Helmet can be removed by Magnet-Shroom.";
        string  almanac     = "He's both secretary and treasurer for the Zombie Knights of the Square Table.";
        string  origin      = "PvZ Heroes";

    //vimpire
        string  special     = "Gains a movement speed and aps buff upon eating a plant. Dies if he bites garlic.";
        string  almanac     = "Did you know moonlight is just reflected sunlight? Vimpire certainly does, he ALWAYS wears sunscreen.";
        string  origin      = "PvZ Heroes";

    //haunting_zombie
        string  description = "Haunting Zombie becomes a ghost upon death.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Becomes a Haunting Ghost upon death.";
        string  almanac     = "He doesn't realize he would look even scarier without the spooky ghost costume...";
        string  origin      = "PvZ Heroes";

            //haunting_ghost
                string  description = "Haunting Ghost ghosts through your plants, damaging them. Can't be killed but can be chilled.";
                double  hp          = 9999999999;
                double  armour      = 0;
                //int   cr          = n/a;
                double  speed       = fast;
                double  dmg         = 2;
                double  aps         = 2;
                string  special     = "Doesn't die but is affected by chilling. Walks through plants dealing damage to them. Ascends on the first lane.";
                string  almanac     = "Is he a Zombie? Is he a ghost? He refuses to be pigeonholded.";
                string  origin      = "PvZ Heroes";

    //elite_haunting_ghost:nightmare_ghost
        string  description = "Nightmare Ghost ghosts even more ghostly than ghosts usually ghost";
        string  special     = "Only spawns on lanes with 4 or more sleeping plants. Doesn't die but is affected by chilling. Walks through plants heavily damaging and stunning to them. Ascends on the first lane or if there are no more sleeping plants on his lane.";
        string  origin      = "Rogue Garden";
        
    //valkyrie_zombie
        string  description = "Valkyrie Zombie gets stronger the more zombies die.";
        double  hp          = 20;
        double  armour      = 19;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 0;
        double  aps         = 2;
        string  special     = "Gets +1 damage for every zombie in her lane that dies whilst she's alive.";
        string  almanac     = "It's not easy hitting those high notes when all you can sing is, 'Braaaaains.'";
        string  origin      = "PvZ Heroes";
    
    //shieldcrusher_viking_zombie
        string  special     = "Deals gargantuar damage to wall plants.";
        string  origin      = "PvZ Heroes";

    //intergalactic_warlord_zombie
        string  special     = "While alive, all zombies in his garden have +4 hp and +1 dmg.";
        string  origin      = "PvZ Heroes";

    //unthawed_viking_zombie
        string  special     = "Freezes the first plant on the water lanes.";
        string  origin      = "PvZ Heroes";

    //blowgun_imp
        string  special     = "Attacks plants from 2 tiles away. The dart damages the first two plants it encounters.";
        string  origin      = "PvZ Heroes";

    //frankentuar
        string  special     = "Gains +1 hp for every zombie that dies in his lane while he's alive. Throws a Vimpire upon reaching half hp.";
        string  origin      = "PvZ Heroes";

    //guard-gantuar
        string  special     = "Drops his shield on death, that acts as a though gravestone, destroying the plant on that tile.";
        string  origin      = "PvZ 2 China";

//event_dependent_zombies
    
    //zombotany_zombies
        //please refer to the zombotany_list.cs

    //neutron_imp
        string  special     = "Affected by E.M.Peach. Flies towards your roof. Attacks from 1 tile away.";
        string  origin      = "PvZ Heroes";

        //elite_neutron_imp:cryotron_imp
            string  special     = "Only spawns during winter. Affected by E.M.Peach. Flies towards your roof. Attacks from 2 tiles away. Attacks slowly freeze target plants.";
            string  origin      = "PvZ Heroes (Neutron Imp)";

        //elite_neutron_imp:photon_imp
            string  special     = "Only spawns during summer. Affected by E.M.Peach. Flies towards your roof. Upon reaching half way through the garden, stops and charges up a large beam. The beam stuns the first couple of plants in the lane. He then keeps going as normal.";
            string  origin      = "PvZ Heroes (Neutron Imp)";

        //elite_neutron_imp:proton_imp
            string  special     = "Only spawns during fall. Affected by E.M.Peach. Flies towards your roof. Attacks from 1 tile away. Drains energy from the plants under itself, dealing passive damage and healing itself.";
            string  origin      = "PvZ Heroes (Neutron Imp)";

        //elite_neutron_imp:electron_imp
            string  special     = "Only spawns during spring. Affected by E.M.Peach. Flies towards your roof. Attacks from 1 tile away. Attacks from 2 tile away. Bio-electrical attack jumps to neighbouring plants dealing small damage to them.";
            string  origin      = "PvZ Heroes (Neutron Imp)";

    //iron_boarder_imp
        string  special = "Flies towards your roof. Gains +5 HP and +1 dmg when the season changes.";

    //portal_gatekeeper_zombie
        string  description = "While alive, the Portal Gatekeeper Zombie creates portals in the garden that disappear on her death.";
        double  hp          = 30;
        double  armour      = 0;
        //int   cr          = n/a;
        double  speed       = slow;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Spawns with the bottom half of its body inside a portal and jumps down to a random lane once the event ends. Creates pairs of linked portals. Zombies and projectiles that traverse a portal come out the opposite side of whichever portal they are linked to. All portals disappear on her death.";
        string  almanac     = "'Stand here and guard this gate with your unlife,' she was told. And that's what she's been doing ever since.";
        string  origin      = "PvZ Heroes (Wormhole Gatekeeper)";

    //impfinity_clone
        string  description = "A small copy of Impfinity, sent to ruin your day.";
        double  hp          = 7;
        double  armour      = 0;
        //int   cr          = n/a;
        double  speed       = fast;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  specials    = "Can spawn in the pool. Attacks from 2 tiles away.";
        string  almanac     = "An IMPerfect copy, but it'll do.";
        string  origin      = "PvZ Heroes";

    //zom-bats
        string  special     = "Flies towards your roof. Heals the zombie Boss as it damages plants.";

    //variant_exploding_imp:cake_bomb_imp
        string  description = "He's come to celebrate with cake and dynamite.";
        double  hp          = 5;
        double  armour      = 0;
        //int   cr          = n/a;
        double  speed       = fast;
        double  dmg         = 0.5;
        double  aps         = 3;
        string  special     = "Once he reaches a plant, he deals heavy damage to it and half damage to the plants around it and dies.";
        string  almanac     = "4 eggs. 2 cups flour. 10 sticks TNT.";
        string  origin      = "PvZ Heroes ; PvZ GW";

    //dancing_zombies: only spawn in the music event, each event is dedicated to a single zombie.
        
        //jack-in-the-box_zombie
            string  event_name  = "Asylum Escape";
            string  special     = "Eventually explodes in a 3x3 area. Jack-in-the-box can be removed by Magnetshroom.";
            string  origin      = "PvZ 1";
        
        //cuckoo_zombie
            string  event_name  = "Asylum Escape";
            string  special     = "Attacks from a two tile distance.";
            string  origin      = "PvZ Heroes";

        //trickster_zombie
            string  event_name  = "Asylum Escape";
            string  special     = "Uses a punch-box to launch himself forwards, walking back towards the road after landing. Attacks with a rubber chicken instead of bitting.";
            string  origin      = "PvZ Heroes";

        //orchestra_conductor_zombie
            string  event_name  = "Orchestral jam";
            string  description = "While alive, the Orchesta Conductor Zombie makes all zombies do more damage.";
            double  hp          = 20;
            double  armour      = 0;
            //int   cr          = n/a;
            double  speed       = normal;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Spawns in the Zomspear Troupe Theatre and jumps down to a random lane at the end of the event. While alive, all zombies do +1 dmg.";
            string  almanac     = "He isn't in it for the music. He just likes waving sticks.";
            string  origin      = "PvZ Heroes";

        //dancer_zombie
            string  event_name  = "Thriller";
            string  special     = "Behaves exactly like Disco Zombie";
            string  origin      = "PvZ 1 (Original Design) ; Michael Jackson 'Thriller'";

            //backup_dancer_zombie
                string  origin      = "PvZ 1 (Original Design)";

        //piano_zombie
            string  event_name  = "Swing jam";
            string  special     = "Spawns in the Zomspear Troupe Theatre and jumps down to a random lane at the end of the event. Plays a song that makes all basics change between tiles. Crushes plants it touches and dies to spikeweed.";
            string  origin      = "PvZ 2";

        //aerobics_instructor_zombie
            string  event_name  = "Aerobics Class";
            string  description = "While alive, the Aerobics Instructor Zombie makes all zombies fast.";
            double  hp          = 20;
            double  armour      = 0;
            //int   cr          = n/a;
            double  speed       = slow;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Spawns in the Multi-Stage Masher and jumps down to a random lane at the end of the event. While alive, makes all zombies 'fast.'";
            string  almanac     = "Aerobics really bring the dead to life.";
            string  origin      = "PvZ Heroes";

        //binary_stars
            string  event_name  = "Double-Z jam";
            string  description = "While alive, the Binary Stars make all zombies have double attack speed.";
            double  hp          = 20;
            double  armour      = 0;
            //int   cr          = n/a;
            double  speed       = normal;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "Spawn in the Multi-Stage Masher and jump down to a random lane at the end of the event. Two zombies, share HP but eat separately. While alive, all zombies have double aps.";
            string  almanac     = "He's a Gemini and so is she. Which explains so much, right?";
            string  origin      = "PvZ Heroes";

        //punk_zombie
            string  event_name  = "Punk jam";
            string  special     = "Head can be reomved by Magnet-shroom and disappears faster than other objects. Pushes plants it hits backwards. Doesn't affect Infi-nut with its push-back and therefore cannot damage or traverse it.";
            string  origin      = "PvZ 2";

        //glitter_zombie
            string  event_name  = "Pop jam";
            string  special     = "Makes zombies behind itself imune to damage and status effects. Crushes ground plants it passes through.";
            string  origin      = "PvZ 2";

        //mc_zom-b
            string  event_name  = "Rap jam";
            double  dmg         = 3;
            string  special     = "Attacks in a 3x3 area centered on himself.";
            string  origin      = "PvZ 2";

        //breakdancer_zombie
            string  event_name  = "Rap jam";
            string  event_name  = "Pushes other zombies forwards 1 or 2 tiles.";
            string  origin      = "PvZ 2";

        //hair_metal_gargantuar
            string  event_name  = "Metal jam";
            string  description = "Attacks shoot sound waves to damage plants from affar.";
            string  special     = "Throws a Hair Metal Imp upon reaching half hp. Attacks shoot sound waves to damage plants from affar.";
            string  origin      = "PvZ 2";

        //hair_metal_imp
            string  event_name  = "Metal jam";
            string  description = "Moves faster than a normal imp.";
            string  origin      = "PvZ 2";

        //boombox_zombie
            string  event_name  = "Boombox jam";
            string  special     = "Once it walks past a few rows, it plays its music, stunning all plants in its garden. Plants planted after the song has started aren't immediately stunned.";
            string  origin      = "PvZ 2";

        //conga_leader_zombie
            string  event_name  = "Conga line";
            string  description = "He's a born leader, and a born dancer.";
            double  hp          = 10;
            double  armour      = 0;
            //int   cr          = n/a;
            double  speed       = normal;
            double  dmg         = 1;
            double  aps         = 2;
            string  special     = "While alive, Browncoats (and his variants) and Conga Drummer Zombies will continuisly spawn on his lane.";
            string  almanac     = "Conga Line Leader's pretty sure he took a wrong turn a few miles back, but ain't no way he's going to admit it. That's the key to leadership.";
            string  origin      = "PvZ Adventure";

                //variant:ducky_conga_leader_zombie
                    string  event_name  = "Conga line";
                    //stats of Conga Leader Zombie
                    string  special     = "Only spawns in the pool. While alive, ducky browncoats will continuously spawn on his lane.";
                    string  origin      = "PvZ Adventure";

                //conga_drummer_zombie
                    string  description = "Conga Drummer Zombie thrusts music at neighbouring plants to damage them.";
                    double  hp          = 15;
                    double  armour      = 0;
                    //int   cr = n/a;
                    double  speed       = normal;
                    double  dmg         = 1;
                    double  aps         = 1;
                    string  special     = "Plays an instrument. Summoned by Conga Leader Zombie. Attacks neighbouring lanes with her drum instead of the lane in front.";
                    string  almanac     = "Important Note: The fruit on her hat is made of plastic.";
                    string  origin      = "PvZ Heroes";