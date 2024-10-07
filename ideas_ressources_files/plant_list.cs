
//This is the full list of plants, which will have an almanac in the game. There will be adjustements with play-testing and many of these will take a long to actually join the game. Any ideas are welcome as long as you follow the guideline;s according to the comented template. You are welcome to propose changes and give feedback.
//See a reference to HP in here: https://plantsvszombies.fandom.com/wiki/Damage#Plants_vs._Zombies
    //The projectile properties (dmg, pierce and lifespan may become it's own class unrelated to the plants)

    //template_plant
        string despcription = "";   //basic description of the plant (if available, you can easily take it straight from its game of origin)
        double cost = 25;           //sun cost of the plant. The game works on a 25 sun basis
        int rech_time = ;           //mesured in seconds - time needed for the plant to be available again
        double hp = 6;              //hit points (hp) are counted in peas. Yes, even the plants'. Note: A regular plant has 6 hp
        string projectile = "pea";  //from the projectiles_list
        int ai = 1;                 //mesured in seconds - ai stands for attack interval, aka time between each attack, aka how fast the plant attacks
        double range = line;        //measured in tiles or 'line;' or 'garden', range of sight of the plant
        string special = "";        //if relevant, add a precise description of the ability/ies (this won't show up in the actual almanac, it is instead used as guidance for coding), if not remove this line;.
        string almanac = "";        //almanac entry, be it copied from one of the original games or entirely/partially new
        string origin = "";         //game(s) or mod(s) of origin/main reference

    //copy_paste
        string  despcription    = "";
        double  cost            = ;
        int     rech_time       = ;
        double  hp              = 6;
        string  projectile      = "";
        int     ai              = ;
        double  range           = line;
        string  special         = "";
        string  almanac         = "";
        string  origin          = "";

//Bacic day deck
    //sunflower
        string  despcription    = "Sunflowers are essential for you to produce extra sun. Try planting as many as you can!";
        double  cost            = 50;
        int     rech_time       = ;
        double  hp              = 6;
        string  projectile      = "sun";
        int     ai              = 24;
        string  special         = "Doesn't attack, it produces sun";
        string  almanac         = "'Not to brag, but I'm pretty much your basic franchise-founding superstar.'";
        string  origin          = "PvZ 1";

        //twin_sunflower
            string  despcription    = "Twin Sunflowers give twice as much sun as a normal sunflower.";
            double  cost            = 150;
            int     rech_time       = ;
            double  hp              = 6;
            string  projectile      = "sun";
            int     ai              = burst(2, 24);
            string  special         = "Doesn't attack, it produces sun";
            string  almanac         = "It was a crazed night of forbidden science that brought Twin Sunflower into existence. Thunder crashed overhead, strange lights flickered, even the very roaring wind seemed to hiss its angry denial. But to no avail. Twin Sunflower was alive, ALIVE!";
            string  origin          = "PvZ 1";

        //metal_petal_sunflower
            string  despcription    = "Metal Petal is an armored Sunflower. While the metal weighs her down-making her slower than other Sunflowers-she has the added benefit of higher health.";
            double  cost            = 100;
            int     rech_time       = ;
            double  hp              = 80;
            string  projectile      = "sun";
            int     ai              = 27;
            string  special         = "Doesn't attack, it produces sun";
            string  almanac         = "'Time to put the metal to the petal, baby!'";
            string  origin          = "PvZ GW, PvZ Heroes";

    //peashooter
        string  despcription    = "Peashooters are your first line; of defense. They shoot peas at attacking zombies.";
        double  cost            = 100;
        int     rech_time       = ;
        double  hp              = 6;
        string  projectile      = "pea";
        int     ai              = 1.5;
        double  range           = line;
        string  special         = "";
        string  almanac         = "How can a single plant grow and shoot so many peas so quickly? Peashooter says, 'Hard work, commitment, and a healthy, well-balanced breakfast of sunlight and high-fiber carbon dioxide make it all possible.'";
        string  origin          = "PvZ 1";

        //peapods
            string  despcription    = "Stack multiple Peas to quintuple the power!";
            double  cost            = 100 * n; //scalling price by the number of pods
            int     rech_time       = ;
            double  hp              = 6;
            string  projectile      = "pea";
            int     ai              = burst(n, 1.5);
            double  range           = line;
            string  special         = "";
            string  almanac         = "Pea Pod studied spacial quantum mechanics and graduated from Professional Clown Academy. As a barrel of laughs in the family, everyone loves him.";
            string  origin          = "PvZ 2";

        //skyshooter
            string  despcription    = "Skyshooters are your second line; of defense. They shoot more efficiently when on the roof. Targets flying zombies first";
            double  cost            = 75;
            int     rech_time       = ;
            double  hp              = 6;
            string  projectile      = "pea";
            int     ai              = 1.5; //halves when on the roof
            double  range           = line;
            string  special         = "Doubles the attack speed when on the roof. Targets first flying zombies on its line;";
            string  almanac         = "The youngest Peashooter ever to earn a pilot's license. Also the only Peashooter ever to earn a pilot's license.";
            string  origin          = "PvZ Heroes";

    //repeater
        string  despcription    = "Repeaters fire two peas at a time.";
        double  cost            = 225;
        int     rech_time       = ;
        double  hp              = 6;
        string  projectile      = "pea";
        int     ai              = burst(2, 1.5);
        double  range           = line;
        string  special         = "";
        string  almanac         = "Repeater is fierce. He's from the streets. He doesn't take attitude from anybody, plant or zombie, and he shoots peas to keep people at a distance. Secretly, though, Repeater yearns for love.";
        string  origin          = "PvZ 1";

        //threepeater
            string  despcription    = "Threepeater shoots peas in three lanes.";
            double  cost            = 150;
            int     rech_time       = ;
            double  hp              = 6;
            string  projectile      = "pea";
            int     ai              = 1.5;
            double  range           = line;
            string  special         = "Shoots 3 peas, one in its line; and one in each adjacent line;";
            string  almanac         = "Threepeater likes reading, backgammon and long periods of immobility in the park. Threepeater enjoys going to shows, particularly modern jazz. 'I'm just looking for that special someone,' he says. Threepeater's favorite number is 5";
            string  origin          = "PvZ 1";

        //gatling_pea
            string  despcription    = "Gatling Peas shoot four peas at a time.";
            double  cost            = 250;
            int     rech_time       = ;
            double  hp              = 6;
            string  projectile      = "pea";
            int     ai              = burst(4, 1.5);
            double  range           = line;
            string  special         = "";
            string  almanac         = "Gatling Pea's parents were concerned when he announced his intention to join the military. "But honey, it's so dangerous!" they said in unison. Gatling Pea refused to budge. "Life is dangerous," he replied, eyes glinting with steely conviction.";
            string  origin          = "PvZ 1";

    //wall-nut
        string  despcription    = "Wall-nuts have hard shells which you can use to protect your other plants.";
        double  cost            = 50;
        int     rech_time       = ;
        double  hp              = 80;
        string  projectile      = "";
        int     ai              = ;
        double  range           = ;
        string  special         = "";
        string  almanac         = "People wonder how I feel about getting constantly chewed on by zombies, What they don't realize is that with my limited senses all I can feel is a kind of tingling, like a relaxing back rub.";
        string  origin          = "PvZ 1";







































//wow... so empty