
//This is the full list of flag zombie variants for all the various events.

//A few waves before any event, a respective flag zombie appears. Ambush events and Bosses aren't anounced.
//These flag zombies vary in style and stats.
//Whenever a Flag Zombie dies, he drops his flag (or whatever he's holding) and it flies to the bottom of the screen as a little pop-up icon to make sure players don't miss the flag zombies amidst the masses.

//flag_zombie_template
    string event_name = "Everyone Explode Now";                                             //name of the event announced by the flag, add : ____ if there are precisions like day, night, frontyard, backyard, etc...
    string description = "A flag zombie.";                                                  //basic description of the zombie and reference to the fact he is leading a wave or event (you can be just discreet as you can be very obvious about what it is)
    string appearance = "Has a tie and a flag.";                                            //detailed description of the appearance. If based on an existing design, mentioning it will suffice
    double hp = 10;                                                                         //hit points (hp) is counted in peas
    double armour = 0;                                                                      //if relevant, add the hp of potential armour (i.e. Cone), if not "double armour = 0"
    double speed = fast;                                                                    //speeds written after template
    double dmg = 1;
    double aps = 2;
    string special = "Suddenly combusts, but only if it feels like it.";                    //if relevant, add a precise description of the ability/ies (this won't   show up in the actual almanac, it is instead used for coding), if not remove this line. This is also where you include Magnet-shroom weakness. Note : by default, zombies can't spawn on water or on air at all, so add precisions such as "Can spawn" or "only spawns in water" for the pool and "Flies towards the roof" (Flying zombies fly at "roof height", so if a peashooter is placed on the roof it'll be able to shoot the flying zombies) when necessary.
    string almanac = "Because why wouldn't we add 5000 more almanac entries to the game ?"; //almanac entry, be it copied from one of the original games or entirely/partially new
    string origin = "Rogue Garden";                                                         //game(s) or mod(s) of origin - add the original name of the zombie if the name changes for this (i.e. Monitor Head: string origin = "PvZ Battle for Neighbourville (TV Head)") as well as the origing of its gimmicks (i.e. Mad Chemist Zombie: string origin = "PvZ Heroes ; PvZ 2 (Dark Ages Potions)")

double slower = 1;
double slow = 2;
double normal = 3;
double fast = 4;
double faster = 5;


//flag_zombie
    string event_name = "Huge Wave : Front Garden";
    string description = "Flag Zombie announces the arrival of many things, notably Huge Waves of zombies.";
    string appearance = "The classic Flag Zombie design.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Make no mistake, Flag Zombie loves brains. But somewhere down the line he also picked up a fascination with flags. Maybe it's because the flags always have brains on them. Hard to say.";
    string origin = "PvZ 1";

//duckytube_flag_zombie
    string event_name = "Huge Wave : Back Garden";
    string description = "Ducky Tube Flag Zombie announces the arrival of many things, but they are all watery.";
    string appearance = "The classic Flag Zombie desig but Ducky Tube. The flag has a blue backdrop.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "He's not patriotic; he just likes fabric suspended from sticks.";
    string origin = "PvZ 1 ; PvZ Heroes";

//buckethead_rally_zombie
    string event_name = "Final Wave";
    string description = "Buckethead Rally Zombie and his flag marks the final daily arrival of an above-average number of zombies.";
    string appearance = "PvZ 2's Rally Zombie (New World) but with a bucket.";
    double hp = 10;
    double armour = 55;
    double speed = faster;
    double dmg = 2;
    double aps = 3;
    string special = "Bucket can be removed by Magnetshroom.";
    string almanac = "Buckethead Rally Zombie splurged on the all-leather flag because, heck, he's worth it.";
    string origin = "PvZ 2 (New World Rally Zombies) ; PvZ GW2 (Flag Zombie)";

//drum_major
    string event_name = "Zombie Concert";
    string description = "He leads a band, or something... bigger.";
    string appearance = "PvZ Heroe's Drum Major. Holds his stick instead of a flag. Buckethead.";
    double hp = 10;
    double armour = 55;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string special = "Helmet can be removed by Magnetshroom.";
    string almanac = "Recently promoted from Drum Minor.";
    string origin = "PvZ Heroes";

//zcorp_flag_zombie
    string event_name = "Rush Hour";
    string description = "The flag is a tremendous way to create brand awareness while also indicating a lot more zombies are about to appear and eat your brains.";
    string appearance = "PvZ 2's ZCorp Flag Zombie";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "ZCorp developed its flag logo in-house and is very proud of it.";
    string origin = "PvZ 2";

//city_planner_flag_zombie
    string event_name = "Eminent Domain";
    string description = "He likes coming to the site before the workers.";
    string appearance = "Wears a hard hat, has a pencil through his head, a jacket and is holding up a blue-print attached to a ruler.";
    double hp = 10;
    double armour = 10;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Why does he hold the blueprint so high up ? Why does he go into the garden at all when the plans are already made ? Why can't he just give directions to the workers ? These questions are still left unanswered...";
    string origin = "Rogue Garden";

//carnie_flag_zombie
    string event_name = "Street Carnival";
    string description = "Exciting banners promise fun new experiences for your brain!";
    string appearance = "PvZ 2's Carnie Flag Zombie";
    double hp = 15;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Carrying the flag comes with extra benefits and a uniform upgrade.";
    string origin = "PvZ 2";

//beach_flag_zombie
    string event_name = "Pool Party";
    string description = "Marks the arrival of a huge wet wave of zombies.";
    string appearance = "PvZ 2's Beach Flag Zombie. Swims in the pool.";
    double hp = 10;
    double armour = 0;
    double speed = normal;
    double dmg = 1;
    double aps = 2;
    string special = "Only spawns in the pool."
    string almanac = "Talk about a disgruntled zombie. Beach Flag Zombie is fed up. None of the other zombies seem to appreciate just how difficult it is for him to swim while holding a flag. Not once have they thanked him for doing the hard work that needs to be done. So it shouldn't come as a surprise: He's been interviewing for jobs somewhere else.";
    string origin = "PvZ 2";

//super_fan_flag_zombie
    string event_name = "Football Game";
    string description = "He's very excited about what's to come!";
    string appearance = "He resemble the All-Star Super Fan Imp. His flag also has the sparklers and a football instead of a brain.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "With the upcoming football game, he now has three obsessions. He might give up brains for football flags...";
    string origin = "PvZ 2 (All-star Super Fan Imp)";

//neon_flag_zombie
    string event_name = "Season Cycle : Summer";
    string description = "Marks the first Summer day.";
    string appearance = "PvZ 2's Neon Flag Zombie";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Fluorescent colors and little yellow plastic strips are the marks of a truly hip, groundbreaking new style of zombie wave flag.";
    string origin = "PvZ 2";

//lawn_of_doom_flag_zombie
    string event_name = "Season Cycle : Fall";
    string description = "Marks the first Autumn day. Happy Lawn of Doom !";
    string appearance = "PvZ 2's Lawn of Doom Flag Zombie";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "The great thing about carving pumpkins is they are just big enough to fit a brain and save it for later.";
    string origin = "PvZ 2";

//brownparka_flag_zombie
    string event_name = "Season Cycle : Winter";
    string description = "Marks the first Winter day. It's gonna get cold...";
    string appearance = "A Brownparka Zombie but with a snowy flag.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "The brownparka is for the style, the flag is for the honour and the brain... well, it'll be for the decomposing stomach.";
    string origin = "Rogue Garden";

//springening_flag_zombie
    string event_name = "Season Cycle : Spring";
    string descriptiom = "Marks the first Spring day. Happy Springening !";
    string appearance = "PvZ 2's Springening Flag Zombie";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Rabbits, pink, eggs, and brain mystery hunts. This flag zombie likes springening a lot.";
    string origin = "PvZ 2";

//flag_pilot_zombie
    string event_name = "Airstrike";
    string description = "You can expect a few more pilots to come, though they prever falling with style over flying.";
    string appearance = "PvZ 2 China's Flag Pilot Zombie.";
    double hp = 10;
    double armour = 5;
    double speed = fast;
    double dmg = 0.5;
    double aps = 4;
    string special = "Flies at roof height. Affected by E.M.Peach. Uses a flamethrower to attack from one tile away.";
    string almanac = "In Flag Pilot Zombie's opinion, if you want to walk in the forefront of fashion, the bright side of the banner is very important. However, other zombies are only concerned about his ability to lead them to find fresh brains.";
    string origin = "PvZ 2 China";

//balloon_flag_zombie
    string event_name = "Air Raid";
    string description = "The first balloon of many.";
    string appearance = "Hangs from a balloon that resembles his usual flag. The balloon becomes the icon.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string special = "Flies at roof height. Balloon can't be popped.";
    string almanac = "Flying makes the Balloon Flag Zombie a lot more visible, so other zombies know where to follow him.";
    string origin = "PvZ 1 ; PvZ 2 (Birthdayz Flag Zombie)";

//pogo_flag_zombie
    string event_name = "Pogo Party";
    string description = "He likes jumping. His followers do too...";
    string appearance = "Flag Zombie on a pogo stick. Flag has a grey backdrop.";
    double hp = 20;
    double armour = 0;
    double speed = normal;
    double dmg = 1;
    double aps = 2;
    string special = "Pogo stick can be removed by magnet-shroom. Jumps at 'fast' speed. Jumps over all plants instead of eating them, except Tall-nut which makes him loose his pogo stick if he jumps into it.";
    string almanac = "He likes jumping, flags, brains and leading riots.";
    string origin = "PvZ 1"

//tiny_flag_zombie
    string event_name = "Big Trouble Little Zombie";
    string description = "Be wary, he might be small but he brings forth something BIG.";
    string appearance = "Just a little guy with a little flag.";
    double hp = 5;
    double armour = 0;
    double speed = faster;
    double dmg = 0.5;
    double aps = 4;
    string special = "Is tiny.";
    string almanac = "'I don't mind being small' says Tiny Flag Zombie 'But when people call me little guy, I bite 'en.'";
    string origin = "PvZ 1 Minigame";

//inivisi-flag_zombie
    string event_name = "Invisi-ghoul";
    string description = "You will never see what's coming.";
    string appearance = "The zombie holding the flag looks like a regular flag zombie, though he is invisible. The flag itself is on a transluscent backdrop.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string special = "Zombie, not the flag, remains invisible unless lit by a light producer.";
    string almanac = "Where is he ? Who knows ? The answer is most people, because Invisi-flag Zombie forgot to coat his flag in invisi-paint.";
    string origin = "PvZ 1";

//ski_flag_zombie
    string event_name = "Bobsled Bonansa";
    string description = "He slides alone, but those who follow him don't.";
    string appearance = "Similar to a bobsled in color and style but wearing ski outfit. Drops his ski cane instead of a flag.";
    double hp = 25;
    double armour = 0;
    double speed = normal;
    double dmg = 2;
    double aps = 2;
    string special = "Slides down the garden at 'faster' speed until he reaches his first plant. Attacks with his cane instead of eating.";
    string almanac = "Other flag zombies hate Ski Flag Zombie for calling himself that. Flag Zombie himself said it best : 'What he's holding is nowhere near a flag!'";
    string origin = "Rogue Garden";

//sunflower_zombie
    string  event_name  = "Zombotany : Day";
    string  description = "He might look nice but remember : zombie sun-production just means more zombies.";                      
    double  hp          = 6;                                           
    double  armour      = 0;                                                                                     
    double  speed       = normal;                                    
    double  dmg         = 1;                                           
    double  aps         = 2;                                              
    string  projectile  = ""; 
    int     ai          = ;                 
    double  range       = ;                                     
    string  special     = "Heals zombies that pass by him by 2hp.";                      
    string  almanac     = "How does sun production translate to healing, you ask ? It doesn't : announcing Huge Waves does. The healing comes from the flag. It's a family heirloom.";
    string  origin      = "Rogue Garden";  

//eclipse_glasses_vendor
    string event_name = "Total Eclipse";
    string description = "Eclipse glasses can only mean one thing... Profit for Eclipse Glasses Vendor.";
    string appearance = "Resembles Brain Vendor Zombie in model but dark palette and sells eclipse glasses.";
    double hp = 10;
    double armour = 3;
    double speed = slow;
    double dmg = 1;
    double aps = 2;
    string special = "Zombies that pass by him get Eclipse Glasses, that give them 3 armor.";
    string almanac = "Eclipse Glasses Vendor originaly intended on selling brains, but after an astrologist 'consentfully lended' him a moon calender he got a genius idea for a new business.";
    string origin = "Rogue Garden";

//holographic_flag_zombie
    string event_name = "Radiation Wave";
    string description = "Holographic Flag Zombie anounces dangers from the far future coming in the near future.";
    string appearance = "PvZ 2's Far Future Flag Zombie.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "'Holograms are not really a future tech,' says Holographic Flag Zombie 'I mean time travel bringing stuff back is basically creating them in the present right?'";
    string origin = "PvZ 2 (Far Future Flag Zombie)";

//bright_night_flag_zombie
    string event_name = "Full Moon";
    string description = "A glorious night is coming. Bright Night Flag Zombie seems to be the only one of his side to look forward to it.";
    string appearance = "PvZ 2's Summer Nights Flag Zombie. Drops flag and sparkles for icon.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Being friends with Fireworks Zombie has its advantages and its disadvantages.";
    string origin = "PvZ 2 (Summer Nights Flag Zombie)";

//vampire_flag_zombie
    string event_name = "New Moon";
    string description = "Did you know moonlight is just reflected sunlight ? Vampire Flag Zombie certainly does.";
    string appearance = "Similar to the Vimpire but full zombie.";
    double hp = 10;
    double armour = 0;
    double speed = normal;
    double dmg = 1;
    double aps = 2;
    string special = "Takes passive fire damage during the day. Gains a movement speed and aps buff upon eating a plant. Dies if he bites garlic.";
    string almanac = "He's still can't understand how Vimpire can survive during full moons, and much less when in direct sunlight!";
    string origin = "Rogue Garden";

//flag_mummy_zombie
    string event_name = "Heat Wave";
    string description = "Mummys come from the desert. The desert is hot. You can make out the rest.";
    string appearance = "PvZ 2's mummy flag zombie.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string almanac = "Egyptian Flag Zombie is so far behind Flag Mummy Zombie he thinks he's in first place. He's clearly living in de-Nile.";
    string origin = "PvZ 2";

//flashlight_zombie
    string event_name = "Dark Storm":
    string description = "Flashlight Zombie is prepared for the upcoming dark.";
    string appearance = "Resembles a regular browncoat, but with darker clothing and holding a flashlight that he drops as an icon.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string special = "Produces light in its tile and the tile in front of itself.";
    string almanac = "'Flashlight Zombie had the decency of not calling himself a flag zombie,' said Flag Zombie, 'That's why he's welcome and to the annual flag convention and Ski Flag Zombie isn't.'";
    string origin = "Rogue Garden";

//raincoat_flag_zombie
    string event_name = "Rain Storm";
    string descitpion = "Raincoat Flag Zombie always watches the weather forecast.";
    string appearance = "Ressembles the Raincoat Zombie from PvZ 2 but has a regular body build and has the upside-down umbrella attached to the top of the flag that he drops instead of on his head.";
    double hp = 10;
    double armour = 0;
    double speed = fast;
    double dmg = 1;
    double aps = 2;
    string special = "Reflects lobbed attacks targeted at him specifically.";
    string almanac = "When not raiding the lawns, Raincoat Flag Zombie can always be found raiding the clothing stores around the town. Dr. Zomboss has saved loads of money on laundry since Raincoat Flag Zombie never repeats a raincoat it has worn.";
    string origin = "PvZ 2 (Raincoat Zombie)";
