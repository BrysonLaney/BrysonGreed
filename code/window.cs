using Raylib_cs;
class movement : player{ //controls the movemnet for the players
    player player = new player();
    //moves the player either left or right
    public void moveright(){
        player.xpositive();
    }
    public void moveleft(){
        player.xnegative();
    }
    public int playerx(){
        return player.getx();
    }
    //returns the players x or y
    public int playery(){
        return player.gety();
    }
    
}
class player{ // holds the player class data for variables such as the players location and functions to move the player
    private int x = 700;
    private int y = 600;
    //returns either the x or the y
    public int getx(){ return x;}
    public int gety(){ return y;}
    //moves the player
    public void xpositive(){ x += 5; }
    public void xnegative(){ x -= 5; }
    public void ypositive(){ y += 5; }
    public void ynegative(){ y -= 5; }

}
class rockspawn{ //creates the x coord for the rock to fall down
    private int x;
    Random rndm = new Random();
    //creates and returns the x coords for the rock
    public int spawnrock(){
        x = rndm.Next(10, 1190);
        return x;
    }
}
class gemspawn{ //used to create the x coord for the gem to fall down
    Random rndm = new Random();
    private int x;
    //creates the gems x coords
    public int spawngem(){
        x = rndm.Next(15, 1185);
        return x;
    }
}