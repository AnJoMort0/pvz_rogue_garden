//This is the full list of basic zombie variants.

//template_category
    //template_zombie                               //think of including the words "Imp", "Zombie" or "Gargantuar" to the zombie's name if it doesn't already include a reference to its zombie status (i.e. Abracadaver, ZCorp). You can also include "variant_X:---" for special variants of zombies, and "elite_X:---" for elite versions of the zombies for ultra late-game.
        string  description = "It's a browncoat, but...";          //basic description of the zombie and its abilities (if available, you can easily take it straight from its game of origin)
        double  hp          = 10;                   //hit points (hp) is counted in peas
        double  armour      = 0;                    //if relevant, add the hp of potential armour (i.e. Cone), if not "double armour = 0"
        int     cr          = 1;                    //CR stands for Challenge Rating, being the amount of "points" needed to spawn (Higher CR means the zombie spawns later/less often) and therefore should be based on how threatening the zombie is. Check the CR Calculator to see a more in depth description of what CR is and get some help to decide it.
        double  speed       = normal;               //speeds written after template
        double  dmg         = 1;                    //damage (dmg) is counted in peas - yes, even the zombies'. Note: the average non-wall plant will have 6 HP.
        double  aps         = 2;                    //aps stands for attacks per second, aka how fast the zombie attacks
        string  special     = "Ha, as if";                   //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line. This is also where you include Magnet-shroom, Umbrella Leaf and other plant based weaknesses. Note: by default, zombies can't spawn on water or on air at all, so add precisions such as "Can spawn" or "only spawns in water" for the pool and "Flies towards the roof" (Flying zombies fly at "roof height", so if a peashooter is placed on the roof it'll be able to shoot the flying zombies) when necessary.
        string  almanac     = "How else would the Ducky Tube screendoor variant get an almanac entry?";    //almanac entry, be it copied from one of the original games or entirely/partially new
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

//browncoats
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

//ducky_tube
    //ducky_tuber_zombie
        string  description = "The ducky tube allows this zombie to float on water.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns in the pool.";
        string  almanac     = "It takes a certain kind of zombie to be a Ducky Tuber. Not every zombie can handle it. Some crack. They can't take it. They walk away and give up on brains forever.";
        string  origin      = "PvZ 1";

    //ducky_tuber_conehead_zombie
        string  description = "His fishy cone makes him twice as though as normal ducky tubers.";
        double  hp          = 10;
        double  armour      = 18;
        int     cr          = 2;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns in the pool.";
        string  almanac     = "Th starfish on his cone is a plastic toy he bought from Z-Bay.";
        string  origin      = "PvZ 2";

    //lounge_chair_zombie
        string  description = "His lougne chair is an effective shield.";
        double  hp          = 10;
        double  armour      = 58;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special = "Only spawns in the pool. Screendoor blocks incoming, non-piercing attacks from the front and can be removed by magnet-shroom.";
        string  almanac     = "The reason the Ducky Tuber Lounge Chair Zombie carries the lounge chair in front of him is because he doesn't know how to lay down.";
        string  origin      = "Rogue Garden";

    //ducky_tuber_buckethead_zombie
        string  description = "His shell-ornated helmet makes him extremely resistant to damage.";
        double  hp          = 10;
        double  armour      = 55;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns in the pool. Bucket can be removed by Magnetshroom";
        string  almanac     = "He tried picking up shell collecting one time, but got tired after the first one. He stils bousts about finding it whenever he gets the chance, though.";
        string  origin      = "PvZ 2";
    
    //barrelhead_zombie
        string  description = "The Barrelhead's barrel head provides thoroughly barreled barrel-likeness.";
        double  hp          = 10;
        double  armour      = 95;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns in the pool.";
        string  almanac     = "He dreamed of becoming a pirate when he was younger. The barrel on his head is his way of fulfilling that wish.";
        string  origin      = "PvZ 2 (Barrelhead Zombie)";

//balloon
    //balloon_zombie
        string  description = "Regular airborn zombie.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing.";
        string  almanac     = "The original Balloon Zombie was quite disappointed to see that the basics picked up on his technique.";
        string  origin      = "PvZ 1";

    //balloon_conehead_zombie
        string  description = "His lit-up cone headpiece makes him twice as though as normal baloon zombies.";
        double  hp          = 10;
        double  armour      = 18;
        int     cr          = 2;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing.";
        string  almanac     = "His cone is used to allow pilots to see the landing track from the sky. If you get enough Baloon Conehead Zombies together, that should be enough to pull a fun prank on a passager train.";
        string  origin      = "PvZ 2 China (Pilot Zombie)";

    //balloon_kite_zombie
        string  description = "His pink kite is an effective shield.";
        double  hp          = 10;
        double  armour      = 58;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing. Screendoor blocks incoming, non-piercing attacks from the front and can be removed by magnet-shroom.";
        string  almanac     = "He couldn't quite get his kite to fly in the wind so he decided to just fly himself instead.";
        string  origin      = "Rogue Garden";

    //enginehead_zombie
        string  description = "His engine hat makes him extremely resistant to damage.";
        double  hp          = 10;
        double  armour      = 55;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing. Bucket can be removed by Magnetshroom";
        string  almanac     = "No one knows where he got that plane engine from, which is incredibly worrying.";
        string  origin      = "PvZ 2 China (Pilot Zombie)";
    
    //birdhousehead_zombie
        string  description = "Birdhousehead's bird house head provides birds a house on his head.";
        double  hp          = 10;
        double  armour      = 95;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Flies towards your roof. When the balloon pops, the zombie drops down onto the garden. He takes 3 dmg on landing.";
        string  almanac     = "Birdhousehead Zombie doesn't know he's wearing a birdhouse, so he gets confused whenever a blue jay flies straight into his eye.";
        string  origin      = "Rogue Garden";

//brown_parka
    //brownparka_zombie
        string  description = "The zombie's brown parka protects him from the cold.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling.";
        string  almanac     = "Though many see the use of thicker clothing as a simple survival instinct, Brown Parka Zombie disapproves of this theory. For him, it's all about fashion.";
        string  origin      = "PvZ 2 (Frostbite Caves basic)";

    //brownparka_conehead_zombie
        string  description = "His souvenir headpiece makes him twice as though as normal zombies.";
        double  hp          = 10;
        double  armour      = 18;
        int     cr          = 2;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling.";
        string  almanac     = "He got his cone from a visit to Mount Fuji.";
        string  origin      = "PvZ 2 China (Samurai World conehead)";

    //sled_zombie
        string  description = "His sled is an effective shield.";
        double  hp          = 10;
        double  armour      = 58;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling. Screendoor blocks incoming, non-piercing attacks from the front and can be removed by magnet-shroom.";
        string  almanac     = "Unfortunately for Sled Zombie, the garden is too flat for snow-sliding.";
        string  origin      = "Rogue Garden";

    //pothead_zombie
        string  description = "His pot hat makes him extremely resistant to damage.";
        double  hp          = 10;
        double  armour      = 55;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling. Bucket can be removed by Magnetshroom";
        string  almanac     = "Why does he have a pot on his head? Because he's not going to be camping in winter so he might as well put it to use some other way.";
        string  origin      = "PvZ 2 (Lost City buckethead)";
    
    //blockhead_zombie
        string  description = "The ice block on his head provides some frostily blocky ice protection.";
        double  hp          = 10;
        double  armour      = 95;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Only spawns during winter. Immune to chilling and reduces the freezing effect to chilling.";
        string  almanac     = "The blockhead is a huge fan of the Brownparka Flag Zombie, so much so that he froze his head in just the same pattern as the flag.";
        string  origin      = "PvZ 2";

//zcorp
    //zcorp_new_hire
        string  description = "A typical ZCorp Incorporated employee.";
        double  hp          = 10;
        double  armour      = 0;
        int     cr          = 1;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "He was issued the standard ZCorp coffee mug at orientation.";
        string  origin      = "PvZ 1";

    //zcorp_conehead
        string  description = "His pined agenda makes him twice as though as minimum wage employees.";
        double  hp          = 10;
        double  armour      = 18;
        int     cr          = 2;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "He thought pinning his agenda to his head would make him less forgetful. Turns out having what's left of your skull pierced by a gigantic pin actually makes it harder to remember things.";
        string  origin      = "PvZ 1";

    //zcorp_wc_door
        string  description = "His bathroom door is an effective shield.";
        double  hp          = 10;
        double  armour      = 58;
        int     cr          = 4;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string special      = "Screendoor blocks incoming, non-piercing attacks from the front and can be removed by magnet-shroom.";
        string  almanac     = "So that's where it went.";
        string  origin      = "PvZ 1";

    //zcorp_trashcan
        string  description = "His recycling bin makes him extremely resistant to damage.";
        double  hp          = 10;
        double  armour      = 55;
        int     cr          = 6;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  special     = "Bucket can be removed by Magnetshroom";
        string  almanac     = "ZCorp Trashcan named himself that before going green and switching for the recycling bin, the name just kind of stuck after that.";
        string  origin      = "PvZ 1";
    
    //zcorp_holo-head
        string  description = "Holo-Head's head-mounted holo-field provides hyper-protection.";
        double  hp          = 10;
        double  armour      = 95;
        int     cr          = 8;
        double  speed       = normal;
        double  dmg         = 1;
        double  aps         = 2;
        string  almanac     = "He is SIGNIFICANTLY less productive than his Monitor Head co-worker, but that's fine; ZR gives him priviledges for having his head stuck in a futuristic headpiece, that and because he pays for their coffees.";
        string  origin      = "PvZ 2";