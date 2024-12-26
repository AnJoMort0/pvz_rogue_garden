
//This is the full list of plants, which will have an almanac in the game. There will be adjustements with play-testing and many of these will take a long time to actually join the game. Any ideas are welcome as long as you follow the guidelines according to the comented template. You are welcome to propose changes and give feedback.
//See a reference to HP in here: https://plantsvszombies.fandom.com/wiki/Damage#Plants_vs._Zombies

    //template_plant
        string  description = "";           //basic description of the plant (if available, you can easily take it straight from its game of origin)
        double  cost        = 25;           //sun cost of the plant. The game works on a 25 sun basis
        int     rech_time   = ;             //recharge time: mesured in seconds - time needed for the plant to be available again
        double  hp          = 6;            //hit points (hp) are counted in peas. Yes, even the plants'. Note: A regular plant has 6 hp
        string  projectile  = "pea";        //from the projectiles_list
        string  attack_type = straight;   //see below, aims dependant on the range
        double  ai          = 1;            //mesured in seconds - ai stands for attack interval, aka time between each attack, aka how fast the plant attacks
        double  range       = lane;         //measured in [see bellow];
        string  special     = "";           //if relevant, add a precise description of the ability/ies (this won't show up in the actual almanac, it is instead used as guidance for coding), if not remove this line.
        string  almanac     = "";           //almanac entry, be it copied from one of the original games or entirely/partially new
        string  origin      = "";           //game(s) or mod(s) of origin/main reference

            //attack_type
            var straight    = "Straight down the lane.";
            var sun         = "Pops into existence.";
            var aim         = "From the coords of the plant to the coords of the aimed zombie defined by range.";
            var explosion   = "Explosion based on the projectile's lifespan as a square range";
            var lob         = "Lobbed attacks.";

            //range
            var lane        = "A lane of the map.";
            var row         = "A row of the map.";
            var cross       = "Lane and rows of the map.";
            var garden      = "The whole garden";
            var adjLane     = "Adjacent lanes and the one it is in.";
            var adjFront    = "Adjacent tile in front.";
            var adjBack     = "Adjacent tile behind.";
            var adjX        = "Adjacent tiles in the same lane.";
            var adjY        = "Adjacent tiles in the same row.";
            var adjCross    = "Adjacent tiles in the same lane and row.";
            var adj3        = "Tiles in a 3x3 area centred around itself.";
            var eaten       = "Attacks the zombie that ate it.";
            var tile        = "Attacks on its own tile.";

    //copy_paste
        string  description = "";
        double  cost        = ;
        int     rech_time   = ;
        double  hp          = 6;
        string  projectile  = "";
        string  attack_type = straight;
        double  ai          = ;
        double  range       = lane;
        string  special     = "";
        string  almanac     = "";
        string  origin      = "";

//Bacic day deck
    //sunflower
        string  description = "Sunflowers are essential for you to produce extra sun. Try planting as many as you can!";
        double  cost        = 50;
        int     rech_time   = ;
        double  hp          = 6;
        string  projectile  = "sun";
        string  attack_type = sun;
        double  ai          = 24;
        string  special     = "Doesn't attack, it produces sun";
        string  almanac     = "'Not to brag, but I'm pretty much your basic franchise-founding superstar.'";
        string  origin      = "PvZ 1";

        //twin_sunflower
            string  description = "Twin Sunflowers give twice as much sun as a normal sunflower.";
            double  cost        = 150;
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "sun";
            string  attack_type = sun;
            double  ai          = burst(2, 24);
            string  special     = "Doesn't attack, it produces sun";
            string  almanac     = "It was a crazed night of forbidden science that brought Twin Sunflower into existence. Thunder crashed overhead, strange lights flickered, even the very roaring wind seemed to hiss its angry denial. But to no avail. Twin Sunflower was alive, ALIVE!";
            string  origin      = "PvZ 1";

        //metal_petal_sunflower
            string  description = "Metal Petal is an armored Sunflower. While the metal weighs her down, making her slower than other Sunflowers, she has the added benefit of higher health.";
            double  cost        = 100;
            int     rech_time   = ;
            double  hp          = 80;
            string  projectile  = "sun";
            string  attack_type = sun;
            double  ai          = 27;
            string  special     = "Doesn't attack, it produces sun";
            string  almanac     = "'Time to put the metal to the petal, baby!'";
            string  origin      = "PvZ GW, PvZ Heroes";

    //peashooter
        string  description = "Peashooters are your first lane; of defense. They shoot peas at attacking zombies.";
        double  cost        = 100;
        int     rech_time   = ;
        double  hp          = 6;
        string  projectile  = "pea";
        string  attack_type = straight;
        double  ai          = 1.5;
        double  range       = lane;
        string  almanac     = "How can a single plant grow and shoot so many peas so quickly? Peashooter says, 'Hard work, commitment, and a healthy, well-balanced breakfast of sunlight and high-fiber carbon dioxide make it all possible.'";
        string  origin      = "PvZ 1";

        //peapods
            string  description = "Stack multiple Peas to quintuple the power!";
            double  cost        = 100 * n; //scalling price by the number of pods
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "pea";
            string  attack_type = straight;
            double  ai          = burst(n, 1.5);
            double  range       = lane;
            string  special     = "Can be progressively upgraded to add more shooters";
            string  almanac     = "Pea Pod studied spacial quantum mechanics and graduated from Professional Clown Academy. As a barrel of laughs in the family, everyone loves him.";
            string  origin      = "PvZ 2";

        //skyshooter
            string  description = "Skyshooters are your second lane; of defense. They shoot more efficiently when on the roof. Targets flying zombies first";
            double  cost        = 75;
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "pea";
            string  attack_type = aim;
            double  ai          = 1.5; //halves when on the roof
            double  range       = lane;
            string  special     = "Doubles the attack speed when on the roof. Targets first flying zombies on its lane;";
            string  almanac     = "The youngest Peashooter ever to earn a pilot's license. Also the only Peashooter ever to earn a pilot's license.";
            string  origin      = "PvZ Heroes";

    //repeater
        string  description = "Repeaters fire two peas at a time.";
        double  cost        = 225;
        int     rech_time   = ;
        double  hp          = 6;
        string  projectile  = "pea";
        string  attack_type = straight;
        double  ai          = burst(2, 1.5);
        double  range       = lane;
        string  almanac     = "Repeater is fierce. He's from the streets. He doesn't take attitude from anybody, plant or zombie, and he shoots peas to keep people at a distance. Secretly, though, Repeater yearns for love.";
        string  origin      = "PvZ 1";

        //threepeater
            string  description = "Threepeater shoots peas in three lanes.";
            double  cost        = 150;
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "pea";
            string  attack_type = straight;
            double  ai          = 1.5;
            double  range       = adjLane;
            string  special     = "Shoots 3 peas, one in its lane; and one in each adjacent line";
            string  almanac     = "Threepeater likes reading, backgammon and long periods of immobility in the park. Threepeater enjoys going to shows, particularly modern jazz. 'I'm just looking for that special someone,' he says. Threepeater's favorite number is 5";
            string  origin      = "PvZ 1";

        //gatling_pea
            string  description = "Gatling Peas shoot four peas at a time.";
            double  cost        = 250;
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "pea";
            string  attack_type = straight;
            double  ai          = burst(4, 1.5);
            double  range       = lane;
            string  almanac     = "Gatling Pea's parents were concerned when he announced his intention to join the military. "But honey, it's so dangerous!" they said in unison. Gatling Pea refused to budge. "Life is dangerous," he replied, eyes glinting with steely conviction.";
            string  origin      = "PvZ 1";

    //wall-nut
        string  description = "Wall-nuts have hard shells which you can use to protect your other plants.";
        double  cost        = 50;
        int     rech_time   = ;
        double  hp          = 80;
        string  projectile  = "";
        string  attack_type = ;
        double  ai          = ;
        double  range       = ;
        string  almanac     = "People wonder how I feel about getting constantly chewed on by zombies, What they don't realize is that with my limited senses all I can feel is a kind of tingling, like a relaxing back rub.";
        string  origin      = "PvZ 1";

        //tall-nut
            string  description = "Tall-nuts are heavy-duty wall plants that can't be vaulted or jumped over.";
            double  cost        = 100;
            int     rech_time   = ;
            double  hp          = 160;
            string  projectile  = "";
            string  attack_type = ;
            double  ai          = ;
            double  range       = ;
            string  special     = "Cannot be jumped over.";
            string  almanac     = "People wonder if there's a rivalry between Wall-nut and Tall-nut. Tall-nut laughs a rich baritone laugh. 'How could there be anything between us? We are brothers. If you knew what Wall-nut has done for me...' Tall-nut's voice trails off and he smiles knowingly.";
            string  origin      = "PvZ 1";

        //sweet_potato
            string  description = "Sweet Potatoes attract zombies from other lanes when they are close by.";
            double  cost        = 100;
            int     rech_time   = ;
            double  hp          = 80;
            string  projectile  = "";
            string  attack_type = ;
            double  ai          = ;
            double  range       = ;
            string  special     = "Attracts zombies in a 3x3 area centered on the tile in front of her into her lane.";
            string  almanac     = "Sweet Potato really is as sweet as she looks. Her favorite animal is the unicorn. Her favorite color is (and this is a direct quote) 'all the colors in the rainbow.' When she writes the letter 'i', she draws a little heart where the dot belongs. Frankly, if it were anyone else, this amount of syrup would be sickening. But on her, well, it just seems right.";
            string  origin      = "PvZ 2";

    //potato_mine
        string description = "Potato Mines pack a powerful punch, but they need a while to arm themselves. You should plant them ahead of zombies. They will explode on contact."
        double  cost        = 25;
        int     rech_time   = ;
        double  hp          = 6;
        string  projectile  = "potato_explosion";
        string  attack_type = explosion;
        double  ai          = ;
        double  range       = tile;
        string  special     = "It needs to arm up. Can be eaten while arming up";
        string  almanac     = "Some folks say Potato Mine is lazy, that he leaves everything to the last minute. Potato Mine says nothing. He's too busy thinking about his investment strategy.";
        string  origin      = "PvZ 1";

        //hot_head
            string  description = "It packs an even more powerful punch. Instantly armed.";
            double  cost        = 50;
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "hothead_explosion";
            string  attack_type = explosion;
            double  ai          = ;
            double  range       = lane;
            string  special     = "";
            string  almanac     = "Sure, he has an explosive temper. But for the most part, he's pretty even peeled.";
            string  origin      = "PvZ Heroes";

        //levitater
            string  description = "Levitaters levitate random zombies";
            double  cost        = 150;
            int     rech_time   = ;
            double  hp          = 6;
            string  projectile  = "";
            string  attack_type = random;
            double  ai          = ;
            double  range       = garden;
            string  special     = "";
            string  almanac     = "'I'm a bit different from my other tater cousins,' explains Levitater. 'Chief among those differences, I'd say, is that I don't explode on contact, or at all. I stick around!'";
            string  origin      = "PvZ 2";