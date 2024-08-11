double slower = 1;
double slow = 2;
double normal = 3;
double fast = 4;
double faster = 5;

    //template_category
        //template_event
            string description = "";
            string origin = "";

        //template_boss
            string descitpion = "";
            string almanac = "";
            string origin = "";
            string summon = "";
            string attack_1 = "";

        //template_zombot
            string descitpion = "";
            string almanac = "";
            string origin = "";
            string summon = "";
            //phase_1
                string attack_1 = "";
            //phase_2
            //phase_3

    //shallow_water
            string descitpion = "Shallow water that covers a grass tile in the lawn. Both land and water plants can be placed on it and both land and water zombies can traverse it. Moist Moss can prevent it from disappearing after the event that spawned it ends. If a full lane is covered with shallow water tiles, both land and water zombies can spawn in said lane. If ran over by a Zomboni, it behaves the same except water plants cannot be placed and bobsleds can spawn.";
            string origin = "Rogue Garden";

//almanac_of_events
    //day-night_cycle
        string description = "The time of day changes between day and night throughout the game. Plants working on the 'wrong' shift (i.e.: shrooms during the day) may fall asleep and if they are placed outside of 'work time' they'll be asleep.";
        string origin = "PvZ 1";

        //day
            string descritpion = "During the day : Sun fall from the sky.";

            //total_eclipse
                string description = "For all intents and porpuses, behaves the same as a New Moon but triggers during the day.";
                string origin = "PvZ Heroes";

            //radiation_wave
                string description = "Sun falling from the sky glow a radioactive purple. If clicked before they land, they explode dealing massive damage to zombies and plants in a 3x3 area. Zom-blobs and Genetic Experiments are more likely to spawn.";
                string origin = "PvZ 2 (Far Future - Sun Bombs)";

        //night
            string descritpion = "During the night : Sun don't fall from the sky.";

    //moon_phase_cycle
        string description = "This game features a moon cycle, though only the two extremes are relevent.";
         string origin = "Rogue Garden";

        //full_moon
            string description = "During full moon, no plants fall asleep.";

            //haunting_moon
                string description = "For its duration, upgrades all zombies on screen. May trigger during full moons.";
                string origin = "PvZ Heroes (Bad Moon Rising)";

        //new_moon
            string description = "For its duration, all plants have a higher chance of falling asleep and day plants are weaker.";

    //season_cycle
        string description = "This game features seasons, that are mostly indicated by the UI and a general change in hue. Whenever a new season starts, 3 Neutron Imps spawn in each garden.";
        string origin = "Rogue Garden";

        //summer
            string description = "Druing summer, sun are more likely to fall from the sky.";

            //sandstorm
                string description = "Basics and low CR zombies can appear in small sand hurricanes, moving them fast past your defenses.";
                string origin = "PvZ 2 (Ancient Egypt - Sandstorm)";

            //pool_party
                string description = "For its duration, zombies are more likely to spawn in the backyard than the front yard. Zombies that spawn in the backyard have a higher chance of spawning in the pool lanes.";

            //heat_wave
                string description = "Only triggers during the day. For its duration, all plants have a higher chance of falling asleep and night plants are weaker.";
                string origin = "PvZ 1 DS Version";

                //drought
                    string descitpion = "The pool dries, turning all its tiles into shallow water. May trigger during heat waves.";

        //fall
            string description = "Fog appears on both sides of the map. This blocks visibility and may be countered with various plants.";
            string origin = "PvZ 1";

            //dark_storm
                string description = "The screen will remain dark until lightning flashes.";
                string origin = "PvZ 1";

            //rain_storm
                string descritpion = "A large rain cloud covers the yard. Grass tiles are randomly covered in 'Shallow Water' and only go away a few seconds after the event ends.";
                    
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
                        string description = "For the duration, zombies don't spawn normally. Spawns various Jack-in-the-box Zombies, Cuckoo Zombies and Trickster Zombies spread over the 7 lanes of a garden.";
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
                        string description = "For the duration, zombies don't spawn normally. Spawns various Punk Zombies spread over the 7 lanes of a garden each wave.";
                        string origin = "PvZ 2";

                    //pop_jam
                        string description = "Spawns a glitter zombie in every lane of a garden.";
                        string origin = "PvZ 2";

                    //rap_jam
                        string description = "For the duration, zombies don't spawn normally. Spawns various Mc-ZomBs and Breakdancer Zombies spread over the 7 lanes of a garden each wave.";
                        string origin = "PvZ 2";

                    //metal_jam
                        string description = "For the duration, zombies don't spawn normally. Spawns 1 to 3 Hair Metal Gargantuars and 30 to 10 Hair Metal Imps respectivelly each wave.";
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
                string descitpion = "Giant robots built and controlled by Dr. Edgar Zomboss. They all have three phases at 3/3, 2/3 and 1/3 of their health, where they get progressively more difficult before being defeated. Zombies in the garden he appears in stop spawning normally and instead get summoned by the boss.";
                
                //mark_iii
                    string descitpion = "The Zombot Mark III is a colossal robot reminicent of its original apearance and its Mark II edition in the time-travel adventure. Its hulking height leaves it standing even higher than the roof. It can only be damage when hit at the head.";
                    string almanac = "He may have exploded once and even twice, but he always believes that third time's the charm.";
                    string origin = "PvZ 1 ; PvZ 2 China (Mark II) ; PvZ Heroes (Zom-Blob and Gargantuar's Feast)";
                    string summon = "He summons zombies near himself, by placing them with his giant mechanical hand. He prefers placing few tougher zombies and mostly creates zombies originating from PvZ 1. Can place bobsled teams.";
                    //phase_1
                        string attack_1 = "Fire Ball : The Zombot lowers its head to the gardens level, making Zomboss vulnerable, in order to release a giant ball of fire that slides down the lane, buring plants and even the mowers. Can be countered with Ice-shroom and damaged by ice projectiles. Disappears if aimed at the pool.";
                        string attack_2 = "Ice Ball : The Zombot lowers its head to the gardens level, making Zomboss vulnerable, in order to release a giant ball of ice that slides down the lane, freezing plants and even the mowers and leaving a trail of ice for bobsleds behind. Can be countered with Jalapeño and damaged by fire projectiles. Freezes the pool's surface if aimed at it, making it behave like frozen shallow water.";
                    //phase_2
                        string attack_3 = "Bungee Release : The Zombot holds its hand out over the garden, or the roof, and releases five bungee jumpers or bungee plumbers, whose ropes are attached to its fingers.";
                        string attack_4 = "Zombot Stomp : The Zombot stomps a 2x3 to 3x3 area near him with its foot.";
                        string attack_5 = "Ball of Blob : The Zombot lowers its head to the gardens level, making Zomboss vulnerable, in order to release a giant ball similar to the Zom-Blob that slides down the lane, crushing plants and leaving a trail of blob behind, and cannot be countered. Gives Disinfection zombie's effect, if aimed at the pool.";
                    //phase_3
                        string attack_6 = "Camper Throw : The Zombot throws a camping van at the garden or the roof, crushing plants in a 2x4 area and occasionally spawing a Campimp Porter, unless aimed at the pool.";
                        string attack_7 = "Gargantuar's Feast : The Zombot lowers its head, making Zomboss, who rings a small golden bell, vulnerable. 3 gargantuars of any type spawn in its garden, spread acroos the 7 lanes."
                
                //dug-up_sphinx-inator
                    string descitpion = "The Zombot Sphinx-inator is a large ancient robot, that was stolen from the Neighbourghville Museum and, until now, impossible to find. It occupies only a small area on the map but can move around with its spider-like legs.";
                    string almanac = "Finding his precious old creation in the Neighbourghville Museum was, to be sure, a suprise for Dr. Edgar Zomboss, but a more than welcome one.";
                    string origin = "PvZ 2";
                    string summon = "Opens its mouth to release zombies. Prefers spawning groups of basics and zombies from the Museum category, as well as Headstone Carver Zombie and Mixed-up Gravedigger Zombies.";
                    //phase_1
                        string attack_1 = "Gravestone Lauch : The Zombot suddenly stops. Its pupil dialetes then reveales a missile that shoots towards a targeted tile on the lawn. If it hits a plant, it destroys it and sometimes places a gravestone where it lands.";
                        string attack_2 = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself. If it hits a Zombie Statue, brings it to 0 HP.";
                        string attack_3 = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                    //phase_2
                        string attack_3 = "Sun Strike : The Zombot suddenly stops. Its eye turns blue as it steals sun from the map. After catching 3 to 5 it releases a beam of fire down its lane, vaporizing all plants. If it fails to gather all required sun, it releases a smaller beam that simply damages the plants.";
                    //phase_3
                        string attack_4 = "Dash : The Zombot rears back, charges up and then dashes down the garden, crushing plants it touches. If it hits a Zombie Statue, brings it to 0 HP.";
                        string attack_5 = "Medusa Stare : The Zombot suddenly stops. Its pupil turns green and dilates until covering its whole eye. Once charged up, it will throw its beam at zombies in a 1x3 area in front of itself, creating a barrier of statues and more zombies for the Zombie Medusas to push.";

                //catastro-liope
                    string descitpion = "The mystery-filled circus-wagon of terrors and delights. It occupies only a small area on the map but can move around with its wagon wheel legs.";
                    string almanac = "'Despite the decline of circuses in recent years, I refuse to give up on a form of entertainment with so much history and plant-destroying potential,' cackles Dr. Zomboss, all while tapping out a jaunty little tune on his keyboard.";
                    string origin = "PvZ 2";
                    string summon = "Opens its mouth to release zombies. Prefers spawning zombies from the Carnival category.";
                    //phase_1
                        string attack_1 = "Imp Lauch : The Zombot's eye opens to reveal a cannon that shoots 1 to 3 Carnie Imps, multiplied by the phase it's in, at random tiles on the lawn.";
                        string attack_2 = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself.";
                        string attack_3 = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                    //phase_2
                        string attack_3 = "Animal Release : The Zombot opens its side-cage, releasing Zombie Doves, Rabits and Rats down the three lanes in occupies.";
                    //phase_3
                        string attack_4 = "Dash : The Zombot rears back, charges up and then dashes down the garden, crushing plants it touches.";

                //desk-a-tron
                    string descitpion = "Dr. Zomboss's corporate desk, but on legs. It occupies only a small area on the map but can move around with its office adequate legs.";
                    string almanac = "After consultation, Dr. Edgar Zomboss finally decided to show who the Boss really is. He put on his coat, sat at his desk and told his managers to the rest.";
                    string origin = "Rogue Garden";
                    string summon = "Zomboss rings the bell on his shelf to call zombies in. Prefers spawning zombies from the ZCorp category and only spawns ZCorp variant basics.";
                    //phase_1
                        string attack_1 = "Costumer Service Please : Zomboss calls costumer service, summoning up to 5 ZCorp Costumer Sevice accros the garden.";
                        string attack_2 = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself.";
                        string attack_3 = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                    //phase_2
                        string attack_3 = "Work Emergency : Causes a Rush Hour event and spawns a ZCorp Consultant in each lane.";
                    //phase_3
                        string attack_4 = "Mass Firing : The Zombot rears back, charges up and then dashes down the garden, crushing plants and ZCorp basics it touches.";
                        string attack_5 = "Promotion : Turns all non-armored ZCorp basics into ZCorp Middle Managers";

                //multi-stage_masher
                    //Concert

                //water-based
                    
                    //sharktronic

                //air-based
                    
                    //dark_dragon
                        //Fantasy Roleplaying Club

                    //aerostatic_blimp

                    //battle_cruiser_5000

            //heroes
                
                //the_smash
                    //Sportive Zombies

                //rustbolt
                    //Construction Zombies

                //professor_brainstorm
                    //Scientific Zombies
                
                //z-mech
                    //Mechanized Zombies

                //immorticia
                    //Fantasy Roleplaying Club

                //impfinity

                //electric_boogaloo

                //brain_freeze

                //water-based
                    //neptuna

                //air-based
                    //huge_giganticus

                    //super_brainz

        //airstrike
            string description = "For the duration, all CR goes into Parachutist Zombies and Roof-Climber Zombies";
            string origin = "PvZ 2 (Lost City lost pilot ambush)";

        //air_raid
            string description = "For the duration, all CR goes into Ballon Zombies";
            string origin = "PvZ 1 Minigame";

        //imp_rain
            string description = "Two Transport Fighters spawn in each garden.";
            string origin = "PvZ 2 (Far Future neutron imp ambush)";

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
            string description = "All CR goes into Zombonis and Bobsleds.";
            string origin = "PvZ 1 Minigame";

        //portal_combat
            string description = "Spawns a Portal Gatekeeper Zombie that cannot die for the duration of the event.";
            string origin = "PvZ 1 Minigame ; PvZ Heroes";

        //invisi-ghoul
            string description = "For the duration, all zombies are invisible, unless lit by Plantern.";
            string origin = "PvZ 1 Minigame";

        //big_trouble_little_zombie
            string description = "For the duration, new zombies are smaller : running faster and eating faster but having less health and dealing less damage.";
            string origin = "PvZ 1 Minigame";

        //pogo_party
            string description = "For the duration, all CR goes into Pogo Zombies and Seahorse Rider Zombies.";
            string origin = "PvZ 1 Minigame";

        //zen_garden
            string description = "Fake-crashes the game. Very rare. 'You've been Zen Gardened'.";
            string origin = "PvZ 1 Limbo Page";
