double slower = 1;
double slow = 2;
double normal = 3;
double fast = 4;
double faster = 5;

    //template_category
        //zombie_template
            string description = "blablabla";
            double hp = 10;
            double armor = 0;
            int cr = 1;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "";
            string almanac = "ladders on sale";
            string origin = "rogue garden";

//almanac_of_zombies

    //basics
        //browncoat_zombie
            string description = "Regular Garden-variety Zombie";
            double hp = 10;
            double armor = 0;
            int cr = 1;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string almanac = "This zombie loves brains. Can't get enough. Brains, brains, brains day in and night out. Old and stinky brains? Rotten brains? Brains clearly past their prime? Doesn't matter : Browncoat Zombie wants'em.";
            string origin = "PvZ 1";

        //flag_zombie
            string description = "Flag Zonbie marks the arrival of a huge pile or 'wave' of zombies.";
            double hp = 10;
            double armor = 0;
            //int cr = N/A;
            double speed = fast;
            double dmg = 1;
            double aps = 1;
            string almanac = "Make no mistake, Flag Zombie loves brains. But somewhere down the line he also picked up a fascination with flags. Maybe it's because the flags always have brains on them. Hard to say.";
            string origin = "PvZ 1";

        //conehead_zombie
            string description = "His traffic cone headpiece makes him twice as though as normal zombies";
            double hp = 10;
            double armor = 19;
            int cr = 2;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string almanac = "Conehead Zombie shuffled mindlessly forward like every other zombie. But something made him stop, made him pick up a traffic cone and put it on his head.";
            string origin = "PvZ 1";

        //screendoor_zombie

        //buckethead_zombie
            string description = "His bucket hat makes him extremely resistant to dmg.";
            double hp = 10;
            double armor = 57;
            double speed = normal;
            int cr = 4;
            double dmg = 1;
            double aps = 1;
            string almanac = "Buckethead Zombie always wore a bucket. Part of it was to assert uniqueness in an uncaring world. Mostly he just forgot it was there in the first place.";
            string origin = "PvZ 1";
        
        //brickhead_zombie
             string description = "Brickhead Zombie's brick head provides thorough brickheaded brickheadness.";
            double hp = 10;
            double armor = 95;
            int cr = 6;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string almanac = "After consultation with various storybook wolves, it was determined that straw helmets and wood helmets were not up to snuff, and that brick helmets had to be seriously considered.";
            string origin = "PvZ 2";
        
            //variant:ducky_tube_zombie
            string description = "The ducky tube allows this zombie to float on water.";
            //stats_of_relevent_basics
            string special = "Only appears in the pool.";
            string almanac = "It takes a certain kind of zombie to be a Ducky Tuber. Not every zombie can handle it. Some crack. They can't take it. They walk away and give up on brains forever.";
            string origin = "PvZ 1";

            //variant:brown_parka_zombie
            string description = "The zombie's brown parka protects him from the cold.";
            //stats_of_relevent_basics
            string special = "Only appears in winter. Immune to chilling and reduces the freezing effect to chilling.";
            string almanac = "Though many see the use of thicker clothing as simple survival instinct, Brown Parka Zombie disaproves of this theory. For him, it's all about fashion.";
            string origin = "PvZ 2 (Frostbite Caves basic)";

            //variant:zcorp_zombie
            string description = "A typical ZCorp Incorporated employee.";
            //stats_of_relevent_basics
            string special = "Only appears during the 'Rush Hour' ambush.";
            string almanac = "He was issued the standard ZCorp coffee mug at orientation.";
            string origin = "PvZ 2";

    //default_zombies
        //imp

            //variant:brownparka_imp
                string spceial = "Only appears in winter. Immune to chilling and reduces the freezing effect to chilling.";
                string origin = "PvZ 2 (Yeti Imp)";

            //variant:fishy_imp
                string special = "Only appears in the pool.";

        //gargantuar
            string special = "Throws an Imp upon reaching half hp.";

            //variant:king_of_the_grill
                string spcial = "Only appears in the summer. Throws a Hot Dog Imp upon reaching half hp.";

            //variant:brownparka_gargantuar
                string spceial = "Only appears in winter. Immune to chilling and reduces the freezing effect to chilling. Throws 3 Brownparka Imps upon reaching half hp.";
                string origin = "PvZ 2 (Sloth Gargantuar)";

            //variant:smashing_gargantuar
                string description = "Attacks faster than a regular gargantuar. Throws an Imp upon reaching half hp.";

            //variant:deep_sea_gargantuar
                string special = "Only appears in the pool. Throws a Fishy Imp upon reaching half hp.";

            //variant:hippity_hop_gargantuar
                string special = "Throws a Mystery Egg upon reaching half hp.";

                    //mystery_egg
                        string special = "Turns into a random CR 3 or less zombie or imp afetr a few seconds.";

            //variant:surprise_gargantuar
                string special = "Moves to a random lane upon reaching half hp. Throws an Imp in the lane he leaves and one in the lane he lands on."

        //zombie_yeti
    
    //modern_zombies
        //newspaper_zombie

        //pogo_zombie

        //snowball_thrower_imp
            string origin = "PvZ 2 (Hunter Zombie)";

        //ice_pirate_zomboie
            string origin = "When she appears, freezes the first plant in her lane.";

        //chicken_wrangler

            //zombie_chicken

        //fire_rooster_zombie
            string special = "When a plant is placed on this lane, shoots a fireball down the lane before moving to a neighbouring lane.";

        //mixed-up_gravedigger_zombie
            string description = "The Mixed-Up Gravedigger creates tombstones all over the map.";
            double hp = 20;
            double armor = 0;
            int cr = 5;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Creates tombstones on random tiles of the lawn. If the tile is occupied, no tombstone appears.";
            string almanac = "Digging graves is hard work, but seeing customers rise out of them makes it all worth it.";
            string origin = "PvZ Heroes ; PvZ 2 (Tomb Raiser Zombie)";

        //grave_robber_zombie
            string special = "Gets +2 hp and +1 dmg for every tombstone he walks through.";

        //parasol_zombie
            string special = "Only appears in spring and summer daytime. Blocks attacks from above : blocks splash dmg, effects and AKEE's bouncing.";

        //umbrella_zombie
            string special = "Only appears during fall. Flies over the first plant he encounters. Blocks attacks from above : doesn't blocks splash dmg, effects or AKEE's bouncing.";
            string origin = "PvZ 2 (Parasol Zombie) ; PvZ Heroes and PvZ China (Gentleman Zombie)";

        //campimp_porter
            string origin = "PvZ 2 (Imp Porter)";
            
        //nutcracker_zombie
            string special = "Deals gargantuar damage to nuts."

        //abracadaver
            string special = "Lifts up his hat to reveal a Zombie Dove who'll try to fly off with your plants. If the dove dies, the hat falls off, which releases a Zombie Rabbit.";
            string origin = "PvZ Heroes ; PvZ 2 (Magician Zombie)";

            //zombie_dove
                string origin = "PvZ 2";

            //zombie_rabbit
                string origin = "PvZ Heroes ; PvZ 2 (Weasel)";
        
        //dog_walker_zombie
            string special = "When a plant is placed on a neighbouring lane, moves to it.";

        //zombie's_best_friend
            string special = "Never appears by itself, only besides non-gargantuar zombies."

        //cat_lady_zombie
            string special = "Releases a fraidy cat on her lane and on the two neighbouring lanes upon death.";
            
            //fraidy_cat_zombie
                string special = "Gains a movement speed buff and moves to a random lane when an instant plant is used in its lane or neighbouring lanes.";

        //biodome_botanist_zombie

        //overstuffed_zombie
            string special = "Upon eating a plant, he restores his health (up to full if over half and up to half if under half -> dropped arm)";

        //energy_drink_zombie
            string special = "Moves to a neighbouring lane and gains a movement speed and aps buff every 4 rows.";

        //sneezing_zombie
            string special = "Whilst alive, plants in her garden cannot heal.";

        //chimney_sweep_zombie
            string description = "The Chimney Sweep Zombie aims for your chimney instead of your doors.";
            double hp = 30;
            double armor = 0;
            int cr = 4;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Appears on the side of the house with a ladder. Climbs up and moves to either side of the roof by hanging onto the roof's edge. Then acts like normal until he reaches the chimney (making you lose).";
            string almanac = "Who needs backdoors when you have chimneys. It's a growth industry.";
            string origin = "PvZ Heroes";

        //pied_piper_zombie
            string description = "The Pied Piper stuns the front-most plant on his lane.";
            double hp = 10;
            double armor = 0;
            int cr = 3;
            double speed = slow;
            double dmg = 1;
            double aps = 1;
            string special = "Whatever plant is in front of him, is stunned.";
            string almanac = "He was told that playing the pipe would summon raccoons. But whatevs.";
            string origin = "PvZ Heroes";

        //unlife_of_the_party
            string description = "The Unlife Of The Party is more robust the more zombies there are.";
            double hp = 10;
            double armor = 19;
            int cr = 5;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Gets +1 hp for every other zombie on screen.";
            string almanac = "His archenemy is the Wall-Flower. Oh yeah, he likes to party.";
            string origin = "PvZ Heroes";

        //paparazzi_zombie
            string description = "The Paparazzi Zombie becomes stronger during events";
            double hp = 10;
            double armor = 0;
            int cr = 1;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "During events : HP = 30, speed = fast, dmg = 2, aps = 1 and gains a 1 tile ranged attack with the camera.";
            string almanac = "Why is everyone always screaming and running away in his photos?";
            string origin = "PvZ Heroes";

        //trick-or-treater-zombie
            string description = "The Trick-or-treater Zombie buffs the health or damage of nearby zombies after eating a plant.";
            double hp = 30;
            double armor = 0;
            int cr = 3;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Gives +2 hp OR +1 dmg to a nearby zombie after eating a plant.";
            string almanac = "Trick or treat? He is haunted by that question - and by an answer that continues to elude him.";
            string origin = "PvZ Heroes";

        //gadget_scientist_zombie
            string description = "The Gadget Scientist Zombie summons Space Cadet Zombies onto the garden once he reaches it.";
            double hp = 30;
            double armor = 0;
            int cr = 8;
            double speed = fast;
            double dmg = 1;
            double aps = 0.5;
            string special = "Creates 4 Space Cadet Zombies across the 7 lanes, on the rows 4 to 6. Attacks from 2 tiles away.";
            string almanac = "He whises the Mad Chemist would stop copying his hair style.";
            string origin = "PvZ Heroes";

                //space_cadet_zombie
                    string description = "Is summoned by the Gadget Scientist Zombie.";
                    double hp = 10;
                    double armor = 5;
                    //int cr = N/A;
                    double speed = normal;
                    double dmg = 1;
                    double aps = 1;
                    string almanac = "His body is in space but his head is in the clouds.";
                    string origin = "PvZ Heroes";

        //mad_chemist_zombie
            string description = "The Mad Chemist Zombie places potions on the ground around him to buff other zombies.";
            double hp = 40;
            double armor = 0;
            int cr = 8;
            double speed = fast;
            double dmg = 1;
            double aps = 1;
            string special = "Places potions on his lane and on neighbouring lanes every three tiles. There are three different potions : Purple gives the zombies +10 armor (visualy indicated by purple cloud), orange makes them faster (not stackable) and blue makes them invisible and untouchable for three tiles. These effects do not stack with each other. Cannot use his own potions.";
            string almanac = "He's not so much 'mad' as he is 'mildly annoyed.'";
            string origin = "PvZ Heroes";

        //teleportation_zombie
            string description = "The Teleportation Zombie teleports all zombies in his row one tile forwards upon death.";
            double hp = 30;
            double armor = 0;
            int cr = 7;
            double speed = slow;
            double dmg = 1;
            double aps = 1;
            string special = "Teleports all zombies in his row one tile forwards upon death.";
            string almanac = "The phone cord stretches to another dimension.";
            string origin = "PvZ Heroes";

        //portal_technician_zombie
            string description = "The Portal Thechnician Zombie turns into a random zombie after dying.";
            double hp = 20;
            double armor = 10;
            int cr = 8;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "After dying, creates a random, non-imp and non-gargantuar, zombie in his place.";
            string almanac = "Soon everyone will own their own portal. But for now, he enjoys being an early adopter.";
            string origin = "PvZ Heroes";

        //exploding_imp
            string special = "Once he reaches a plant, he explodes it and himself. Chilling and freezing disable the bomb.";

        //space_ninja_zombie
            string description = "He deals massive gargantuar worthy damage but has low health.";

        //zom-blob
            string special = "Ignores plants and leaves a blob trail behind him that deals dot and disappears after a few seconds.";

        //squirrel_herder_zombie
            string special = "Destroys the first nut or berry in her lane when she appears";

        //hamster_ball_imp
            string special = "Releases the 'faster' moving imp inside it when it's destroyed.";

        //trash_can_zombie
            string special = "Once he reaches half hp, he jumps into the trash can. This stops him in place and protects him from all directions. After the trash can is destryed he keeps walking at half hp.";

        //genetic_experiement
            string special = "Upon reaching the garden, incapsulates himself. He does not until the capsule is destroyed. Whilst in the capsule, gains +2 hp and +1 dmg for evry four zombies that pass him.";

        //gargologist_zombie
            string special = "While alive, all gargantuars in her lane get +0.5 aps.";

        //turkey_rider_imp
            string special = "Gives all zombies on his garden +1 hp when he dies.";

        //bonus_track_buckethead
            string special = "While alive, stuns the highest aps plant in his lane.";

        //coffee_zombie
            string special = "While alive, every zombie in his garden has double aps.";

        //headstone_carver
            string special = "Turns graves he passes into engraved graves. They take are imune to gravebusters and zombies that rise from them have 125% hp.";

        //imposter
            string special = "Splits into two Imps on adjancent lanes on death, one of wich has a mustache. While wearing the coat, it deals more damage when eating plants.";
            string origin = "PvZ Heroes and Pvz Adventure ; PvZ 2 (Carnie Imp Twins)";

        //mini-ninja
            string special = "After taking damage for the first time, he turns invisible for 4 tiles before reapearing.";
            string origin = "PvZ Heroes ; PvZ 2 China (Bandit Zombie)";

        //hot_dog_imp
            string special = "When he eats, he dashes forward, skipping ahead one lane and damaging the plant in the process.";

        //moneky_smuggler_zombie
            string description = "The monkey smuggler sends out his monkey behind the floral wall.";
            double hp = 22;
            double armor = 0;
            int cr = 6;
            double speed = slow;
            double dmg = 1;
            double aps = 1;
            string special = "Once he reaches a wall plant, he spawns a zombie monkey behind it.";
            string almanac = "Piracy is serious monkey business.";
            string origin = "PvZ Heroes";

            //zombie_monkey
                string description = "The Zombie Money is released by the Monky Smuggler Zombie to attack your offence.";
                double hp = 15;
                double armor = 0;
                //int cr = N/A;
                double speed = fast;
                double dmg = 1;
                double aps = 1.5;
                string almanac = "It has a strange fascination with lifting eyepatches.";
                string origin = "PvZ 2 ; PvZ Heroes (Monkey Smuggler)";
        
        //smelly_zombie
            string special = "Deals extra dmg to non-wall plants.";

        //imp-throwing_imp
            string special = "Creates a random imp on a random lane of his garden when hit.";
        
        //trapper_zombie
            string special = "Creates a single-use trap on the tile he dies on. Any plant planted on that tile is stunned.";

        //cryo-yeti
            string special = "Freezes the first plant in his lane. If chilled, becomes 'faster' and gets double aps. Freezing becomes chilling.";

        //firefighter_zombie
            string special = "Destroys incoming fire projectiles in a 3x3 area.";

        //drinking_zombie
            string special = "Drinks from his bottle upon reaching half hp. This buffs his speed, dmg and aps.";
            string origin = "PvZ 2 China";

        //perfume_zombie
            string special = "Throws perfume bottles at plants that release poisonous perfume that stuns and damages them.";
            string origin = "PvZ 2 China";

        //ballerina_zombie
            string special = "Always appears in 'back-up dancer formation'.";
            string origin = "PvZ 2 China";

        //firework_zombie
            string special = "Launches fireworks at random tiles that burn the plant there and create fire trails on them.";
            string origin = "PvZ 2 China ; design PvZ Heroes";

        //rocket_zombie
            string special = "While on its rocket, he has triple speed and ignores all plants other. Rocket can be disabled with chilling or freezing.";
            string origin = "PvZ Adventure";

        //ice_block_zombie
            string special = "Once the ice block is brocken, all plants in a 3x3 radius are frozen. Flaming profectiles instantly destroy the ice block. Immune to chilling and freezing.";
            string origin = "PvZ Adventure";

        //barrel_of_deadbeards
            string special = "On destruction, damages all plants in a 3x3 radius and spawns a Captain Deadbeard in its place.";
            string origin = "PvZ Garden Warfare";

                //captain_deadbeard
                    string special = "Shoots from a 2 tiles away. Sends out a Zombie Parrot.";
                    string origing = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";

                //zombie_parrot
                    string special = "Attempts to fly away with your plants.";
                    string origing = "PvZ Garden Warfare ; PvZ 2 (Pirate Captain Zombie)";

    //sportive_zombies
        //pole_vaulting_zombie

        //football_zombie

        //all-star_zombie

            //all-star_super_fan_imp

        //imp_cannon
            string origin = "PvZ 2 ; design PvZ Heroes (Loose Canon)";

        //tennis_champ_zombie
            string special = "Has 5 dmg until eating her first plant.";

        //arm_wrestler_zombie
            string special = "Gains +2 hp and +1 dmg when a plant is planted on his lane.";

        //planetary_gladiator_zombie
            string special = "Absorbs damage for zombies in fornt of him in his lane.";

        //brain_vendor_zombie
            string special = "Moves zombies behind him from neighbouring lanes into his own.";

        //team_mascot_imp
            string spceial = "Gives all zombies in his lane +1 dmg for every plant that dies in his lane whilst he's alive.";

        //zombie_coach
            string special = "Gives all zombies in his lane +2 hp for every plant that dies in his lane whilst he's alive.";

        //defensive_end_gargantuar
            string special = "While alive, all plants cost an extra 25 sun. Throws an All-star Super Fan Imp upon reaching half hp.";

        //rodeo_gargantuar
            string special = "Switches plant with plant behind it before smashing it. Throws a Zombie Chicken upon reaching half hp.";

    //construction_zombies
        //ladder_zombie

        //supply-barrel_roller_zombie
            string origin = "PvZ 2 (Barrel Roller Zombie)";

            //supply-barrel
        
        //digger_zombie

        //excavator_zombie

        //electrician_zombie
            string special = "Zombies behind him on his lane are faster.";

        //kitchen_skin_zombie
            string description = "This zombie has essentially got the power of a garantuar, though he prefers eating over smashing.";

        //landscaper_zombie
            string special = "While alive, stuns the highest damage plant in his lane.";

        //waste_barrel_imp
            string special = "Crushes plants he walks into. Destryed by spike weed.";

        
    //museum_zombies
        //awaken_ra_zombie

        //dodo_fossil_rider_imp

        //turquoise_skull_thief_zombie
            string origin = "PvZ 2 (Turquoise Skull Zombie)";

        //zombie_medusa

        //primeval_yeti
            string special = "Gives all zombies in his lane +2 hp and +1 dmg when he dies.";

        //cursed_gargolith
            string special = "Only appears from engraved gravestones. Throws an Imp upon reaching half hp.";

        //archeology_guide_zombie
            string special = "Digs underground for 5 tiles before coming back up, creating a pathway for non-gargantuar zombies to evade attacks. Diggers that dig into it come out the end of the tunnel. The tunnel only lasts 3 tiles.";
            string origin = "PvZ 2 China (Lost Guide Zombie)";

    //mechanized_zombies:affected by EMPeach - flying zombies affected by EMPeach fall to the ground.
        //zomboni

            //bobsled_team

        //catapult_zombie

        //neutron_imp
            string special = "Flies towards your roof.";

        //celestial_custodian_zombie
            string special = "Flies towards the roof. Inflicts double damage to plants with 0 aps.";

        //space_cowimp
            string special = "Flies towards your roof. Moves to a neighbouring lane when he eats a plant.";
            string origin = "PvZ Heroes (Space Cowboy)";

        //interdimensional_zombie
            string description = "The Interdemensional Zombie occasionnaly avoids attacks by glitching forward.";
            double hp = 20;
            double armor = 0;
            int cr = 4;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Every 3 attack that hits him doesn't inflict damage and causes him to glitch forwards one tile.";
            string almanac = "In a parallel dimension, this Zombie is a Space Pirate. In another he's a Trash Can Zombie. Turns out, little choices in life can make a big difference.";
            string origin = "PvZ Heroes";

        //cyborg_zombie
            string description = "The Cyborg Zombie summons a stronger version of himself upon death.";
            double hp = 30;
            double armor = 0;
            int cr = 6;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Once dead, a Vengeful Cyborg Zombie appears in his lane.";
            string almanac = "He'll be back.";
            string origin = "PvZ Heroes";

                //vengeful_cyborg_zombie
                    string description = "He is stronger than his summoner in every way.";
                    double hp = 60;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = fast;
                    double dmg = 2;
                    double aps = 2;
                    string almanac = "He's back";
                    string origin = "PvZ Heroes";

        //arcade_zombie

            //variant:8-bit_zombie

        //shield_zombie

        //bug_bot_imp

        //robo-cone_zombie

        //mecha-football_zombie
            string special = "Pushes plants back for as long as there is space behind it.";

        //gargantuar_prime
            string special = "Throws Bug Bot Imp upon reaching half hp.";

    //airborn_zombies
        //ballon_zombie
            string special = "Appears form the normal spawnpoint but in roof height.";

        //bungee_zombie

        //bungee_plumber_zombie

        //parachutist_zombie
            string origin = "PvZ 2 (Lost Pilot Zombie)";

        //roof_climber_zombie
            string origin = "PvZ Heroes (Mountain Climber) ; PvZ 2 (Swashbuckler / Relic Hunter)";

        //stiltwalker_zombie

        //copter_commandimp
            string orgin = "PvZ Heroes (Copter Commando)";

        //kite_flyer_zombie
            string description = "Kite Flyer Zombie flyes a kyte above him. He shoots any damage inflicted to the kite right back at the plants.";
            double hp = 30;
            double armor = 0;
            int cr = 5;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "The kite flies on roof height above the Kite Flyer Zombie. Whatever damage the kite takes is shot back at the plants on the ground.";
            string almanac = "The naysayers were right. Flying a kite in a lightning storm WAS a real bright idea.";
            string origin = "PvZ Heroes";

                //kite
                    string description = "The Kite Flyer Zombie's kite";
                    double hp = 15;
                    double armor = 0;
                    //int cr = N/A;
                    //double speed = N/A;
                    //double dmg = N/A;
                    //double aps = N/A;

        //stupid_cupid_imp
            string description = "Flies. Deals damage to plants under him, which stuns them for a few sceonds.";
            double hp = 14;
            double armor = 0;
            int cr = 5;
            double speed = fast;
            double dmg = 1;
            double aps = 1;
            string special = "Flies towards your roof. Attacks plants beneath him, which stuns them for a few seconds.";
            string almanac = "What's love got to do with it? Honestly, he has no idea.";
            string origin = "rogue garden";

        //transport_fighter
            string special = "Flies towards your roof. Drops a Bug Bot Imp upon reaching 75%, 50% and 25% hp.";

    //aquatic_zombies
        //snorkel_zombie

        //dolphin_rider_zombie

        //surfer_zombie

        //fisherman_zombie

        //octo_zombie

        //synchronized_swimmer_zombie
            string special = "Only appears in the pool. Always appears in groups of three, covering all three pool lanes.";

        //imp_commander
            string special = "Only appears in the pool. While alive, every zombie in his lane gets +0.5 aps.";

        //zombie_high_diver
            string special = "Only appears in the pool. Dives into the water and stays submerged for five tiles before going back over the water.";

        //walrus_rider_imp
            string special = "Slides over the water, propelling the imp forward on the first plant it hits.";

        //disinfection_zombie
            string special = "Only appears in the pool. Releases toxic chemicals that slowly move along the his lane, lightly damaging all plants."

    //zcorp_zombies
        //zcopr_monitor_head
            string description = "ZCorp Monitor Heads are zombies with Cone-grade protection that can attack your plants from a distance.";
            double hp = 10;
            double armor = 19;
            int cr = 4;
            double speed = normal;
            double dmg = 1;
            double aps = 0.5;
            string special = "Can shoot plants in his lane from 4 tiles away.";
            string almanac = "ZCorp Monitor Head is hard-working. So much so that he purpusefully fused his head with his monitor to achieve never-before seen work efficiency.";
            string origin = "PvZ Battle for Neighborville (TV Head)";
        
        //zcorp_consultant
            string description = "ZCorp Consultant disrupts your paradigm and tableflips your bluesky/redocean.";
            double hp = 24;
            double armor = 0;
            int cr = 3;
            double speed = fast;
            double dmg = 1;
            double aps = 1;
            string special = "Hops between adjancent lanes, shoving other zombies in the process.";
            string almanac = "She works for ZCorp AND consults for them. Great gig if you can get it!";
            string origin = "PvZ 2";

        //zcorp_chair_racer

        //zcorp_customer_service
            string description = "When he appears, ZCorp Customer Service creates one ZCorp basic on every lane.";
            double hp = 10;
            double armor = 0;
            int cr = 8;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Creates one random ZCorp variant basic (only up to screendoor) in every lane.";
            string almanac = "Hang on - he's got to take this.";
            string origin = "PvZ Heroes (Cell Phone Zombie)";

        //zcorp_drone_engineer
            string description = "The ZCorps Drone Enginner's flying drone attacks plants from a distance for him while he avoids being hit.";
            double hp = 10;
            double armor = 10;
            int cr = 6;
            double speed = slow;
            double dmg = 1;
            double aps = 1;
            string special = "Controls a drone from 2 tiles distance. he only moves if he must do so to for the drone to be able to attack.";
            string almanac = "He's not entirely sure how to fly this thing. Behaves like a normal zombie if the drone dies.";
            string origin = "PvZ Heroes (Zombot Drone Engineer)";

                //zcorp_drone
                    string description = "It is piloted by the ZCorp Drone Enginner and attacks from a distance.";
                    double hp = 7;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = fast;
                    double dmg = 1;
                    double aps = 0,5;
                    string special = "It can only be targetted by plants that can attack flying zombies. Attacks from a 3 lane distance. If the ZCorp Drone Engineer dies, the drone joins another ZCorp Drone Engineer. If there are none on the field, it dies.";
                    string almanac = "The pencil on his helmet is completely useless, but the ZCorp engineer liked the astetics of it.";
                    string origin = "PvZ Heroes (Zombot Drone Engineer)";

        //zcorp_middle_manager
            string description = "Gets faster and more resilient with the death of ZCorp zombies.";
            double hp = 10;
            double armor = 0;
            int cr = 8;
            double speed = slow;
            double dmg = 1;
            double aps = 0.5;
            string special = "Gains +1 hp and +0.25 aps for every ZCorp zombie that dies in his lane.";
            string almanac = "Like most managers, bringing pain to his employees gives him strength.";
            string origin = "PvZ Heroes (Zombie Middle Manager)";

    //police_and_military
        //foot_soldier_zombie
            string special = "Upon reaching the 4th row, he lauches himself upwards to the second to last lane of the roof, dealing heavy damage to the plant he lands on in the process.";

        //riot_police_bomber_zombie
            string special = "Throws smoke bombs forwards to stun plants. Hits plants with his stick instead of eating.";
            string origin = "PvZ 2 China (Riot Police Zombie)";

        //riot_police_squadron
            string special = "Spawns in formation from 3 to 5 zombies. The zombies on the front and back hold their shields in front and behind them respectively. The zombies in the middle hold it above their heads. Thsi protects the formation from attacks from all directiosn except up. They attack with their bastons instead of eating.";
            string origin = "PvZ 2 (Camel Zombies) | PvZ 2 China (Riot Police Zombie)";

        //detonator_zombie
            string origin = "PvZ 2 (Prospector Zombie)";

        //medic_zombie
            string origin = "PvZ Heroes ; PvZ 2 (Healer Zombie)";

        //nurse_gargantuar
            string special = "Heals himself 10hp when he smashes a plant. Throws an Imp upon reaching half hp.";

        //gilet_jaune_zombie
            string description = "The Gilet Jaune Zombie joins the undead protest with a megaphone in hand.  His passionate shouts can rally other zombies to his cause.";
            double hp = 10;
            double armor = 0;
            int cr = 5;
            double speed = slow;
            double dmg = 1;
            double aps = 1;
            string special = "The Gilet Jaune Zombie is armed with a megaphone that he uses to shout slogans against the plants. This shout not only disorients nearby plants but can also turn nearby basics into 'Rallied Protestor Zombies.'";
            string almanac = "Once a common citizen, now a shuffler of the streets, the Gilet Jaune Zombie marches against anything in his path. To defend against the Gilet Jaune Zombie consider using plants with resistance to public dissatisfaction.";
            string origin = "rogue garden";

            //rallied_protestor_zombie
                string description = "The Rallied Protestor Zombie is an incendiary addition to the undead protest, carriying a torch to burn the rival flora.";
                double hp = 10;
                double armor = 0;
                //int cr = N/A;
                double speed = Fast;
                double dmg = 1;
                double aps = 1;
                string special = "Burns any plant he in front of he. Fire is extinguished with the Chill or Freeze effects and becomes a regular zombie. Fire projectiles can reignate the torch.";
                string almanac = "Ah, the Rallied Protestor Zombie, a connoisseur of chaos summoned by the Gilet Jaune Zombie's botanical revolution. With a torch in hand and a fervent spirit, he elegantly waltzes through the garden, turning flora into a spectacle of flames. Mon dieu, the theatrics! Prepare for a fiery soirée.";
                string origin = "PvZ 2 (Explorer Zombie)";

    //fantasy_roleplaying_club
        //imp_dragon

        //jester_zombie

        //wizard_zombie

        //wizard_gargantuar
            string special = "Turns plants he smashes into Zombie Goats. Throws a Imp Dragon upon reaching half hp.";

                //zombie_goat

        //zombie_king

        //vimpire
            string special = "Gains a movement speed and aps buff upon eating a plant. Dies if he bites garlic.";

        //haunting_zombie
            string description = "Haunting Zombie becomes a ghost upon death.";
            double hp = 10;
            double armor = 0;
            int cr = 6;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Becomes a Haunting Ghost upon death.";
            string almanac = "He doesn't realize he would look even scarier without the spooky ghost costume...";
            string origin = "PvZ Heroes";

                //haunting_ghost
                    string description = "Haunting Ghost ghosts through your plants, damaging them. Can't be killed but can be chilled.";
                    double hp = 9999999999;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = fast;
                    double dmg = 2;
                    double aps = 1;
                    string special = "Doesn't die but is affacted by chilling. Walks through plants dealing damange to them. Ascends on the first lane.";
                    string almanac = "Is he a Zombie? Is he a ghost? He refuses to be pigeonholded.";
                    string origin = "PvZ Heroes";
            
        //valrkyrie_zombie
            string description = "Valkyrie Zombie gets stronger the more zombies die.";
            double hp = 20;
            double armor = 19;
            int cr = 5;
            double speed = normal;
            double dmg = 1;
            double aps = 1;
            string special = "Gets +1 damage for every zombie that dies whilst she's alive.";
            string almanac = "It's not easy hitting those high notes when all you can sing is, 'Braaaaains.'";
            string origin = "PvZ Heroes";
        
        //shieldcrusher_viking_zombie
            string special = "Deals gargantuar damage to wall plants.";

        //intergalactic_warlord_zombie
            string special = "While alive, all zombies in his garden have +4 hp and +1 dmg.";

        //unthawed_viking_zombie
            string special = "Freezes the first plant on the water lanes.";

        //blowgun_imp
            string special = "Attacks plants from 4 tiles away.";

        //frankentuar
            string special = "Gains +1 hp for every zombie that dies in his lane while he's alive. Throws a Vimpire upon reaching half hp.";

    //event_dependent_zombies
        //portal_gatekeeper_zombie
            string description = "While alive, the Portal Gatekeeper Zombie creates portals on the garden that disappear on her death.";
            double hp = 30;
            double armor = 0;
            //int cr = N/A;
            double speed = slow;
            double dmg = 1;
            double aps = 1;
            string special = "Creates pairs of linked portals. Zombies and projectiles that traverse a portal come out the opposite side of whichever portal they are linked to. All portals disappear on her death.";
            string almanac = "'Stand here and guard this gate with your unlife,' she was told. And that's what she's been doing ever since.";
            string origin = "PvZ Heroes (Wormwhole Gatekeeper)";

            //dancing_zombies:only appear in the music event, each event being dedicated to a single zombie.
                //jack-in-the-box_zombie
                    string event_name = "Asylum Escape";

                //orchestra_conductor_zombie
                    string event_name = "Orchestral jam"
                    string description = "While alive, the Orchestra Conductor Zombie makes all zombies fast.";
                    double hp = 7;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = fast;
                    double dmg = 1;
                    double aps = 1;
                    string special = "While alive, makes all zombies 'fast.'";
                    string almanac = "What he lacks in size, he makes up for in volume.";
                    string origin = "PvZ Heroes";

                //disco_dancer_zombie
                    string event_name = "Thriller";

                    //backup_dancer_zombie

                //pianist_zombie
                    string event_name = "Swing jam";

                //aerobics_instructor_zombie
                    string event_name = "Aerobics Class";
                    string description = "While alive, the Aerobics Instructor Zombie makes all zombies do more damage.";
                    double hp = 20;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = normal;
                    double dmg = 1;
                    double aps = 1;
                    string special = "While alive, all zombies do +1 dmg.";
                    string almanac = "Aerobics really bring the dead to life.";
                    string origin = "PvZ Heroes";

                //binary_stars
                    string event_name = "Double-Z jam";
                    string description = "While alive, the Binary Stars make all zombies have double attack speed.";
                    double hp = 20;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = normal;
                    double dmg = 1;
                    double aps = 1;
                    string special = "While alive, all zombies have double dps.";
                    string almanac = "He's a Gemini and so is she. Which explains so much, right?";
                    string origin = "PvZ Heroes";

                //line_dancer_zombie
                    string event_name = "Yoddle jam";
                    string description = "Line Dancer Zombie yoddles down your lanes to damage all plants.";
                    double hp = 20;
                    double armor = 0;
                    //int cr = N/A;
                    double speed = normal;
                    double dmg = 1;
                    double aps = 1;
                    string special = "Moves between lanes. Occasionnaly yoddles, damaging every plant in her lane.";
                    string almanac = "In her opinion, there's no better song to line dance to than the 'Zombie Shuffle.'";
                    string origin = "PvZ Heroes";

                //punk_zombie
                    string event_name = "Punk jam";

                //glitter_zombie
                    string event_name = "Pop jam";

                //mc_zom-b
                    string event_name = "Rap jam";

                //breakdancer_zombie
                    string event_name = "Rap jam";

                //hair_metal_gargantuar
                    string event_name = "Metal jam";
                    string description  = "Attacks shoot sound waves to damage plants from affar.";
                    string special = "Throws a Hair Metal Imp upon reaching half hp.";

                    //hair_metal_imp
                        string event_name = "Metal jam";
                        string description = "Moves faster than a normal imp.";

                //boombox_zombie
                    string event_name = "Boombox jam";

                //conga_leader_zombie
                    string event_name = "Conga jam";
                    string special = "While alive, browncoat (or variant) will continuisly spawn on his lane.";
                    string origin = "PvZ Adventure";

                    //variant:ducky_conga_leader_zombie
                        string event_name = "Conga jam";
                        string special = "Only appears in the pool. While alive, ducky browncoats will continuisly spawn on his lane.";
                        string origin = "PvZ Adventure";