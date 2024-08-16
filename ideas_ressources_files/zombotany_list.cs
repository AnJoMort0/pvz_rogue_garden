
//This is the full list of zombotany zombie variants for all the various plants, yes, ALL the various plants. Any plants added to the "plant_list.cs" will be have a unique zombotany.

    //template_zombotani
            string plant_name = "Grass"; //name of the plant
            string description = "Grass, but dead"; //basic description of the zombie and its abilities (if available, you can easily take it straight from its game of origin)
            double hp = 10; //hit points (hp) is counted in peas
            double armour = 0; //if relevant, add the hp of potential armour (i.e. Cone), if not "double armour = 0"
            int cr = 1; //CR stands for Challenge Rating, being the amount of "points" needed to spawn (+CR = Spawns later/less often) and therefore should be base on how threatening the zombie is. A zombotani specific guide will be made in due time, but winging it usually works too.
            double speed = normal; //speeds written after template
            double dmg = 1; //damage (dmg) is counted in peas - yes, even the zombies'
            double dmg_ranged = 1; //dmg for the ranged attack. Only keep if relevent
            double aps = 2; //aps stands for attacks per second, aka how fast the zombie attacks
            double aps_ranged = 2; //aps but for the ranged attack. Only keep if relevent
            string special = "Suddenly combusts, but only if it feels like it."; //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line. This is also where you include Magnet-shroom weakness. Note : by default, zombies can't spawn on water or on air at all, so add precisions such as "Can spawn" or "only spawns in water" for the pool and "Flies towards the roof" (Flying zombies fly at "roof height", so if a peashooter is placed on the roof it'll be able to shoot the flying zombies) when necessary.
            string almanac = "Because why wouldn't we add 5000 more almanac entries to the game ?";
            string origin = "Rogue Garden"; //game(s) or mod(s) of origin - Add the game of origin of the plant, taken from the list and the game of origin of the zombotani if taken from one.

double slower = 1;
double slow = 2;
double normal = 3;
double fast = 4;
double faster = 5;