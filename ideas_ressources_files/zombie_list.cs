
//This is the full list of zombies, which will have an almanac in the game. There will be adjustements with play-testing and many of these will take a long to actually join the game. Any ideas are welcome as long as you follow the guidelines according to the comented template. You are welcome to propose changes and give feedback.

//template_category
    //template_zombie                               //think of including the words "Imp", "Zombie" or "Gargantuar" to the zombie's name if it doesn't already include a reference to its zombie status (i.e. Abracadaver, ZCorp). You can also include "variant_X:---" for special variants of zombies, and "elite_X:---" for elite versions of the zombies for ultra late-game.
        string  description = "blablabla";          //basic description of the zombie and its abilities (if available, you can easily take it straight from its game of origin)
        double  hp          = 10;                   //hit points (hp) is counted in peas
        double  armour      = 0;                    //if relevant, add the hp of potential armour (i.e. Cone), if not "double armour = 0"
        int     cr          = 1;                    //CR stands for Challenge Rating, being the amount of "points" needed to spawn (Higher CR means the zombie spawns later/less often) and therefore should be based on how threatening the zombie is. Check the guide under this template for how to calculate it.
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

//How to calculate CR
//  Note: CR is an arbitrary value that will likely change with play-testing
//Start at the conehead's CR of 2 -> The conehead is special because it is 3x as tough as a browncoat but only 2x less likely to spawn.
//  Note: If making an imp or a gargantuar, start with the normal's CR and stats but apply the same rules.
//Starting from its stats :
//          - Add or remove 1 or 2 CR depending on the speed difference (compared to the Conehead's "normal" speed)
//                  i.e. : "faster" = 2 speeds higher = +2 CR
//                  Note: Sometimes, a zombie benefits from being slower (i.e. Teleportation Zombie being protected from hits until reaching front line.), when that is the case, increase CR for the slower speed.
//          - Add or remove CR depending on the total hp + Armor difference (compared to the Conehead's 10 hp) divided by 10
//                  i.e. : 20 hp + 10 Armor = 20 hp difference = +2 CR
//                  Note: Since armor cannot be healed and can sometimes be removed or ignored (i.e. Magnet vs Buckethead, Fumeshroom vs Screendoor) a high hp zombie is more challenging than a high Armor one, so adapt if necessary
//          - Add or remove CR depending on the difference in dmg and aps (compared to the Conehead's 1 dmg and 2 aps)
//                  i.e. : 2 dmg + 1 aps = more dmg + less aps = +CR -CR = No change
//                       : 2 dmg + 2 aps = more dmg + same aps = +CR
//          - If the zombie has special abilities change the staring point (instead of Conehead's 2 CR)
//                       > weak ability / early-game challenge          = 3-4 CR base
//                       > niche but strong ability/ mid-game challenge = 5-7 CR base
//                       > strong ability / late-game challenge         = 8+  CR base

    //copy-paste
        string  description = "";
        double  hp          = 10;
        double  armor       = 0;
        int     cr          = ;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "";
        string  origin      = "";


//basics
        
    //browncoat_zombie
        string  description = "Regular Garden-variety Zombie";
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
        //int   cr          = N/A;
        double  speed       = fast;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "Make no mistake, Flag Zombie loves brains. But somewhere down the line he also picked up a fascination with flags. Maybe it's because the flags always have brains on them. Hard to say.";
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
        string  special     = "Screendoor blocks incoming, non-piercing attacks from the front and can be removed by magnet-shroom."
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
    
        //variant_basic:ducky_tube_zombie
            string  description = "The ducky tube allows this zombie to float on water.";
            //stats_of_relevent_basics
            string  special     = "Only spawns in the pool.";
            string  almanac     = "It takes a certain kind of zombie to be a Ducky Tuber. Not every zombie can handle it. Some crack. They can't take it. They walk away and give up on brains forever.";
            string  origin      = "PvZ 1";

        //variant_basic:balloon_zombie
            string description  = "A regular airborn zombie.";
            //stats_of_relevent_basics
            string special      = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing.";
            string almanac      = "The original Balloon Zombie was quite disappointed to see that the basics picked up on his technique.";
            string origin       = "PvZ 1";

        //variant_basic:brown_parka_zombie
            string description  = "The zombie's brown parka protects him from the cold.";
            //stats_of_relevent_basics
            string special      = "Only spawns in winter. Immune to chilling and reduces the freezing effect to chilling.";
            string almanac      = "Though many see the use of thicker clothing as a simple survival instinct, Brown Parka Zombie disapproves of this theory. For him, it's all about fashion.";
            string origin       = "PvZ 2 (Frostbite Caves basic)";

        //variant_basic:zcorp_zombie
            string description  = "A typical ZCorp Incorporated employee.";
            //stats_of_relevent_basics
            string special      = "Only spawns during the 'Rush Hour' ambush or when spawned by the ZCorp Costumer Service and Conga Leader Zombie.";
            string almanac      = "He was issued the standard ZCorp coffee mug at orientation.";
            string origin       = "PvZ 2";

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
            string  almanac     = "Paper Plane Imp realized the cons of the old balloon and made a new spike-proof mode of aerial movement.";
            string  origin      = "Rogue Garden";

        //variant_imp:brownparka_imp
            string  description = "It's just an imp, but with a winter jacket.";
            //stats_of_imp
            string  spceial     = "Only spawns in winter. Immune to chilling and reduces the freezing effect to chilling.";
            string  almanac     = "Brownparka Imp recently took up knitting. He started with a scarf, moved to mittens and eventually knitted an entire parka out of cloth he ripped off of Brownparka Gargantuar's brownparka.";
            string  origin      = "PvZ 2 (Yeti Imp)";

        //variant_imp:head_office_imp
            string  description = "Even imps have to work in this economy.";
            //stats_of_imp
            string  special     = "Only spawns during the 'Rush Hour' ambush or when spawned by the ZCorp Costumer Service.";
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
            string  spceial     = "Only spawns in winter. Immune to chilling and reduces the freezing effect of chilling. Throws 3 Brownparka Imps, at 75%, 50% and 25% hp.";
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
        string  special     = "Spawns a browncoat or browncoat variant on the neighbourghing lanes once he reaches the garden.";
    
    //zombie_yeti
        string  special     = "Once it walkes past 4 columns or once 2 waves have passed (whichever one comes first) he walks backwards and out of the garden. If he gets killed, drops a yeti lunch box."; //rewards from yeti lunch box to be defined

    //comsic_yeti
        string  special     = "Once it walkes past 4 columns or once 2 waves have passed (whichever one comes first) he walks backwards and out of the garden. If he gets killed, spawns 2 Yeti zombies.";

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

    //pogo_zombie
        string  description = "Pogo Zombie hops to bypass your defenses.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 5;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Pogo stick can be removed by magnet-shroom. Jumps at 'fast' speed. Jumps over all plants instead of eating them, except Tall-nut which makes him loose his pogo stick if he jumps into it.";
        string  almanac     = "Sproing ! Sproing ! Sproing !That's the sound of a powerful and effective zombie doing what he does best.";
        string  origin      = "PvZ 1";

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
        string  special     = "Moves to a random lane upon reaching half hp. Throws a random imp, except Gargantuar-throwing Imps, in the lane he leaves and another in the lane he lands on."
        string  almanac     = "Surprise! It's a brains-eating monster at your party!";
        string  origin      = "PvZ Heroes";

    //cosmic_imp
        string  special     = "When killed, disapates into 5 random imps in a cross formation centered on himself. Can't create Gargantuar-throwing Imps.";

    //imp-throwing_imp
        string  special     = "Creates a random imp on another random lane when hit. Doesn't create Gargantuar-throwing Imps.";

    //gargantuar-throwing_imp
        string  special     = "Creates a random gargantuar on another random lane upon death. Doesn't create Gargantuar-throwing Gargantuars.";

    //gargantuar-throwing_gargantuar
        string  special     = "Creates a random gargantuar on another random lane upon reaching half hp and upon death. Doesn't create Gargantuar-throwing Gargantuars.";

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

        //zombie_chicken

    //elite_chicken_wrangler_zombie:fire_rooster_wrangler_zombie
        string  special     = "Upon reaching a plant, being hit for a certain amount of damage or dieing, releases a Fire Rooster Zombie on his lane and on each neighbourghing lane.";

    //fire_rooster_zombie
        string  special     = "When a plant is placed on this lane, moves to a neighboring lane then shoots a fireball before continuing forwards.";

    //mixed-up_gravedigger_zombie
        string  description = "The Mixed-Up Gravedigger creates tombstones all over the map.";
        double  hp          = 20;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Creates tombstones on random tiles of the lawn. If the tile is occupied, no tombstone is created. Shovel can be removed by magnet-shroom.";
        string  almanac     = "Digging graves is hard work, but seeing customers rise out of them makes it all worth it.";
        string  origin      = "PvZ Heroes ; PvZ 2 (Tomb Raiser Zombie)";

    //grave_robber_zombie
        string  description = "Robs tombstones to become stronger.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Stops at every tombstone he passes by and gets +3 hp and +1 dmg but damages them stlightly. Buffs are doubled on engraved tombstones and they take double damage.";
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
        string  special     = "Only spawns in spring and summer daytime. Blocks the effects and damage of attacks from above on the tile(s) she's on but not the tiles around";
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
        string  special     = "Only spawns during fall and winter. Spawns with the umbrela closed, then opens it to jump over the first plant he encounters and keeps it open. While open, blocks attacks from above, removes splash damage and stops A.K.E.E's bouncing but doens't block effects.";
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
        string  almanac     = "Imp Porter is stronger than he looks. He's also more charming, smarter and has a better education.";
        string  origin      = "PvZ 2 (Imp Porter)";

        //camping_tent
            string  description = "A tent filled with more zombies than it can fit.";
            strinh  hp          = 50;
            string  special     = "Continuously spawns basics. Can't be healed.";
    
    //dog_walker_zombie
        string  description     = "His dog can smell newly placed plants, and chases after them."
        double  hp              = 20;
        double  armour          = 0;
        int     cr              = 4;
        double  speed           = normal;
        double  dmg             = 1;
        double  aps             = 2;
        string  special         = "Dog walks and eats one tile ahead of the zombie. When a plant is placed on a neighbouring lane, moves to it.";
        string  almanac         = "Is the zombie walking the dog, or is the dog walking the zombie? Hard to say.";
        string  origin          = "PvZ Heroes";

    //cat_lady_zombie
        string  despcription = "Releases hers cats when she dies."
        double  hp          = 30;
        double  armour      = 0;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 0;
        double  aps         = 0;
        string  special     = "Releases a fraidy cat on her lane and on the two neighbouring lanes upon death.";
        string  almanac     = "One of her cats is a Z-Tube celebrity."
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
        string  origin = "OvZ Heroes";

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
        string  origin      = "PvZ 2 (Zombie Hamsterball)"

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
        string  origin      = "PvZ 1 Console Edition ; PvZ Heroes"

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

    //bonus_track_buckethead
        string description = "Prevents your fastest plant from attacking";
        double hp = 10;
        double armour = 55;
        int cr = 11;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "While alive, stuns the highest aps plant in his lane.";
        string almanac = "He put all his favorite songs on that mixtape. If only he could find the right Zombie to give it to.";
        string origin = "PvZ Heroes";

    //coffee_zombie
        string description = "Caffeinates his fellow zombies.";
        double hp = 25;
        double armour = 0;
        int cr = 12;
        double speed = fast;
        double dmg = 1;
        double aps = 2;
        string special = "While alive, every zombie in his garden has double aps.";
        string almanac = "He's been trying to cut back.";
        string origin = "PvZ Heroes";

    //headstone_carver
        string description = "Engraves tombstones he passes by.";
        double hp = 10;
        double armour = 0;
        int cr = 4;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Stops by gravestones he passes and turns them into engraved gravestones. They are uneffected by plant attacks, only defeatable by gravebuster and zombies that rise from them have 125% hp.";
        string almanac = "His epitaphs have been published on headstones around the world.";
        string origin = "PvZ Heroes ; PvZ 1 (Tombstones)";

    //mini-ninja
        string description = "A small zombie that sneaks past your defences."
        double hp = 5;
        double armour = 0;
        int cr = 3;
        double speed = fast;
        double dmg = 0.5;
        double aps = 3;
        string special = "After taking damage for the first time, he turns invisible for 4 tiles before reapearing.";
        string almanac = "His motto: Walk softly and carry a big nunchuck.";
        string origin = "PvZ Heroes ; PvZ 2 China (Bandit Zombie)";

    //stealth_imp
        string description = "A small zombie that wanders through your defences, untraceable.";
        double hp = 5;
        double armour = 0;
        int cr = 3;
        double speed = fast;
        double dmg = 0.5;
        double aps = 3;
        string special = "Only spawns at night. Remains invisible and sneaks past plants for as long as he has his night-vision goggles on. He takes out his night-vision goggles when in range of light producers and fire plants and they can be removed by magnet-shroom.";
        string almanac = "Gadget Scientist Zombie is behind the mysterious technology that allows these night-vision goggles to make Stealth imp invisible.";
        string origin = "PvZ 3";

    //monkey_smuggler_zombie
        string description = "The monkey smuggler sends out his monkey behind the floral wall.";
        double hp = 22;
        double armour = 0;
        int cr = 6;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "Once he reaches a wall plant, he spawns a zombie monkey behind it.";
        string almanac = "Piracy is serious monkey business.";
        string origin = "PvZ Heroes";

        //zombie_monkey
            string description = "The Zombie Money is released by the Monkey Smuggler Zombie to attack your offence.";
            double hp = 15;
            double armour = 0;
            //int cr = N/A;
            double speed = fast;
            double dmg = 1;
            double aps = 3;
            string almanac = "It has a strange fascination with lifting eyepatches.";
            string origin = "PvZ 2 ; PvZ Heroes (Monkey Smuggler)";
    
    //smelly_zombie
        string description = "His nasty odor deals extra damage to non-defensive plants.";
        double hp = 25;
        double armour = 0;
        int cr = 4;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Deals passive damage to non-wall plants in a cross shaped area centered on him.";
        string almanac = "Casual acquaintances don't understand where his pets are. They don't realize that stinkflies can be such tender little friends.";
        string origin = "PvZ Heroes";
    
    //trapper_zombie
        string description = "He lays a trap, what else would a trapper do ?";
        double hp = 20;
        double armour = 0;
        int cr = 5;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Creates a single-use trap on the tile he dies on. Any plant planted on that tile is stunned.";
        string almanac = "Purveyor of only the finest banana peel coats.";
        string origin = "PvZ Heroes";

    //cryo-yeti
        string special = "If chilled, becomes 'faster' and gets double aps. Immune to freezing and chilling.";

    //firefighter_zombie
        string special = "Blocks incoming fire projectiles in a 3x3 area centered on him.";
        double hp = 10;
        double armor = 25;
        int cr = 6;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string almanac = "He's a little too eager to rescue kittens from trees.";
        string origin = "PvZ Heroes";

    //perfume_zombie
        string description = "Throws a poisonous perfume bottle at the plants so they can't attack and are hurt."
        double hp = 30;
        double armor = 0;
        int cr = 11;
        double speed = normal;
        double dmg = 1;
        double aps = 0.5;
        string special = "Throws perfume bottles at plants that release poisonous perfume that stuns and damages them.";
        string almanac = "Perfume Zombie's perfume is popular among the aristocrats.Smells, hmm... tasty !";
        string origin = "PvZ 2 China";

    //ballerina_zombie
        string description = "A group of four agile dancing zombies."
        string hp = 20;
        string armor = 0;
        int cr = 8;
        double speed = fast;
        double dmg = 1;
        double aps = 2;
        string special = "More likely to spawn during Aerobics Class concert event. Always spawns in 'back-up dancer formation' and can randomly switch lanes.";
        string almanac = "'Spin, jump, close my eyes'. Ballerina Zombie likes this song the most.";
        string origin = "PvZ 2 China";

    //firework_zombie
        string almanac = "Launches fireworks at your plants."
        double hp = 35;
        double armor = 0;
        int cr = 12;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Launches fireworks at random tiles that burn the plant there and create fire trails on them.";
        string almanac = "Want to clear some mushrooms? Fire works.";
        string origin = "PvZ 2 China ; design PvZ Heroes";

    //rocket_zombie
        string description = "He rockets his way past your defences.";
        double hp = 35;
        double armor = 0;
        int cr = 10;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "While with its rocket, he becomes 'faster' and ignores all plants. Rocket can be disabled with chilling or freezing.";
        string almanac = "Rocket Zombie ain't got time for this. He ain't got time for that. He does, however, have time for differential calculus.";
        string origin = "PvZ Adventure";

    //ice_block_zombie
        string description = "He's pretty cold right now, and he'll make your plants cold too.";
        double hp = 10;
        double armor = 25;
        int cr = 6;
        double speed = nomral;
        double dmg = 1;
        double aps = 2;
        string special = "Once the ice block is broken, all plants in a 3x3 radius are frozen. Flaming projectiles instantly destroy the ice block. Immune to chilling and freezing.";
        string almanac = "The story how he was frozen along with a fish is completely bogus. Lies from beginning to end.";
        string origin = "PvZ Adventure";

    //barrel_of_deadbeard
        string description = "A barrel that explodes into a powerful pirate captain.";
        double hp = 20;
        double armor = 0;
        int cr = 15;
        double speed = slow;
        double dmg = 0;
        double aps = 0;
        string special = "On destruction, damages all plants in a 3x3 radius and spawns a Captain Deadbeard in its place.";
        string almanac = "No monkeys, just Zombies.";
        string origin = "PvZ Garden Warfare";

            //captain_deadbeard
                string description = "Sends out his trusty parrot while he attacks with his laser gun.";
                double hp = 32;
                double armor = 0;
                //int cr = n/a
                double speed = normal;
                double dmg = 2;
                double aps = 2;
                string special = "Shoots from a 2 tiles away. Sends out a Zombie Parrot.";
                string almanac = "Yo ho ho! It's a pirate's unlife for him!";
                string origin = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";

                //zombie_parrot
                    string description = "Attempts to fly away with your plants.";
                    double hp = 12;
                    double armor = 0;
                    double speed = fast;
                    double dmg = 0;
                    double aps = 0;
                    string special = "Flies towards the front-most plant of a random lane. Once it reaches it, it grabs onto it and stands for a few seconds before flying off with it. Once it flies off or is blown away by a plant, it reappears on the back of its Abracadaver's lane and goes back into the hat. It is instantly killed by butter and if it tries to grab onto a Spring Bean, it will activate and headbutt the Zombie Parrot, killing it.";
                    string almanac = "He's a third generation aviation revolutionary. He wants to serve his pirate brethren like his father and his grandmother, Salty Anne, before him.";
                    string origing = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";

    //elite_barrel_of_deadbeard:barrel_of_flameface
        string description = "A barrel that explodes into a fiery pirate captain.";
        double hp = 25;
        double armor = 0;
        int cr = 19;
        double speed = slow;
        double dmg = 0;
        double aps = 0;
        string special = "On destruction, damages all plants in a 3x3 radius and spawns a Captain Flameface in its place.";
        string almanac = "No flames, just Flameface.";
        string origin = "PvZ Garden Warfare ; PvZ Heroes";
            
            //captain_flameface
                string description = "Sends out his firey companion while he attacks with his fire gun.";
                double hp = 45;
                double armor = 0;
                //int cr = n/a
                double speed = normal;
                double dmg = 2;
                double aps = 2;
                string special = "Shoots from a 1 tiles away, attack pierces through the first plant and also damages the next one. Spawns a Fire Rooster Zombie, and respawns at the back of his lane when it dies.";
                string almanac = "Yo ho ho! It's a pirate's unlife for him!";
                string origin = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";
        
    //pigeon_feeder_zombie
        string special = "While alive, spawns and respawns pigeons on a 3x3 area around him similiarily to the disco zombie.";
        string origin = "PvZ 3";

            //pigeon_zombie
                string special = "Flies at roof height, clogging up your skies but land to eat.";

    //disco_zombie
        string special = "Unlike Dancer Zombie, he can spawn anywhen. While alive, creates Disco Backup Dancers in the tiles above, below and besides him.";

            //backup_disco_zombie

    //elite_disco_zombie:cosmic_dancing_zombie
        string special = "While alive, creates random instrument playing zombies above, below and besides him.";

    //line_dancer_zombie
        string description = "Line Dancer Zombie sings down your lanes to damage all plants.";
        string special = "Moves between lanes. Occasionally sings, damaging every plant in her lane.";
        string almanac = "In her opinion, there's no better song to line dance to than the 'Zombie Shuffle.'";
        string origin = "PvZ Heroes";

    //foot_soldier_zombie
        string special = "Upon reaching the 4th column, he lauches himself upwards to the second to last lane of the roof, dealing heavy damage to the plant he lands on in the process.";
        string origin = "PvZ Garden Warfare"

    //riot_police_bomber_zombie
        string special = "Throws smoke bombs forwards to stun plants. Hits plants with his stick instead of eating.";
        string origin = "PvZ 2 China (Riot Police Zombie)";

    //riot_police_squadron
        string special = "Spawns in formation from 3 to 5 zombies. The zombies on the front and back hold their shields in front and behind them respectively. The zombies in the middle hold it above their heads. This protects the formation from attacks from all directions except down. They attack with their bastons instead of eating.";
        string origin = "PvZ 2 (Camel Zombies) | PvZ 2 China (Riot Police Zombie)";

    //detonator_zombie
        string origin = "PvZ 2 (Prospector Zombie)";

    //medic_zombie
        string special = "Every few seconds, heals all zombies in an 'plus' formation centered on himself for 2hp. Heals Riot Police Zombies and Foot Soldier Zombies for double hp.";
        string origin = "PvZ Heroes ; PvZ 2 (Healer Zombie)";

    //nurse_gargantuar
        string special = "Heals himself 10 hp when he smashes a plant. Throws an Imp upon reaching half hp. If a boss event is ongoing, heals the boss instead.";

    //gilet_jaune_zombie
        string description = "The Gilet Jaune Zombie joins the undead protest with a megaphone in hand. His passionate shouts can rally other zombies to his cause.";
        double hp = 10;
        double armour = 0;
        int cr = 5;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "The Gilet Jaune Zombie shouts slogans against the plants. This shout stuns plants in a 3x3 area and turns  basics into 'Rallied Protestor Zombies.'";
        string almanac = "Once a common citizen, now a shuffler of the streets, the Gilet Jaune Zombie marches against anything in his path. To defend against the Gilet Jaune Zombie consider using plants with resistance to public dissatisfaction.";
        string origin = "Rogue Garden";

        //rallied_protestor_zombie
            string description = "The Rallied Protestor Zombie is an incendiary addition to the undead protest, carrying a torch to burn the rival flora.";
            double hp = 10;
            double armour = 0;
            //int cr = N/A;
            double speed = Fast;
            double dmg = 1;
            double aps = 2;
            string special = "Burns any plant he in front of he. Fire is extinguished with the Chill or Freeze effects and becomes a regular zombie. Fire projectiles can reignite the torch.";
            string almanac = "Ah, the Rallied Protestor Zombie, a connoisseur of chaos summoned by the Gilet Jaune Zombie's botanical revolution. With a torch in hand and a fervent spirit, he elegantly waltzes through the garden, turning flora into a spectacle of flames. Mon dieu, the theatrics! Prepare for a fiery soirée.";
            string origin = "PvZ 2 (Explorer Zombie)";

    //tuba_zombie
        string special = "Plays an instrument. Once it reaches the middle of a tile, it stops then blows to push all zombies on that tile forwards 1-2 tile.";
        string origin = "Rogue Garden";

    //keytar_zombie
        string special = "Plays an instrument. Every few seconds, makes all basics and imps switch lanes.";
        string origin = "PvZ 3 ; PvZ Heroes (Disc-naut)";

    //undead_flamenco_dancers
        string special = "Plays an instrument. Two zombies, share HP but eat separately. Plays castanets to turn basics in a 3x3 area into Flamenco Backup Dancers that walk along the Undead Flamenco Dancers. Throws hat that deals damage equal to amount of Flamenco Backup Dancers in 3x3 area.";
        string origin = "PvZ Heroes (Flamenco Zombie); Rogue Garden";
        
        //flamenco_backup_dancers

    //airborn_zombies

        //bungee_zombie
            string special = "Before appearing, a target is placed on the tile it will land on. After a wave, he jumps down, waits for a few seconds during which it can be hit then steals the plant on that tile. If there is a pumpkin-like plant on that tile, it will prioritize the plant inside. It is blocked by Umbrella Leaf.";

        //bungee_plumber_zombie
            string special = "Before appearing, a copper pipe falls on the tile it will land on, dealing one damage to the plant on that tile and activating instants like potato mines. If there is a pumpkin-like plant on that tile, it will prioritize the plant inside. It is blocked by Umbrella Leaf. After a wave, the he jumps down to pick up the pipe, damaging the plant he lands on for 5 damage. If there is a pumpkin-like plant on that tile, it will prioritize the plant inside. It is blocked by Umbrella Leaf, but deals 2 damage to it.";
            string origin = "PvZ Heroes (Bungee Plumber Jumper)";

        //parachutist_zombie
            string special = "Falls down and gets stuck midair for 1 to 2 waves before falling onto the garden and acting like a normal zombie. It is blocked by Umbrella Leaf once it falls.";
            string origin = "PvZ 2 (Lost Pilot Zombie)";

        //roof_climber_zombie
            string special = "Throws his hook at the roof's gutter then swings into the garden. It is blocked by Umbrella Leaf.";
            string origin = "PvZ Heroes (Mountain Climber) ; PvZ 2 (Swashbuckler / Relic Hunter)";

        //copter_commandimp
            string special = "Flies towards your roof. Attacks from 2 tiles away.";
            string orgin = "PvZ Heroes (Copter Commando)";

        //kite_flyer_zombie
            string description = "Kite Flyer Zombie flies a kyte above him. He shoots any damage inflicted to the kite right back at the plants.";
            double hp = 30;
            double armour = 0;
            int cr = 5;
            double speed = normal;
            double dmg = 1;
            double aps = 2;
            string special = "More likely to appear during Fall. The kite flies on roof height above the Kite Flyer Zombie. Whatever damage the kite takes is shot back at the plants on the ground.";
            string almanac = "The naysayers were right. Flying a kite in a lightning storm WAS a real bright idea.";
            string origin = "PvZ Heroes";

                //kite
                    string description = "The Kite Flyer Zombie's kite";
                    double hp = 15;
                    double armour = 0;
                    //int cr = N/A;
                    //double speed = N/A;
                    //double dmg = N/A;
                    //double aps = N/A;

        //stupid_cupid_imp
            string description = "Flies and attacks to plants under him, which stuns them for a few seconds.";
            double hp = 14;
            double armour = 0;
            int cr = 5;
            double speed = fast;
            double dmg = 1;
            double aps = 2;
            string special = "Flies towards your roof. Deals damage to plants beneath him, which stuns them for a few seconds.";
            string almanac = "What's love got to do with it? Honestly, he has no idea.";
            string origin = "PvZ Heroes";

    //aquatic_zombies
        
        //snorkel_zombie
            string special = "Only spawns in the pool. Dives underwater and only comes out to eat. He can be targeted and hit by lobbers while underwater.";

            //elite_snorkel_zombie:zombie_deep_diver
                string special = "Only spawns in the pool. Dives underwater and only comes out to eat. Skips the first 1 to 3 plants he encounters and instead swims under them. He can't be targeted and hit by lobbers while underwater.";

        //dolphin_rider_zombie
            string special = "Only spawns in the pool. Swims on 'faster' speed while riding his dolphin. Jumps over the first plant he encounters and loses his dolphin. Can't jump over a tall-nut.";

        //seahorse_rider_zombie
            string description = "Rides a seahorse to jump over your defenses.";
            double hp = 20;
            double armour = 0;
            int cr = 6;
            double speed = fast;
            double dmg = 1;
            double aps = 2;
            string special = "Only spawns in the pool. Jumps over all plants instead of eating them, except Tall-nut which makes him loose his seahorse and drown.";
            string almanac = "His small skirt risks making him exposed, which gives him headaches.";
            string origin = "PvZ Endless Edition";

        //surfer_zombie
            string special = "Only spawns during summer and spring. May spawn in the pool. If on land, carries a surfboard over his head that he smashes into the first plant he encounters and drops upon death. If in the pool, surfs rapidly, ignoring your plants except for tall-nut. Behaves like it would do in the pool when on shallow water lanes.";

        //fisherzombie
            string special = "Doesn't spawn during winter. Only spawns in the pool. Stays in the last column of the pool and hooks the front-most plant in his lane and pulls it forwards one tile. Doesn't affect Infi-nut.";
            string origin = "PvZ 2 (Fisherman Zombie)";

            //elite_fisherzombie:fisher_bucket_zombie
                string special = "Can spawn in the pool, except during winter. If in the pool, stays in the last column and hooks the front-most plant in his lane and pulls it forwards one tile. Doesn't affect Infi-nut. If on land, once it reaches the garden, if it still has his bucket, lobs it forwads dealing 6 damage where he lands and an extra 1 damage to all plants in a 1x3 area behind it with the splattering fish. If it flies over an unoccupied Magnetshroom, gets pulled in and doesn't attack. Bucket can be removed by Magnetshroom.";
                string origin = "PvZ 2 (Fisherman Zombie) ; PvZ Heroes (Buckethead Zombie)";

        //octo_zombie
            string special = "Throws octopus at plants in the garden, prioritizing his lane. The octopus acts as a thombstone but is weak to Hot Potato instead of Grave Buster.";

        //synchronized_swimmer_zombie
            string special = "Only spawns in the pool. More likely to spawn during Aerobics Class concert event. Always spawns in groups of three, covering all three pool lanes.";
            string origin = "PvZ Heroes";

        //imp_commander
            string special = "Only spawns in the pool. While alive, every zombie in his lane gets +0.5 aps.";
            string origin = "PvZ Heroes";

        //zombie_high_diver
            string special = "Spawns in the roof like the chimney swipper. Dives into one of the pool lanes, stays submerged for 1 to 3 tiles and advances away from the house.";
            string origin = "PvZ Heroes";

        //walrus_rider_imp
            string special = "Only spawns in the pool, during winter. Slides over the water, propelling the imp forward on the first plant it hits.";
            string origin = "PvZ Heroes";

    //mechanized_zombies: affected by EMPeach - flying zombies affected by EMPeach fall to the ground
    
        //zomboni
            string special = "Creates an ice trail behind him that plants, except plant pots, cannot be planted on and Bobsleds can spawn on. Overrides Paint Bucket Zombie's Paint Trail.";

        //celestial_custodian_zombie
            string special = "Flies towards the roof. Inflicts double damage to plants with 0 aps, inlcuding stunned plants.";

        //space_cowimp
            string special = "Flies towards your roof. Moves to a neighbouring lane when he eats a plant.";
            string origin = "PvZ Heroes (Space Cowboy)";

        //hover_goat-3000
            string special = "Flies towards your roof. Gives zombies directly under itself +1 dmg and heals them over time.";

        //interdimensional_zombie
            string description = "The Interdimensional Zombie occasionally avoids attacks by glitching forward.";
            double hp = 20;
            double armour = 0;
            int cr = 4;
            double speed = normal;
            double dmg = 1;
            double aps = 2;
            string special = "Every third attack that hits him doesn't inflict damage and causes him to glitch forwards one tile.";
            string almanac = "In a parallel dimension, this Zombie is a Space Pirate. In another, he's a Trash Can Zombie. Turns out, little choices in life can make a big difference.";
            string origin = "PvZ Heroes ; PvZ It's Versus Time (Glitched Zombie)";

        //cyborg_zombie
            string description = "The Cyborg Zombie summons a stronger version of himself upon death.";
            double hp = 30;
            double armour = 0;
            int cr = 6;
            double speed = normal;
            double dmg = 1;
            double aps = 2;
            string special = "Once dead, a Vengeful Cyborg Zombie spawns in his lane.";
            string almanac = "He'll be back.";
            string origin = "PvZ Heroes";

                //vengeful_cyborg_zombie
                    string description = "He is stronger than his summoner in every way.";
                    double hp = 60;
                    double armour = 0;
                    //int cr = N/A;
                    double speed = fast;
                    double dmg = 2;
                    double aps = 4;
                    string almanac = "He's back";
                    string origin = "PvZ Heroes";

        //arcade_zombie
            string special = "Pushes an arcade machine that slows itself down but takes hits from the front and spawns 8-Bit Zombies. Can't push the arcade machine past gravestones.";

            //variant:8-bit_zombie
                //animated in less fps

        //bug_bot_imp

        //robo-cone_zombie

        //gargantuar_prime
            string special = "Shoots his laser at plants in the back of the garden. Attacks twice per attack. Throws Bug Bot Imp upon reaching half hp.";

//carnival_zombies
    
    //nutcracker_zombie
        string special = "Deals gargantuar damage to nuts."

    //abracadaver
        string special = "Lifts his hat to reveal a Zombie Dove who'll try to fly off with your plants. If the dove dies, the hat falls off, which releases a Zombie Rabbit.";
        string origin = "PvZ Heroes ; PvZ 2 (Magician Zombie)";

        //zombie_dove
            string special = "Flies towards the front-most plant of a random lane. Once it reaches it, it grabs onto it and stands for a few seconds before flying off with it. Once it flies off or is blown away by a plant, it reappears on the back of its Abracadaver's lane and goes back into the hat. It is instantly killed by butter and if it tries to grab onto a Spring Bean, it will activate and headbutt the Zombie Dove, killing it.";
            string origin = "PvZ 2";

        //zombie_rabbit
            string origin = "PvZ Heroes (Abracadaver); PvZ 2 (Weasel)";

    //pied_piper_zombie
        string description = "The Pied Piper sends out rats to block the front-most plant in his lane.";
        double hp = 10;
        double armour = 0;
        int cr = 3;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "Plays an instrument. Sends Rat Zombies down his lane.";
        string almanac = "He was told that playing the pipe would summon raccoons. But whatevs.";
        string origin = "PvZ Heroes";

            //rat_zombie
                string special = "Cannot be hit by plants. Stuns the first plant they encounter until it dies, then goes on to the next plant. Dies if their Pied Piper dies.";

    //stiltwalker_zombie
        string special = "Walks over plants on his wooden stilts. The zombie itself walks at roof height and the stilts are weak to fire attacks.";

    //drinking_zombie
        string special = "Drinks from his bottle upon reaching half hp. This buffs his speed, dmg and aps.";
        string origin = "PvZ 2 China";

    //carnie_cannon
        string special = "Stays at the back of the garden and occasionnaly shoots out Carnie Imps. If not defeated after a certain time, explodes, shooting 4 to 6 Carnie Imps much further into the garden than it normally would.";
        string origin = "PvZ 2";

            //carnie_imp
                string description = "Often launched from carnie cannons.";
                double hp = 5;
                double armour = 10;
                //int cr = n/a;
                double speed = fast;
                double dmg = 0.5;
                double aps = 3;
                string special = "Helmet can be removed by Magnetshroom.";
                string almanac = "At the same time, though, you wouldn't want to bet your life on these guys only coming out of cannons.";
                string origin = "PvZ 2";

    //imposter
        string special = "Splits into two Imps on adjacent lanes on death, one of which has a moustache. While wearing the coat, it deals more damage when eating plants.";
        string origin = "PvZ Heroes and PvZ Adventure ; PvZ 2 (Carnie Imp Twins)";

//sportive_zombies
    
    //cosmic_sports_star
        string special = "Once he reaches the garden, summons a random non-garg and non-mechanic zombie from the Sportive category in his lane and the neighbourghing lanes.";
    
    //pole_vaulting_zombie

    //catapult_zombie
        string special = "Affected by E.M.Peach.";

    //elite_catapult_zombie:football_catapult_zombie
        string special = "Affected by E.M.Peach.";

    //football_zombie

    //elite_football_zombie:giga_football_zombie

    //quarterback_zombie
        string special = "Helmet does not provide extra HP but instead reduces damage taken by all attacks by 1 and can be removed by Magnetshroom. Upon spawning, throws a football that bounces twice before disappearing then rushes at 'faster' speed until he reaches a plant.";
        string origin = "PvZ Heroes (All-Star Zombie)";
    
    //elite_quarterback_zombie:all-star_zombie
        string special = "Helmet does not provide extra HP but instead reduces damage taken by all attacks by 2 and can be removed by Magnetshroom. Upon spawning, summons an All-star Super Fan Imp on his lane. Once it reaches the garden, rushes forwards at 'faster' speed, throws it forwards and deals gargantuar damage to the first plant it encounters.";

        //all-star_super_fan_imp

    //tennis_champ_zombie
        string special = "Has 5 dmg until eating her first plant.";

    //arm_wrestler_zombie
        string special = "Gains +2 hp and +1 dmg when a plant is planted on his lane.";

    //planetary_gladiator_zombie
        string special = "Absorbs damage for zombies in front of him in his lane.";

    //brain_vendor_zombie
        string special = "Moves zombies behind him from neighbouring lanes into his own.";

    //team_mascot_imp
        string spceial = "Gives all zombies in his lane +1 dmg for every plant that dies in his lane whilst he's alive.";

    //zombie_coach
        string special = "Gives all zombies in his lane +2 hp for every plant that dies in his lane whilst he's alive.";

    //bobsled_team
        string special = "Only spawns in winter or in Zomboni ice trail.";

    //mecha-football_zombie
        string special = "Affected by E.M.Peach. Pushes plants back for as long as there is space behind it.";

    //defensive_end_gargantuar
        string special = "While alive, all seeds recharge time is increased. Throws an All-Star Super Fan Imp upon reaching half hp.";

    //rodeo_gargantuar
        string special = "Switches plant with a plant behind it before smashing it. Throws a Zombie Chicken upon reaching half hp.";

//construction_zombies
    
    //construction_cone_zombie
        string special = "Once it reaches an empty tile, if it still has its cone, places it down turning the tile into a construction site that cannot be planted on. The construction finishes once 10 zombies have walked past it. Construction Zombies count twice.";
        string origin = "PvZ 1 (Conehead Beta Design)";

    //paint_bucket_zombie
        string special = "Doesn't spawn during winter. Once he reaches the garden, drops his bucket and drags it creating a trail of red paint the boosts the speed of zombies on it. It overrides Zomboni Ice Trails.";
        string origin = "PvZ 1 (Buckethead Beta Design)"

    //ladder_zombie

    //supply-barrel_roller_zombie
        string origin = "PvZ 2 (Barrel Roller Zombie)";

        //supply-barrel
    
    //digger_zombie

    //excavator_zombie
    
    //electrician_zombie
        string special = "Zombies behind him on his lane are faster.";

    //kitchen_sink_zombie
        string description = "This zombie has essentially got the power of a gargantuar, though he prefers eating over smashing.";
        string special = "Throws a pipe forwards before every attack.";

    //landscaper_zombie
        string special = "While alive, stuns the highest damage plant in his lane.";
            
    //gardener_zombie
        string special = "Once it reaches the garden, 'shovels' the front-most attacking plant in his lane (deosn't count as destroying it*) and replaces it with a Plant Pot that cannot be shoveled or be planted on for 3 waves.";  //*relevent for plants like Explodo-nut and Puni-Shroom
        string description = "PvZ Heroes (Biodome Botanist Zombie)";

    //waste_barrel_imp
        string special = "Can spawn in the pool. Crushes plants he walks into. Destroyed by spike weed and tangled kelp.";

    
//museum_zombies
    
    //awakened_ra_zombie

    //awakened_cleopatra_zombie
        string origin = "PvZ 2 China";

    //dodo_fossil_rider_imp

    //turquoise_skull_thief_zombie
        string almanac = "Every one of them brags about having stolen the real skull, but none realize they took it from the Neighbourghville Museum's gift shop.";
        string origin = "PvZ 2";

    //zombie_medusa
        string special = "Turns basics in front of it into zombie statues that she then pushes, crushing plants as she does so but being heavily slowed down. Can only have one zombie statue per tile.";

        //zombie_statue
            string special = "Works essentially like a gravestone, also being affected by gravebuster. Cannot be pushed past gravestones and other alike things. If it reaches 0hp it'll turn into a Sculpted Zombie, unless killed by a gravebuster.";

            //variant_kinght:bust_head_zombie
                string description = "A bust head means this sculpted zombie can take a serious beating.";
                double hp = 10;
                double armour = 75;
                //int cr = n/a;
                double speed = normal;
                double dmg = 1;
                double aps = 2;
                string special = "Imune to Zombie Medusa's effect even after loosing all armor.";
                string almanac = "Bust Head Zombie belongs in the Neighbourghville Museum with a big sign that says, 'WARNING: THIS IS A ZOMBIE!'";
                string origin = "PvZ 2";

    //primeval_yeti
        string special = "Gives all zombies in his lane +2 hp and +1 dmg when he dies.";

    //cursed_gargolith
        string special = "Only spawns from engraved gravestones, but has high chances to spawn. Throws an Impstone upon reaching half hp.";

        //impstone
            string special = "A gravestone that spawns a CR 2 or less imp on every Huge and Final Wave.";

    //archeology_guide_zombie
        string special = "After a few seconds on the garden, opens a whole on the garden, digs forwards 3 tiles, then comes back up, creating a 5 tile long tunnel for non-gargantuar zombies to evade attacks and pass into your defenses. Diggers that dig into it come out the end of the tunnel. Each tile of the tunnel only lasts 10 seconds before disapearing. If he creates the tunnel on a shallow water tile, the tunnel collapses and the zombies inside die.";
        string origin = "PvZ 2 China (Lost Guide Zombie)";

//scientific_zombies
    
    //cosmic_scientist
        string special = "Once it reaches the garden, throws a potion on the lanes above and below him that each spawn a  zombie from the Scientific category.";

    //cardboard_robot_zombie
        double hp = 14;
        double armour = 0;
        int cr = 2;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Attacks from 1 tiles away.";

    //disinfection_zombie
        string special = "Only spawns in the pool. Releases toxic chemicals that slowly move along his lane, lightly damaging all plants.";
        string origin = "PvZ 2 China";
    
        //zombie_drop-off_rocket
        string special = "Flies towards your roof. Drops a Bug Bot Imp upon reaching 75%, 50% and 25% hp. Once it reaches the roof, stops and drops off a Moonwalker.";
        string origin = "PvZ 2 China (Transport Ship) ; PvZ 2 (Far Future imp rain)";

        //moonwalker
            string special = "Dropped off by a Zombie Drop-off Rocket on the roof. Places down a flag at the edge of the roof that lasts 2 to 3 waves and makes all new zombies in that lane spawn with an additional 3 HP.";
    
    //gargologist_zombie
        string special = "While alive, all gargantuars in her lane get +0.5 aps.";

    //gadget_scientist_zombie
        string description = "The Gadget Scientist Zombie summons Space Cadet Zombies onto the garden.";
        double hp = 30;
        double armour = 0;
        int cr = 8;
        double speed = fast;
        double dmg = 2;
        double aps = 1;
        string special = "Gun can be removed by Magnetshroom. Creates 4 Space Cadet Zombies across the 7 lanes, on the columns 4 to 6, once he reaches the garden. Attacks from 2 tiles away.";
        string almanac = "He wishes the Mad Chemist would stop copying his hairstyle.";
        string origin = "PvZ Heroes";

            //space_cadet_zombie
                string description = "Is summoned by the Gadget Scientist Zombie.";
                double hp = 10;
                double armour = 5;
                //int cr = N/A;
                double speed = normal;
                double dmg = 1;
                double aps = 2;
                string almanac = "His body is in space but his head is in the clouds.";
                string origin = "PvZ Heroes";

    //mad_chemist_zombie
        string description = "The Mad Chemist Zombie places potions on the ground around him to buff other zombies.";
        double hp = 40;
        double armour = 0;
        int cr = 8;
        double speed = fast;
        double dmg = 1;
        double aps = 2;
        string special = "Places potions on his lane and neighbouring lanes every three tiles. There are three different potions: Purple gives the zombies +10 armour (visually indicated by a purple cloud), orange makes them faster (not stackable) and blue makes them invisible and untouchable for three tiles. These effects do not stack with each other. Isn't affected by potions.";
        string almanac = "He's not so much 'mad' as he is 'mildly annoyed.'";
        string origin = "PvZ Heroes ; PvZ 2 and Pv2 China (Dark Ages potions)";

    //teleportation_zombie
        string description = "The Teleportation Zombie teleports all zombies in his column one tile forwards upon death.";
        double hp = 30;
        double armour = 0;
        int cr = 9;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "Teleports all zombies in his column one tile forwards upon death.";
        string almanac = "The phone cord stretches to another dimension.";
        string origin = "PvZ Heroes";

    //portal_technician_zombie
        string description = "The Portal Technician Zombie turns into a random zombie after dying.";
        double hp = 20;
        double armour = 10;
        int cr = 8;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "After dying, creates a random zombie in his place.";
        string almanac = "Soon everyone will own their own portal. But for now, he enjoys being an early adopter.";
        string origin = "PvZ Heroes";

    //space_ninja_zombie
        string description = "He attacks all plants in a 3x3 area for 0.5 damage everytime he attacks.";

    //zom-blob
        string special = "More likely to spawn during Radiation Wave event. Ignores plants and leaves a blob trail behind him that deals dot and disappears after a few seconds.";

    //genetic_experiement
        string special = "More likely to spawn during the Radiation Wave event. Upon reaching the garden, incapsulates himself. He does leave not until the capsule is destroyed. Whilst in the capsule, gains +2 hp and +1 dmg for every four zombies that pass him.";

//zcorp_zombies
    
    //zcopr_monitor_head
        string description = "ZCorp Monitor Heads are zombies with Cone-grade protection that can attack your plants from a distance.";
        double hp = 29;
        double armour = 0;
        int cr = 4;
        double speed = normal;
        double dmg = 1;
        double aps = 1;
        string special = "Can shoot plants in his lane from 4 tiles away.";
        string almanac = "ZCorp Monitor Head is hard-working. So much so that he purposefully fused his head with his monitor to achieve never-before-seen work efficiency.";
        string origin = "PvZ Battle for Neighborville (TV Head)";
    
    //zcorp_consultant
        string description = "ZCorp Consultant disrupts your paradigm and table flips your bluesky/redocean.";
        double hp = 24;
        double armour = 0;
        int cr = 3;
        double speed = fast;
        double dmg = 1;
        double aps = 2;
        string special = "Hops between adjacent lanes, shoving other zombies in the process.";
        string almanac = "She works for ZCorp AND consults for them. Great gig if you can get it!";
        string origin = "PvZ 2";

    //zcorp_chair_racer

    //zcorp_customer_service
        string description = "Once he reaches the garden, ZCorp Customer Service creates one ZCorp basic on every lane.";
        double hp = 10;
        double armour = 0;
        int cr = 8;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Creates one random ZCorp variant basic (except Brickhead) or imp in every lane.";
        string almanac = "Hang on - he's got to take this.";
        string origin = "PvZ Heroes (Cell Phone Zombie)";

    //zcorp_drone_engineer
        string description = "The ZCorps Drone Enginner's flying drone attacks plants from a distance for him while he avoids being hit.";
        double hp = 10;
        double armour = 10;
        int cr = 6;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "Remote can be removed by Magnetshroom. Controls a drone from 2 tiles distance. He only moves if he must do so for the drone to be able to attack. Behaves like a normal zombie if the drone dies.";
        string almanac = "He's not entirely sure how to fly this thing.";
        string origin = "PvZ Heroes (Zombot Drone Engineer)";

            //zcorp_drone
                string description = "It is piloted by the ZCorp Drone Enginner and attacks from a distance.";
                double hp = 7;
                double armour = 0;
                //int cr = N/A;
                double speed = fast;
                double dmg = 1;
                double aps = 1;
                string special = "It can only be targetted by plants that can attack flying zombies. Attacks from a 3-lane distance. If the ZCorp Drone Engineer dies or looses his remote, the drone joins another ZCorp Drone Engineer. If there are none on the field, it dies.";
                string almanac = "The pencil on his helmet is completely useless, but the ZCorp engineer liked the aesthetics of it.";
                string origin = "PvZ Heroes (Zombot Drone Engineer)";

    //zcorp_robo-shield
        string  origin      = "PvZ 2 (Shield Zombie)";

    //zcorp_middle_manager
        string  description = "Gets faster and more resilient with the death of ZCorp zombies.";
        double hp = 10;
        double armour = 0;
        int cr = 8;
        double speed = slow;
        double dmg = 0.5;
        double aps = 1;
        string special = "Gains +1 hp and +0.5 aps for every ZCorp basic that dies in his lane.";
        string almanac = "Leike most managers, bringing pain to his employees gives him strngth.";
        string origin = "PvZ Heroes (Zombie Middle Manager)";
    
//fantasy_roleplaying_club
    
    //cosmic_roleplayer_zombie
        string special = "Once it reaches the garden, turns into a random zombie from the Fantasy Roleplaying Club category.";
        //zombie knight for design
    
    //imp_dragon
        string special = "Immune to fire damage.";

    //jester_zombie
        double speed = normal;
        string special = "Reflects projectiles forwards in front of itself. While spinning, moves at 'fast' speed.";

    //wizard_zombie
        string special = "Turns plants into sheep that zombies can pass through. Plants stay in that form until the Zombie Wizard that turned them dies.";

    //wizard_gargantuar
        string special = "Turns plants he smashes into Zombie Goats. Throws an Imp Dragon upon reaching half hp.";
        string origin = "PvZ Heroes";

            //zombie_goat
                string special = "When another Zombie Goat within a 3x1 tile area reaches half-hp, gains +1 dmg and +2 hp.";

    //royal_horn_imp
        string special = "Plays an instrument. Once it reaches the garden, stops and blows his horn, summoning a Zombie King on his tile but being crushed in the process.";
        string origin = "PvZ 2 (Zombie King)";
    
        //zombie_king
            string special = "Turns basics into Zombie Knights";

                //zombie_knight
                    string description = "His king appointed helm proves amazing protection from damage.";
                    double hp = 10;
                    double armour = 75;
                    //int cr = n/a;
                    double speed = normal;
                    double dmg = 1;
                    double aps = 2;
                    string special = "Helmet can be removed by Magnet-Shroom.";
                    string almanac = "Knight Zombie was just as surprised as anyone when Zombie King promoted him. He'd never say this out loud, but he's not sure he deserves the position. He's not sure he has what it takes to wear the armor. But like they say, 'Fake it 'til you make it.'";
                    string origin = "PvZ 2";

    //knight_of_the_living_dead
        string description = "The Knight of the Living Dead is more living than dead due to his armor.";
        double hp = 10;
        double armour = 75;
        int cr = 10;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Shield blocks straight shooting attacks from the front. As long as he has his helmet, takes 2 less damage from non-fire damage but takes double fire damage. Helmet can be removed by Magnet-Shroom.";
        string almanac = "He's both secretary and treasurer for the Zombie Knights of the Square Table.";
        string origin = "PvZ Heroes";

    //vimpire
        string special = "Gains a movement speed and aps buff upon eating a plant. Dies if he bites garlic.";
        string origin = "PvZ Heroes";

    //haunting_zombie
        string description = "Haunting Zombie becomes a ghost upon death.";
        double hp = 10;
        double armour = 0;
        int cr = 6;
        double speed = normal;
        double dmg = 1;
        double aps = 2;
        string special = "Becomes a Haunting Ghost upon death.";
        string almanac = "He doesn't realize he would look even scarier without the spooky ghost costume...";
        string origin = "PvZ Heroes";

            //haunting_ghost
                string description = "Haunting Ghost ghosts through your plants, damaging them. Can't be killed but can be chilled.";
                double hp = 9999999999;
                double armour = 0;
                //int cr = N/A;
                double speed = fast;
                double dmg = 2;
                double aps = 2;
                string special = "Doesn't die but is affected by chilling. Walks through plants dealing damage to them. Ascends on the first lane.";
                string almanac = "Is he a Zombie? Is he a ghost? He refuses to be pigeonholded.";
                string origin = "PvZ Heroes";
        
    //valkyrie_zombie
        string description = "Valkyrie Zombie gets stronger the more zombies die.";
        double hp = 20;
        double armour = 19;
        int cr = 6;
        double speed = normal;
        double dmg = 0;
        double aps = 2;
        string special = "Gets +1 damage for every zombie in her lane that dies whilst she's alive.";
        string almanac = "It's not easy hitting those high notes when all you can sing is, 'Braaaaains.'";
        string origin = "PvZ Heroes";
    
    //shieldcrusher_viking_zombie
        string special = "Deals gargantuar damage to wall plants.";
        string origin = "PvZ Heroes";

    //intergalactic_warlord_zombie
        string special = "While alive, all zombies in his garden have +4 hp and +1 dmg.";
        string origin = "PvZ Heroes";

    //unthawed_viking_zombie
        string special = "Freezes the first plant on the water lanes.";
        string origin = "PvZ Heroes";

    //blowgun_imp
        string special = "Attacks plants from 2 tiles away. The dart damages the first two plants it encounters.";
        string origin = "PvZ Heroes";

    //frankentuar
        string special = "Gains +1 hp for every zombie that dies in his lane while he's alive. Throws a Vimpire upon reaching half hp.";
        string origin = "PvZ Heroes";

//event_dependent_zombies
    
    //zombotany_zombies
        //please refer to the zombotany_list.cs

    //neutron_imp
        string special = "Flies towards your roof. Affected by E.M.Peach. Attacks from 1 tile away.";

    //portal_gatekeeper_zombie
        string description = "While alive, the Portal Gatekeeper Zombie creates portals in the garden that disappear on her death.";
        double hp = 30;
        double armour = 0;
        //int cr = N/A;
        double speed = slow;
        double dmg = 1;
        double aps = 2;
        string special = "Creates pairs of linked portals. Zombies and projectiles that traverse a portal come out the opposite side of whichever portal they are linked to. All portals disappear on her death.";
        string almanac = "'Stand here and guard this gate with your unlife,' she was told. And that's what she's been doing ever since.";
        string origin = "PvZ Heroes (Wormhole Gatekeeper)";

    //impfinity_clone
        string description = "A small copy of Impfinity, sent to ruin your day.";
        double hp = 7;
        double armour = 0;
        //int cr = n/a;
        double speed = fast;
        double dmg = 0.5;
        double aps = 3;
        string specials = "Can spawn in the pool. Attacks from 2 tiles away.";
        string almanac = "An IMPerfect copy, but it'll do.";
        string origin = "PvZ 2";

    //variant_exploding_imp:cake_bomb_imp
        string despcription = "He's come to celebrate with cake and dynamite.";
        double hp = 5;
        double armour = 0;
        //int cr = n/a;
        double speed = fast;
        double dmg = 0.5;
        double aps = 3;
        string special = "Once he reaches a plant, he deals heavy damage to it and hald damage to the plants around it and dies.";
        string almanac = "4 eggs. 2 cups flour. 10 sticks TNT.";
        string origin = "PvZ Heroes and GW";

    //dancing_zombies: only spawn in the music event, each event is dedicated to a single zombie.
        
        //jack-in-the-box_zombie
            string event_name = "Asylum Escape";
            string special = "Eventually explodes in a 3x3 area. Jack-in-the-box can be removed by Magnetshroom.";
        
        //cuckoo_zombie
            string event_name = "Asylum Escape";
            string special = "Attacks from a two tile distance.";

        //trickster_zombie
            string event_name = "Asylum Escape";
            string special = "Uses a punch-box to launch itself forwards. Attacks with a rubber chicken instead of bitting.";

        //orchestra_conductor_zombie
            string event_name = "Orchestral jam";
            string description = "While alive, the Orchesta Conductor Zombie makes all zombies do more damage.";
            double hp = 20;
            double armour = 0;
            //int cr = N/A;
            double speed = normal;
            double dmg = 1;
            double aps = 2;
            string special = "While alive, all zombies do +1 dmg.";
            string almanac = "He isn't in it for the music. He just likes waving sticks.";
            string origin = "PvZ Heroes";

        //dancer_zombie
            string event_name = "Thriller";
            string special = "Behaves exactly like Disco Zombie";

            //backup_dancer_zombie

        //pianist_zombie
            string event_name = "Swing jam";
            string special = "Plays a song that makes all basics change between tiles. Crushes plants it touches and dies to spikeweed.";

        //aerobics_instructor_zombie
            string event_name = "Aerobics Class";
            string description = "While alive, the Aerobics Instructor Zombie makes all zombies fast.";
            double hp = 20;
            double armour = 0;
            //int cr = N/A;
            double speed = slow;
            double dmg = 1;
            double aps = 2;
            string special = "While alive, makes all zombies 'fast.'";
            string almanac = "Aerobics really bring the dead to life.";
            string origin = "PvZ Heroes";

        //binary_stars
            string event_name = "Double-Z jam";
            string description = "While alive, the Binary Stars make all zombies have double attack speed.";
            double hp = 20;
            double armour = 0;
            //int cr = N/A;
            double speed = normal;
            double dmg = 1;
            double aps = 2;
            string special = "Two zombies, share HP but eat separately. While alive, all zombies have double aps.";
            string almanac = "He's a Gemini and so is she. Which explains so much, right?";
            string origin = "PvZ Heroes";

        //punk_zombie
            string event_name = "Punk jam";
            string special = "Head can be reomved by Magnet-shroom and is disappears faster than other objects. Pushes plants it hits backwards. Doesn't affect Infi-nut with its push-back and therefore cannot damage or traverse it.";

        //glitter_zombie
            string event_name = "Pop jam";
            string event_name = "Makes zombies behind itself imune to damage and status effects. Crushs ground plants it passes through.";

        //mc_zom-b
            string event_name = "Rap jam";
            double dmg = 3;
            string special = "Attacks in a 3x3 area centered on himself.";

        //breakdancer_zombie
            string event_name = "Rap jam";
            string event_name = "Pushes other zombies forwards 1 or 2 tiles when it reaches them it plays its music, stunning all plants in its garden. Plants planted after the song has started aren't immediately stunned.";

        //hair_metal_gargantuar
            string event_name = "Metal jam";
            string description  = "Attacks shoot sound waves to damage plants from affar.";
            string special = "Throws a Hair Metal Imp upon reaching half hp.";

            //hair_metal_imp
                string event_name = "Metal jam";
                string description = "Moves faster than a normal imp.";

        //boombox_zombie
            string event_name = "Boombox jam";
            string special = "Once it walks past a few rows, it makes ";

        //conga_leader_zombie
            string event_name = "Conga line";
            string description = "He's a born leader, and a born dancer.";
            double hp = 10;
            double armour = 0;
            //int cr = n/a;
            double speed = normal;
            double dmg = 1;
            double aps = 2;
            string special = "While alive, Browncoats (and his variants) and Conga Drummer Zombies will continuisly spawn on his lane.";
            string almanac = "Conga Line Leader's pretty sure he took a wrong turn a few miles back, but ain't no way he's going to admit it. That's the key to leadership.";
            string origin = "PvZ Adventure";

            //variant:ducky_conga_leader_zombie
                string event_name = "Conga line";
                //stats of Conga Leader Zombie
                string special = "Only spawns in the pool. While alive, ducky browncoats will continuously spawn on his lane.";
                string origin = "PvZ Adventure";

            //conga_drummer_zombie
                string description = "Conga Drummer Zombie thrusts music at neighbouring plants to damage them.";
                double hp = 15;
                double armour = 0;
                //int cr = n/a;
                double speed = normal;
                double dmg = 1;
                double aps = 1;
                string special = "Plays an instrument. Summoned by Conga Leader Zombie. Attacks neighbouring lanes with her drum instead of the lane in front.";
                string almanac = "Important Note: The fruit on her hat is made of plastic.";
                string origin = "PvZ Heroes";