double  slower   = 1;
double  slow     = 2;
double  normal   = 3;
double  fast     = 4;
double  faster   = 5;

//This is the full list of events, which will have an almanac in the game. Things such as the day-night cycle, seasons, random events, ambushes and even bosses. There will be adjustements with play-testing and many of these will take a long to actually join the game. Any ideas are welcome as long as you follow the guidelines according to the comented template. You are welcome to propose changes and give feedback. Shallow water is a nice mechanic that is also included at the top of this list because we did not know where to put it.

//template_category
    //template_event
        string  description = "";
        string  origin      = "";

    //template_zombot
        string  description = "";
        string  almanac     = "";
        string  origin      = "";
        string  summon      = "";
        //phase_1
            string  attack_1    = "";
        //phase_2
        //phase_3

    //template_heroe_boss
        string  descitpion  = "";
        string  almanac     = "";
        string  origin      = "";
        string  zombies     = "";
        //attacks
            string  signature_super = "";
            string  attack_1        = "";
            string  attack_2        = "";
            string  attack_3        = "";
            string  attack_4        = "";
            string  attack_5        = "";
            string  attack_6        = "";
        //shields
            string  super_a         = "";
            string  super_b         = "";
            string  super_c         = "";

//shallow_water
        string description = "Shallow water that covers a grass tile in the lawn. Both land and water plants can be placed on it and both land and water zombies can traverse it. Moist Moss can prevent it from disappearing after the event that spawned it ends. If a full lane is covered with shallow water tiles, both land and water zombies can spawn in said lane. If ran over by a Zomboni, it behaves the same except water plants cannot be placed and bobsleds can spawn.";
        string origin = "Rogue Garden";

//day-night_cycle
    string description = "The time of day changes between day and night throughout the game. Plants working on the 'wrong' shift (i.e.: shrooms during the day) may fall asleep and if they are placed outside of 'work time' they'll be asleep.";
    string origin = "PvZ 1";

    //huge_wave
        string description = "Huge Waves of zombies are just like regular waves of zombies but huge. They happen between 1 and 5 times per day and night.";

    //final_wave
        string descritpion = "Final Waves end days and nights. They are similar to Huge Waves but happen in both gardens and are even bigger. The next wave only spawns once the Final Wave has been fully cleared.";

        //grave_ambush
            string description = "Zombies or Imps emerge from random gravestones on the gardens and non-Imp and non-Gargantuar, except Cursed Gargoliths, zombies spawn from engraved gravestones on the gardens during Final Waves.";

        //pool_ambush
            string description = "Aquatic Zombies or Imps covered in Kelp emerge from random tiles of the pool during Final Waves.";

    //day
        string descritpion = "During the day : Sun fall from the sky.";

        //total_eclipse
            string description = "For all intents and porpuses, behaves the same way as a New Moon but triggers during the day.";
            string origin = "PvZ Heroes";

        //radiation_wave
            string description = "Sun falling from the sky glow a radioactive purple. If clicked before they land, they explode dealing massive damage to zombie in a 3x3 area. Zom-blobs and Genetic Experiments are more likely to spawn.";
            string origin = "PvZ 2 (Far Future - Sun Bombs)";

    //night
        string descritpion = "During the night : Sun don't fall from the sky.";

        //moon_phase_cycle
            string description = "This game features a moon cycle, though only the two extremes are relevent.";
            string origin = "Rogue Garden";

            //full_moon
                string description = "During full moon, no plants fall asleep.";

                //haunting_moon
                    string description = "For its duration, all zombies spawn as their elite variants if they have one. May trigger during full moons.";
                    string origin = "PvZ Heroes (Bad Moon Rising)";

            //new_moon
                string description = "For its duration, all plants have a higher chance of falling asleep and day plants are weaker.";

//season_cycle
    string description = "This game features seasons, that are mostly indicated by the UI and a general change in hue. Whenever a new season starts, 3 Neutron Imps spawn in each garden.";
    string origin = "Rogue Garden";

    //summer
        string description = "During summer, sun are more likely to fall from the sky.";

        //sandstorm
            string description = "Weak zombies can appear in small sand hurricanes, moving them fast past your defenses.";
            string origin = "PvZ 2 (Ancient Egypt - Sandstorm)";

        //pool_party
            string description = "For its duration, zombies are more likely to spawn in the backyard than the front yard. Zombies that spawn in the backyard have a higher chance of spawning in the pool lanes.";

        //heat_wave
            string description = "Only triggers during the day. For its duration, all plants have a higher chance of falling asleep and night plants are weaker.";
            string origin = "PvZ 1 DS Version";

            //drought
                string description = "The pool dries, turning all its tiles into shallow water. May trigger during heat waves.";

    //fall
        string description = "Fog appears on both sides of the map. This blocks visibility and may be countered with various plants.";
        string origin = "PvZ 1";

        //dark_storm
            string description = "The screen will remain dark until lightning flashes.";
            string origin = "PvZ 1";

        //rain_storm
            string descritpion = "A large rain cloud covers the yard. Grass tiles are randomly covered in Shallow Water and only go away a few seconds after the event ends. Umbrella Zombies are more likely to spawn.";
                
            //pool_flood
                string description = "The lanes next to the pool are covered in shallow water. After a few seconds the next lanes get flooded too. The reverse effect happens after the event ends. May trigger during rain storms.";

    //winter
        string description = "During winter, sun fall less often from the sky. Brownparka variants of basics, imps and gargantuars will spawn.";

        //freezing_breeze
            string description = "A freezing breeze freezes random plants on your lawn, fire and ice plants are not affected. The ice can be melted away. Frozen plants get hit by straight-shooting projectiles, are ignored by zombies and cannot be shovelled.";
            string origin = "PvZ 2 (Frostbite Caves)";

    //spring
        string description = "-";

        //zombotany
            string description = "For the duration, only Zombotany Zombies can appear.";
            string origin = "PvZ 1";

        //zombie_concert
            string description = "This event affects only one garden at a time and never the air. When triggered, any of the 'concerts' below will happen. Paparazzi zombies are more likely to spawn.";

                //asylum_escape
                    string description = "For the duration, zombies don't spawn normally, instead various Jack-in-the-box Zombies, Cuckoo Zombies and Trickster Zombies appear across the 7 lanes of a garden.";
                    string origin = "PvZ 1";

                //orchestral_jam
                    string description = "Spawns an Orchestra Conductor Zombie in one of the gardens that is unkillable for the duration of the event. Zombies playing instruments are more likely to spawn.";
                    string origin = "PvZ Heroes";

                //thriller
                    string description = "Spawns a Dancer Zombie in one of the the gardens that is unkillable for the duration of the event. Creates a 4x5 block of Backup Dancer Zombies behind the Dancer Zombie, centered on him.";
                    string origin = "PvZ 1 ; Michael Jackson - Thriller";

                //swing_jam
                    string description = "Spawns a Piano Zombie in one of the gardens that is unkillable for the duration of the event.";
                    string origin = "PvZ 2";

                //aerobics_class
                    string description = "Spawns an Aerobics Instructor Zombie in one of the gardens that is unkillable for the duration of the event.";
                    string origin = "PvZ Heroes";

                //double-z_jam
                    string description = "Spawns a Binary Stars in one of the gardens that is unkillable for the duration of the event.";
                    string origin = "PvZ Heroes";

                //punk_jam
                    string description = "For the duration, zombies don't spawn normally, instead various Punk Zombies appear across the 7 lanes of a garden each wave.";
                    string origin = "PvZ 2";

                //pop_jam
                    string description = "Spawns a glitter zombie in every lane of a garden.";
                    string origin = "PvZ 2";

                //rap_jam
                    string description = "For the duration, zombies don't spawn normally, instead various Mc-ZomBs and Breakdancer Zombies appear across the 7 lanes of a garden each wave.";
                    string origin = "PvZ 2";

                //metal_jam
                    string description = "For the duration, zombies don't spawn normally, instead 1 to 3 Hair Metal Gargantuars  and 30 to 10 Hair Metal Imps respectivelly appear each wave.";
                    string origin = "PvZ 2";

                //boombox_jam
                    string description = "Spawns a Boombox Zombie in one of the gardens that is unkillable for the duration of the event.";
                    string origin = "PvZ 2";

                //conga_line
                    string description = "Spawns a (Duckytube) Conga Leader Zombie in one of the gardens that is unkillable for the duration of the event.";
                    string origin = "PvZ Adventure";

//random_events
    string description = "These events can happen at any time during the gameplay.";

    //boss_events
        string descritpion = "A boss appears on the outer edge of one of the gardens, outside of the plantable grid.";

        //zombots
            string description = "Giant robots built and controlled by Dr. Edgar Zomboss. They all have three phases at 3/3, 2/3 and 1/3 of their health, that get progressively more difficult before being defeated. Zombies in the garden he appears in stop spawning normally and instead get summoned by the boss.";
            
            //mark_iii
                string description = "The Zombot Mark III is a colossal robot reminicent of its original apearance and its Mark II edition in the time-travel adventure. Its hulking height leaves it standing even higher than the roof. It can only be damage when hit at the head.";
                string almanac = "He may have exploded once and even twice, but Dr. Edgar Zomboss always believes that third time's the charm.";
                string origin = "PvZ 1 ; PvZ 2 China (Mark II) ; PvZ Heroes (Zom-Blob and Gargantuar's Feast)";
                string summon = "He summons zombies near himself, by placing them with his giant mechanical hand. He prefers placing few tougher zombies and mostly creates zombies originating from PvZ 1. Can place bobsled teams.";
                //phase_1
                    string attack_1 = "Fire Ball : The Zombot lowers its head to the garden's level, making Zomboss vulnerable, in order to release a giant ball of fire that slides down the lane, buring plants and even the mowers. Can be countered with Ice-shroom and damaged by ice projectiles. Disappears if aimed at the pool.";
                    string attack_2 = "Ice Ball : The Zombot lowers its head to the garden's level, making Zomboss vulnerable, in order to release a giant ball of ice that slides down the lane, freezing plants and even the mowers and leaving a trail of ice for bobsleds behind. Can be countered with Jalapeño and damaged by fire projectiles. Freezes the pool's surface if aimed at it, making it behave like frozen shallow water.";
                //phase_2
                    string attack_3 = "Bungee Release : The Zombot holds its hand out over the garden, or the roof, and releases five bungee jumpers or bungee plumbers, whose ropes are attached to its fingers.";
                    string attack_4 = "Zombot Stomp : The Zombot stomps a 2x3 to 3x3 area near him with its foot.";
                    string attack_5 = "Ball of Blob : The Zombot lowers its head to the garden's level, making Zomboss vulnerable, in order to release a giant ball similar to the Zom-Blob that slides down the lane, crushing plants and leaving a trail of blob behind, and cannot be countered. Gives Disinfection zombie's effect, if aimed at the pool.";
                //phase_3
                    string attack_6 = "Camper Throw : The Zombot throws a camping van at the garden or the roof, crushing plants in a 2x4 area and occasionally spawing a Campimp Porter, unless aimed at the pool.";
                    string attack_7 = "Gargantuar's Feast : The Zombot lowers its head, making Zomboss, who rings a small golden bell, vulnerable. 3 gargantuars of any type spawn in its garden, spread across the 7 lanes."
            
            //dug-up_sphinx-inator
                string description = "The Zombot Sphinx-inator is a large ancient robot, that was stolen from the Neighbourghville Museum and, until now, was impossible to find. It occupies only a small area on the map but can move around with its spider-like legs.";
                string almanac = "Finding his precious old creation in the Neighbourghville Museum was, to be sure, a suprise for Dr. Edgar Zomboss, but more than a welcome one.";
                string origin = "PvZ 2";
                string summon = "Opens its mouth to release zombies. Prefers spawning groups of basics and zombies from the Museum category, as well as Headstone Carver Zombie and Mixed-up Gravedigger Zombies.";
                //phase_1
                    string attack_1 = "Gravestone Lauch : The Zombot suddenly stops. Its pupil dialetes then reveales a missile that shoots towards a targeted tile on the lawn. If it hits a plant, it destroys it and sometimes places a gravestone where it lands.";
                    string attack_2 = "Claws : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself. If it hits a Zombie Statue, brings it to 0 HP.";
                    string attack_3 = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                //phase_2
                    string attack_3 = "Sun Strike : The Zombot suddenly stops. Its eye turns blue as it steals sun from the map. After catching 3 to 5 it releases a beam of fire down its lane, vaporizing all plants. If it fails to gather all required sun, it releases a smaller beam that simply damages the plants.";
                //phase_3
                    string attack_4 = "Dash : The Zombot rears back, charges up and then dashes down the garden, crushing plants it touches. If it hits a Zombie Statue, brings it to 0 HP.";
                    string attack_5 = "Medusa Stare : The Zombot suddenly stops. Its pupil turns green and dilates until covering its whole eye. Once charged up, it will throw its beam at zombies in a 1x3 area in front of itself, creating a barrier of statues and more zombies for the Zombie Medusas to push.";

            //catastro-liope
                string description = "The mystery-filled circus-wagon of terrors and delights. It occupies only a small area on the map but can move around with its wagon wheel legs.";
                string almanac = "'Despite the decline of circuses in recent years, I refuse to give up on a form of entertainment with so much history and plant-destroying potential,' cackles Dr. Edgar Zomboss, all while tapping out a jaunty little tune on his keyboard.";
                string origin = "PvZ 2";
                string summon = "Opens its mouth to release zombies. Prefers spawning Animal Herder type zombies and zombies from the Carnival category.";
                //phase_1
                    string attack_1 = "Imp Lauch : The Zombot's eye opens to reveal a cannon that shoots 1 to 3 Carnie Imps, multiplied by the phase it's in, at random tiles on the lawn.";
                    string attack_2 = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself.";
                    string attack_3 = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                //phase_2
                    string attack_3 = "Animal Release : The Zombot opens its side-cage, releasing up to 5 zombie animals down each lane it occupies.";
                //phase_3
                    string attack_4 = "Dash : The Zombot rears back, charges up and then dashes down the garden, crushing plants it touches.";

            //desk-a-tron
                string description = "Dr. Zomboss's corporate desk, but on legs. It occupies only a small area on the map but can move around with its office adequate legs.";
                string almanac = "After consultation, Dr. Edgar Zomboss finally decided to show who the Boss really is. He put on his coat, sat at his desk and told his managers to do the rest.";
                string origin = "Rogue Garden ; PvZ Heroes (Maniacal Laugh)";
                string summon = "Zomboss rings the bell on his shelf to call zombies in. Prefers spawning zombies from the ZCorp category and only spawns ZCorp variant basics.";
                //phase_1
                    string attack_1 = "Costumer Service Please : Zomboss calls costumer service, summoning up to 5 ZCorp Costumer Sevice zombies across the garden.";
                    string attack_2 = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself.";
                    string attack_3 = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                //phase_2
                    string attack_3 = "Work Emergency : Causes a Rush Hour event and spawns a ZCorp Consultant in each lane.";
                    string attack_4 = "Maniacle Laugh : A random ZCorp Middle Manager gains 15 hp.";
                //phase_3
                    string attack_5 = "Mass Firing : The Zombot rears back, charges up and then dashes down the garden, crushing plants and ZCorp basics it touches.";
                    string attack_6 = "Promotion : Turns all non-armored ZCorp basics into ZCorp Middle Managers";

            //multi-stage_masher
                string description = "The Multi-Stage Masher is a huge concert stage that covers the whole road, leaving it vulnerable from every lane.";
                string almanac = "In another world, in another time, Dr. Zomboss would receive the bounty of enthusiastic applause that is his due. Not here and now, though. Nope.":
                string origin = "PvZ 2 ; PvZ Heroes (Monster Mash)";
                string summon = "Beats his speakers to summon zombies from the ground in front of the stage. He prefers spawning many low-health zombies spread across the 7 lanes. Likes spawning Disco Zombies, Cosmic Disco Zombies, and instrument playing zombies.";
                    //phase_1
                        string attack_1 = "Medley : Zomboss switches into a costume reminiscent of either an Orchestra Conductor Zombie, a Pianist Zombie, an Aerobics Instructor Zombie, the Binary Stars, or a Boom Box Zombie and gives their effect to the garden until he uses this attack again.";
                        string attack_2 = "Monster Mash : Creates 3 or 4 Disco Zombies, one lane away from each-other.";
                        string attack_3 = "Speaker Launch : A target appears on a random tile in the three last rows of the garden. A Speaker lands on that tile after a few seconds, destroying whatever plant was on that tile.";
                    //phase_2
                        string attack_4 = "Booming Tunes : Make the speakers launch a heavy wave of music forwards. they deal 6 damage to the first plant they reach.";
                        string attack_5 = "Asylum Keys : Zomboss switches into a costume reminiscent of the Jack-in-the-box Zombie and triggers an Asylum Escape Event.";
                        string attack_6 = "Rap Battle : Zomboss switches into his rappper outfit and triggers a Rap Jam event.";
                        string attack_7 = "Punk! : Zomboss switches into his Punk outfit and triggers a Punk Jam event.";
                    //phase_3
                        string attack_8 = "Column Like You See 'Em : Zombot switches into his glitter outfit and creates a Glitter Zombie followed by a Conga Leader followed by a Line Dancer in every lane. The Glitter Zombies and Line Dancers drown if they walk into the pool.";
                        string attack_9 = "Heavy Hair Metal : Zombot switches into his hair metal outfit and triggers a Hair Metal Jam event.";

            //water-based
                
                //sharktronic

            //air-based
                
                //dark_dragon
                    //Fantasy Roleplaying Club

                //aerostatic_blimp

                //battle_cruiser_5000

        //heroe_bosses
            string descitpion = "Heroe Bosses are incredibly powerful zombies with special abilites. They all have a signature superpower and six powers based on their original categories in PvZ Heroes and sometimes their attacks in Garden Warfare. Zombies keep spawning naturally tough they have higher chances of spawning from a specific category. Upon reaching 75%, 50%, and 25% health, the Heroe Bosses create a 30-50 armor shield on themselves and activate one of three superpowers they have.";

            //the_smash
                string descitpion = "";
                string almanac = "The Smash enjoys...SMASHING!";
                string origin = "PvZ Heroes";
                string zombies = "Zombies from the Sportive Category are more likely to spawn.";
                //attacks
                    string signature_super = "Slammin' Smackdown : Destroy a random plant with 4 damage or less.";
                    string attack_1 = "Extinction Event : Deals 3 damage to a random plant. All copies of that plant take 2 damage.";
                    string attack_2 = "Vitamin Z : Turns random basics into Arm Wrestler Zombies.";
                    string attack_3 = "Locust Swarm : Puts a Locust Swarm in a random 3x3 area. It can be cleared by blover. All plants in the area take 0.5 damage per second.";
                    string attack_4 = "Knockout : Stuns all plants with 1 or less damage in a lane.";
                    string attack_5 = "Rolling Stones : Sends a large boulder down one of the lanes dealing 4 damage to all plants and zombies.";
                    string attack_6 = "Going Viral : 2-4 zombies lose 2 hp but become 'frienzied' - Gains +0.5aps when it kills a plant.";
                //shields
                    string super_a = "Heroic Health : Heals himself for 12 hp.";
                    string super_b = "Possessed : 4-8 random zombies gain 4 armor if they already have any and become 'frienzied' - Gains +0.5aps when he kills a plant.";
                    string super_c = "Galvanise : 4-8 random zombies gain 10 hp and 2 dmg.";

            //rustbolt
                string descitpion = "";
                string almanac = "He enjoys keeping his bolts tight and his screws loose.";
                string origin = "PvZ Heroes";
                string zombies = "Zombies from the Construction category are more likely to spawn.";
                //attacks
                    string signature_super = "Shrink Ray : Shrinks a random plant. Halfing all its stats.";
                    string attack_1 = "Going Viral : 2-4 zombies lose 2 hp but becomes 'frienzied' - Gains +0.5aps when he kills a plant.";
                    string attack_2 = "Escape Through Time : Replaces the lowest hp zombie with a random zombie from the Museum category.";
                    string attack_3 = "Terrify : Switches the places of 8 plants in a random 2x7 area.";
                    string attack_4 = "Cryo-brain : Increases the CR pool by 1 until the end of the boss battle.";
                    string attack_5 = "Triplication : Replaces a wave with just three zombies, an Imp, a Zombie and a Gargantuar.";
                    string attack_6 = "Hail-a-copter : Spawns 2 Copter Comandimps.";
                //shields
                    string super_a = "Heroic Health : Heals himself for 12 hp.";
                    string super_b = "Cut Down to Size : Kills the highest damage plant in the garden.";
                    string super_c = "Rock Wall : Creates a 1x3 line of Tombstones in front of the highest CR zombie in the garden.";

            //professor_brainstorm
                string descitpion = "";
                string almanac = "His countless years of research revealed that E=MCraaazy!";
                string origin = "PvZ Heroes";
                string zombies = "Zombies from the Scientific category are more likely to spawn.";
                //attacks
                    string signature_super = "Eureka : Spawns three random zombies.";
                    string attack_1 = "";
                    string attack_2 = "";
                    string attack_3 = "";
                    string attack_4 = "";
                    string attack_5 = "";
                    string attack_6 = "";
                //shields
                    string super_a = "Summoning : Spawns a random 5 CR zombie";
                    string super_b = "Telepathy : Instantly does two attacks.";
                    string super_c = "Dance Off : Spawns 1 Backup Dancer, 1 Disco Backup Dancer and 1 Flamenco Backup Dancer in each lane.";
            
            //z-mech
                //Mechanized Zombies

            //immorticia
                //Fantasy Roleplaying Club

            //impfinity
                string descitpion = "";
                string almanac = "He believes good things come in small packages. And in threes.";
                string origin = "PvZ Heroes";
                string zombies = "Imps are more likely to spawn.";
                //attacks
                    string signature_super = "Triple Treath : Spawns three Impfinity Clones in the garden.";
                    string attack_1 = "Cakesplosion : Spawns a Cake Bomb Imp on a random tile.";
                    string attack_2 = "Final Mission : Sacrifices a 6 CR or more zombie to shoot a rocket into the roof, dealing heavy damage in a plus shaped area.";
                    string attack_3 = "The Chickening : Triggers a Chicken Run ambush.";
                    string attack_4 = "Smoke Bomb : Spawns a smoke bomb on a tile and teleports all zombies on it 3 tiles forwards.";
                    string attack_5 = "Barrel of Barrels : Spawns a Supply Barrel Roller, a Waster Barrel Imp, a Carnie Imp Cannon, a Barrel of Deadbeard or a Barrel of Flameface.";
                    string attack_6 = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                //shields
                    string super_a = "In-Crypted : Replaces 2 zombies with Engraved Gravestones and 1 imp with an Impstone.";
                    string super_b = "Brute Strenght : 4-8 zombies gain 5 damage.";
                    string super_c = "Super Stench : Creates 2 Waste Barrel Imps and 5 Smelly Zombies spread across the seven lanes.";

            //electric_boogaloo
                string descitpion = "";
                string almanac = "They say that disco is dead, but he's down with the dead.";
                string origin = "PvZ Heroes";
                string zombies = "(Cosmic) Disco Zombies and instrument-playing zombies are more likely to spawn.";
                //attacks
                    string signature_super = "Stayin' Alive : Deals 3 damage to a plant and heals himself for 3 hp.";
                    string attack_1 = "Cakesplosion : Spawns a Cake Bomb Imp on a random tile.";
                    string attack_2 = "Final Mission : Sacrifices a 6 CR or more zombie to shoot a rocket into the roof, dealing heavy damage in a plus shaped area.";
                    string attack_3 = "Sugary Treat : Spawns a Trick or Treater Zombie.";
                    string attack_4 = "Vitamin Z : Turns random basics into Arm Wrestler Zombies.";
                    string attack_5 = "Secret Agent : Kills a zombie that has an elite version and spawns its elite version on the next wave.";
                    string attack_6 = "B-Flat : Drops a piano in a random tile, crushing the plant there but being blocked by Umbrella Leaf and doesn't affect Spikeweed and Spikerock.";
                //shields
                    string super_a = "Dance Off : Spawns 2 Backup Dancers in each lane.";
                    string super_b = "Evaporate : Kills the 2 lowest hp wall plants in the garden. Doens't work if they are on water.";
                    string super_c = "Electrobolt : Shoots down a lighting strike that deals 6 damage to a plant. If it kills it, creates a crater there.";

            //brain_freeze
                string descitpion = "";
                string almanac = "Loves ice cream, snowstorms, and brains...not necessarily in that order.";
                string origin = "PvZ Heroes";
                string zombies = "Yetis are more likely to spawn.";
                //attacks
                    string signature_super = "Frozen Tundra : Adds two levels of frost to the front-most plant of every lane.";
                    string attack_1 = "Extinction Event : Deals 3 damage to a random plant. All copies of that plant take 2 damage.";
                    string attack_2 = "Nibble : A plant gets stuned temporarily. Heals the boss for 1 hp.";
                    string attack_3 = "Locust Swarm : Puts a Locust Swarm in a random 3x3 area. It can be cleared by blover. All plants in the area take 0.5 damage per second.";
                    string attack_4 = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                    string attack_5 = "Barrel of Barrels : Spawns a Supply Barrel Roller, a Waster Barrel Imp, a Carnie Imp Cannon, a Barrel of Deadbeard or a Barrel of Flameface.";
                    string attack_6 = "Backyard Bouncy : Launches 2 zombies into the roof.";
                //shields
                    string super_a = "Dolphinado : Triggers a Sandstorm ambush that, if in the backyard, brings Doplhin Rider Zombies to the pool lanes.";
                    string super_b = "Acid Rain : Gives all plants in a 5x5 area -5 hp and -0.5 damage.";
                    string super_c = "Galvanise : 4-8 random zombies gain 10 hp and 2 dmg.";

            //water-based
                //neptuna

            //air-based
                //huge_giganticus

                //super_brainz
                    string descitpion = "";
                    string almanac = "His most heroic quality is his hairstyle.";
                    string origin = "PvZ GW ; PvZ Heroes";
                    string zombies = "Roof Climber Zombies, Chimney Sweep Zombies and Foot Soldier Zombies are more likely to spawn.";
                    //attacks
                        string signature_super = "Carried Away : Rushes through one of the lanes of the garden. Pushing all zombies forwards 1 tile and launching up to 2 to the roof.";
                        string attack_1 = "Super Ultra Ball : Shoots a high damage projectile towards a random tile of the garden.";
                        string attack_2 = "Bad Moon Rising : Only works during nightime. Triggers a Haunting Moon (ignores moon cycle).";
                        string attack_3 = "Lurch for Lunch : 4-8 random zombies get +1 aps.";
                        string attack_4 = "Smoke Bomb : Spawns a smoke bomb on a tile and teleports all zombies on it 3 tiles forwards.";
                        string attack_5 = "Backyard Bouncy : Launches 2 zombies into the roof.";
                        string attack_6 = "Hail-a-copter : Spawns 2 Copter Comandimps.";
                    //shields
                        string super_a = "Telepathy : Instantly does two attacks.";
                        string super_b = "Cut Down to Size : Kills the highest damage plant in the garden.";
                        string super_c = "Super Stench : Creates 2 Waste Barrel Imps and 5 Smelly Zombies spread across the seven lanes.";

        //gw's_football_zombie

    //eminent_domain
        string description = "A Construction Cone Zombie and a Pylon Imp spawn in a random lane. If there are no empty tiles in that lane, remove the front-most plant and don't allow that tile to be placed on until the Construction Cone Zombie reaches it. It then stops zombies spawning naturally in that lane and instead spawns every construction zombie in the following order each wave: a Digger Zombie and an Excavator Zombie, a Supply Barrel Roller Zombie, a Ladder Zombie, an Electrician Zombie, an AC perry, a Kitchen Sink Zombie, a Paint Bucket Zombie, a Waste Barrel Imp, a Landscaper Zombie, a Gardener Zombie. Zombies can then naturally spawn in that lane once again.";
        string origin = "Rogue Garden";

    //football_game
        string description = "For the duration, only Football Zombies, Giga-Football Zombies, Quarterback Zombies, All-Star Zombies, Football Catapult Zombies, Defensive End Gargantuars, Mecha Football Zombies, Zombie Coaches, Team-Mascot Imps, and Brain Vendor Zombies may appear.";
        string origin = "Rogue Garden";

    //street_carnival
        string description = "For the duration, only zombies from the Carnival category may appear.";
        string origin = "PvZ 2 (Carnie Thymed Events)";
    
    //airstrike
        string description = "For the duration only Parachutist Zombies and Roof-Climber Zombies may appear.";
        string origin = "PvZ 2 (Lost City lost pilot ambush)";

    //air_raid
        string description = "For the duration only Balloon Zombies may appear.";
        string origin = "PvZ 1 Minigame";

    //imp_rain
        string description = "Two Zombie Drop-off Rockets spawn in each garden.";
        string origin = "PvZ 2 (Far Future bug bot imp ambush)";

    //bungee_ambush
        string description = "A half a dozen Bungee Zombies and Bungee Plumbers appear in each graden and in the roof.";

    //chicken_run
        string description = "Spawns a dozen chickens in each garden, spread on 3 to 4 lanes.";
        string origin = "PvZ 2 Mod - Eclise";

    //rush_hour
        string description = "For the duration, all CR goes into ZCorp Zombies and basics, imps and gargantuars are replaced with their ZCorp variants.";
        string origin = "Rogue Garden";

    //pine_clone_bonanza
        string description = "All plants are temporarily turned into pineclones.";
        string origin = "PvZ Heroes ; Rogue Garden";

    //bobsled_bonanza
        string description = "For the duration, only Zombonis and Bobsled Teams may appear.";
        string origin = "PvZ 1 Minigame";

    //portal_combat
        string description = "Spawns a Portal Gatekeeper Zombie that cannot die for the duration of the event.";
        string origin = "PvZ 1 Minigame ; PvZ Heroes";

    //invisi-ghoul
        string description = "For the duration, all zombies are invisible, unless lit by a light producer.";
        string origin = "PvZ 1 Minigame";

    //big_trouble_little_zombie
        string description = "For the duration, new zombies are smaller : running faster and eating faster but having less health and dealing less damage. They get insta-killed by Shrinking Violet";
        string origin = "PvZ 1 Minigame";

    //pogo_party
        string description = "For the duration, only Pogo Zombies and Seahorse Rider Zombies may appear.";
        string origin = "PvZ 1 Minigame";

    //zen_garden
        string description = "Fake-crashes the game. Very rare. 'You've been Zen Gardened'.";
        string origin = "PvZ 1 Limbo Page";
