//See the reference for the dmg in here: https://plantsvszombies.fandom.com/wiki/Damage#Plants_vs._Zombies

//Template:
    int     dmg         = 1;    //damage (dmg) is counted in peas
    double  pierce      = 1;    //mesured in zombies, projectile pierce
    double  lifespan    = inf;  //mesured in tiles or inf, projectile lifespan

//copy-paste
    int     dmg         = 1;
    double  pierce      = 1;
    double  lifespan    = inf;

//normal_sun
    int     dmg         = 25;
    double  pierce      = 0;
    double  lifespan    = 30; //measured in seconds here

//pea
    int     dmg         = 1;
    double  pierce      = 1;
    double  lifespan    = inf;

//potato_explosion
    int     dmg         = //half a gargantuar
    double  pierce      = inf;
    double  lifespan    = 0;

//hothead_explosion
    int     dmg         = 3 * potato_head.dmg;
    double  pierce      = inf;
    double  lifespan    = 0;