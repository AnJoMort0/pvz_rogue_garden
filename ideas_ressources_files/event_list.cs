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
    string description = "Shallow water that covers a grass tile in the lawn. Both land and water plants can be placed on it and both land and water zombies can traverse it. Moist Moss can prevent it from disappearing after the event that spawned it ends. If a full lane is covered in Shallow Water tiles, both land and water zombies can spawn in said lane. If ran over by a Zomboni, it becomes a Frozen Shallow Water tile.";
    string origin = "Rogue Garden";

//frozen_shallow_water
    string description = "Frozen shallow water that covers a grass tile in the lawn. Only land plants can be placed on it but both land and water zombies can traverse it. If a full lane is covered in Frozen Shallow Water tiles, both land and water zombies can spawn in said lane, including Bobsleds.";
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
            string description = "Only triggers during the day. For its duration, all plants have a higher chance of falling asleep and night plants are weaker. Awakened Zombies from the Museum category are slightly more likely to spawn.";
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
        string descritpion = "A boss appears on the outer edge of one of the gardens, on the road or in the sky, outside or above of the plantable grid.";

        //zombots
            string description = "Giant robots built and controlled by Dr. Edgar Zomboss. They all have three phases at 3/3, 2/3 and 1/3 of their health, that get progressively more difficult before being defeated. Zombies in the garden he appears in stop spawning normally and instead get summoned by the boss.";
            
            //mark_iii
                string  description = "The Zombot Mark III is a colossal robot reminicent of its original apearance and its Mark II edition in the time-travel adventure. Its hulking height leaves it standing even higher than the roof. It can only be damage when hit at the head.";
                string  almanac     = "He may have exploded once and even twice, but Dr. Edgar Zomboss always believes that third time's the charm.";
                string  origin      = "PvZ 1 ; PvZ 2 China (Mark II) ; PvZ Heroes (Zom-Blob and Gargantuar's Feast)";
                string  summon      = "He summons zombies near himself, by placing them with his giant mechanical hand. He prefers placing few tougher zombies and mostly creates zombies originating from PvZ 1. Can place bobsled teams.";
                //phase_1
                    string  attack_1    = "Fire Ball : The Zombot lowers its head to the garden's level, making Zomboss vulnerable, in order to release a giant ball of fire that slides down the lane, buring plants and even the mowers. Can be countered with Ice-shroom and damaged by ice projectiles. Disappears if aimed at the pool.";
                    string  attack_2    = "Ice Ball : The Zombot lowers its head to the garden's level, making Zomboss vulnerable, in order to release a giant ball of ice that slides down the lane, freezing plants and even the mowers and leaving a trail of ice for bobsleds behind. Can be countered with Jalapeño and damaged by fire projectiles. Freezes the pool's surface if aimed at it, making it behave like frozen shallow water.";
                //phase_2
                    string  attack_3    = "Bungee Release : The Zombot holds its hand out over the garden, or the roof, and releases five bungee jumpers or bungee plumbers, whose ropes are attached to its fingers.";
                    string  attack_4    = "Zombot Stomp : The Zombot stomps a 2x3 to 3x3 area near him with its foot.";
                    string  attack_5    = "Ball of Blob : The Zombot lowers its head to the garden's level, making Zomboss vulnerable, in order to release a giant ball similar to the Zom-Blob that slides down the lane, crushing plants and leaving a trail of blob behind, and cannot be countered. Gives Disinfection zombie's effect, if aimed at the pool.";
                //phase_3
                    string  attack_6    = "Camper Throw : The Zombot throws a camping van at the garden or the roof, crushing plants in a 2x4 area and occasionally spawing a Campimp Porter, which imediately drowns if aimed the pool.";
                    string attack_7     = "Gargantuar's Feast : The Zombot lowers its head, making Zomboss, who rings a small golden bell, vulnerable. 3 gargantuars of any type spawn in its garden, spread across the 7 lanes.";
            
            //dug-up_sphinx-inator
                string  description = "The Zombot Sphinx-inator is a large ancient robot, that was stolen from the Neighbourghville Museum and, until now, was impossible to find. It occupies only a small area on the map but can move around with its spider-like legs.";
                string  almanac     = "Finding his precious old creation in the Neighbourghville Museum was, to be sure, a suprise for Dr. Edgar Zomboss, but more than a welcome one.";
                string  origin      = "PvZ 2";
                string  summon      = "Opens its mouth to release zombies. Prefers spawning groups of basics and zombies from the Museum category, as well as Headstone Carver Zombie and Mixed-up Gravedigger Zombies.";
                //phase_1
                    string  attack_1    = "Gravestone Lauch : The Zombot suddenly stops. Its pupil dialetes then reveales a missile that shoots towards a targeted tile on the lawn. If it hits a plant, it destroys it and sometimes places a gravestone where it lands.";
                    string  attack_2    = "Claws : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself. If it hits a Zombie Statue, brings it to 0 HP.";
                    string attack_3     = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                //phase_2
                    string  attack_3    = "Sun Strike : The Zombot suddenly stops. Its eye turns blue as it steals sun from the map. After catching 3 to 5 it releases a beam of fire down its lane, vaporizing all plants. If it fails to gather all required sun, it releases a smaller beam that simply damages the plants.";
                //phase_3
                    string  attack_4    = "Dash : The Zombot rears back, charges up and then dashes down the garden, crushing plants it touches. If it hits a Zombie Statue, brings it to 0 HP.";
                    string  attack_5    = "Medusa Stare : The Zombot suddenly stops. Its pupil turns green and dilates until covering its whole eye. Once charged up, it will throw its beam at zombies in a 1x3 area in front of itself, creating a barrier of statues and more zombies for the Zombie Medusas to push.";

            //catastro-liope
                string  description = "The mystery-filled circus-wagon of terrors and delights. It occupies only a small area on the map but can move around with its wagon wheel legs.";
                string  almanac     = "'Despite the decline of circuses in recent years, I refuse to give up on a form of entertainment with so much history and plant-destroying potential,' cackles Dr. Edgar Zomboss, all while tapping out a jaunty little tune on his keyboard.";
                string  origin      = "PvZ 2";
                string  summon      = "Opens its mouth to release zombies. Prefers spawning Animal Herder type zombies and zombies from the Carnival category.";
                //phase_1
                    string  attack_1    = "Imp Lauch : The Zombot's eye opens to reveal a cannon that shoots 1 to 3 Carnie Imps, multiplied by the phase it's in, at random tiles on the lawn.";
                    string  attack_2    = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself.";
                    string  attack_3    = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                //phase_2
                    string  attack_3    = "Animal Release : The Zombot opens its side-cage, releasing up to 5 zombie animals down each lane it occupies.";
                    string  attack_4    = "Fire Show : The Zombot summons up to 5 Firebreather Zombies and Firework Zombies.";
                //phase_3
                    string  attack_5    = "Dash : The Zombot rears back, charges up and then dashes down the garden, crushing plants it touches.";
                    string  attack_6    = "The Show Must Go On : Spawns 3 Ringmaster Zombies.";


            //desk-a-tron
                string  description = "Dr. Zomboss's corporate desk, but on legs. It occupies only a small area on the map but can move around with its office adequate legs.";
                string  almanac     = "After consultation, Dr. Edgar Zomboss finally decided to show who the Boss really is. He put on his coat, sat at his desk and told his managers to do the rest.";
                string  origin      = "Rogue Garden ; PvZ Heroes (Maniacal Laugh)";
                string  summon      = "Zomboss rings the bell on his shelf to call zombies in. Prefers spawning zombies from the ZCorp category and only spawns ZCorp variant basics.";
                //phase_1
                    string  attack_1    = "Costumer Service Please : Zomboss calls costumer service, summoning up to 3 ZCorp Costumer Sevice zombies across the garden.";
                    string  attack_2    = "Swing : The Zombot swings its metalic claws at the plants, destroying plants in a 1x3 area in front of itself.";
                    string  attack_3    = "Jump : The Zombot jumps to a different place instead of walking, avoiding land attacks while in movement.";
                //phase_2
                    string  attack_3    = "Work Emergency : Causes a Rush Hour event and spawns a ZCorp Consultant in each lane.";
                    string  attack_4    = "Maniacle Laugh : A random ZCorp Middle Manager gains 15 hp.";
                //phase_3
                    string  attack_5    = "Mass Firing : The Zombot rears back, charges up and then dashes down the garden, crushing plants and ZCorp basics it touches.";
                    string  attack_6    = "Promotion : Turns all non-armored ZCorp basics on the lanes he occupies into ZCorp Middle Managers";

            //multi-stage_masher
                string  description = "The Multi-Stage Masher is a huge concert stage that covers the whole road, leaving it vulnerable from every lane.";
                string almanac      = "In another world, in another time, Dr. Zomboss would receive the bounty of enthusiastic applause that is his due. Not here and now, though. Nope.";
                string  origin      = "PvZ 2 ; PvZ Heroes (Monster Mash)";
                string  summon      = "Beats his speakers to summon zombies from the ground in front of the stage. He prefers spawning many low-health zombies spread across the 7 lanes. Likes spawning Disco Zombies, Cosmic Disco Zombies, and instrument playing zombies.";
                    //phase_1
                        string  attack_1    = "Medley : Zomboss switches into a costume reminiscent of either an Orchestra Conductor Zombie, a Pianist Zombie, an Aerobics Instructor Zombie, the Binary Stars, or a Boom Box Zombie and gives their effect to the garden until he uses this attack again.";
                        string  attack_2    = "Monster Mash : Creates 3 or 4 Disco Zombies, one lane away from each-other.";
                        string  attack_3    = "Speaker Launch : A target appears on a random tile in the three last rows of the garden. A Speaker lands on that tile after a few seconds, destroying whatever plant was on that tile.";
                    //phase_2
                        string  attack_4    = "Booming Tunes : Make the speakers launch a heavy wave of music forwards. they deal 6 damage to the first plant they reach.";
                        string  attack_5    = "Asylum Keys : Zomboss switches into a costume reminiscent of the Jack-in-the-box Zombie and triggers an Asylum Escape Event.";
                        string  attack_6    = "Rap Battle : Zomboss switches into his rappper outfit and triggers a Rap Jam event.";
                        string  attack_7    = "Punk! : Zomboss switches into his Punk outfit and triggers a Punk Jam event.";
                    //phase_3
                        string  attack_8    = "Column Like You See 'Em : Zombot switches into his glitter outfit and creates a Glitter Zombie followed by a Conga Leader followed by a Line Dancer in every lane. The Glitter Zombies and Line Dancers drown if they walk into the pool.";
                        string  attack_9    = "Heavy Hair Metal : Zombot switches into his hair metal outfit and triggers a Hair Metal Jam event.";

            //zombspear_troupe_theatre
                string  description = "The Zombspear Troupe Theatre is a massive theatre stage that spans the entire garden, leaving it vulnerable from everylane. Be wary of the actors though!";
                string almanac      = "The Zombspear Troupe Theatre is Dr. Edgar Zomboss' greatest theatric performance yet! Open the red curtains for a true shakespearean drama, worthy of your eyes and ears... and your brains.";
                string  origin      = "PvZ 2 China (Zombot Troupe Manipulator)";
                string  summon      = "Zomboss writes a paper then throws it in the air, causing zombies to spawn from the trapdoors in front of the theatre. Only spawns at most one zombie per trapdoor but can spawn in multiple lanes at once. Likes spawning: Theatre Zombies, Ballerina Zombies, Perfume Zombies, Headstone Carver Zombies, Medusa Zombies, Imposters, Parasol Zombies, Umbrella Zombies";
                    //phase_1
                        string attack_1     = "Spotlights : Large spotlights aim at random tiles, stunning the plant on it.";
                        string attack_2     = "Recycling Scripts: Zomboss folds his old scripts. He lauches up to 4 Paper Plane Imps at the roof.";
                        string shylock_1    = "A Deal Is A Deal : Shylock steals 100 to 150 sun from the player.";
                        string shylock_2    = "Pound of Flesh : Shylock throws his dagger at the garden, destroying the plant it lands on and leaving the dagger on that tile.";
                        string antonio_1    = "Maritime Trade : Summons 1 to 3 Imp Commanders in the pool.";
                    //phase_2
                        string attack_3     = "Curtain Call : Zomboss slams the curtains shut on a random lane. It blocks straight-shooting projectiles for 2 waves then spawns one of Zomboss' preferred zombies after opening.";
                        string attack_4     = "The World's A Stage : Large spotlights aim at random tiles within 3 columns of the zombot. Zombies illuminated by it are immune to damage.";
                        string hamlet_1     = "To Eat Or Not To Eat : Hamlet jumps onto a flying balcony above the garden. Until he takes enough damage to return to the stage, he will monologue, throwing down skulls as he does. These deal 6 damage to the plant they land on or become a Theatre Zombie if they land on an empty tile.";
                        string hamlet_2     = "Mad North-North-West : Hamlet erratically dashes across a random lane, pushing all plants back one tile and ejecting any plant on the last column.";
                    //phase_3
                        string attack_5     = "Reprise : Zomboss throws Shylock's dagger or Hamlet's skull at a random tile in the garden.";
                        string romeo_1      = "Love's Shield : Romeo moves to a different lane and temporarily takes out his sword, reflecting all straight shooting projectiles on his lane and preventing them from damaging the zombot.";
                        string romeo_2      = "Final Act : Romeo throws a poisonous flask at the garden, dealing damage over time to plants in a cross shaped area where it lands.";
                        string juliet_1     = "Lover's Guard : Juliet's umbrella stops lobbed projectiles on her lane from damaging the zombot. She moves to a different lane.";
                        string juliet_2     = "Tragic End : Juliet stabs herself with Romeo's dagger, summoning 2 to 4 Haunting Ghosts on the garden.";

            //water-based
                
                //sharktronic_sub
                    string  description = "The Lion King of the Tidal Waves is here. Prepare your lilypads because the Zombot Sharktronic Sub knows no mercy.";
                    string  almanac     = "The Zombot Sharktronic Sub is a true labor of love. Dr. Zomboss obsessed over every detail of the aquatic mechanism of doom as he worked on it day in and day out from the wee hours of the morning until well after dark. It's no surprised he tinkred on a way to flood the garden just to bring it back!";
                    string  origin      = "PvZ 2";
                    string  summon      = "The Zombot Sharktronic Sub snaps at the water, causing zombies to submerge from the waters next to the Zombot. He prefers spawning aquatic zombies and can do so outside the pool.";
                    //phase_1
                        string  attack_1    = "Tidal Wave : Causes the Shallow Water next to the Zombot to expand by one column.";
                        string  attack_2    = "Submerge : The Zombot submerges and reemerges in a different part of the lawn, avoiding attacks while submerged.";
                        string  attack_3    = "Splash : The Zombot quickly dives and emerges back in the same spot. Doing so, it lauches 4 droplets that land on random tiles, turning them into Shallow Water tiles if they're dry or Water Tiles if there's already Shallow Water on them, destroying whatever plants without lily pads are already there.";
                    //phase_2
                        string  attack_4    = "Sharks : Summons sharks that destroy 1 to 3 random plants on water tiles.";
                        string  attack_5    = "Turbine : The Zombot opens its mouth to reveal a turbine that begins spinning, creating a maelstorm that pulls plants and zombies on the lanes it covers into it. Upon reaching the Zombot, these will die. The attack stops after eating 8 plants (not accounting for Lily Pads), taking enough damage or swallowing a Tangled Kelp, which will tangle up the turbine, stunning the Zombot for some time.";
                    //phase_3
                        string  attack_6    = "Big Wave Beach : Turns Shallow Water tile closest to Zombot on every lane into a Water tile.";
                        string  attack_7    = "Brought To Shore : Triggers a Pool Ambush that can happen on any Water tile of the garden.";

            //air-based
                
                //dark_dragon
                    string  description = "Get ready for the Game Master and his flying game of Darkness & Dragons!";
                    string  almanac     = "With a rumble of destruction, Dr. Zomboss forged his Dark Dragon in the heart of a volcano. Then he tempered the beast in the chilled waters of Doom Lake. Finally he fed its furnace with coal from the Mines of Morbidity. And the paint job - that was done by Carl.";
                    string  origin      = "PvZ 2";
                    string  summon      = "The Zombot roars, summoning zombies that rise from the ground. He prefers spawning zombies from the Fantasy Roleplaying Club.";
                    //phase_1
                        string  attack_1    = "Fireballs : The Zombot regurgitates 1 or 2 fireballs multiplied by the phase it's on that fall onto random tiles, leaving the tile burned for a few seconds, instantly killing the plant there and sometimes spawning Imp Dragons";
                        string  attack_2    = "Risen Dragon : The Zombot flies up, staying at roof height for a few waves. It can still summon zombies and perform its attacks.";
                        string  attack_3    = "Dark Night : Causes up to 4 Gravestones, Engraved Gravestones or Impstones to appear on empty tiles of the garden.";
                    //phase_2
                        string  attack_4    = "Dashing Swipe : The Zombot dashes upwards, does a full turn and swooshes down one lane, spewing fire that damages all plants. If there are 4 or more unoccupied Magnetshrooms on the three last columns of the garden, his nose ring will be pulled down by them, interrupting the attack and temporarily stunning the zombot.";
                        string  attack_5    = "Game Night : Summons a Wizard Zombie, a Knight of the Living Dead, a Shieldcrusher Viking Zombie and a Jester Zombie.";
                    //phase_3
                        string  attack_6    = "Necromancy : Triggers a Grave Ambush event.";
                        string  attack_8    = "High Level One-Shot : Summons a Wizard Gargantuar, a Royal Horn Imp on the garden, or a Guard-Gantuar.";

                //aerostatic_blimp
                    string  description = "The Aerostatic Blimp is an incredible tool for advertising and mass aerial destruction.";
                    string  almanac     = "The Aerostatic Blimp is even more Eco-Friendly than its lost predecessor: It now works entirely on Hydrogen, no fuel or heating required.";
                    string  origin      = "PvZ 2 (Zombot Aerostatic Gondola)";
                    string  summon      = "When on ground level, he opens a latch to drop down zombies. While on roof level, he sounds an alarm to summon flying zombies.";
                    //phase_1
                        string  attack_1    = "Altering Air Pressure : The Zombot rises to roof height or lowers itself to garden height. Either way it never lands.";
                        string  attack_2    = "Parachute Drop : The Zombot opens a latch to release up to 4 Parachutists underneath him.";
                    //phase_2
                        string  attack_3    = "Corporate Advertising : The Blimp's screen turns on to reveal an add for ZCorp. ZCorp Consultants and ZCorp Costumer Service can naturally appear in the garden until the screen changes.";
                        string  attack_4    = "Sports Advertising : The Blimp's screen turns on to reveal an add for the next Football Event. Super-fan Imps, Brain Vendor Zombies and Paparazzi Zombies can naturally appear in the garden until the screen changes.";
                        string  attack_5    = "Bot Swarm : The Zombot opens a latch to release up to 7 Bug Bot Imps into the garden.";
                    //phase_3
                        string  attack_6    = "News Advertising : The Blimp's screen turns on to reveal breaking news of a protest. Gilet Jaune Zombies, Riot Police Zombies and Medic Zombies can naturally appear in the garden until the screen changes.";
                        string  attack_7    = "Fanfare Advertising : The Blimp's screen turns on to reveal news for the upcoming Fanfare Parade. Drum Major Zombies can naturally appear in the garden until the screen changes.";
                        string  attack_8    = "Assistance Required : The Zombot sounds an alarm, summoning up to three Copter Comandimps";

                //battlecruiser_5000
                    string  description = "";
                    string  almanac     = "This model of vehicle is not space legal in 35 different galaxies. Luckily for Zomboss, this galaxy is much too dumb to ban it.";
                    string  origin      = "PvZ Heroes";
                    string  summon      = "The Zombot sounds its horn to summon zombies. It prefers summoning zombies weak to E.M.Peach. and the Zombie Drop-Off Rocket.";
                    //phase_1
                        string  attack_1    = "Takeoff : The Zombot rapidly flies upwards to roof height, being immune to damage as it does so.";
                        string  attack_2    = "Landing : The Zombot slowly flies downwards, landing on the road, being immune to damage as it does so.";
                        string  attack_3    = "Ion Cannon : Shoots a large electric bolt at a random attacking plant, burning it as it does so and scorching the tile.";
                    //phase_2
                        string  attack_4    = "Battle Immunity : The Zombot places a shield on the front-most zombie of each lane that is immune to all damage and only disappears after a few seconds.";
                        string  attack_5    = "Cruise Mode : While at roof height, the Zombot grants itself temporary immunity. It cannot perform any of its attacks while immune but it can still spawn zombies.";
                    //phase_3
                        string  attack_6    = "Alert Signal : The Zombot signals its siren, summoning flying backup in the form of Balloon Basics, Copter Comandimps or Zombie Drop-Off Rockets on each lane.";

                //vulture_fighter
                    string  description = "In wind or rain, lightning or thunder, comes the zombie king of the sky!";
                    string  almanac     = "Dr. Edgar Zomboss is not a bioligist, but he did find himself doing research on vultures until the early morning. None of it was used when designing the actual Zombot though, he just gets distracted easily.";
                    string  origin      = "PvZ 2 China";
                    string  summon      = "The Zombot screaches, summoning zombies onto the garden. He prefers summoning flying zombies and can summon Flag Pilot Zombies as well as Neutron Imps.";
                    //phase_1
                        string  attack_1    = "Early Bird : The Zombot flies up to roof height.";
                        string  attack_2    = "Gets The Worm : The Zombot dashes into the garden, clawing down two neighbouring plants. This attack can only be performed if the Zombot is flying.";
                        string  attack_3    = "Beak Attack : The Zombot bites down on a plant near it. This attack can only be performed while in the ground.";
                    //phase_2
                        string  attack_3    = "Lightning Call (Cryotron) : The Zombot summons lightning bolts that freeze the plant hit.";
                        string  attack_4    = "Lightning Call (Photon) : The Zombot summons lightning bolts that stun the plant hit and all plants in a cross shaped area.";
                        string  attack_5    = "Lightning Call (Proton) : The Zombot summons lightning bolts that deal up to 8 damage to the plant and heals the Zombot for the same amount of health.";
                        string  attack_6    = "Lightning Call (Electron) : The Zombot summons lightning bolts that deal heavy damage to the hit plant and jump to neighbourghing plants dealing less damage to them.";
                    //phase_3
                        string  escape_pod  = "As you reach phase three, the fight changes completely. Most of the Vulture Fighter is destroyed and crashes onto the road. It's head drops the beak and becomes a small fighter pod piloted by Zombot. It has a completely new set of attacks, never lands and will use a radar to summon zombies instead of screaching. This phase also has notably less health than the other phases.";
                        string  attack_b1   = "Master of the Seasons : The Zombot summons up to 8 Neutron Imps or his elite variants.";
                        string  attack_b2   = "Ion Barrage : The Zombot shoots a wave of projectiles that spread with distance and deal very low damage to plants.";
                        string  attack_b3   = "Electric Current : The Zombot releases two electrodes that create an electic current across the three lanes between them. The electrodes themselves ignore plants entirely while the electric current stuns plants it passes through. They can be damaged by plants. If one of them is destroyed, the other will flip around and start shooting electric bolts down, reminiscent of the four 'Lightning Call' attacks.";

        //hero_bosses
            string descitpion = "Hero Bosses are incredibly powerful zombies with special abilites. They all have a signature superpower and six powers based on their original categories in PvZ Heroes  for those that can and sometimes their attacks in Garden Warfare or their game of origin. Zombies keep spawning naturally tough they have higher chances of spawning from a specific category. Upon reaching 75%, 50%, and 25% health, the Heroe Bosses create a 30-50 armor shield on themselves and activate one of three superpowers they have.";

            //the_smash
                string  descitpion  = "It's the unrelenting brawler, the undead bruiser, he puts the G in Gargantuar... Stepping into the ring... it's THE SMASH!";
                string  almanac     = "The Smash enjoys...SMASHING!";
                string  origin      = "PvZ Heroes";
                string  zombies     = "Zombies from the Sportive Category are more likely to spawn.";
                //attacks
                    string  signature_super = "Slammin' Smackdown : Destroy a random plant with 4 damage or less.";
                    string  attack_1        = "Extinction Event : Deals 3 damage to a random plant. All copies of that plant take 2 damage.";
                    string  attack_2        = "Vitamin Z : Turns random basics into Arm Wrestler Zombies.";
                    string  attack_3        = "Locust Swarm : Puts a Locust Swarm in a random 3x3 area. It can be cleared by blover. All plants in the area take 0.5 damage per second.";
                    string  attack_4        = "Knockout : Stuns all plants with 1 or less damage in a lane.";
                    string  attack_5        = "Rolling Stones : Sends a large boulder down one of the lanes dealing 4 damage to all plants and zombies.";
                    string  attack_6        = "Going Viral : 2-4 zombies lose 2 hp but become 'frienzied' - Gains +0.5aps when it kills a plant.";
                //shields
                    string  super_a         = "Heroic Health : Heals himself for 12 hp.";
                    string  super_b         = "Possessed : 4-8 random zombies gain 4 armor if they already have any and become 'frienzied' - Gains +0.5aps when he kills a plant.";
                    string  super_c         = "Galvanise : 4-8 random zombies gain 10 hp and 2 dmg.";

            //rustbolt
                string  descitpion  = "Do not understimate this junkyard cyborg because the Rustbolt is no joking matter.";
                string  almanac     = "He enjoys keeping his bolts tight and his screws loose.";
                string  origin      = "PvZ Heroes";
                string  zombies     = "Zombies weak to E.M.Peach are more likely to spawn.";
                //attacks
                    string  signature_super = "Shrink Ray : Shrinks a random plant. Halfing all its stats.";
                    string  attack_1        = "Going Viral : 2-4 zombies lose 2 hp but becomes 'frienzied' - Gains +0.5aps when he kills a plant.";
                    string  attack_2        = "Escape Through Time : Replaces the lowest hp zombie with a random zombie from the Museum category.";
                    string  attack_3        = "Terrify : Switches the places of 8 plants across two random columns.";
                    string  attack_4        = "Cryo-brain : Increases the CR pool by 1 until the end of the boss battle.";
                    string  attack_5        = "Triplication : Replaces a wave with just three zombies, an Imp, a Zombie and a Gargantuar.";
                    string  attack_6        = "Hail-a-copter : Spawns 2 Copter Comandimps.";
                //shields
                    string  super_a         = "Heroic Health : Heals himself for 12 hp.";
                    string  super_b         = "Cut Down to Size : Kills the highest damage plant in the garden.";
                    string  super_c         = "Rock Wall : Creates a 1x3 line of Tombstones in front of the highest CR zombie in the garden.";

            //professor_brainstorm
                string  descitpion  = "He's crazy genius, and he's a crazy genius so be careful when defending from the Professor Brainstorm.";
                string  almanac     = "His countless years of research revealed that E=MCraaazy!";
                string  origin      = "PvZ Heroes";
                string  zombies     = "Zombies from the Scientific category are more likely to spawn.";
                //attacks
                    string  signature_super = "Eureka : Spawns three random zombies.";
                    string  attack_1        = "Quarterly Bonus : A random zombie gets +1 damage and +1 aps.";
                    string  attack_2        = "Rocket Science : Lauches a rocket at a random attacking plant, burning it as it does so, leaving a crater for just two waves.";
                    string  attack_3        = "Triplication : Replaces a wave with just three zombies, an Imp, a Zombie and a Gargantuar.";
                    string  attack_4        = "Cryo-brain : Increases the CR pool by 1 until the end of the boss battle.";
                    string  attack_5        = "Final Mission : Sacrifices a 6 CR or more zombie to shoot a rocket into the roof, dealing heavy damage in a plus shaped area.";
                    string  attack_6        = "Thinking Cap : Triggers a non-superpower attack from any Heroe Boss.";
                //shields
                    string  super_a         = "Summoning : Spawns a random 5 CR zombie";
                    string  super_b         = "Telepathy : Instantly does two attacks.";
                    string  super_c         = "Dance Off : Spawns 1 Backup Dancer, 1 Disco Backup Dancer and 1 Flamenco Backup Dancer in each lane.";
            
            //z-mech
                string  descitpion  = "Meet Imp, the smallest of the zombies, and his massive secret weapon: Z-Mech. A professional Z-Corp creation, this duo is down to do some damage.";
                string  almanac     = "He interrupted his 12 hour mecha anime maraton to make his now fifth appearance in a game. Don't worry, though; he's cleared it with his manager.";
                string  origin      = "PvZ Gw 2 ; PvZ Heroes ; PvZ 2 ";
                string  zombies     = "Disco Zombies, Imps and Zombie Drop-Off Rockets are more likely to spawn.";
                //attacks
                    string  signature_super = "Missile Madness : Lauches a missile at a plant that deals high damage to it and very low damage to every plant in its lane and column.";
                    string  attack_1        = "Robo Laser : Fire a concentrated laser down a lane that does constant damage to the first plant. It overheats after a few seconds and stuns the Boss as it goes away if it didn't kill a single plant.";
                    string  attack_2        = "Teleport : Spawns a teleportation device on a tile and teleports all zombies that walk into it 1 to 4 tiles forwards. It disappears after 2 waves.";
                    string  attack_3        = "Monster Mash : Creates 2 Disco Zombies, at least one lane away from each-other.";
                    string  attack_4        = "Sugary Treat : Spawns a Trick or Treater Zombie.";
                    string  attack_5        = "Escape Through Time : Replaces the lowest hp zombie with a random zombie from the Museum category.";
                    string  attack_6        = "Final Mission : Sacrifices a 6 CR or more zombie to shoot a rocket into the roof, dealing heavy damage in a plus shaped area.";
                //shields
                    string  super_a         = "Rock Wall : Creates a 1x3 line of Tombstones in front of the highest CR zombie in the garden.";
                    string  super_b         = "Brute Strenght : 4-8 zombies gain 5 damage.";
                    string  super_c         = "Electrobolt : Shoots down a lighting strike that deals 6 damage to a plant. If it kills it, creates a crater there.";

            //impfinity
                string  descitpion  = "Prepare for a more imps than you've ever seen. One could even call it an Impfinity.";
                string  almanac     = "He believes good things come in small packages. And in threes.";
                string  origin      = "PvZ Heroes";
                string  zombies     = "Imps are more likely to spawn.";
                //attacks
                    string  signature_super = "Triple Treath : Spawns three Impfinity Clones in the garden.";
                    string  attack_1        = "Cakesplosion : Spawns a Cake Bomb Imp on a random tile.";
                    string  attack_2        = "Final Mission : Sacrifices a 6 CR or more zombie to shoot a rocket into the roof, dealing heavy damage in a plus shaped area.";
                    string  attack_3        = "The Chickening : Triggers a Chicken Run ambush.";
                    string  attack_4        = "Smoke Bomb : Spawns a smoke bomb on a tile and teleports all zombies on it 3 tiles forwards.";
                    string  attack_5        = "Barrel of Barrels : Spawns a Supply Barrel Roller, a Waster Barrel Imp, a Carnie Imp Cannon, a Barrel of Deadbeard or a Barrel of Flameface.";
                    string  attack_6        = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                //shields
                    string super_a = "In-Crypted : Replaces 2 zombies with Engraved Gravestones and 1 imp with an Impstone.";
                    string super_b = "Brute Strenght : 4-8 zombies gain 5 damage.";
                    string super_c = "Super Stench : Creates 2 Waste Barrel Imps and 5 Smelly Zombies spread across the seven lanes.";

            //electric_boogaloo
                string  descitpion  = "If you think disco is dead then you might find that it is actually more alive than you'll be after the Electric Boogaloo finds you.";
                string  almanac     = "Do not mention Electric Slide to the Electric Boogaloo, he is still quite mad that he didn't make the cut.";
                string  origin      = "PvZ Heroes";
                string  ombies      = "(Cosmic) Disco Zombies and instrument-playing zombies are more likely to spawn.";
                //attacks
                    string  signature_super = "Stayin' Alive : Deals 3 damage to a plant and heals himself for 3 hp.";
                    string  attack_1        = "Cakesplosion : Spawns a Cake Bomb Imp on a random tile.";
                    string  attack_2        = "Final Mission : Sacrifices a 6 CR or more zombie to shoot a rocket into the roof, dealing heavy damage in a plus shaped area.";
                    string  attack_3        = "Sugary Treat : Spawns a Trick or Treater Zombie.";
                    string  attack_4        = "Vitamin Z : Turns random basics into Arm Wrestler Zombies.";
                    string  attack_5        = "Secret Agent : Kills a zombie that has an elite version and spawns its elite version on the next wave.";
                    string  attack_6        = "B-Flat : Drops a piano in a random tile, crushing the plant there but being blocked by Umbrella Leaf and doesn't affect Spikeweed and Spikerock.";
                //shields
                    string  super_a         = "Dance Off : Spawns 2 Backup Dancers in each lane.";
                    string  super_b         = "Evaporate : Kills the 2 lowest hp wall plants in the garden. Doens't work if they are on water.";
                    string  super_c         = "Electrobolt : Shoots down a lighting strike that deals 6 damage to a plant. If it kills it, creates a crater there.";

            //brain_freeze
                string  descitpion  = "The chill is strong when this yeti approaches. Be warry or you might just get an unexpected Brainfreeze.";
                string  almanac     = "Loves ice cream, snowstorms, and brains...not necessarily in that order.";
                string  origin      = "PvZ Heroes";
                string  zombies     = "Yetis are more likely to spawn.";
                //attacks
                    string  signature_super = "Frozen Tundra : Adds two levels of frost to the front-most plant of every lane.";
                    string  attack_1        = "Extinction Event : Deals 3 damage to a random plant. All copies of that plant take 2 damage.";
                    string  attack_2        = "Nibble : A plant gets stuned temporarily. Heals the boss for 3 hp.";
                    string  attack_3        = "Locust Swarm : Puts a Locust Swarm in a random 3x3 area. It can be cleared by blover. All plants in the area take 0.5 damage per second.";
                    string  attack_4        = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                    string  attack_5        = "Barrel of Barrels : Spawns a Supply Barrel Roller, a Waster Barrel Imp, a Carnie Imp Cannon, a Barrel of Deadbeard or a Barrel of Flameface.";
                    string  attack_6        = "Backyard Bouncy : Launches 2 zombies into the roof.";
                //shields
                    string  super_a         = "Dolphinado : Triggers a Sandstorm ambush that, if in the backyard, brings Doplhin Rider Zombies to the pool lanes.";
                    string  super_b         = "Acid Rain : Gives all plants in a 5x5 area -5 hp and -0.5 damage.";
                    string  super_c         = "Galvanise : 4-8 random zombies gain 10 hp and 2 dmg.";

            //foreman_garg
                string  descitpion  = "Foreman Garg is a mercyless boss... and a mercyless Boss. Prepare your defenses and your contracts.";
                string  almanac     = "He has no patience for stragglers. If you don't work, you're fired!";
                string  origin      = "PvZ 2 China (Foreman Gargantuar)";
                string  zombies     = "Zombies from the Construction category are more likely to spawn.";
                //attacks
                    string  signature_super = "Old School : Launches burning coal at a random tile of the garden from his coal burner, leaving the tile burned for a few seconds and instantly killing the plant there.";
                    string  attack_1        = "Construction Contractor : Spawns a Construction Cone Zombie and a Pylon Imp on a random lane of the garden.";
                    string  attack_2        = "Call For Supplies : Spawns up to three Supply Barrel Roller Zombies.";
                    string  attack_3        = "Painting the Roof : Spawns a Ladder Zombie and a Paint Bucket Zombie on the roof.";
                    string  attack_4        = "Weed Spray : Damages every plant with 0 aps.";
                    string  attack_5        = "Quarterly Bonus : A random zombie gets +1 damage and +1 aps.";
                    string  attack_6        = "Barrel of Barrels : Spawns a Supply Barrel Roller, a Waster Barrel Imp, a Carnie Imp Cannon, a Barrel of Deadbeard or a Barrel of Flameface.";
                //shields
                    string  super_a         = "Site Excavation : Spawns 5 Digger Zombies and Excavator Zombies.";
                    string  super_b         = "Electronics Instalation : Spawns 5 AC Perrys and Electrician Zombies.";
                    string  super_c         = "Super Stench : Creates 2 Waste Barrel Imps and 5 Smelly Zombies spread across the seven lanes.";

            //football_superstar
                string  descitpion  = "This superstar is more than just a Football star, be prepared for the game of the season.";
                string  almanac     = "The Football Superstar's game-plan involves suppressing the Plants with a never-ending barrage of footballs, pucks, kicks and punches.";
                string  origin      = "PvZ GW (All-Star)";
                string  zombies     = "Zombies that spawn in the Football Game event are very likely to spawn.";
                //attacks
                    string  signature_super = "Star of All Sports: Switches to one of his variants, each of which has two unique attacks.";
                    string  attack_1        = "Shield Decoy : Spawns a Shield Decoy on a random tile, destroying the plant there and shielding the zombies behind.";
                    string  attack_2        = "Imp Punt : Lobs a Super-Fan Imp into the garden.";
                    string  attack_3        = "Ultra Tackle : Sprints into a lane, hitting the first plant for high damage and pushing it back one tile.";
                    string  attack_4        = "Vitamin Z : Turns random basics into Arm Wrestler Zombies.";
                    //football_star
                        string  attack_5    = "Last Line Of Defense : Spawns a Defensive End Gargantuar.";
                        string  attack_6    = "Lurch for Lunch : 4-8 random zombies get +1 aps.";
                    //hockey_star
                        string  attack_5    = "Ice Stadium : Spawns up to two Zombonis in different lanes of the garden.";
                        string  attack_6    = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                    //olympian_star
                        string  attack_5    = "Lost Colosseum : Spawns up to three Planetary Gladiator's on the garden.";
                        string  attack_6    = "Backyard Bouncy : Launches 2 zombies into the roof.";
                    //wrestling_star
                        string  attack_5    = "Rodeo : Spawns a Rodeo Gargantuar and a Bull-Rider Imp on the garden.";
                        string  attack_6    = "Flex : Two zombies gain +1 dmg and the first plant on their lane is stunned for two waves.";
                //shields
                    string  super_a         = "Dummy Shield : Spawns a dummy shield that creates a protective dome, taking damage instead of the Boss and the zombies in the last column. It must be defeated to attack the Boss once more.";
                    string  super_b         = "Game Time : Instantly spawns Zombie Coaches, Team Mascot Imps and Brain Vendors on every lane.";
                    string  super_c         = "Brute Strenght : 4-8 zombies gain 5 damage.";

            //mirror_queen
                string  descitpion  = "She'll create cavalry, duplicating mirrors, poisoned apples and most of all... she'll look into your future for only $17.82 USD.";
                string  almanac     = "The Mirror Queen has become quite the master of the magical orb. It always shows brains in her future which she is very happy about.";
                string  origin      = "PvZ 2 China (Mirror Queen Zombie)";
                string  zombies     = "Zombies stop spawing on the other garden entirely. Mirrors appear on the extremities of each garden, duplicating the zombies that spawn in Mirror Queen's garden into the other. The pool lane is unaffected by this. Zombies from the Carnival category, Royal Horn Imps, Guard-gantaurs and Knights of the Living Dead are more likely to spawn.";
                //attacks
                    string  signature_super = "Poison Apple : The Mirror Queen throws a poisonous apple at a plant that behaves similarily to the Perfume Zombie's perfume.";
                    string  attack_1        = "Royal Guard : Spawns a Guard-gantuar.";
                    string  attack_2        = "Knighting Ceremony : Turns up to 3 basics into Knights of the Living Dead.";
                    string  attack_3        = "Queen of the Troupe : Spawns an Abracadaver, a Pied Piper Zombie and a Carnie Cannon.";
                    string  attack_4        = "Nibble : A plant gets stuned temporarily. Heals the boss for 3 hp.";
                    string  attack_5        = "Cakesplosion : Spawns a Cake Bomb Imp on a random tile.";
                    string  attack_6        = "Locust Swarm : Puts a Locust Swarm in a random 3x3 area. It can be cleared by blover. All plants in the area take 0.5 damage per second.";
                //shields
                    string  super_a         = "Portal Queen : Spawns a Portal Gatekeeper Zombie that remains unkillable until the end of the boss event.";
                    string  super_b         = "Acid Rain : Gives all plants in a 5x5 area -5 hp and -0.5 damage.";
                    string  super_c         = "Possessed : 4-8 random zombies gain 4 armor if they already have any and become 'frienzied' - Gains +0.5aps when he kills a plant.";

            //water-based
                //neptuna
                    string  descitpion  = "Prepare for the Lady of Neptune and her see of tentacles.";
                    string  almanac     = "The little fish that swims around is called Greg and he somehow lives in both saltwater and freshwater.";
                    string  origin      = "PvZ Heroes";
                    string  zombies     = "Aquatic zombies in the pool and animal herder type zombies are more likely to spawn. Octo Zombies are very likely to spawn.";
                    //attacks
                        string  signature_super = "Octo-Pult : Throws an Octo-Pet into the garden.";
                        string  attack_1        = "Tidal Wave : Causes the Shallow Water next to Neptuna to expand by one column.";
                        string  attack_2        = "Going Viral : 2-4 zombies lose 2 hp but become 'frienzied' - Gains +0.5aps when it kills a plant.";
                        string  attack_3        = "Flood : Turns up to three random Shallow Water tiles into Water tiles.";
                        string  attack_4        = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                        string  attack_5        = "Weed Spray : Damages every plant with 0 aps.";
                        string  attack_6        = "Terrify : Switches the places of 8 plants across two random columns.";
                    //shields
                        string  super_a         = "Dolphinado : Triggers a Sandstorm ambush that brings Doplhin Rider Zombies to into the garden.";
                        string  super_b         = "Possessed : 4-8 random zombies gain 4 armor if they already have any and become 'frienzied' - Gains +0.5aps when he kills a plant.";
                        string  super_c         = "In-Crypted : Replaces 2 zombies with Engraved Gravestones and 1 imp with an Impstone.";

            //air-based
                //immortal_lords
                    string  descitpion  = "The two greatest vampire lords of the land join forces to defeat the plant army. Can you handle the bat storm?";
                    string  almanac     = "Immorticia and Baron Von Bats might be a unexpected duo to you, but they're actually very close friends.";
                    string  origin      = "PvZ Heroes (Immorticia) ; PvZ GW";
                    string  zombies     = "Less zombies spawn overall. Vimpires and more likely to spawn.";
                    string  special     = "Immorticia flies while Baron Von Bats remains on the ground. They share a health bar and can both perform attacks and the signature super.";
                    //attacks
                        string  signature_super = "Bat Warp : Teleports to a different spot on the garden, leaving behind a cloud of fog and Zom-Bats on the tile they left.";
                        string  attack_1        = "Locust Swarm : Puts a Locust Swarm in a random 3x3 area. It can be cleared by blover. All plants in the area take 0.5 damage per second.";
                        string  attack_2        = "Extinction Event : Deals 3 damage to a random plant. All copies of that plant take 2 damage.";
                        string  attack_3        = "Bad Moon Rising : Only works during nightime. Triggers a Haunting Moon (ignores moon cycle).";
                        string  attack_4        = "Lurch for Lunch : 4-8 random zombies get +1 aps.";
                        string  attack_5        = "Nibble : A plant gets stuned temporarily. Heals the boss for 3 hp.";
                        string  attack_6        = "B-Flat : Drops a piano in a random tile, crushing the plant there but being blocked by Umbrella Leaf and doesn't affect Spikeweed and Spikerock.";
                    //shields
                        string  super_a         = "Vampire Summoning : Summons 3 Vimpires on the garden.";
                        string  super_b         = "Evaporate : Kills the 2 lowest hp wall plants in the garden. Doens't work if they are on water.";
                        string  super_c         = "Acid Rain : Gives all plants in a 5x5 area -5 hp and -0.5 damage.";

                //huge-giganticus
                    string  descitpion  = "Huge-Giganticus is the epitomy of imps and a daring threat to your plant line.";
                    string  almanac     = "Go on, tell him he's actually quite small. See what happens. You're not going to like it.";
                    string  origin      = "PvZ Heroes";
                    string  zombies     = "Imps and daytime specific zombies are more likely to spawn. Season specific zombies are very likely to spawn.";
                    //attacks
                        string  signature_super = "Terror-Former 10'000 : Changes the game to a random season. Neutron Imps will spawn as usual.";
                        string  attack_1        = "Teleport : Spawns a teleportation device on a tile and teleports all zombies that walk into it 1 to 4 tiles forwards. It disappears after 2 waves.";
                        string  attack_2        = "Bad Moon Rising : Only works during nightime. Triggers a Haunting Moon (ignores moon cycle).";
                        string  attack_3        = "Triplication : Replaces a wave with just three zombies, an Imp, a Zombie and a Gargantuar.";
                        string  attack_4        = "Rocket Science : Lauches a rocket at a random attacking plant, burning it as it does so, leaving a crater for just two waves.";
                        string attack_5 = "Barrel of Barrels : Spawns a Supply Barrel Roller, a Waster Barrel Imp, a Carnie Imp Cannon, a Barrel of Deadbeard or a Barrel of Flameface.";
                        string attack_6 = "Frosty Mustache : Freezes a random plant and places an Impostor on that tile.";
                    //shields
                        string  super_a         = "Iron Boarder : Summons an Iron Boarder Imp on each lane of the garden.";
                        string  super_b         = "Teleportation Station : Triggers the Teleport Attack on a full column.";
                        string  super_c         = "Ice Moon : Changes the game to night time if it is daytime and spawns a Zomboni on the garden.";

                //super_brainz
                    string  descitpion  = "Beware of the Super Brainz, he's not nearly as much a hero as he is a zombie.";
                    string  almanac     = "His most heroic quality is his hairstyle.";
                    string  origin      = "PvZ GW ; PvZ Heroes";
                    string  zombies     = "Roof Climber Zombies, Chimney Sweep Zombies and Foot Soldier Zombies are more likely to spawn.";
                    //attacks
                        string  signature_super = "Carried Away : Rushes through one of the lanes of the garden. Pushing all zombies forwards 1 tile and launching up to 2 to the roof.";
                        string  attack_1        = "Super Ultra Ball : Shoots a 12 damage projectile towards a random tile of the garden.";
                        string  attack_2        = "Bad Moon Rising : Only works during nightime. Triggers a Haunting Moon (ignores moon cycle).";
                        string  attack_3        = "Lurch for Lunch : 4-8 random zombies get +1 aps.";
                        string  attack_4        = "Smoke Bomb : Spawns a smoke bomb on a tile and teleports all zombies on it 3 tiles forwards.";
                        string  attack_5        = "Backyard Bouncy : Launches 2 zombies into the roof.";
                        string  attack_6        = "Hail-a-copter : Spawns 2 Copter Comandimps.";
                    //shields
                        string  super_a         = "Telepathy : Instantly does two attacks.";
                        string  super_b         = "Cut Down to Size : Kills the highest damage plant in the garden.";
                        string  super_c         = "Super Stench : Creates 2 Waste Barrel Imps and 5 Smelly Zombies spread across the seven lanes.";

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
        string description = "For the duration, all CR goes into ZCorp Zombies, and basics, imps and gargantuars are replaced with their ZCorp variants.";
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
